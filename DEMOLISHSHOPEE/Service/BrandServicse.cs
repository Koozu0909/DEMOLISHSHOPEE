﻿using DEMOLISHSHOPEE.Models;

namespace DEMOLISHSHOPEE.Service
{
    public class BrandServicse
    {
        private readonly QUANLYTHUONGMAIContext context;

        public BrandServicse(QUANLYTHUONGMAIContext ctx)
        {
            context = ctx;
        }

        public List<TbBrand> GetList()
        {
            return context.TbBrands.ToList();
        }

        public TbBrand GetItem(int brandid)
        {
            return context.TbBrands.FirstOrDefault(x => x.MaThuongHieu == brandid);
        }

        public TbBrand Add(TbBrand brand)
        {
            try
            {
                context.TbBrands.Add(brand);
                context.SaveChanges();
                return brand;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public TbBrand Update(TbBrand brand)
        {
            try
            {
                var _brand = context.TbBrands.FirstOrDefault(x => x.MaThuongHieu == brand.MaThuongHieu);
                _brand.TenThuongHieu = brand.TenThuongHieu;
                context.SaveChanges();
                return _brand;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public void Delete(int brandid)
        {
            try
            {
                var _brand = context.TbBrands.FirstOrDefault(x => x.MaThuongHieu == brandid);
                context.TbBrands.Remove(_brand);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }
    }
}