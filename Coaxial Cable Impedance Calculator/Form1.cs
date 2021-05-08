using System;
using System.Windows.Forms;

namespace Coaxial_Cable_Impedance_Calculator
{
    public partial class Form1 : Form
    {
        ICalculate cal;
        public Form1()
        {
            InitializeComponent();
            cal = new Calculate();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            try
            {
                double id = Convert.ToDouble(inner_diameter.Text);
                double od = Convert.ToDouble(outer_diameter.Text);
                double er = Convert.ToDouble(constxt.Text);
                string uid = unit_id.Text;
                string uod = unit_od.Text;
                double[] result = cal.ImCox(id, od, er, uid, uod, "دی الکتریک");
                if (id >= od)
                {
                    MessageBox.Show("!جوون دل، ممکن نیست قطر درونی بزرگتر یا مساوی قطر بیرونی باشه");
                }
                else if (id <=0 || od<=0)
                {
                    MessageBox.Show("!!!از موتوری جنس نگیرید، قطر کابل منفی نمیشه");
                }
                else 
                {
                    MessageBox.Show(" :اینم مقادیری که می خواستی جوون دل" + "\n\n"+
                                     "Zo: " + result[0] + " Ω" + "\n\n" +
                                     "C: " + result[1] + " pF" + "\n\n" +
                                     "L: " + result[2] + " nH" + "\n\n" +
                                     "f_cutoff: " + result[3] + " GHz");
                }
            }
            catch
            {
                MessageBox.Show("برگام، چرا حرف وارد کردی بجای عدد؟ زود درستش کن");
            }
        }
    }
}
