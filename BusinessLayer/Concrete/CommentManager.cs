using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {

        ICommentDal _comment;

        public CommentManager(ICommentDal comment)
        {
            _comment = comment;
        }

        public void add(Comment t)
        {
            _comment.add(t);
        }

        public void delete(Comment t)
        {
            _comment.delete(t);
        }

        public Comment GetByID(int id)
        {
            return _comment.GetByID(id);

        }

        public List<Comment> GetFilterList(int id)
        {
            return _comment.GetFilterList(x => x.DestinationID == id);
        }

        public List<Comment> List()
        {
            return _comment.list();
        }

        public void update(Comment t)
        {
             _comment.update(t);
        }
    }
}
