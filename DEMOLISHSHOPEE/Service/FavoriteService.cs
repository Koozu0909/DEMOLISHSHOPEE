using DEMOLISHSHOPEE.Models;

namespace DEMOLISHSHOPEE.Service
{
    public class FavoriteService
    {
        private readonly QUANLYTHUONGMAIContext context;

        public FavoriteService(QUANLYTHUONGMAIContext ctx)
        {
            context = ctx;
        }

        public List<TbFavourite> GetList()
        {
            return context.TbFavourites.ToList();
        }

        public TbFavourite GetItem(int brandid)
        {
            return context.TbFavourites.FirstOrDefault(x => x.MaYeuThich == brandid);
        }

        public TbFavourite Add(TbFavourite origin)
        {
            try
            {
                context.TbFavourites.Add(origin);
                context.SaveChanges();
                return origin;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public TbFavourite Update(TbFavourite origin)
        {
            try
            {
                TbFavourite _origin = context.TbFavourites.FirstOrDefault(x => x.MaYeuThich == origin.MaYeuThich);
                _origin.MaYeuThich = origin.MaYeuThich;
                _origin.MaSp = origin.MaSp;
                _origin.MaUser = origin.MaUser;

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
                var _origin = context.TbFavourites.FirstOrDefault(x => x.MaYeuThich == origin);
                context.TbFavourites.Remove(_origin);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }
    }
}