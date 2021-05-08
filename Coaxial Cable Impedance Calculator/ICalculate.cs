using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coaxial_Cable_Impedance_Calculator
{
    interface ICalculate
    {
        double[] ImCox(double id, double od, double epsilon_r,
                     string unit_id, string unit_od, string kind_const);
    }
}
