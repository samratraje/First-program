using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_OOPs_App
{
    class DeveloperPayroll : PayrollBase
    {
        public override double CalculateTax(int netsalary)
        {
            TaxRules tax = new TaxRules();
            int slab = tax.GetTaxSlab(netsalary);
            // cast the slab/100 to double because int/int is always int
            return netsalary * ((double)slab / 100);
        }

        private bool IsNewCustomerAligned()
        {
            return true;
        }
        private int GetFlightTicketsAmout()
        {
            return 10000;
        }

        public override int CalculateIncome(EmployeeDTO emp)
        {
            DeveloperDTO DeveloperDTO = new DeveloperDTO();
            DeveloperDTO.Salary = emp.Salary;
            DeveloperDTO.ProfitShare = 120000;
            if (IsNewCustomerAligned())
            {
                return DeveloperDTO.Salary + GetFlightTicketsAmout() + DeveloperDTO.ProfitShare;
            }
            else
            {
                return DeveloperDTO.Salary;
            }


            // as it is implmentation of base
            // return base.CalculateIncome(emp);
        }
    }
}
