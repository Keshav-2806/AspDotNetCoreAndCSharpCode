using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassDemo
{
    public partial class StudentPartial
    {
        public String getCompleteName()
        {
            return _firstName + " " + _lastName;
        }
    }
}
