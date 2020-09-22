using System.ComponentModel.DataAnnotations;

namespace DetectiveAgency.Models
{
    public class Employee
    { 
    [Required(ErrorMessage = "Please enter an employee ID to continue.")]
    public int ID { get; set; }

    [StringLength(30)]
    public string Name { get; set; }

    [Required(ErrorMessage = "Please enter the amount of hours worked per week.")]
        [Range(10,75, ErrorMessage = "Hours must be between 10 and 75.")]
    public double Hours { get; set; }

    [Required(ErrorMessage = "Please enter your hourly pay rate.")]
        [Range(15, 75, ErrorMessage ="Rate should be between $15 and $75")]
    public double Rate { get; set; }
    public double CalcSalary()
    {
            double grossPay = 0;
            double overtime = 0;
            double regPay = 0;
            if (Hours>40)
            {
                regPay = 40 * Rate;
                overtime = (Hours - 40) * (1.5 + Rate);
            }
            else
            {
                regPay = Hours * Rate;
            }
            grossPay = regPay + overtime;
            return grossPay;
    }
}
}