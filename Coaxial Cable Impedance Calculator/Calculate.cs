using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coaxial_Cable_Impedance_Calculator
{
    class Calculate : ICalculate
    {
        public double factor_unit(string unit)
        {
            double fact = 0;

            switch (unit)
            {
                case "میلیمتر":
                    fact = 0.001;
                    break;

                case "سانتی متر":
                    fact = 0.01;
                    break;

                case "اینچ":
                    fact = 0.0254;
                    break;

                case "فوت":
                    fact = 0.3048;
                    break;
                case "یارد":
                    fact = 0.9144;
                    break;
                default:
                    fact = 1;
                    break;
            }

            return fact;
        }

        public double[] ImCox(double id, double od, double epsilon_r, 
                            string unit_id, string unit_od, string kind_const)
        {
            double factor_i = factor_unit(unit_id);
            double factor_o = factor_unit(unit_od);
            double Zo = (138 * Math.Log10((od* factor_o)/(id* factor_i))) / Math.Sqrt(epsilon_r);
            double CpF = (7.354 * epsilon_r)/(Math.Log10((od * factor_o) / (id * factor_i)));
            double LnH = 140.4 * Math.Log10((od * factor_o) / (id * factor_i));
            double f_cutoff_GHz = 11.8 / (Math.Sqrt(epsilon_r) * Math.PI * ((od * factor_o + id * factor_i) / 2));
            double[] result = new double[4];
            result[0] = Math.Round(Zo, 2);
            result[1] = Math.Round(CpF, 2);
            result[2] = Math.Round(LnH, 2);
            result[3] = Math.Round(f_cutoff_GHz, 2);
            return  result;
        }
    }
}
