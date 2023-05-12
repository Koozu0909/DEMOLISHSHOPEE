using DEMOLISHSHOPEE.Models;

namespace DEMOLISHSHOPEE.Service
{
    public class DescriptionService
    {
        private readonly QUANLYTHUONGMAIContext context;

        public DescriptionService(QUANLYTHUONGMAIContext ctx)
        {
            context = ctx;
        }

        public List<TbDescription> GetList()
        {
            return context.TbDescriptions.ToList();
        }

        public TbDescription GetItem(int brandid)
        {
            return context.TbDescriptions.FirstOrDefault(x => x.MaMoTa == brandid);
        }

        public TbDescription Add(TbDescription origin)
        {
            try
            {
                context.TbDescriptions.Add(origin);
                context.SaveChanges();
                return origin;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public TbDescription Update(TbDescription origin)
        {
            try
            {
                TbDescription _origin = context.TbDescriptions.FirstOrDefault(x => x.MaMoTa == origin.MaMoTa);

                _origin.MaMoTa = origin.MaMoTa;
                _origin.MaSp = origin.MaSp;
                _origin.MoTa = origin.MoTa;

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
                var _origin = context.TbDescriptions.FirstOrDefault(x => x.MaMoTa == origin);
                context.TbDescriptions.Remove(_origin);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }
    }
}