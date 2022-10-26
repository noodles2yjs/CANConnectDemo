
namespace CANConnectDemo
{
    partial class SystemStandard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VhicleSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Max = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PFJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PFK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PFI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vhicleSpeedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dZDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCJDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pFJDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pFIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.standardPIDModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPID = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.vhicleSpeedDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kPDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kIDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dZDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCJDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCKDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCIDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pFJDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pFKDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pFIDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sysAdminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnShowCurve = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardPIDModelBindingSource)).BeginInit();
            this.tabPID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysAdminBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPID);
            this.tabControl1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(16, 16);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(942, 659);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(934, 629);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基本助力表";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(32, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "PId";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.VhicleSpeed,
            this.KP,
            this.KI,
            this.KD,
            this.DZ,
            this.Max,
            this.PCJ,
            this.PCK,
            this.PCI,
            this.PFJ,
            this.PFK,
            this.PFI});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(25, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(876, 265);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // VhicleSpeed
            // 
            this.VhicleSpeed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VhicleSpeed.HeaderText = "车速";
            this.VhicleSpeed.Name = "VhicleSpeed";
            this.VhicleSpeed.ReadOnly = true;
            // 
            // KP
            // 
            this.KP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KP.HeaderText = "KP";
            this.KP.Name = "KP";
            this.KP.ReadOnly = true;
            // 
            // KI
            // 
            this.KI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KI.HeaderText = "KI";
            this.KI.Name = "KI";
            this.KI.ReadOnly = true;
            // 
            // KD
            // 
            this.KD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KD.HeaderText = "KD";
            this.KD.Name = "KD";
            this.KD.ReadOnly = true;
            // 
            // DZ
            // 
            this.DZ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DZ.HeaderText = "DZ";
            this.DZ.Name = "DZ";
            this.DZ.ReadOnly = true;
            // 
            // Max
            // 
            this.Max.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Max.HeaderText = "Max";
            this.Max.Name = "Max";
            this.Max.ReadOnly = true;
            // 
            // PCJ
            // 
            this.PCJ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PCJ.HeaderText = "PCJ";
            this.PCJ.Name = "PCJ";
            this.PCJ.ReadOnly = true;
            // 
            // PCK
            // 
            this.PCK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PCK.HeaderText = "PCK";
            this.PCK.Name = "PCK";
            this.PCK.ReadOnly = true;
            // 
            // PCI
            // 
            this.PCI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PCI.HeaderText = "PCI";
            this.PCI.Name = "PCI";
            this.PCI.ReadOnly = true;
            // 
            // PFJ
            // 
            this.PFJ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PFJ.HeaderText = "PFJ";
            this.PFJ.Name = "PFJ";
            this.PFJ.ReadOnly = true;
            // 
            // PFK
            // 
            this.PFK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PFK.HeaderText = "PFK";
            this.PFK.Name = "PFK";
            this.PFK.ReadOnly = true;
            // 
            // PFI
            // 
            this.PFI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PFI.HeaderText = "PFI";
            this.PFI.Name = "PFI";
            this.PFI.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(934, 629);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "基本标定量";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.vhicleSpeedDataGridViewTextBoxColumn,
            this.kPDataGridViewTextBoxColumn,
            this.kIDataGridViewTextBoxColumn,
            this.kDDataGridViewTextBoxColumn,
            this.dZDataGridViewTextBoxColumn,
            this.maxDataGridViewTextBoxColumn,
            this.pCJDataGridViewTextBoxColumn,
            this.pCKDataGridViewTextBoxColumn,
            this.pCIDataGridViewTextBoxColumn,
            this.pFJDataGridViewTextBoxColumn,
            this.pFKDataGridViewTextBoxColumn,
            this.pFIDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.standardPIDModelBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(35, 96);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(867, 150);
            this.dataGridView2.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vhicleSpeedDataGridViewTextBoxColumn
            // 
            this.vhicleSpeedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vhicleSpeedDataGridViewTextBoxColumn.DataPropertyName = "VhicleSpeed";
            this.vhicleSpeedDataGridViewTextBoxColumn.HeaderText = "VhicleSpeed";
            this.vhicleSpeedDataGridViewTextBoxColumn.Name = "vhicleSpeedDataGridViewTextBoxColumn";
            this.vhicleSpeedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kPDataGridViewTextBoxColumn
            // 
            this.kPDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kPDataGridViewTextBoxColumn.DataPropertyName = "KP";
            this.kPDataGridViewTextBoxColumn.HeaderText = "KP";
            this.kPDataGridViewTextBoxColumn.Name = "kPDataGridViewTextBoxColumn";
            this.kPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kIDataGridViewTextBoxColumn
            // 
            this.kIDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kIDataGridViewTextBoxColumn.DataPropertyName = "KI";
            this.kIDataGridViewTextBoxColumn.HeaderText = "KI";
            this.kIDataGridViewTextBoxColumn.Name = "kIDataGridViewTextBoxColumn";
            this.kIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kDDataGridViewTextBoxColumn
            // 
            this.kDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kDDataGridViewTextBoxColumn.DataPropertyName = "KD";
            this.kDDataGridViewTextBoxColumn.HeaderText = "KD";
            this.kDDataGridViewTextBoxColumn.Name = "kDDataGridViewTextBoxColumn";
            this.kDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dZDataGridViewTextBoxColumn
            // 
            this.dZDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dZDataGridViewTextBoxColumn.DataPropertyName = "DZ";
            this.dZDataGridViewTextBoxColumn.HeaderText = "DZ";
            this.dZDataGridViewTextBoxColumn.Name = "dZDataGridViewTextBoxColumn";
            this.dZDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maxDataGridViewTextBoxColumn
            // 
            this.maxDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maxDataGridViewTextBoxColumn.DataPropertyName = "Max";
            this.maxDataGridViewTextBoxColumn.HeaderText = "Max";
            this.maxDataGridViewTextBoxColumn.Name = "maxDataGridViewTextBoxColumn";
            this.maxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pCJDataGridViewTextBoxColumn
            // 
            this.pCJDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pCJDataGridViewTextBoxColumn.DataPropertyName = "PCJ";
            this.pCJDataGridViewTextBoxColumn.HeaderText = "PCJ";
            this.pCJDataGridViewTextBoxColumn.Name = "pCJDataGridViewTextBoxColumn";
            this.pCJDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pCKDataGridViewTextBoxColumn
            // 
            this.pCKDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pCKDataGridViewTextBoxColumn.DataPropertyName = "PCK";
            this.pCKDataGridViewTextBoxColumn.HeaderText = "PCK";
            this.pCKDataGridViewTextBoxColumn.Name = "pCKDataGridViewTextBoxColumn";
            this.pCKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pCIDataGridViewTextBoxColumn
            // 
            this.pCIDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pCIDataGridViewTextBoxColumn.DataPropertyName = "PCI";
            this.pCIDataGridViewTextBoxColumn.HeaderText = "PCI";
            this.pCIDataGridViewTextBoxColumn.Name = "pCIDataGridViewTextBoxColumn";
            this.pCIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pFJDataGridViewTextBoxColumn
            // 
            this.pFJDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pFJDataGridViewTextBoxColumn.DataPropertyName = "PFJ";
            this.pFJDataGridViewTextBoxColumn.HeaderText = "PFJ";
            this.pFJDataGridViewTextBoxColumn.Name = "pFJDataGridViewTextBoxColumn";
            this.pFJDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pFKDataGridViewTextBoxColumn
            // 
            this.pFKDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pFKDataGridViewTextBoxColumn.DataPropertyName = "PFK";
            this.pFKDataGridViewTextBoxColumn.HeaderText = "PFK";
            this.pFKDataGridViewTextBoxColumn.Name = "pFKDataGridViewTextBoxColumn";
            this.pFKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pFIDataGridViewTextBoxColumn
            // 
            this.pFIDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pFIDataGridViewTextBoxColumn.DataPropertyName = "PFI";
            this.pFIDataGridViewTextBoxColumn.HeaderText = "PFI";
            this.pFIDataGridViewTextBoxColumn.Name = "pFIDataGridViewTextBoxColumn";
            this.pFIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // standardPIDModelBindingSource
            // 
            this.standardPIDModelBindingSource.DataSource = typeof(Models.StandardPIDModel);
            // 
            // tabPID
            // 
            this.tabPID.Controls.Add(this.dataGridView3);
            this.tabPID.Location = new System.Drawing.Point(4, 26);
            this.tabPID.Name = "tabPID";
            this.tabPID.Padding = new System.Windows.Forms.Padding(3);
            this.tabPID.Size = new System.Drawing.Size(934, 629);
            this.tabPID.TabIndex = 2;
            this.tabPID.Text = "PID及温度保护";
            this.tabPID.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vhicleSpeedDataGridViewTextBoxColumn1,
            this.kPDataGridViewTextBoxColumn1,
            this.kIDataGridViewTextBoxColumn1,
            this.kDDataGridViewTextBoxColumn1,
            this.dZDataGridViewTextBoxColumn1,
            this.maxDataGridViewTextBoxColumn1,
            this.pCJDataGridViewTextBoxColumn1,
            this.pCKDataGridViewTextBoxColumn1,
            this.pCIDataGridViewTextBoxColumn1,
            this.pFJDataGridViewTextBoxColumn1,
            this.pFKDataGridViewTextBoxColumn1,
            this.pFIDataGridViewTextBoxColumn1,
            this.idDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.standardPIDModelBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(22, 106);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(825, 207);
            this.dataGridView3.TabIndex = 0;
            // 
            // vhicleSpeedDataGridViewTextBoxColumn1
            // 
            this.vhicleSpeedDataGridViewTextBoxColumn1.DataPropertyName = "VhicleSpeed";
            this.vhicleSpeedDataGridViewTextBoxColumn1.HeaderText = "VhicleSpeed";
            this.vhicleSpeedDataGridViewTextBoxColumn1.Name = "vhicleSpeedDataGridViewTextBoxColumn1";
            this.vhicleSpeedDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // kPDataGridViewTextBoxColumn1
            // 
            this.kPDataGridViewTextBoxColumn1.DataPropertyName = "KP";
            this.kPDataGridViewTextBoxColumn1.HeaderText = "KP";
            this.kPDataGridViewTextBoxColumn1.Name = "kPDataGridViewTextBoxColumn1";
            this.kPDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // kIDataGridViewTextBoxColumn1
            // 
            this.kIDataGridViewTextBoxColumn1.DataPropertyName = "KI";
            this.kIDataGridViewTextBoxColumn1.HeaderText = "KI";
            this.kIDataGridViewTextBoxColumn1.Name = "kIDataGridViewTextBoxColumn1";
            this.kIDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // kDDataGridViewTextBoxColumn1
            // 
            this.kDDataGridViewTextBoxColumn1.DataPropertyName = "KD";
            this.kDDataGridViewTextBoxColumn1.HeaderText = "KD";
            this.kDDataGridViewTextBoxColumn1.Name = "kDDataGridViewTextBoxColumn1";
            this.kDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dZDataGridViewTextBoxColumn1
            // 
            this.dZDataGridViewTextBoxColumn1.DataPropertyName = "DZ";
            this.dZDataGridViewTextBoxColumn1.HeaderText = "DZ";
            this.dZDataGridViewTextBoxColumn1.Name = "dZDataGridViewTextBoxColumn1";
            this.dZDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // maxDataGridViewTextBoxColumn1
            // 
            this.maxDataGridViewTextBoxColumn1.DataPropertyName = "Max";
            this.maxDataGridViewTextBoxColumn1.HeaderText = "Max";
            this.maxDataGridViewTextBoxColumn1.Name = "maxDataGridViewTextBoxColumn1";
            this.maxDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // pCJDataGridViewTextBoxColumn1
            // 
            this.pCJDataGridViewTextBoxColumn1.DataPropertyName = "PCJ";
            this.pCJDataGridViewTextBoxColumn1.HeaderText = "PCJ";
            this.pCJDataGridViewTextBoxColumn1.Name = "pCJDataGridViewTextBoxColumn1";
            this.pCJDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // pCKDataGridViewTextBoxColumn1
            // 
            this.pCKDataGridViewTextBoxColumn1.DataPropertyName = "PCK";
            this.pCKDataGridViewTextBoxColumn1.HeaderText = "PCK";
            this.pCKDataGridViewTextBoxColumn1.Name = "pCKDataGridViewTextBoxColumn1";
            this.pCKDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // pCIDataGridViewTextBoxColumn1
            // 
            this.pCIDataGridViewTextBoxColumn1.DataPropertyName = "PCI";
            this.pCIDataGridViewTextBoxColumn1.HeaderText = "PCI";
            this.pCIDataGridViewTextBoxColumn1.Name = "pCIDataGridViewTextBoxColumn1";
            this.pCIDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // pFJDataGridViewTextBoxColumn1
            // 
            this.pFJDataGridViewTextBoxColumn1.DataPropertyName = "PFJ";
            this.pFJDataGridViewTextBoxColumn1.HeaderText = "PFJ";
            this.pFJDataGridViewTextBoxColumn1.Name = "pFJDataGridViewTextBoxColumn1";
            this.pFJDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // pFKDataGridViewTextBoxColumn1
            // 
            this.pFKDataGridViewTextBoxColumn1.DataPropertyName = "PFK";
            this.pFKDataGridViewTextBoxColumn1.HeaderText = "PFK";
            this.pFKDataGridViewTextBoxColumn1.Name = "pFKDataGridViewTextBoxColumn1";
            this.pFKDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // pFIDataGridViewTextBoxColumn1
            // 
            this.pFIDataGridViewTextBoxColumn1.DataPropertyName = "PFI";
            this.pFIDataGridViewTextBoxColumn1.HeaderText = "PFI";
            this.pFIDataGridViewTextBoxColumn1.Name = "pFIDataGridViewTextBoxColumn1";
            this.pFIDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // sysAdminBindingSource
            // 
            this.sysAdminBindingSource.DataSource = typeof(Models.SysAdmin);
            // 
            // btnShowCurve
            // 
            this.btnShowCurve.Location = new System.Drawing.Point(1046, 69);
            this.btnShowCurve.Name = "btnShowCurve";
            this.btnShowCurve.Size = new System.Drawing.Size(94, 35);
            this.btnShowCurve.TabIndex = 1;
            this.btnShowCurve.Text = "显示曲线";
            this.btnShowCurve.UseVisualStyleBackColor = true;
            this.btnShowCurve.Click += new System.EventHandler(this.btnShowCurve_Click);
            // 
            // SystemStandard2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1283, 814);
            this.Controls.Add(this.btnShowCurve);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SystemStandard2";
            this.Text = "SystemStandard2";
            this.Load += new System.EventHandler(this.SystemStandard2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardPIDModelBindingSource)).EndInit();
            this.tabPID.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysAdminBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn VhicleSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn KP;
        private System.Windows.Forms.DataGridViewTextBoxColumn KI;
        private System.Windows.Forms.DataGridViewTextBoxColumn KD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Max;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCK;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCI;
        private System.Windows.Forms.DataGridViewTextBoxColumn PFJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn PFK;
        private System.Windows.Forms.DataGridViewTextBoxColumn PFI;
        private System.Windows.Forms.BindingSource sysAdminBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vhicleSpeedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dZDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCJDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pFJDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pFIDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource standardPIDModelBindingSource;
        private System.Windows.Forms.TabPage tabPID;
        private System.Windows.Forms.DataGridViewTextBoxColumn vhicleSpeedDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kPDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kIDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dZDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCJDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCKDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCIDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pFJDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pFKDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pFIDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnShowCurve;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.DataGridView dataGridView3;
    }
}