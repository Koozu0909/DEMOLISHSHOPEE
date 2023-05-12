using DEMOLISHSHOPEE.Models;

namespace DEMOLISHSHOPEE.Service
{
    public class StatusOrderService
    {
        private readonly QUANLYTHUONGMAIContext context;

        public StatusOrderService(QUANLYTHUONGMAIContext ctx)
        {
            context = ctx;
        }

        public List<TbStatusOrder> GetList()
        {
            return context.TbStatusOrders.ToList();
        }

        public TbStatusOrder GetItem(int brandid)
        {
            return context.TbStatusOrders.FirstOrDefault(x => x.MaTrangThai == brandid);
        }

        public TbStatusOrder Add(TbStatusOrder origin)
        {
            try
            {
                context.TbStatusOrders.Add(origin);
                context.SaveChanges();
                return origin;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public TbStatusOrder Update(TbStatusOrder origin)
        {
            try
            {
                TbStatusOrder _origin = context.TbStatusOrders.FirstOrDefault(x => x.MaTrangThai == origin.MaTrangThai);
                _origin.MaTrangThai = origin.MaTrangThai;
                _origin.TenTrangThai = origin.TenTrangThai;

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
                var _origin = context.TbStatusOrders.FirstOrDefault(x => x.MaTrangThai == origin);
                context.TbStatusOrders.Remove(_origin);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }
    }
}