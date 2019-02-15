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
    public partial class ChartLevelPrepare : Form
    {
        public ChartLevelPrepare()
        {
            InitializeComponent();
        }

        private void btnDrawChart_Click(object sender, EventArgs e)
        {
            List<float?> quality = new List<float?> { };
            List<int> countList = new List<int> { };
            DateTime dt = DateTime.ParseExact(textBox1.Text, "yyyy", null);
            using (Entrants db = new Entrants())
            {
                var specs = db.Specialty.Select(sp => new { sp.Id, sp.Name }).ToList();
                chart1.Series["Уровень подготовленности абитуриентов"].Points.Clear();
                for (int i = 0; i < specs.Count; i++)
                {
                    int sp = specs[i].Id;
                    var ens = db.Entrant
                        .Where(s => s.prospective_spec == sp &&
                                    s.yearOfEntry == dt)
                        .Average(a => a.av_ball_cert);

                    var count = db.Entrant
                          .Where(s => s.prospective_spec == sp &&
                                      s.yearOfEntry == dt)
                          .Count();

                    countList.Add(count);
                    quality.Add(ens);

                }
                try
                {
                    for (int i = 0; i < quality.Count; i++)
                        chart1.Series["Уровень подготовленности абитуриентов"].Points.AddXY(specs[i].Name + " (" + countList[i] + ")", quality[i]);
                }catch(Exception)
                {
                    throw;
                }
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            btnDrawChart.Enabled = (textBox1.Text != "") ? true : false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
