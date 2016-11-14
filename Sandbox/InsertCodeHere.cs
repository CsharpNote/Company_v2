using System;
using System.Collections.Generic;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            // Insert your tests here...
            List<Employee> allEmployees = new List<Employee>();

            Worker w1 = new Worker("John", 130, 130);
            Worker w2 = new Worker("Annie", 120, 160);
            allEmployees.Add(w1);
            allEmployees.Add(w2);

            JuniorManager j1 = new JuniorManager("Steve", 25000, 6000);
            j1.setHoursWorked(140);
            JuniorManager j2 = new JuniorManager("Tanya", 23000, 8000);
            j2.setHoursWorked(185);
            allEmployees.Add(j1);
            allEmployees.Add(j2);

            SeniorManager s1 = new SeniorManager("Sandra", 35000, 16000);
            s1.setPerformanceLevel(7);
            SeniorManager s2 = new SeniorManager("Olav", 38000, 12000);
            s2.setPerformanceLevel(5);
            allEmployees.Add(s1);
            allEmployees.Add(s2);

            foreach (Employee e in allEmployees)
            {
                Console.WriteLine("{0} has a salary of {1}", e.GetName(), e.GetSalaryPerMonth());
            }

            // The LAST line of code should be ABOVE this line
        }
    }
}
