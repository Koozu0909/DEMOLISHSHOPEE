using DEMOLISHSHOPEE.Models;

namespace DEMOLISHSHOPEE.Service
{
    public class OriginService
    {
        private readonly QUANLYTHUONGMAIContext context;

        public OriginService(QUANLYTHUONGMAIContext ctx)
        {
            context = ctx;
        }

        public List<TbOrigin> GetList()
        {
            return context.TbOrigins.ToList();
        }

        public TbOrigin GetItem(int originid)
        {
            return context.TbOrigins.FirstOrDefault(x => x.MaXuatXu == originid);
        }

        public TbOrigin Add(TbOrigin origin)
        {
            try
            {
                context.TbOrigins.Add(origin);
                context.SaveChanges();
                return origin;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public TbOrigin Update(TbOrigin origin)
        {
            try
            {
                var _origin = context.TbOrigins.FirstOrDefault(x => x.MaXuatXu == origin.MaXuatXu);
                _origin.TenXuatXu = origin.TenXuatXu;
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
                var _origin = context.TbOrigins.FirstOrDefault(x => x.MaXuatXu == originid);
                context.TbOrigins.Remove(_origin);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }
    }
}