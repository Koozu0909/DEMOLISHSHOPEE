using DEMOLISHSHOPEE.Alias;
using DEMOLISHSHOPEE.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace DEMOLISHSHOPEE.Service
{
    public class UserService
    {

        private readonly QUANLYTHUONGMAIContext context;
       
        public UserService(QUANLYTHUONGMAIContext ctx)
        {
            context = ctx;
        }

        // get all list
        public List<TbUser> GetList()
        {
            return context.TbUsers.ToList();
        }
       
        // get 1 item
        public TbUser GetItem(int originid)
        {
            return context.TbUsers.FirstOrDefault(x => x.MaUser == originid);
        }

        // add one address
        public TbUser Add(TbUser origin)
        {
            try
            {
                context.TbUsers.Add(origin);
                context.SaveChanges();
                return origin;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        // update one address
        public TbUser Update(TbUser origin)
        {
            try
            {
                var _origin = context.TbUsers.FirstOrDefault(x => x.MaUser == origin.MaUser);
                _origin.MaUser = origin.MaUser;
                _origin.HoTen = origin.HoTen; 
                _origin.Ten = origin.Ten;
                _origin.Gmail = origin.Gmail;
                _origin.Sdt = origin.Sdt;
                _origin.UserName = origin.UserName;
                _origin.PassWord = origin.PassWord;
                _origin.GioiTinh = origin.GioiTinh;
                _origin.NgaySinh = origin.NgaySinh;
                _origin.Avatar = origin.Avatar;
                _origin.CreateBy = origin.CreateBy;
                _origin.CreateDate = origin.CreateDate;
                _origin.UpdateBy = origin.UpdateBy;
                _origin.UpdateDate = origin.UpdateDate;

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
                var _origin = context.TbUsers.FirstOrDefault(x => x.MaUser == originid);
                context.TbUsers.Remove(_origin);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

    }
}
