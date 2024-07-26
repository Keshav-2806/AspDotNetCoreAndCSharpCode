using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationDemo
{
    [Serializable]
     class Employee
    {
        public int Id;
        public string EmpName;

      public Employee(int Id,string EmpName)
        {
            this.Id = Id;
            this.EmpName = EmpName;

        }
    }
}
