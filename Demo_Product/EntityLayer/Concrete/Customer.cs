using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string City { get; set; }
        public int JobID { get; set; }
        public Job Job { get; set; }
    }
}
