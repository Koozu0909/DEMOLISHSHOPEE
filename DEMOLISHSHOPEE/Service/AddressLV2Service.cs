using DEMOLISHSHOPEE.Alias;
using DEMOLISHSHOPEE.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace DEMOLISHSHOPEE.Service
{
    public class AddressLV2Service
    {

        private readonly QUANLYTHUONGMAIContext context;
      
        public AddressLV2Service(QUANLYTHUONGMAIContext ctx)
        {
            context = ctx;
        }

        // get all list
        public List<TbAddressLv2> GetList()
        {
            return context.TbAddressLv2s.ToList();
        }

        // get 1 item
        public TbAddressLv2 GetItem(int originid)
        {
            return context.TbAddressLv2s.FirstOrDefault(x => x.MaA2 == originid);
        }

        // add one address
        public TbAddressLv2 Add(TbAddressLv2 origin)
        {
            try
            {
                context.TbAddressLv2s.Add(origin);
                context.SaveChanges();
                return origin;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        // update one address
        public TbAddressLv2 Update(TbAddressLv2 origin)
        {
            try
            {
                var _origin = context.TbAddressLv2s.FirstOrDefault(x => x.MaA2 == origin.MaA2);
                _origin.TenA2 = origin.TenA2;
                _origin.MaA2 = origin.MaA2;
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
                var _origin = context.TbAddressLv2s.FirstOrDefault(x => x.MaA2 == originid);
                context.TbAddressLv2s.Remove(_origin);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

    }
}
