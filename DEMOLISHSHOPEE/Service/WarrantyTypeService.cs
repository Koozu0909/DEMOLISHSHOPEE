using DEMOLISHSHOPEE.Models;

namespace DEMOLISHSHOPEE.Service
{
    public class WarrantyTypeService
    {
        private readonly QUANLYTHUONGMAIContext context;

        public WarrantyTypeService(QUANLYTHUONGMAIContext ctx)
        {
            context = ctx;
        }

        public List<TbWarrantyType> GetList()
        {
            return context.TbWarrantyTypes.ToList();
        }

        public TbWarrantyType GetItem(int originid)
        {
            return context.TbWarrantyTypes.FirstOrDefault(x => x.MaLoaiBaoHanh == originid);
        }

        public TbWarrantyType Add(TbWarrantyType origin)
        {
            try
            {
                context.TbWarrantyTypes.Add(origin);
                context.SaveChanges();
                return origin;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public TbWarrantyType Update(TbWarrantyType origin)
        {
            try
            {
                var _origin = context.TbWarrantyTypes.FirstOrDefault(x => x.MaLoaiBaoHanh == origin.MaLoaiBaoHanh);
                _origin.MaLoaiBaoHanh = origin.MaLoaiBaoHanh;
                _origin.LoaiBaoHanh = origin.LoaiBaoHanh;

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
                var _origin = context.TbWarrantyTypes.FirstOrDefault(x => x.MaLoaiBaoHanh == originid);
                context.TbWarrantyTypes.Remove(_origin);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }
    }
}