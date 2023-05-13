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

        public List<TbCategory> GetList()
        {
            return context.TbCategories.ToList();
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
                _origin.MaLoaiSp = origin.MaLoaiSp;
                _origin.TenLoaiSp = origin.TenLoaiSp;
                _origin.Parent = origin.Parent;
                _origin.Role = origin.Role;
                _origin.ImagePath = origin.ImagePath;
                _origin.TenLoaiSp = origin.TenLoaiSp;
                context.SaveChanges();
                return origin;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public void Delete(int origin)
        {
            try
            {
                var _origin = context.TbCategories.FirstOrDefault(x => x.MaLoaiSp == origin);
                context.TbCategories.Remove(_origin);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }
    }
}