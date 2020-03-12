using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySystem.BussinessLayer
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public Nullable<int> AuthorID { get; set; }
        public Nullable<int> BookID { get; set; }

        public virtual Author Author { get; set; }
        public virtual Book Book { get; set; }
    }
}
