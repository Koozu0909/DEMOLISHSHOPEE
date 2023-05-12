using DEMOLISHSHOPEE.Models;

namespace DEMOLISHSHOPEE.Service
{
    public class ProductTagService
    {
        private readonly QUANLYTHUONGMAIContext context;

        public ProductTagService(QUANLYTHUONGMAIContext ctx)
        {
            context = ctx;
        }

        public List<TbProductTag> GetList()
        {
            return context.TbProductTags.ToList();
        }

        public TbProductTag GetItem(int brandid)
        {
            return context.TbProductTags.FirstOrDefault(x => x.MaProductTag == brandid);
        }

        public TbProductTag Add(TbProductTag origin)
        {
            try
            {
                context.TbProductTags.Add(origin);
                context.SaveChanges();
                return origin;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public TbProductTag Update(TbProductTag origin)
        {
            try
            {
                TbProductTag _origin = context.TbProductTags.FirstOrDefault(x => x.MaProductTag == origin.MaProductTag);
                _origin.MaProductTag = origin.MaProductTag;
                _origin.MaSp = origin.MaSp;
                _origin.MaTag = origin.MaTag;

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
                var _origin = context.TbProductTags.FirstOrDefault(x => x.MaProductTag == origin);
                context.TbProductTags.Remove(_origin);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }
    }
}