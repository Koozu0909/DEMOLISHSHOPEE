using DEMOLISHSHOPEE.Alias;
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

        public List<ProductAlias> GetList()
        {
            var lst = context.TbProducts.ToList();
            List<ProductAlias> lsProduct = new List<ProductAlias>();
            ProductAlias productDTO;
            foreach (var item in lst)
            {
                productDTO = new ProductAlias();
                productDTO.MaSp = item.MaSp;
                productDTO.TenSp = item.TenSp;
                productDTO.MaLoaiSp = item.MaLoaiSp;
                var loaisp = context.TbCategories.FirstOrDefault(t => t.MaLoaiSp == item.MaLoaiSp);
                productDTO.TenLoaiSp = loaisp.TenLoaiSp;
                productDTO.SeoName = item.SeoName;
                productDTO.MaThuongHieu = item.MaThuongHieu;
                var th = context.TbBrands.FirstOrDefault(t => t.MaThuongHieu == item.MaThuongHieu);
                productDTO.TenThuongHieu = th.TenThuongHieu;
                productDTO.MaLoaiBaoHanh = item.MaLoaiBaoHanh;
                var lbh = context.TbWarrantyTypes.FirstOrDefault(t => t.MaLoaiBaoHanh == item.MaLoaiBaoHanh);
                productDTO.TenLoaiBaoHanh = lbh.LoaiBaoHanh;
                productDTO.MaHanBaoHanh = item.MaHanBaoHanh;
                var hbh = context.TbWarrantyPeriods.FirstOrDefault(t => t.MaHanBaoHanh == item.MaHanBaoHanh);
                productDTO.TenHanBaoHanh = hbh.HanBaoHanh;
                productDTO.MaXuatXu = item.MaXuatXu;
                var xuatxu = context.TbOrigins.FirstOrDefault(t => t.MaXuatXu == item.MaXuatXu);
                productDTO.TenXuatXu = xuatxu.TenXuatXu;
                productDTO.TotalRate = item.TotalRate;
                productDTO.GiaSp = String.Format("{0:0.000}", item.GiaSp);
                productDTO.CreateDay = item.CreateDay;
                productDTO.CreateBy = item.CreateBy;
                productDTO.UpdateBy = item.UpdateBy;
                productDTO.UpdateDay = item.UpdateDay;
                lsProduct.Add(productDTO);
            }
            return lsProduct;
        }

        public TbProduct GetItem(int originid)
        {
            return context.TbProducts.FirstOrDefault(x => x.MaSp == originid);
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