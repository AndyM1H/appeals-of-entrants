using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntrantsProj
{
    public partial class ChartTMethod : Form
    {
        public ChartTMethod()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            btnDrawChart.Enabled = (textBox1.Text != "") ? true : false;
        }

        private void btnDrawChart_Click(object sender, EventArgs e)
        {
            List<string> t_methodList = new List<string> {
                "Интернет"
            ,   "Родители"
            ,   "Друзья"
            ,   "Другое"
            };
            List<int> countMethods = new List<int> { };
            DateTime dt = DateTime.ParseExact(textBox1.Text, "yyyy", null);
            using (Entrants db = new Entrants())
            {
                chart1.Series["Способ обращения"].Points.Clear();
                for (int i = 0; i < t_methodList.Count; i++)
                {
                    string t_method = t_methodList[i];
                    var ens = db.Entrant
                        .Where(s => s.treatment_method == t_method &&
                                    s.yearOfEntry == dt)
                        .Count();

                    countMethods.Add(ens);

                }
                try
                {
                    for (int i = 0; i < countMethods.Count; i++)
                        chart1.Series["Способ обращения"].Points.AddXY(t_methodList[i], countMethods[i]);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
