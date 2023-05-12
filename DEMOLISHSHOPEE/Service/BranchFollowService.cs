using DEMOLISHSHOPEE.Alias;
using DEMOLISHSHOPEE.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace DEMOLISHSHOPEE.Service
{
    public class BranchFollowService
    {
        private readonly QUANLYTHUONGMAIContext context;
       
        public BranchFollowService(QUANLYTHUONGMAIContext ctx)
        {
            context = ctx;
        }

        public  List<TbBranchFollow> GetList()
        {
            return context.TbBranchFollows.ToList();
        }
        public TbBranchFollow GetItem(int tagid)
        {
            return context.TbBranchFollows.FirstOrDefault(x=> x.MaBranchFollow == tagid);
        }


        public TbBranchFollow Add(TbBranchFollow tbBranchFollow)
        {
            try
            {
                context.TbBranchFollows.Add(tbBranchFollow);
                context.SaveChanges();
                return tbBranchFollow;
            }
            catch (Exception ex)
            {

                throw new Exception("Loi: " + ex.Message);
            }

        }

        public TbBranchFollow Update(TbBranchFollow origin)
        {
            try
            {
                var _origin = context.TbBranchFollows.FirstOrDefault(x => x.MaBranchFollow == origin.MaBranchFollow);
                _origin.MaBranchFollow = origin.MaBranchFollow;
                _origin.MaUser = origin.MaUser;
                _origin.MaCuaHang = origin.MaCuaHang;   

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
                var _origin = context.TbBranchFollows.FirstOrDefault(x => x.MaBranchFollow == originid);
                context.TbBranchFollows.Remove(_origin);
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Loi: " + ex.Message);
            }

        }

    }
}
