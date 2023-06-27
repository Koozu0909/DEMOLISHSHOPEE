using DEMOLISHSHOPEE.Models;

namespace DEMOLISHSHOPEE.Service
{
    public class AddressLV3Service
    {
        private readonly QUANLYTHUONGMAIContext context;

        public AddressLV3Service(QUANLYTHUONGMAIContext ctx)
        {
            context = ctx;
        }

        // get all list
        public List<TbAddressLv3> GetList()
        {
            return context.TbAddressLv3s.ToList();
        }

        // get 1 item
        public TbAddressLv3 GetItem(int originid)
        {
            return context.TbAddressLv3s.FirstOrDefault(x => x.MaA3 == originid);
        }

        // add one address
        public TbAddressLv3 Add(TbAddressLv3 origin)
        {
            try
            {
                context.TbAddressLv3s.Add(origin);
                context.SaveChanges();
                return origin;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        // update one address
        public TbAddressLv3 Update(TbAddressLv3 origin)
        {
            try
            {
                var _origin = context.TbAddressLv3s.FirstOrDefault(x => x.MaA3 == origin.MaA3);
                _origin.TenA3 = origin.TenA3;
                _origin.MaA3 = origin.MaA3;
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
                var _origin = context.TbAddressLv3s.FirstOrDefault(x => x.MaA3 == originid);
                context.TbAddressLv3s.Remove(_origin);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }
    }
}