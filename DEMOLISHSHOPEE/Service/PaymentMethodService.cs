using DEMOLISHSHOPEE.Models;

namespace DEMOLISHSHOPEE.Service
{
    public class PaymentMethodService
    {
        private readonly QUANLYTHUONGMAIContext context;

        public PaymentMethodService(QUANLYTHUONGMAIContext ctx)
        {
            context = ctx;
        }

        public List<TbPaymentMethod> GetList()
        {
            return context.TbPaymentMethods.ToList();
        }

        public TbPaymentMethod GetItem(int originid)
        {
            return context.TbPaymentMethods.FirstOrDefault(x => x.MaPayment == originid);
        }

        public TbPaymentMethod Add(TbPaymentMethod origin)
        {
            try
            {
                context.TbPaymentMethods.Add(origin);
                context.SaveChanges();
                return origin;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public TbPaymentMethod Update(TbPaymentMethod origin)
        {
            try
            {
                var _origin = context.TbPaymentMethods.FirstOrDefault(x => x.MaPayment == origin.MaPayment);
                _origin.MaPayment = origin.MaPayment;
                _origin.PaymentMethod = origin.PaymentMethod;

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
                var _origin = context.TbPaymentMethods.FirstOrDefault(x => x.MaPayment == originid);
                context.TbPaymentMethods.Remove(_origin);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }
    }
}