using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Words
    {
        public string fName;
        public string lName;

        public Words(string fName) : this(fName, "Bob")
        {

        }

        public Words(string fName, string lName)
        {
            this.fName = fName;
            this.lName = lName;
        }
    }
}
