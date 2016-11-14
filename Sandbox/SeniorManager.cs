using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class SeniorManager : Manager
    {
        private int performanceLevel;

        public SeniorManager(String name, int baseSalary, int monthlyBonus)
            : base(name, baseSalary, monthlyBonus)
        {
            this.performanceLevel = 0;
        }

        public void setPerformanceLevel(int performanceLevel)
        {
            this.performanceLevel = performanceLevel;
        }

        public override bool IsBonusPaidOut()
        {
            return (performanceLevel >= 6);
        }
    }
}
