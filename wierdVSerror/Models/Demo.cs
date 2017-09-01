using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wierdVSerror.Models
{
    public class Family
    {
        public long ID { get; set; }
        public string FamilyName { get; set; }

        public  virtual List<Child> Children { get; set; }
    }

    public class Child
    {
        public long ID { get; set; }
        public string Name { get; set; }
    }
}