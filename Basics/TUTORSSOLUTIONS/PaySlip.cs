using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryManagement
{
    public class PaySlip
    {
        public int Month { get; set; }

        public int Year { get; set; }

        public PaySlip(int paymentMonth, int paymentYear)
        {
            Month = paymentMonth;
            Year = paymentYear;
        }

        public void GeneratePaySlip(List<Staff> myStaff)
        {
            string path;
            foreach (Staff f in myStaff)
            {
                path = f.FirstName + ".txt";

                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine("PAYSLIP FOR {0} {1}", (Month)Month, Year);
                    sw.WriteLine("====================");
                    sw.WriteLine("Name of Staff: {0} {1}", f.FirstName, f.LastName);
                    sw.WriteLine("Staff Number: {0}", f.StaffNumber);
                    sw.WriteLine("Hours Worked: {0}", f.HoursWorked);
                    sw.WriteLine("");
                    sw.WriteLine("Basic Pay: {0:C}", f.BasicPay);

                    if (f.GetType() == typeof(SalaryManager))
                    sw.WriteLine("Allowance: {0:C}", ((SalaryManager)f).Allowance);
                    /*else if (f.GetType() == typeof(Admin))
                        sw.WriteLine("Overtime: {0:C}",
                        ((Admin)f).overtime);*/
                    sw.WriteLine("");
                    sw.WriteLine("====================");
                    sw.WriteLine("Total Pay: {0:C}", f.TotalPay);
                    sw.WriteLine("====================");
                    sw.WriteLine("Date Issued: {0}", DateTime.UtcNow);
                    sw.Close();
                }
            }
        }

        public void GenerateSummary(List<Staff> myStaff)
        {
            var result = from f in myStaff
                         /*where f.HoursWorked < 10*/
                         orderby f.FirstName ascending
                         select new { f.FirstName, f.HoursWorked };

            string path = "summary.txt";

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("Staff with less than 10 working hours");
                sw.WriteLine("");
                foreach (var f in result)
                    sw.WriteLine("Name of Staff: {0}, Hours Worked:{1} ", f.FirstName, f.HoursWorked);
                sw.Close();
            }
        }


        public void GenerateSummaryBasedOnDesignation(List<Staff> myStaff)
        {
            var result = from f in myStaff
                             where f.Designation == "Manager"
                         orderby f.FirstName ascending
                         select new { f.FirstName, f.TotalPay };

            string path = "summary2.txt";

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("Staff with less than 10 working hours");
                sw.WriteLine("");
                foreach (var f in result)
                    sw.WriteLine("Name of Staff: {0}, Hours Worked:{1} ", f.FirstName, f.TotalPay);
                sw.Close();
            }
        }
        public override string ToString()
        {
            return "month = " + Month + "year = " + Year;
        }

    }
}
