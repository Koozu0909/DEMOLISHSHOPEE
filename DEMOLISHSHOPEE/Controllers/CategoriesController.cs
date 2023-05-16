using DEMOLISHSHOPEE.Models;
using DEMOLISHSHOPEE.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting.Internal;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using DEMOLISHSHOPEE.Alias;

namespace DEMOLISHSHOPEE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly QUANLYTHUONGMAIContext context;
        private readonly IWebHostEnvironment webHostEnvironment;

        public CategoriesController(QUANLYTHUONGMAIContext ctx, IWebHostEnvironment env)
        {
            context = ctx;
            webHostEnvironment = env;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            CategoriesService sv = new CategoriesService(context);
            return Ok(sv.GetItem(id));
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            CategoriesService sv = new CategoriesService(context);

            return Ok(sv.GetList());
        }

        ///HttpPut
        [HttpPut("")]
        public async Task<IActionResult> Update([FromForm] CategoriesImage p)
        {
            CategoriesService sv = new CategoriesService(context);

            var existingCategory = sv.GetItem(p.MaLoaiSp);

            if (existingCategory == null)
            {
                return NotFound();
            }

            existingCategory.TenLoaiSp = p.TenLoaiSp;

            if (p.Image != null && p.Image.Length > 0)
            {
                if (!string.IsNullOrEmpty(existingCategory.ImagePath))
                {
                    string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "Images", existingCategory.ImagePath);

                    if (System.IO.File.Exists(imagePath))
                    {
                        System.IO.File.Delete(imagePath);
                    }
                }

                string fileName = Path.GetFileName(p.Image.FileName);
                string newFileName = $"{p.TenLoaiSp}-{fileName}";
                newFileName = newFileName.Replace(" ", "-");
                string path = Path.Combine(Directory.GetCurrentDirectory(), "Images", newFileName);

                using (var stream = System.IO.File.Create(path))
                {
                    await p.Image.CopyToAsync(stream);
                }

                existingCategory.ImagePath = newFileName;
            }

            sv.Update(existingCategory);
            return Ok(existingCategory);
        }


        [HttpPost("")]
        public async Task<IActionResult> PostWithImage([FromForm] CategoriesImage p)
        {
            CategoriesService sv = new CategoriesService(context);
            var cate = new TbCategory
            {
                TenLoaiSp = p.TenLoaiSp,
                Parent = p.Parent,
                Role = p.Role,
            };

            if (p.Image.Length > 0 && p.Image != null)
            {
                string fileName = Path.GetFileName(p.Image.FileName);
                string newFileName = $"{p.TenLoaiSp}-{fileName}";
                newFileName = newFileName.Replace(" ", "-");
                string path = Path.Combine(Directory.GetCurrentDirectory(), "Images", newFileName);

                using (var stream = System.IO.File.Create(path))
                {
                    await p.Image.CopyToAsync(stream);
                }

                cate.ImagePath = newFileName;
            }
            else
            {
                cate.ImagePath = "";
            }

            sv.Add(cate);
            return Ok(cate);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            CategoriesService sv = new CategoriesService(context);

            var category = sv.GetItem(id);

            if (category == null)
            {
                return NotFound();
            }

            if (!string.IsNullOrEmpty(category.ImagePath))
            {
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "Images", category.ImagePath);

                if (System.IO.File.Exists(imagePath))
                {
                    System.IO.File.Delete(imagePath);
                }
            }

            sv.Delete(id);
            return Ok("Ok");
        }
        [HttpGet("images/{imageName}")]
        public IActionResult GetImage(string imageName)
        {
            var imagePath = Path.Combine(Directory.GetCurrentDirectory(), "Images", imageName);
            if (!System.IO.File.Exists(imagePath))
            {
                return NotFound();
            }
            var image = System.IO.File.OpenRead(imagePath);
            return File(image, "image/jpeg");
        }



    }
}