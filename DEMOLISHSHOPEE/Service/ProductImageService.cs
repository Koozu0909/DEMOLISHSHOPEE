using DEMOLISHSHOPEE.Models;

namespace DEMOLISHSHOPEE.Service
{
    public class ProductImageService
    {
        private readonly QUANLYTHUONGMAIContext context;

        public ProductImageService(QUANLYTHUONGMAIContext ctx)
        {
            context = ctx;
        }

        public List<TbProductImage> GetList()
        {
            return context.TbProductImages.ToList();
        }

        public TbProductImage GetItem(int originid)
        {
            return context.TbProductImages.FirstOrDefault(x => x.MaImage == originid);
        }

        public TbProductImage Add(TbProductImage origin)
        {
            try
            {
                context.TbProductImages.Add(origin);
                context.SaveChanges();
                return origin;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public TbProductImage Update(TbProductImage origin)
        {
            try
            {
                var _origin = context.TbProductImages.FirstOrDefault(x => x.MaImage == origin.MaImage);

                _origin.MaImage = origin.MaImage;
                _origin.ImagePath = origin.ImagePath;
                _origin.MaSp = origin.MaSp;

                context.SaveChanges();
                return _origin;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public void Delete(int originid)
        {
            try
            {
                var _origin = context.TbProductImages.FirstOrDefault(x => x.MaImage == originid);
                context.TbProductImages.Remove(_origin);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }
    }
}