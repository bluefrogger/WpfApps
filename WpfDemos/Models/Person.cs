using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDemos.Models
{
    class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        private string fullName;

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
            set
            {
                fullName = value;
            }
        }
    }
}
