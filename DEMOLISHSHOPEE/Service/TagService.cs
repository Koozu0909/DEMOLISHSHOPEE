using DEMOLISHSHOPEE.Alias;
using DEMOLISHSHOPEE.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace DEMOLISHSHOPEE.Service
{
    public class TagService
    {
        private readonly QUANLYTHUONGMAIContext context;
        private readonly String connectionString = "Data Source=.;Initial Catalog=QUANLYTHUONGMAI;Integrated Security=True;TrustServerCertificate=True";

        public TagService(QUANLYTHUONGMAIContext ctx)
        {
            context = ctx;
        }

        public  List<TbTag> GetList()
        {
            return context.TbTags.ToList();
        }
        public TbTag GetItem(int tagid)
        {
            return context.TbTags.FirstOrDefault(x=> x.MaTag == tagid);
        }


        public TbTag Add(TbTag tag)
        {
            try
            {
                context.TbTags.Add(tag);
                context.SaveChanges();
                return tag;
            }
            catch (Exception ex)
            {

                throw new Exception("Loi: " + ex.Message);
            }

        }

        public TbTag Update(TbTag tag)
        {
            try
            {
                var _tag = context.TbTags.FirstOrDefault(x => x.MaTag == tag.MaTag);
                _tag.TenTag = tag.TenTag;
                context.SaveChanges();
                return _tag;
            }
            catch (Exception ex)
            {

                throw new Exception("Loi: " + ex.Message);
            }

        }

        public void Delete(int tagid)
        {
            try
            {
                var _tag = context.TbTags.FirstOrDefault(x => x.MaTag == tagid);
                var _tagpro = context.TbProductTags.Where(x => x.MaTag == tagid);
                context.TbProductTags.RemoveRange(_tagpro);
                context.TbTags.Remove(_tag);
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Loi: " + ex.Message);
            }

        }

    }
}
