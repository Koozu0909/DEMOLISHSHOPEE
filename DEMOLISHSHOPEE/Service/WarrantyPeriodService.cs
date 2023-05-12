using DEMOLISHSHOPEE.Models;

namespace DEMOLISHSHOPEE.Service
{
    public class WarrantyPeriodService
    {
        private readonly QUANLYTHUONGMAIContext context;
       
        public WarrantyPeriodService(QUANLYTHUONGMAIContext ctx)
        {
            context = ctx;
        }

        public List<TbWarrantyPeriod> GetList()
        {
            return context.TbWarrantyPeriods.ToList();
        }

        public TbWarrantyPeriod GetItem(int originid)
        {
            return context.TbWarrantyPeriods.FirstOrDefault(x => x.MaHanBaoHanh == originid);
        }

        public TbWarrantyPeriod Add(TbWarrantyPeriod origin)
        {
            try
            {
                context.TbWarrantyPeriods.Add(origin);
                context.SaveChanges();
                return origin;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public TbWarrantyPeriod Update(TbWarrantyPeriod origin)
        {
            try
            {
                var _origin = context.TbWarrantyPeriods.FirstOrDefault(x => x.MaHanBaoHanh == origin.MaHanBaoHanh);
                _origin.MaHanBaoHanh = origin.MaHanBaoHanh;
                _origin.HanBaoHanh = origin.HanBaoHanh;


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
                var _origin = context.TbWarrantyPeriods.FirstOrDefault(x => x.MaHanBaoHanh == originid);
                context.TbWarrantyPeriods.Remove(_origin);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }
    }
}