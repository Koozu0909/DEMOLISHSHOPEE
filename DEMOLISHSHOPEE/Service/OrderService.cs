using DEMOLISHSHOPEE.Models;

namespace DEMOLISHSHOPEE.Service
{
    public class OrderService
    {
        private readonly QUANLYTHUONGMAIContext context;

        public OrderService(QUANLYTHUONGMAIContext ctx)
        {
            context = ctx;
        }

        public List<TbOrder> GetList()
        {
            return context.TbOrders.ToList();
        }

        public TbOrder GetItem(int brandid)
        {
            return context.TbOrders.FirstOrDefault(x => x.MaDonHang == brandid);
        }

        public TbOrder Add(TbOrder origin)
        {
            try
            {
                context.TbOrders.Add(origin);
                context.SaveChanges();
                return origin;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public TbOrder Update(TbOrder origin)
        {
            try
            {
                var _origin = context.TbOrders.FirstOrDefault(x => x.MaDonHang == origin.MaDonHang);
                _origin.MaDonHang = origin.MaDonHang;
                _origin.MaUser = origin.MaUser;
                _origin.MaPayment = origin.MaPayment;
                _origin.CreateDay = origin.CreateDay;

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
                var _origin = context.TbOrders.FirstOrDefault(x => x.MaDonHang == origin);
                context.TbOrders.Remove(_origin);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }
    }
}