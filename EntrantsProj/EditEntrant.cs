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
    public partial class EditEntrant : Form
    {
        Entrant entrant;
        public EditEntrant()
        {
            InitializeComponent();
        }
        public EditEntrant(Entrant en)
        {
            InitializeComponent();
            entrant = en;
        }

        private void EditEntrant_Load(object sender, EventArgs e)
        {
            using (Entrants db = new Entrants())
            {
                var specs = db.Specialty.Select(sp => new { sp.Id, sp.Name }).ToList();
                cmbSpec.DataSource = specs;
                cmbSpec.ValueMember = "Id";
                cmbSpec.DisplayMember = "Name";
                
                var spec = db.Specialty.Join(db.Entrant,
                    s => s.Id,
                    en => entrant.prospective_spec,
                    (s, en) => new { s.Name })
                    .ToList();

                cmbSpec.SelectedIndex = cmbSpec.FindString(spec[0].Name);

                var dis_group = db.Entrant.Select(en => new { en.dis_group, en.Id })
                    .Where(en => en.Id == entrant.Id)
                    .ToList();
                cmb_dis_group.SelectedItem = dis_group[0].dis_group;

                var tr_method = db.Entrant.Select(en => new { en.treatment_method, en.Id })
                    .Where(en => en.Id == entrant.Id)
                    .ToList();
                cmb_treatment_method.SelectedItem = tr_method[0].treatment_method;
            }

            DateTime yearEntry = DateTime.Now;
            DateTime? yearEntry_null = null;
            string ye = null;

            if (entrant.yearOfEntry != null)
            {
                yearEntry = (DateTime)entrant.yearOfEntry;
                ye = yearEntry.ToString("yyyy", System.Globalization.CultureInfo.InvariantCulture);
            } 
            else
            {
                yearEntry_null = entrant.yearOfEntry;
            }
              
            string phone = entrant.phone;
            phone = (phone == string.Empty)? null : phone.Remove(0, 1);
            txtF_name.Text = entrant.f_name;
            txtM_name.Text = entrant.m_name;
            txtL_name.Text = entrant.l_name;
            txtAddress.Text = entrant.address;
            mtxt_phone.Text = phone;
            DT_Dob.Value = (DateTime)entrant.dob;
            txtDiagnosis.Text = entrant.diagnosis;
            txtParents_info.Text = entrant.parents_info;
            txtNotes.Text = entrant.notes;
            DT_treatment_date.Value = (DateTime)entrant.treatment_date;
            txt_year_entry.Text = (entrant.yearOfEntry != null)? ye : null;
            txtEdu.Text = entrant.edu;
            mtxt_av_ball.Text = entrant.av_ball_cert.ToString();
            rbtn_male.Checked = entrant.gender;
            rbtn_fmale.Checked = (rbtn_male.Checked) ? false : true;
            chbox_poa.Checked = entrant.poa;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool hasErr = false;
            try
            {
                using (Entrants db = new Entrants())
                {
                    
                    string phone = mtxt_phone.Text;
                    string pattern = @"\W";
                    Regex regex = new Regex(pattern);
                    phone = regex.Replace(phone, "");
                    Specialty sp = db.Specialty.SingleOrDefault(s => s.Name == cmbSpec.Text);
                    entrant.f_name = (txtF_name.Text == string.Empty) ? null : txtF_name.Text;
                    entrant.l_name = (txtL_name.Text == string.Empty) ? null : txtL_name.Text;
                    entrant.m_name = (txtM_name.Text == string.Empty) ? null : txtM_name.Text;
                    entrant.address = (txtAddress.Text == string.Empty) ? null : txtAddress.Text;
                    entrant.phone = phone;
                    entrant.dob = DT_Dob.Value.Date;
                    entrant.treatment_date = DT_treatment_date.Value;
                    entrant.treatment_method = (cmb_treatment_method.Text == string.Empty) ? null : cmb_treatment_method.Text;
                    entrant.diagnosis = (txtDiagnosis.Text == string.Empty) ? null : txtDiagnosis.Text;
                    entrant.notes = (txtNotes.Text == string.Empty) ? null : txtNotes.Text;
                    entrant.dis_group = (cmb_dis_group.Text == string.Empty) ? null : cmb_dis_group.Text;
                    entrant.av_ball_cert = (IsDigitsOnly(mtxt_av_ball.Text)) ?  Convert.ToSingle(mtxt_av_ball.Text) : (float?)null;
                    entrant.edu = (txtEdu.Text == string.Empty) ? null : txtEdu.Text;
                    entrant.parents_info = (txtParents_info.Text == string.Empty) ? null : txtParents_info.Text;
                    entrant.prospective_spec = sp.Id;
                    entrant.yearOfEntry = (txt_year_entry.Text == string.Empty) ? (DateTime?)null : DateTime.ParseExact(txt_year_entry.Text, "yyyy", null);
                    entrant.gender = (rbtn_male.Checked) ? true : false;
                    entrant.poa = (chbox_poa.Checked) ? true : false;
                    if (entrant.Error != null)
                        MessageBox.Show(this, entrant.Error, "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        db.Entry(entrant).State = System.Data.Entity.EntityState.Modified;
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
            if (!hasErr && entrant.Error == null)
                DialogResult = DialogResult.OK;
        
            
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
