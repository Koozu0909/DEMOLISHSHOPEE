using DEMOLISHSHOPEE.Models;

namespace DEMOLISHSHOPEE.Service
{
    public class CommentService
    {
        private readonly QUANLYTHUONGMAIContext context;

        public CommentService(QUANLYTHUONGMAIContext ctx)
        {
            context = ctx;
        }

        public List<TbComment> GetList()
        {
            return context.TbComments.ToList();
        }

        public TbComment GetItem(int brandid)
        {
            return context.TbComments.FirstOrDefault(x => x.MaComment == brandid);
        }

        public TbComment Add(TbComment origin)
        {
            try
            {
                context.TbComments.Add(origin);
                context.SaveChanges();
                return origin;
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }

        public TbComment Update(TbComment origin)
        {
            try
            {
                TbComment _origin = context.TbComments.FirstOrDefault(x => x.MaComment == origin.MaComment);
                _origin.MaComment = origin.MaComment;
                _origin.MaUser = origin.MaUser;
                _origin.MaSp = origin.MaSp;
                _origin.Rate = origin.Rate;
                _origin.Idreply = origin.Idreply;
                _origin.NoiDung = origin.NoiDung;
                _origin.CreateDay = origin.CreateDay;
                _origin.CreateBy = origin.CreateBy;
                _origin.UpdateDay = origin.UpdateDay;
                _origin.UpdateBy = origin.UpdateBy;

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
                var _origin = context.TbComments.FirstOrDefault(x => x.MaComment == origin);
                context.TbComments.Remove(_origin);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Loi: " + ex.Message);
            }
        }
    }
}