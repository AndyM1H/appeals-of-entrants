using LinqKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntrantsProj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Rows_Count = 0;
        bool f_btnYear = true;
        bool f_btnAge = true;

        private void Form1_Load(object sender, EventArgs e)
        {
            GridViewEntrants.AllowUserToDeleteRows = true;
            using (Entrants db = new Entrants())
            {
                var specs = db.Specialty.Select(sp => new { sp.Name });

                cmbSpec.Items.Clear();
                foreach (var s in specs)
                {
                    cmbSpec.Items.Add(s.Name);
                }
                string[] dis_group = {"1 группа","2 группа", "3 группа", "Ребенок-инвалид", "ОВЗ"};
                foreach(var d in dis_group)
                {
                    cmbDisGroup.Items.Add(d);
                }
               
                updateDataGridView();
            }
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEntrant add = new AddEntrant();
            DialogResult result = add.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            MessageBox.Show(this, "Запись добавлена", "Запись абитуриента", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            updateDataGridView();

        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GridViewEntrants.SelectedRows.Count > 0)
            {
                int index = GridViewEntrants.SelectedRows[0].Index;
                int Id = 0;
                bool converted = Int32.TryParse(GridViewEntrants[0, index].Value.ToString(), out Id);
                if (!converted)
                    return;
                GridViewEntrants.Rows.RemoveAt(index);
                Entrant en;
                using (Entrants db = new Entrants())
                {
                    en = db.Entrant.SingleOrDefault(i => i.Id == Id);
                    db.Entrant.Remove(en);
                    db.SaveChanges();
                }


                MessageBox.Show(this, "Запись удалена", "Удаление абитуриента", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GridViewEntrants.Refresh();
                Rows_Count = GridViewEntrants.Rows.Count;
                entrantsCountLabel.Text = $"Количество абитуриентов: {Rows_Count.ToString()}";
            }
        }

        private void GridViewEntrants_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (GridViewEntrants.SelectedRows.Count > 0)
            {
                int index = GridViewEntrants.SelectedRows[0].Index;
                int Id = 0;
                bool converted = Int32.TryParse(GridViewEntrants[0, index].Value.ToString(), out Id);
                if (!converted)
                    return;
                Entrant en;
                using (Entrants db = new Entrants())
                {
                    en = db.Entrant.SingleOrDefault(i => i.Id == Id);
                    db.Entrant.Remove(en);
                    db.SaveChanges();
                }

                MessageBox.Show(this, "Запись удалена", "Удаление абитуриента", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GridViewEntrants.Refresh();
                Rows_Count = GridViewEntrants.Rows.Count;
                entrantsCountLabel.Text = $"Количество абитуриентов: {Rows_Count.ToString()}";
            }
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GridViewEntrants.SelectedRows.Count > 0)
            {
                int index = GridViewEntrants.SelectedRows[0].Index;
                int Id = 0;
                bool converted = Int32.TryParse(GridViewEntrants[0, index].Value.ToString(), out Id);
                if (!converted)
                    return;
                Entrant entrant;
                using (Entrants db = new Entrants())
                {
                    entrant = db.Entrant.SingleOrDefault(i => i.Id == Id);
                }

                EditEntrant edit = new EditEntrant(entrant);
                DialogResult result = edit.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                MessageBox.Show(this, "Запись изменена", "Редактирование абитуриента", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                updateDataGridView();
                checkBox1.Checked = false;
            }
        }

        private void cmbSpec_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            updateDataGridView();
            checkBox1.Checked = false;
            txtSearch.Text = "";
            btnClearSpecs.Enabled = true;
            
        }

        private void cmbDisGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            updateDataGridView();
            btnClearDgroup.Enabled = true;
            checkBox1.Checked = false;
            txtSearch.Text = "";
        }

        private void btnClearDgroup_Click(object sender, EventArgs e)
        {
          
            cmbDisGroup.Items.Clear();
            string[] dis_group = { "1 группа", "2 группа", "3 группа", "Ребенок-инвалид", "ОВЗ" };
            foreach (var d in dis_group)
            {
                cmbDisGroup.Items.Add(d);
            }
            updateDataGridView();
            btnClearDgroup.Enabled = false;
        }
       
        private void btnYear_Click(object sender, EventArgs e)
        {
            if (!f_btnYear)
            {
                txtYear.Text = "";
                btnYear.Image = EntrantsProj.Properties.Resources.tick;
                f_btnYear = true;
                txtYear.Enabled = true;
            }
            else
            {
                btnYear.Image = EntrantsProj.Properties.Resources.clear_button1;
                f_btnYear = false;
                txtYear.Enabled = false;
            }
            updateDataGridView();
            
 
        }

        
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            string searchValue = txtSearch.Text;
            try
            {
                bool valueResult = false;
                foreach (DataGridViewRow row in GridViewEntrants.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (row.Cells[i].Value != null && row.Cells[1].Value.ToString().Contains(searchValue))
                        {
                            int rowIndex = row.Index;
                            GridViewEntrants.Rows[rowIndex].Selected = true;
                            valueResult = true;
                            break;
                        } else
                        {
                            //if(row.Index != -1)
                            //GridViewEntrants.Rows.RemoveAt(row.Index);
                        }
                    }

                }
                if (!valueResult)
                {
                    return;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                using (Entrants db = new Entrants())
                {
                  
                    var ens = db.Specialty.Join(db.Entrant,
                          s => s.Id,
                          en => en.prospective_spec,
                          (s, en) => new
                          {
                              en.Id,
                              ФИО = en.m_name + " " + en.f_name + " " + en.l_name,
                              Адрес = en.address,
                              Дата_рождения = en.dob,
                              Телефон = en.phone,
                              Координаты_родителей = en.parents_info,
                              Базовое_образование = en.edu,
                              Дата_обращения = en.treatment_date,
                              Источник_информирования = en.treatment_method,
                              Предпологаемая_специальность = s.Name,
                              Группа_инвалидности = en.dis_group,
                              Диагноз = en.diagnosis,
                              Примечание = en.notes,
                              Год_поступления = en.yearOfEntry
                          })
                            .OrderBy(en => en.ФИО).ToList();
                    BindingSource bs = new BindingSource();
                    bs.DataSource = ens;
                    GridViewEntrants.DataSource = bs;
                    Rows_Count = GridViewEntrants.Rows.Count;
                    entrantsCountLabel.Text = $"Количество абитуриентов: {Rows_Count.ToString()}";
                }
            }
            else
            {
                /*
                if (cmbSpec.Text != string.Empty)
                    cmbSpec_SelectedIndexChanged(e, e);
                if (cmbDisGroup.Text != string.Empty)
                    cmbDisGroup_SelectedIndexChanged(e, e);
                 */
                updateDataGridView();
            }
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            btnYear.Enabled = (txtYear.Text != string.Empty) ?  true : false;  

        }

        private void экспортToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ExcelExport EReport = new ExcelExport();
            EReport.CreateReport(GridViewEntrants);
        }

        private void рейтингСпециальностейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChartCount cc = new ChartCount();
            DialogResult result = cc.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;
        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void уровеньПодготовленностиАбитуриентовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChartLevelPrepare clp = new ChartLevelPrepare();
            DialogResult result = clp.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;
        }

        private void GridViewEntrants_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridViewEntrants.SelectedRows.Count > 0)
            {
                int index = GridViewEntrants.SelectedRows[0].Index;
                int Id = 0;
                bool converted = Int32.TryParse(GridViewEntrants[0, index].Value.ToString(), out Id);
                if (!converted)
                    return;
                Entrant entrant;
                using (Entrants db = new Entrants())
                {
                    entrant = db.Entrant.SingleOrDefault(i => i.Id == Id);
                }

                EditEntrant edit = new EditEntrant(entrant);
                DialogResult result = edit.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                MessageBox.Show(this, "Запись изменена", "Редактирование абитуриента", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                updateDataGridView();
                //checkBox1.Checked = false;
            }
        }

        private void статистикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChartTMethod ctm = new ChartTMethod();
            DialogResult result = ctm.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;
        }

        private void updateDataGridView()
        {
            bool f_sp, f_dg, f_ye;
            f_sp = (string.IsNullOrEmpty(cmbSpec.Text)) ? false : true;
            f_dg = (string.IsNullOrEmpty(cmbDisGroup.Text)) ? false : true;
            f_ye = (string.IsNullOrEmpty(txtYear.Text)) ? false : true;

            DateTime curdate = DateTime.Now;
            DateTime s_curdate = DateTime.Now;
            if (txtAge.Text.Length > 2)
            {
                string a = txtAge.Text;
                string[] range_age = a.Split('-');
                int f_age = 0;
                int s_age = 0;
                try
                {
                     f_age = int.Parse(range_age[1]);
                     s_age = int.Parse(range_age[0]);
                } catch(FormatException ex)
                {
                    MessageBox.Show(this, ex.Message, "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
                curdate = curdate.AddYears(-f_age-1);
                s_curdate = s_curdate.AddYears(-s_age);

            } else
            {
                int age = 0;
                try
                {
                    age = string.IsNullOrEmpty(txtAge.Text) ? 0 : int.Parse(txtAge.Text);
                }
                catch(FormatException ex)
                {
                    MessageBox.Show(this, ex.Message, "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                   
                curdate = curdate.AddYears(-age - 1);
                s_curdate = s_curdate.AddYears(-age);
            }
           
            
            var year = (string.IsNullOrEmpty(txtYear.Text))? null : (DateTime?)DateTime.ParseExact(txtYear.Text, "yyyy", null);
            var predicate = PredicateBuilder.True<Entrant>();


            using (Entrants db = new Entrants())
            {
                var specialty = db.Specialty.SingleOrDefault(s => s.Name == cmbSpec.Text);
             
                if (f_sp)
                    predicate = predicate.And(i => i.prospective_spec == specialty.Id);

                if (f_dg)
                    predicate = predicate.And(i => i.dis_group == cmbDisGroup.Text);

                if (f_ye)
                    predicate = predicate.And(i => i.yearOfEntry == year);

                if (chbox_poaTrue.Checked && chbox_poaFalse.Checked)
                    predicate = predicate.And(i => i.poa == true || i.poa == false);

                if (chbox_poaTrue.Checked && !chbox_poaFalse.Checked)
                    predicate = predicate.And(i => i.poa == true);
                else if(chbox_poaFalse.Checked && !chbox_poaTrue.Checked)
                    predicate = predicate.And(i => i.poa == false);

                if (chbox_fmale.Checked && chbox_male.Checked)
                    predicate = predicate.And(i => i.gender == true || i.gender == false);

                if (chbox_male.Checked && !chbox_fmale.Checked)
                    predicate = predicate.And(i => i.gender == true);
                else if (chbox_fmale.Checked && !chbox_male.Checked)
                    predicate = predicate.And(i => i.gender == false);

                if (txtAge.Text.Length > 2)
                {
                    predicate = predicate.And(i => i.dob > curdate && i.dob < s_curdate);
                } else 
                if (!string.IsNullOrEmpty(txtAge.Text))
                {

                    predicate = predicate.And(i => i.dob > curdate && i.dob < s_curdate);
                }
               

                var ents  = db.Entrant.AsExpandable().Where(predicate).Join(db.Specialty,
                                         en => en.prospective_spec,
                                         s => s.Id,
                                        (en, s) => new
                                        {
                                            en.Id,
                                            ФИО = en.m_name + " " + en.f_name + " " + en.l_name,
                                            Адрес = en.address,
                                            Дата_рождения = en.dob,
                                            Телефон = en.phone,
                                            Координаты_родителей = en.parents_info,
                                            Базовое_образование = en.edu,
                                            Дата_обращения = en.treatment_date,
                                            Источник_информирования = en.treatment_method,
                                            Предполагаемая_специальность = s.Name,
                                            Группа_инвалидности = en.dis_group,
                                            Диагноз = en.diagnosis,
                                            Примечание = en.notes,
                                            Год_поступления = en.yearOfEntry
                                        }).OrderBy(en => en.ФИО).ToList();
                BindingSource bs = new BindingSource();
                bs.DataSource = ents;
                GridViewEntrants.DataSource = bs;
               
            }
            Rows_Count = GridViewEntrants.Rows.Count;
            entrantsCountLabel.Text = $"Количество абитуриентов: {Rows_Count.ToString()}";
        }

       

        private void chbox_male_CheckedChanged(object sender, EventArgs e)
        {
            updateDataGridView();
        }

        private void chbox_fmale_CheckedChanged(object sender, EventArgs e)
        {
            updateDataGridView();
        }

        private void btnClearSpecs_Click(object sender, EventArgs e)
        {
            using(Entrants db = new Entrants())
            {
                var specs = db.Specialty.Select(sp => new { sp.Name });
                cmbSpec.Items.Clear();
                foreach (var s in specs)
                {
                    cmbSpec.Items.Add(s.Name);
                }
            }
            updateDataGridView();
            btnClearSpecs.Enabled = false;
        }

        private void chbox_poaTrue_CheckedChanged(object sender, EventArgs e)
        {
            updateDataGridView();
        }

        private void chbox_poaFalse_CheckedChanged(object sender, EventArgs e)
        {
            updateDataGridView();
        }

        private void btnAge_Click(object sender, EventArgs e)
        {
            if (!f_btnAge)
            {
                txtAge.Text = "";
                btnAge.Image = EntrantsProj.Properties.Resources.tick;
                f_btnAge = true;
                txtAge.Enabled = true;
            }
            else
            {
                btnAge.Image = EntrantsProj.Properties.Resources.clear_button1;
                f_btnAge = false;
                txtAge.Enabled = false;
            }
            updateDataGridView();
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            btnAge.Enabled = (!string.IsNullOrEmpty(txtAge.Text)) ? true : false;
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 45)
                e.Handled = true;
        }

        
    }

 
}

