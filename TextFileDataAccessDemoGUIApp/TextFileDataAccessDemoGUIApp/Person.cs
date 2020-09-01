using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileDataAccessDemoGUIApp
{
    class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string url { get; set; }

        public Person() { }

        public string Display
        {
            get
            {
                return string.Format("{0} {1} {2}", firstName, lastName, url);
            }
        }
    }

  
}
