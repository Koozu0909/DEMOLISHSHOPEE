using DEMOLISHSHOPEE.Models;

namespace DEMOLISHSHOPEE.Service
{
    public class OrderDetailService
    {
        private readonly QUANLYTHUONGMAIContext context;

        public OrderDetailService(QUANLYTHUONGMAIContext ctx)
        {
            context = ctx;
        }

        public List<TbOrderDetail> GetList()
        {
            return context.TbOrderDetails.ToList();
        }

        public TbOrderDetail GetItem(int brandid)
        {
            return context.TbOrderDetails.FirstOrDefault(x => x.MaDonHangCt == brandid);
        }

        public TbOrderDetail Add(TbOrderDetail origin)
        {
            try
            {
                context.TbOrderDetails.Add(origin);
                context.SaveChanges();
                return origin;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public TbOrderDetail Update(TbOrderDetail origin)
        {
            try
            {
                TbOrderDetail _origin = context.TbOrderDetails.FirstOrDefault(x => x.MaDonHangCt == origin.MaDonHangCt);

                _origin.MaDonHangCt = origin.MaDonHangCt;
                _origin.MaDonHang = origin.MaDonHang;
                _origin.MaBranchProduct = origin.MaBranchProduct;
                _origin.SoLuongSp = origin.SoLuongSp;

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
                var _origin = context.TbOrderDetails.FirstOrDefault(x => x.MaDonHangCt == origin);
                context.TbOrderDetails.Remove(_origin);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }
    }
}