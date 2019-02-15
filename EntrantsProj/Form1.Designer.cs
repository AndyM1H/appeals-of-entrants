namespace EntrantsProj
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GridViewEntrants = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClearSpecs = new System.Windows.Forms.Button();
            this.btnYear = new System.Windows.Forms.Button();
            this.btnClearDgroup = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDisGroup = new System.Windows.Forms.ComboBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSpec = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.студентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.диаграммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рейтингСпециальностейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уровеньПодготовленностиАбитуриентовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статистикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.entrantsCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.chbox_male = new System.Windows.Forms.CheckBox();
            this.chbox_fmale = new System.Windows.Forms.CheckBox();
            this.chbox_poaFalse = new System.Windows.Forms.CheckBox();
            this.chbox_poaTrue = new System.Windows.Forms.CheckBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.btnAge = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupbox_details = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewEntrants)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupbox_details.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridViewEntrants
            // 
            this.GridViewEntrants.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridViewEntrants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridViewEntrants.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridViewEntrants.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.GridViewEntrants.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridViewEntrants.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewEntrants.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.GridViewEntrants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridViewEntrants.DefaultCellStyle = dataGridViewCellStyle20;
            this.GridViewEntrants.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GridViewEntrants.GridColor = System.Drawing.SystemColors.ControlLight;
            this.GridViewEntrants.Location = new System.Drawing.Point(16, 178);
            this.GridViewEntrants.MultiSelect = false;
            this.GridViewEntrants.Name = "GridViewEntrants";
            this.GridViewEntrants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridViewEntrants.Size = new System.Drawing.Size(1035, 268);
            this.GridViewEntrants.TabIndex = 0;
            this.GridViewEntrants.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewEntrants_CellDoubleClick);
            this.GridViewEntrants.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.GridViewEntrants_UserDeletingRow);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnClearSpecs);
            this.panel1.Controls.Add(this.btnYear);
            this.panel1.Controls.Add(this.btnClearDgroup);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmbDisGroup);
            this.panel1.Controls.Add(this.txtYear);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbSpec);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 87);
            this.panel1.TabIndex = 1;
            // 
            // btnClearSpecs
            // 
            this.btnClearSpecs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClearSpecs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClearSpecs.Enabled = false;
            this.btnClearSpecs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClearSpecs.Image = ((System.Drawing.Image)(resources.GetObject("btnClearSpecs.Image")));
            this.btnClearSpecs.Location = new System.Drawing.Point(310, 46);
            this.btnClearSpecs.Name = "btnClearSpecs";
            this.btnClearSpecs.Size = new System.Drawing.Size(27, 25);
            this.btnClearSpecs.TabIndex = 16;
            this.btnClearSpecs.UseVisualStyleBackColor = true;
            this.btnClearSpecs.Click += new System.EventHandler(this.btnClearSpecs_Click);
            // 
            // btnYear
            // 
            this.btnYear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnYear.Enabled = false;
            this.btnYear.Image = ((System.Drawing.Image)(resources.GetObject("btnYear.Image")));
            this.btnYear.Location = new System.Drawing.Point(779, 49);
            this.btnYear.Name = "btnYear";
            this.btnYear.Size = new System.Drawing.Size(28, 23);
            this.btnYear.TabIndex = 15;
            this.btnYear.UseVisualStyleBackColor = true;
            this.btnYear.Click += new System.EventHandler(this.btnYear_Click);
            // 
            // btnClearDgroup
            // 
            this.btnClearDgroup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClearDgroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClearDgroup.Enabled = false;
            this.btnClearDgroup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClearDgroup.Image = ((System.Drawing.Image)(resources.GetObject("btnClearDgroup.Image")));
            this.btnClearDgroup.Location = new System.Drawing.Point(548, 47);
            this.btnClearDgroup.Name = "btnClearDgroup";
            this.btnClearDgroup.Size = new System.Drawing.Size(27, 25);
            this.btnClearDgroup.TabIndex = 14;
            this.btnClearDgroup.UseVisualStyleBackColor = true;
            this.btnClearDgroup.Click += new System.EventHandler(this.btnClearDgroup_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(419, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Льготы";
            // 
            // cmbDisGroup
            // 
            this.cmbDisGroup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbDisGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDisGroup.FormattingEnabled = true;
            this.cmbDisGroup.Location = new System.Drawing.Point(351, 46);
            this.cmbDisGroup.Name = "cmbDisGroup";
            this.cmbDisGroup.Size = new System.Drawing.Size(191, 25);
            this.cmbDisGroup.TabIndex = 12;
            this.cmbDisGroup.SelectedIndexChanged += new System.EventHandler(this.cmbDisGroup_SelectedIndexChanged);
            // 
            // txtYear
            // 
            this.txtYear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtYear.Location = new System.Drawing.Point(621, 49);
            this.txtYear.MaxLength = 4;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(152, 23);
            this.txtYear.TabIndex = 11;
            this.txtYear.TextChanged += new System.EventHandler(this.txtYear_TextChanged);
            this.txtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYear_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(587, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Предполагаемый год поступления";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearch.Location = new System.Drawing.Point(865, 48);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(152, 23);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(893, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Поиск по ФИО";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Специальность";
            // 
            // cmbSpec
            // 
            this.cmbSpec.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbSpec.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cmbSpec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpec.DropDownWidth = 300;
            this.cmbSpec.FormattingEnabled = true;
            this.cmbSpec.Location = new System.Drawing.Point(18, 46);
            this.cmbSpec.Name = "cmbSpec";
            this.cmbSpec.Size = new System.Drawing.Size(286, 25);
            this.cmbSpec.TabIndex = 0;
            this.cmbSpec.SelectedIndexChanged += new System.EventHandler(this.cmbSpec_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.студентыToolStripMenuItem,
            this.диаграммыToolStripMenuItem,
            this.excelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1035, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // студентыToolStripMenuItem
            // 
            this.студентыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.студентыToolStripMenuItem.Name = "студентыToolStripMenuItem";
            this.студентыToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.студентыToolStripMenuItem.Text = "Абитуриент";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // диаграммыToolStripMenuItem
            // 
            this.диаграммыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рейтингСпециальностейToolStripMenuItem,
            this.уровеньПодготовленностиАбитуриентовToolStripMenuItem,
            this.статистикаToolStripMenuItem});
            this.диаграммыToolStripMenuItem.Name = "диаграммыToolStripMenuItem";
            this.диаграммыToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.диаграммыToolStripMenuItem.Text = "Диаграммы";
            // 
            // рейтингСпециальностейToolStripMenuItem
            // 
            this.рейтингСпециальностейToolStripMenuItem.Name = "рейтингСпециальностейToolStripMenuItem";
            this.рейтингСпециальностейToolStripMenuItem.Size = new System.Drawing.Size(307, 22);
            this.рейтингСпециальностейToolStripMenuItem.Text = "Рейтинг специальностей";
            this.рейтингСпециальностейToolStripMenuItem.Click += new System.EventHandler(this.рейтингСпециальностейToolStripMenuItem_Click);
            // 
            // уровеньПодготовленностиАбитуриентовToolStripMenuItem
            // 
            this.уровеньПодготовленностиАбитуриентовToolStripMenuItem.Name = "уровеньПодготовленностиАбитуриентовToolStripMenuItem";
            this.уровеньПодготовленностиАбитуриентовToolStripMenuItem.Size = new System.Drawing.Size(307, 22);
            this.уровеньПодготовленностиАбитуриентовToolStripMenuItem.Text = "Уровень подготовленности абитуриентов ";
            this.уровеньПодготовленностиАбитуриентовToolStripMenuItem.Click += new System.EventHandler(this.уровеньПодготовленностиАбитуриентовToolStripMenuItem_Click);
            // 
            // статистикаToolStripMenuItem
            // 
            this.статистикаToolStripMenuItem.Name = "статистикаToolStripMenuItem";
            this.статистикаToolStripMenuItem.Size = new System.Drawing.Size(307, 22);
            this.статистикаToolStripMenuItem.Text = "Статистика \"Источник информирования\"";
            this.статистикаToolStripMenuItem.Click += new System.EventHandler(this.статистикаToolStripMenuItem_Click);
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.экспортToolStripMenuItem});
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.excelToolStripMenuItem.Text = "Excel";
            // 
            // экспортToolStripMenuItem
            // 
            this.экспортToolStripMenuItem.Name = "экспортToolStripMenuItem";
            this.экспортToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.экспортToolStripMenuItem.Text = "Экспорт";
            this.экспортToolStripMenuItem.Click += new System.EventHandler(this.экспортToolStripMenuItem_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.checkBox1.Location = new System.Drawing.Point(878, 32);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(121, 21);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Показать всех";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entrantsCountLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 449);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(174, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // entrantsCountLabel
            // 
            this.entrantsCountLabel.Name = "entrantsCountLabel";
            this.entrantsCountLabel.Size = new System.Drawing.Size(157, 17);
            this.entrantsCountLabel.Text = "Количество абитуриентов: ";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label17.Location = new System.Drawing.Point(15, 32);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(140, 17);
            this.label17.TabIndex = 36;
            this.label17.Text = "Наличие заявления";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label16.Location = new System.Drawing.Point(420, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 17);
            this.label16.TabIndex = 35;
            this.label16.Text = "Пол";
            // 
            // chbox_male
            // 
            this.chbox_male.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chbox_male.AutoSize = true;
            this.chbox_male.Checked = true;
            this.chbox_male.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbox_male.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.chbox_male.Location = new System.Drawing.Point(470, 32);
            this.chbox_male.Name = "chbox_male";
            this.chbox_male.Size = new System.Drawing.Size(54, 21);
            this.chbox_male.TabIndex = 40;
            this.chbox_male.Text = "Муж";
            this.chbox_male.UseVisualStyleBackColor = true;
            this.chbox_male.CheckedChanged += new System.EventHandler(this.chbox_male_CheckedChanged);
            // 
            // chbox_fmale
            // 
            this.chbox_fmale.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chbox_fmale.AutoSize = true;
            this.chbox_fmale.Checked = true;
            this.chbox_fmale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbox_fmale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.chbox_fmale.Location = new System.Drawing.Point(530, 32);
            this.chbox_fmale.Name = "chbox_fmale";
            this.chbox_fmale.Size = new System.Drawing.Size(56, 21);
            this.chbox_fmale.TabIndex = 41;
            this.chbox_fmale.Text = "Жен";
            this.chbox_fmale.UseVisualStyleBackColor = true;
            this.chbox_fmale.CheckedChanged += new System.EventHandler(this.chbox_fmale_CheckedChanged);
            // 
            // chbox_poaFalse
            // 
            this.chbox_poaFalse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chbox_poaFalse.AutoSize = true;
            this.chbox_poaFalse.Checked = true;
            this.chbox_poaFalse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbox_poaFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.chbox_poaFalse.Location = new System.Drawing.Point(266, 32);
            this.chbox_poaFalse.Name = "chbox_poaFalse";
            this.chbox_poaFalse.Size = new System.Drawing.Size(116, 21);
            this.chbox_poaFalse.TabIndex = 43;
            this.chbox_poaFalse.Text = "Не в наличии";
            this.chbox_poaFalse.UseVisualStyleBackColor = true;
            this.chbox_poaFalse.CheckedChanged += new System.EventHandler(this.chbox_poaFalse_CheckedChanged);
            // 
            // chbox_poaTrue
            // 
            this.chbox_poaTrue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chbox_poaTrue.AutoSize = true;
            this.chbox_poaTrue.Checked = true;
            this.chbox_poaTrue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbox_poaTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.chbox_poaTrue.Location = new System.Drawing.Point(164, 32);
            this.chbox_poaTrue.Name = "chbox_poaTrue";
            this.chbox_poaTrue.Size = new System.Drawing.Size(96, 21);
            this.chbox_poaTrue.TabIndex = 42;
            this.chbox_poaTrue.Text = "В наличии";
            this.chbox_poaTrue.UseVisualStyleBackColor = true;
            this.chbox_poaTrue.CheckedChanged += new System.EventHandler(this.chbox_poaTrue_CheckedChanged);
            // 
            // txtAge
            // 
            this.txtAge.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtAge.Location = new System.Drawing.Point(621, 32);
            this.txtAge.MaxLength = 9;
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(152, 23);
            this.txtAge.TabIndex = 17;
            this.txtAge.TextChanged += new System.EventHandler(this.txtAge_TextChanged);
            this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            // 
            // btnAge
            // 
            this.btnAge.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAge.Enabled = false;
            this.btnAge.Image = ((System.Drawing.Image)(resources.GetObject("btnAge.Image")));
            this.btnAge.Location = new System.Drawing.Point(779, 33);
            this.btnAge.Name = "btnAge";
            this.btnAge.Size = new System.Drawing.Size(28, 23);
            this.btnAge.TabIndex = 17;
            this.btnAge.UseVisualStyleBackColor = true;
            this.btnAge.Click += new System.EventHandler(this.btnAge_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(662, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Возраст";
            // 
            // groupbox_details
            // 
            this.groupbox_details.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupbox_details.Controls.Add(this.label17);
            this.groupbox_details.Controls.Add(this.label5);
            this.groupbox_details.Controls.Add(this.txtAge);
            this.groupbox_details.Controls.Add(this.btnAge);
            this.groupbox_details.Controls.Add(this.checkBox1);
            this.groupbox_details.Controls.Add(this.label16);
            this.groupbox_details.Controls.Add(this.chbox_poaFalse);
            this.groupbox_details.Controls.Add(this.chbox_male);
            this.groupbox_details.Controls.Add(this.chbox_poaTrue);
            this.groupbox_details.Controls.Add(this.chbox_fmale);
            this.groupbox_details.Location = new System.Drawing.Point(14, 93);
            this.groupbox_details.Name = "groupbox_details";
            this.groupbox_details.Size = new System.Drawing.Size(1035, 68);
            this.groupbox_details.TabIndex = 44;
            this.groupbox_details.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 471);
            this.Controls.Add(this.groupbox_details);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GridViewEntrants);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1060, 510);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Абитуриенты";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewEntrants)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupbox_details.ResumeLayout(false);
            this.groupbox_details.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewEntrants;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSpec;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem студентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDisGroup;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel entrantsCountLabel;
        private System.Windows.Forms.Button btnClearDgroup;
        private System.Windows.Forms.Button btnYear;
        private System.Windows.Forms.ToolStripMenuItem диаграммыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экспортToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рейтингСпециальностейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уровеньПодготовленностиАбитуриентовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статистикаToolStripMenuItem;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox chbox_male;
        private System.Windows.Forms.CheckBox chbox_fmale;
        private System.Windows.Forms.Button btnClearSpecs;
        private System.Windows.Forms.CheckBox chbox_poaFalse;
        private System.Windows.Forms.CheckBox chbox_poaTrue;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button btnAge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupbox_details;
    }
}

