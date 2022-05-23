using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_OOPs_App
{
    public class EngineerDTO : EmployeeDTO
    {
        public int ProfitShare { get; set; }
        public int Alloances { get; set; }
        public int TeamMembers { get; set; }
        public int TeamWorkAllowance { get; set; }
    }
}

