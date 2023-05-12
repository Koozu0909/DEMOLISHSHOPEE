using DEMOLISHSHOPEE.Alias;
using DEMOLISHSHOPEE.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace DEMOLISHSHOPEE.Service
{
    public class AddressService
    {

        private readonly QUANLYTHUONGMAIContext context;
       
        public AddressService(QUANLYTHUONGMAIContext ctx)
        {
            context = ctx;
        }

        // get all list
        public List<TbAddress> GetList()
        {
            return context.TbAddresses.ToList();
        }

        // get 1 item
        public TbAddress GetItem(int originid)
        {
            return context.TbAddresses.FirstOrDefault(x => x.MaAddress == originid);
        }

        // add one address
        public TbAddress Add(TbAddress origin)
        {
            try
            {
                context.TbAddresses.Add(origin);
                context.SaveChanges();
                return origin;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        // update one address
        public TbAddress Update(TbAddress origin)
        {
            try
            {
                var _origin = context.TbAddresses.FirstOrDefault(x => x.MaAddress == origin.MaAddress);
                _origin.MaA1 = origin.MaA1;
                _origin.MaA2 = origin.MaA2;
                _origin.MaA3 = origin.MaA3;
                _origin.ChiTiet = origin.ChiTiet;
                _origin.MaUser= origin.MaUser;



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
                var _origin = context.TbAddresses.FirstOrDefault(x => x.MaAddress == originid);
                context.TbAddresses.Remove(_origin);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

    }
}
