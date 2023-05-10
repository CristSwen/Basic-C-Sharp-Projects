using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    class Employee
    {
        public int Id { set; get; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        
        public static bool operator== (Employee id1, Employee id2)
        {
            bool result = false;
            if (id1.Id == id2.Id)
            {
                result = true;
            }
            return result;
        }

        public static bool operator!= (Employee id1, Employee id2)
        {
            bool result = false;
            if (id1.Id != id2.Id)
            {
                result = true;
            }
            return result;
        }
    }
}
