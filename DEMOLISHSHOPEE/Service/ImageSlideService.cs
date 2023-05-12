using DEMOLISHSHOPEE.Models;

namespace DEMOLISHSHOPEE.Service
{
    public class ImageSlideService
    {
        private readonly QUANLYTHUONGMAIContext context;
       
        public ImageSlideService(QUANLYTHUONGMAIContext ctx)
        {
            context = ctx;
        }

        public List<TbImageSlide> GetList()
        {
            return context.TbImageSlides.ToList();
        }

        public TbImageSlide GetItem(int originid)
        {
            return context.TbImageSlides.FirstOrDefault(x => x.MaImageSlide == originid);
        }

        public TbImageSlide Add(TbImageSlide origin)
        {
            try
            {
                context.TbImageSlides.Add(origin);
                context.SaveChanges();
                return origin;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public TbImageSlide Update(TbImageSlide origin)
        {
            try
            {
                var _origin = context.TbImageSlides.FirstOrDefault(x => x.MaImageSlide == origin.MaImageSlide);
                _origin.MaImageSlide = origin.MaImageSlide;
                _origin.ImageSlidePath = origin.ImageSlidePath;


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
                var _origin = context.TbImageSlides.FirstOrDefault(x => x.MaImageSlide == originid);
                context.TbImageSlides.Remove(_origin);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }
    }
}