using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo01.logic
{
    internal class Person
    {
        public String fname;
        public String lname;
    }

    internal class Employee : Person
    {
        public int emp_id;
    }
}
