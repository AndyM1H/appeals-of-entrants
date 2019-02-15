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
    public partial class ChartCount : Form
    {
        public ChartCount()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            btnDrawChart.Enabled = (textBox1.Text != "")? true : false;
            
        }

        private void btnDrawChart_Click(object sender, EventArgs e)
        {
            bool hasErr = false;
            List<int> countList = new List<int> { };
            DateTime dt = DateTime.Now;
            try
            {
                dt = DateTime.ParseExact(textBox1.Text, "yyyy", null);
            } catch (FormatException ex)
            {
                hasErr = true;
                MessageBox.Show(this, ex.Message, "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (!hasErr)
            using (Entrants db = new Entrants())
            {
                var specs = db.Specialty.Select(sp => new { sp.Id, sp.Name }).ToList();
                chart1.Series["Количество абитуриентов"].Points.Clear();
                for (int i = 0; i < specs.Count; i++)
                {
                    int sp = specs[i].Id;
                    var ens = db.Entrant
                        .Where(s => s.prospective_spec == sp &&
                                    s.yearOfEntry == dt)
                        .Count();

                    countList.Add(ens);
                                       
                }

                for (int i = 0; i < countList.Count; i++)
                    chart1.Series["Количество абитуриентов"].Points.AddXY(specs[i].Name, countList[i]);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
