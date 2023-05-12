using DEMOLISHSHOPEE.Models;

namespace DEMOLISHSHOPEE.Service
{
    public class ProductService
    {
        private readonly QUANLYTHUONGMAIContext context;

        public ProductService(QUANLYTHUONGMAIContext ctx)
        {
            context = ctx;
        }

        public List<TbProduct> GetList()
        {
            return context.TbProducts.ToList();
        }

        public TbProduct GetItem(int originid)
        {
            return context.TbProducts.FirstOrDefault(x => x.MaXuatXu == originid);
        }

        public TbProduct Add(TbProduct origin)
        {
            try
            {
                context.TbProducts.Add(origin);
                context.SaveChanges();
                return origin;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public TbProduct Update(TbProduct origin)
        {
            try
            {
                var _origin = context.TbProducts.FirstOrDefault(x => x.MaSp == origin.MaSp);
                _origin.MaSp = origin.MaSp;
                _origin.TenSp = origin.TenSp;
                _origin.SeoName = origin.SeoName;
                _origin.MaLoaiSp = origin.MaLoaiSp;
                _origin.MaThuongHieu = origin.MaThuongHieu;
                _origin.MaLoaiBaoHanh = origin.MaLoaiBaoHanh;
                _origin.MaHanBaoHanh = origin.MaHanBaoHanh;
                _origin.MaXuatXu = origin.MaXuatXu;
                _origin.TotalRate = origin.TotalRate;
                _origin.GiaSp = origin.GiaSp;
                _origin.CreateDay = origin.CreateDay;
                _origin.CreateBy = origin.CreateBy;
                _origin.UpdateDay = origin.UpdateDay;
                _origin.UpdateBy = origin.UpdateBy;
                _origin.DeleteDay = origin.DeleteDay;
                _origin.DeleteBy = origin.DeleteBy;

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
                var _origin = context.TbProducts.FirstOrDefault(x => x.MaSp == originid);
                context.TbProducts.Remove(_origin);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }
    }
}