using DEMOLISHSHOPEE.Models;

namespace DEMOLISHSHOPEE.Service
{
    public class AddressLV1Service
    {
        private readonly QUANLYTHUONGMAIContext context;

        public AddressLV1Service(QUANLYTHUONGMAIContext ctx)
        {
            context = ctx;
        }

        // get all list
        public List<TbAddressLv1> GetList()
        {
            return context.TbAddressLv1s.ToList();
        }

        // get 1 item
        public TbAddressLv1 GetItem(int originid)
        {
            return context.TbAddressLv1s.FirstOrDefault(x => x.MaA1 == originid);
        }

        // add one address
        public TbAddressLv1 Add(TbAddressLv1 origin)
        {
            try
            {
                context.TbAddressLv1s.Add(origin);
                context.SaveChanges();
                return origin;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        // update one address
        public TbAddressLv1 Update(TbAddressLv1 origin)
        {
            try
            {
                var _origin = context.TbAddressLv1s.FirstOrDefault(x => x.MaA1 == origin.MaA1);
                _origin.TenA1 = origin.TenA1;
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
                var _origin = context.TbAddressLv1s.FirstOrDefault(x => x.MaA1 == originid);
                context.TbAddressLv1s.Remove(_origin);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }
    }
}