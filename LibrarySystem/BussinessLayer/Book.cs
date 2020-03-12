using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySystem.BussinessLayer
{
    public class Book
    {
        public int ID { get; set; }
        public string BookName { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
