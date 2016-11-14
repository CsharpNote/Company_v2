using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    abstract class Manager : Employee
    {
        private int baseSalary;
        private int monthlyBonus;

        public Manager(String name, int baseSalary, int monthlyBonus)
            : base(name)
        {
            this.baseSalary = baseSalary;
            this.monthlyBonus = monthlyBonus;
        }

        public override int GetSalaryPerMonth()
        {
            int totalSalary = baseSalary;

            if (IsBonusPaidOut())
            {
                totalSalary = totalSalary + monthlyBonus;
            }

            return totalSalary;
        }

        public override int GetBonusPerMonth()
        {
            return monthlyBonus;
        }
    }
}
