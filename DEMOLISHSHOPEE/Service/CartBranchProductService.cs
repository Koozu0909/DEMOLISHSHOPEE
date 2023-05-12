using DEMOLISHSHOPEE.Alias;
using DEMOLISHSHOPEE.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace DEMOLISHSHOPEE.Service
{
    public class CartBranchProductService
    {
    private readonly QUANLYTHUONGMAIContext context;
   
    public CartBranchProductService(QUANLYTHUONGMAIContext ctx)
    {
        context = ctx;
    }

    public List<TbCartBranchProduct> GetList()
    {
        return context.TbCartBranchProducts.ToList();
    }
    public TbCartBranchProduct GetItem(int brandid)
    {
        return context.TbCartBranchProducts.FirstOrDefault(x => x.MaCart == brandid);
    }


    public TbCartBranchProduct Add(TbCartBranchProduct origin)
    {
        try
        {
            context.TbCartBranchProducts.Add(origin);
            context.SaveChanges();
            return origin;
        }
        catch (Exception ex)
        {

            throw new Exception("Loi: " + ex.Message);
        }

    }

    public TbCartBranchProduct Update(TbCartBranchProduct origin)
    {
        try
        {
                TbCartBranchProduct _origin = context.TbCartBranchProducts.FirstOrDefault(x => x.MaCart == origin.MaCart);
                _origin.MaCart = origin.MaCart;
                _origin.MaBranchProduct = origin.MaBranchProduct;
             


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
            var _origin = context.TbCartBranchProducts.FirstOrDefault(x => x.MaCart == origin);
            context.TbCartBranchProducts.Remove(_origin);
            context.SaveChanges();
        }
        catch (Exception ex)
        {

            throw new Exception("Loi: " + ex.Message);
        }

    }
}
}
