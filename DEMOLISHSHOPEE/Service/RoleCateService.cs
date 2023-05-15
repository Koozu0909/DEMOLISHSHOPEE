using DEMOLISHSHOPEE.Models;

namespace DEMOLISHSHOPEE.Service
{
    public class RoleCateService
    {
        private readonly QUANLYTHUONGMAIContext context;

        public RoleCateService(QUANLYTHUONGMAIContext ctx)
        {
            context = ctx;
        }

        public List<TbRoleCate> GetList()
        {
            return context.TbRoleCates.ToList();
        }

        public TbRoleCate GetItem(int originid)
        {
            return context.TbRoleCates.FirstOrDefault(x => x.MaRole == originid);
        }

        public TbRoleCate Add(TbRoleCate origin)
        {
            try
            {
                context.TbRoleCates.Add(origin);
                context.SaveChanges();
                return origin;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public TbRoleCate Update(TbRoleCate origin)
        {
            try
            {
                var _origin = context.TbRoleCates.FirstOrDefault(x => x.MaRole == origin.MaRole);
                _origin.MaRole = origin.MaRole;
                _origin.TenRole = origin.TenRole;

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
                var _origin = context.TbRoleCates.FirstOrDefault(x => x.MaRole == originid);
                context.TbRoleCates.Remove(_origin);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }
    }
}