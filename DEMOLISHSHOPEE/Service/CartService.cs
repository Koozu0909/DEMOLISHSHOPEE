using DEMOLISHSHOPEE.Alias;
using DEMOLISHSHOPEE.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace DEMOLISHSHOPEE.Service
{
    public class CartService
    {
    private readonly QUANLYTHUONGMAIContext context;
   
    public CartService(QUANLYTHUONGMAIContext ctx)
    {
        context = ctx;
    }

    public List<TbCart> GetList()
    {
        return context.TbCarts.ToList();
    }
    public TbCart GetItem(int brandid)
    {
        return context.TbCarts.FirstOrDefault(x => x.MaCart == brandid);
    }


    public TbCart Add(TbCart origin)
    {
        try
        {
            context.TbCarts.Add(origin);
            context.SaveChanges();
            return origin;
        }
        catch (Exception ex)
        {

            throw new Exception("Loi: " + ex.Message);
        }

    }

    public TbCart Update(TbCart origin)
    {
        try
        {
                TbCart _origin = context.TbCarts.FirstOrDefault(x => x.MaCart == origin.MaCart);
                _origin.MaCart = origin.MaCart;
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
            var _origin = context.TbCarts.FirstOrDefault(x => x.MaCart == origin);
            context.TbCarts.Remove(_origin);
            context.SaveChanges();
        }
        catch (Exception ex)
        {

            throw new Exception("Loi: " + ex.Message);
        }

    }
}
}
