using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        public string Name { get; set; }
        public DateTime CommentDate { get; set; }
        public string CommentString { get; set; }
        public bool CommentStatus { get; set; }
        public int DestinationID { get; set; }
        public Destination Destination { get; set; }
    }
}
