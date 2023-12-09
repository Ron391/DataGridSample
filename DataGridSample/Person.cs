using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridSample
{
    public class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public bool IsFictitious { get; set; }

        public Person(string firstname, string lastname, bool isFictitious)
        {
            Firstname = firstname;
            Lastname = lastname;
            IsFictitious = isFictitious;
        }
    }
}
