using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class JuniorManager : Manager
    {
        private int hoursWorked;

        public JuniorManager(String name, int baseSalary, int monthlyBonus)
            : base(name, baseSalary, monthlyBonus)
        {
            this.hoursWorked = 0;
        }

        public void setHoursWorked(int hoursWorked)
        {
            this.hoursWorked = hoursWorked;
        }

        public override bool IsBonusPaidOut()
        {
            return (hoursWorked > 180);
        }
    }
}
