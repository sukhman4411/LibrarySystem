using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySystem.BussinessLayer
{
    public class Author
    {
        public int ID { get; set; }
        public string AuthorName { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
