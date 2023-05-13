using DEMOLISHSHOPEE.Alias;
using DEMOLISHSHOPEE.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace DEMOLISHSHOPEE.Service
{
    public class BranchProductService
    {
    private readonly QUANLYTHUONGMAIContext context;
   
    public BranchProductService(QUANLYTHUONGMAIContext ctx)
    {
        context = ctx;
    }

    public List<TbBranchProduct> GetList()
    {
        return context.TbBranchProducts.ToList();
    }
    public TbBranchProduct GetItem(int brandid)
    {
        return context.TbBranchProducts.FirstOrDefault(x => x.MaBranchProduct == brandid);
    }


    public TbBranchProduct Add(TbBranchProduct origin)
    {
        try
        {
            context.TbBranchProducts.Add(origin);
            context.SaveChanges();
            return origin;
        }
        catch (Exception ex)
        {

            throw new Exception("Loi: " + ex.Message);
        }

    }

    public TbBranchProduct Update(TbBranchProduct origin)
    {
        try
        {
                TbBranchProduct _origin = context.TbBranchProducts.FirstOrDefault(x => x.MaBranchProduct == origin.MaBranchProduct);
                _origin.MaBranchProduct  = origin.MaBranchProduct;
                _origin.MaCuaHang = origin.MaCuaHang;
                _origin.MaSp =   origin.MaSp;
                _origin.SoLuongSp =  origin.SoLuongSp;


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
            var _origin = context.TbBranchProducts.FirstOrDefault(x => x.MaBranchProduct == origin);
            context.TbBranchProducts.Remove(_origin);
            context.SaveChanges();
        }
        catch (Exception ex)
        {

            throw new Exception("Loi: " + ex.Message);
        }

    }
}
}
