using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Step
{
    internal static class HR
    {
        public static void Empoloy(Worker worker, Organization organization)
        {
            worker.SetWorkPlace(organization);
            worker.SetSalary(50000);
            worker.SetPosition("Программист");
        }
        public static void Dismiss(Worker worker)
        {
            worker.SetWorkPlace(null);
            worker.SetSalary(0);
            worker.SetPosition("");
        }
    }
}
