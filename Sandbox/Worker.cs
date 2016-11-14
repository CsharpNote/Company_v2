using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class Worker : Employee
    {
        private int hourlyPay;
        private int hoursWorked;

        public Worker(String name, int hourlyPay, int hoursWorked)
            : base(name)
        {
            this.hourlyPay = hourlyPay;
            this.hoursWorked = hoursWorked;
        }

        public override int GetSalaryPerMonth()
        {
            return (hourlyPay * hoursWorked);
        }

        public override int GetBonusPerMonth()
        {
            return 0;
        }

        public override bool IsBonusPaidOut()
        {
            return false;
        }
    }
}
