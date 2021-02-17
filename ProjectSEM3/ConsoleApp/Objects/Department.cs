using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Objects
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Create_At { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
