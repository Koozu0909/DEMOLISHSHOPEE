using DEMOLISHSHOPEE.Alias;
using DEMOLISHSHOPEE.Models;

namespace DEMOLISHSHOPEE.Service
{
    public class CategoriesService
    {
        private readonly QUANLYTHUONGMAIContext context;

        public CategoriesService(QUANLYTHUONGMAIContext ctx)
        {
            context = ctx;
        }

        public List<CategoriesAlias> GetList()
        {
            var lst = context.TbCategories.ToList();
            List<CategoriesAlias> lsCate = new List<CategoriesAlias>();
            CategoriesAlias cateDTO;
            foreach (var item in lst)
            {
                cateDTO = new CategoriesAlias();
                cateDTO.MaLoaiSp = item.MaLoaiSp;
                cateDTO.TenLoaiSp = item.TenLoaiSp;
                cateDTO.Parent = item.Parent;
                var cate = context.TbCategories.FirstOrDefault(t => t.MaLoaiSp == item.Parent);
                if (cate != null)
                {
                    cateDTO.TenParent = cate.TenLoaiSp;
                }
                else
                {
                    cateDTO.TenParent = " ";
                }
                cateDTO.Role = item.Role;
                cateDTO.ImagePath = item.ImagePath;
                lsCate.Add(cateDTO);
            }
            return lsCate;
        }

        public TbCategory GetItem(int brandid)
        {
            return context.TbCategories.FirstOrDefault(x => x.MaLoaiSp == brandid);
        }

        public TbCategory Add(TbCategory origin)
        {
            try
            {
                context.TbCategories.Add(origin);
                context.SaveChanges();
                return origin;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public TbCategory Update(TbCategory origin)
        {
            try
            {
                TbCategory _origin = context.TbCategories.FirstOrDefault(x => x.MaLoaiSp == origin.MaLoaiSp);
                _origin.TenLoaiSp = origin.TenLoaiSp;
                _origin.ImagePath = origin.ImagePath;
                context.SaveChanges();
                return origin;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public void Delete(int cateid)
        {
            try
            {
                var _cate = context.TbCategories.FirstOrDefault(x => x.MaLoaiSp == cateid);
                List<TbCategory> _catechild = context.TbCategories.Where(x => x.Parent == cateid).ToList();

                foreach (var item in _catechild)
                {
                    List<TbCategory> _categrandchild = context.TbCategories.Where(x => x.Parent == item.MaLoaiSp).ToList();
                    context.TbCategories.RemoveRange(_categrandchild);
                }

                context.TbCategories.RemoveRange(_catechild);
                context.TbCategories.Remove(_cate);
                context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }
    }
}