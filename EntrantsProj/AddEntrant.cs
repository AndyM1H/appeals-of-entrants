using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntrantsProj
{
    public partial class AddEntrant : Form
    {
        public AddEntrant()
        {
            InitializeComponent();
        }

        private void AddEntrant_Load(object sender, EventArgs e)
        {
            using (Entrants db = new Entrants())
            {
                var specs = db.Specialty.Select(sp => new { sp.Id, sp.Name }).ToList();
                cmbSpec.DataSource = specs;
                cmbSpec.ValueMember = "Id";
                cmbSpec.DisplayMember = "Name";
            }
        }

        private void cmbSpec_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool hasErr = false;
            Entrant en = new Entrant();
            try
            {
                using (Entrants db = new Entrants())
                {
                    string phone = mtxt_phone.Text;
                    string pattern = @"\W";
                    Regex regex = new Regex(pattern);
                    phone = regex.Replace(phone, "");
                    phone = phone.Remove(0, 1);
                    Specialty sp = db.Specialty.SingleOrDefault(s => s.Name == cmbSpec.Text);
                    en = new Entrant
                    {
                        f_name = (txtF_name.Text == string.Empty) ? null : txtF_name.Text,
                        l_name = (txtL_name.Text == string.Empty) ? null : txtL_name.Text,
                        m_name = (txtM_name.Text == string.Empty) ? null : txtM_name.Text,
                        address = (txtAddress.Text == string.Empty) ? null : txtAddress.Text,
                        phone = phone,
                        dob = DT_Dob.Value.Date,
                        treatment_date = DT_treatment_date.Value,
                        treatment_method = (cmb_treatment_method.Text == string.Empty) ? null : cmb_treatment_method.Text,
                        diagnosis = (txtDiagnosis.Text == string.Empty) ? null : txtDiagnosis.Text,
                        notes = (txtNotes.Text == string.Empty) ? null : txtNotes.Text,
                        dis_group = (cmb_dis_group.Text == string.Empty) ? null : cmb_dis_group.Text,
                        av_ball_cert = (IsDigitsOnly(mtxt_av_ball.Text)) ? Convert.ToSingle(mtxt_av_ball.Text) : (float?)null,
                        parents_info = (txtParents_info.Text == string.Empty) ? null : txtParents_info.Text,
                        edu = (txtEdu.Text == string.Empty) ? null : txtEdu.Text,
                        prospective_spec = sp.Id,
                        yearOfEntry = (txt_year_entry.Text == string.Empty) ? (DateTime?)null : DateTime.ParseExact(txt_year_entry.Text, "yyyy", null),
                        gender = (rbtn_male.Checked) ? true : false,
                        poa = (chbox_poa.Checked) ? true : false
                    };
              
                    if (en.Error != null)
                        MessageBox.Show(this, en.Error, "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        db.Entrant.Add(en);
                        db.SaveChanges();
                    }
                  
                }
            }
            catch (FormatException ex)
            {
                hasErr = true;
                MessageBox.Show(this, ex.Message, "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullReferenceException ex)
            {
                hasErr = true;
                MessageBox.Show(this, ex.Message, "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
            {
                hasErr = true;
                MessageBox.Show(this, ex.Message, "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                hasErr = true;
                MessageBox.Show(this, ex.Message, "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (!hasErr && en.Error == null)
                DialogResult = DialogResult.OK;
        }

        private void txt_av_ball_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44)
                e.Handled = true;
        }

        private void txt_year_entry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }
        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if ((c < '0' || c > '9') && c != ',')
                    return false;
            }

            return true;
        }

    }
}
