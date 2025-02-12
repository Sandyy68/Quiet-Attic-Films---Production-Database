namespace DataBase_asssingment
{
    partial class Production_Manager
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProdID = new System.Windows.Forms.TextBox();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Clearall = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.cmbClntName = new System.Windows.Forms.ComboBox();
            this.cmbProdType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbProdPPS = new System.Windows.Forms.ComboBox();
            this.cmbStaffPPS = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbPropPPL = new System.Windows.Forms.ComboBox();
            this.cmbProdPPL = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbLocPPL = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.Production = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Production.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Production ID :\r\n\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Production Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Client Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Strat Date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "End Date :";
            // 
            // txtProdID
            // 
            this.txtProdID.Location = new System.Drawing.Point(147, 46);
            this.txtProdID.Name = "txtProdID";
            this.txtProdID.Size = new System.Drawing.Size(176, 26);
            this.txtProdID.TabIndex = 5;
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(147, 110);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(176, 26);
            this.txtProdName.TabIndex = 7;
            this.txtProdName.TextChanged += new System.EventHandler(this.txtProdName_TextChanged);
            // 
            // dtp_start
            // 
            this.dtp_start.Location = new System.Drawing.Point(147, 169);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(292, 26);
            this.dtp_start.TabIndex = 8;
            // 
            // dtp_end
            // 
            this.dtp_end.Location = new System.Drawing.Point(147, 216);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(292, 26);
            this.dtp_end.TabIndex = 9;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(34, 371);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(71, 42);
            this.btnsearch.TabIndex = 10;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.bttn_Search_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(146, 371);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(63, 42);
            this.btn_Add.TabIndex = 11;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(250, 371);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(73, 42);
            this.btn_Update.TabIndex = 12;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(364, 371);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(78, 42);
            this.btn_Delete.TabIndex = 13;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Clearall
            // 
            this.btn_Clearall.Location = new System.Drawing.Point(483, 371);
            this.btn_Clearall.Name = "btn_Clearall";
            this.btn_Clearall.Size = new System.Drawing.Size(92, 42);
            this.btn_Clearall.TabIndex = 14;
            this.btn_Clearall.Text = "Clear all";
            this.btn_Clearall.UseVisualStyleBackColor = true;
            this.btn_Clearall.Click += new System.EventHandler(this.btn_Clearall_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1248, 332);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1199, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(63, 40);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmbClntName
            // 
            this.cmbClntName.FormattingEnabled = true;
            this.cmbClntName.Location = new System.Drawing.Point(478, 45);
            this.cmbClntName.Name = "cmbClntName";
            this.cmbClntName.Size = new System.Drawing.Size(199, 28);
            this.cmbClntName.TabIndex = 21;
            // 
            // cmbProdType
            // 
            this.cmbProdType.FormattingEnabled = true;
            this.cmbProdType.Items.AddRange(new object[] {
            "Movie",
            "Advertisement",
            "Information Film",
            "Training Film"});
            this.cmbProdType.Location = new System.Drawing.Point(478, 111);
            this.cmbProdType.Name = "cmbProdType";
            this.cmbProdType.Size = new System.Drawing.Size(199, 28);
            this.cmbProdType.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(341, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Production Type :";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 450);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1262, 371);
            this.tabControl1.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1254, 338);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Production";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1254, 338);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Production Property Location";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(1248, 332);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1254, 338);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Production Staff";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(1254, 338);
            this.dataGridView3.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Production :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Staff :";
            // 
            // cmbProdPPS
            // 
            this.cmbProdPPS.FormattingEnabled = true;
            this.cmbProdPPS.Location = new System.Drawing.Point(118, 32);
            this.cmbProdPPS.Name = "cmbProdPPS";
            this.cmbProdPPS.Size = new System.Drawing.Size(192, 28);
            this.cmbProdPPS.TabIndex = 27;
            this.cmbProdPPS.SelectedIndexChanged += new System.EventHandler(this.cmbProdPS_SelectedIndexChanged);
            // 
            // cmbStaffPPS
            // 
            this.cmbStaffPPS.FormattingEnabled = true;
            this.cmbStaffPPS.Location = new System.Drawing.Point(118, 77);
            this.cmbStaffPPS.Name = "cmbStaffPPS";
            this.cmbStaffPPS.Size = new System.Drawing.Size(192, 28);
            this.cmbStaffPPS.TabIndex = 28;
            this.cmbStaffPPS.SelectedIndexChanged += new System.EventHandler(this.cmbStaffPS_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 34);
            this.button1.TabIndex = 29;
            this.button1.Text = "Assign";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(323, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 34);
            this.button2.TabIndex = 34;
            this.button2.Text = "Assign";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbPropPPL
            // 
            this.cmbPropPPL.FormattingEnabled = true;
            this.cmbPropPPL.Location = new System.Drawing.Point(118, 210);
            this.cmbPropPPL.Name = "cmbPropPPL";
            this.cmbPropPPL.Size = new System.Drawing.Size(192, 28);
            this.cmbPropPPL.TabIndex = 33;
            this.cmbPropPPL.SelectedIndexChanged += new System.EventHandler(this.cmbPropPP_SelectedIndexChanged);
            // 
            // cmbProdPPL
            // 
            this.cmbProdPPL.FormattingEnabled = true;
            this.cmbProdPPL.Location = new System.Drawing.Point(118, 166);
            this.cmbProdPPL.Name = "cmbProdPPL";
            this.cmbProdPPL.Size = new System.Drawing.Size(192, 28);
            this.cmbProdPPL.TabIndex = 32;
            this.cmbProdPPL.SelectedIndexChanged += new System.EventHandler(this.cmbProdPP_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "Property :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 20);
            this.label10.TabIndex = 30;
            this.label10.Text = "Production :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbLocPPL);
            this.groupBox1.Controls.Add(this.cmbProdPPS);
            this.groupBox1.Controls.Add(this.cmbPropPPL);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbProdPPL);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.cmbStaffPPS);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(763, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 333);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Property and Staff Assigner";
            // 
            // cmbLocPPL
            // 
            this.cmbLocPPL.FormattingEnabled = true;
            this.cmbLocPPL.Location = new System.Drawing.Point(118, 254);
            this.cmbLocPPL.Name = "cmbLocPPL";
            this.cmbLocPPL.Size = new System.Drawing.Size(192, 28);
            this.cmbLocPPL.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 254);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 20);
            this.label11.TabIndex = 36;
            this.label11.Text = "Location :";
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter1.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 825);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1274, 8);
            this.splitter1.TabIndex = 36;
            this.splitter1.TabStop = false;
            // 
            // Production
            // 
            this.Production.Controls.Add(this.txtProdName);
            this.Production.Controls.Add(this.label1);
            this.Production.Controls.Add(this.label2);
            this.Production.Controls.Add(this.txtProdID);
            this.Production.Controls.Add(this.cmbProdType);
            this.Production.Controls.Add(this.label3);
            this.Production.Controls.Add(this.cmbClntName);
            this.Production.Controls.Add(this.label6);
            this.Production.Controls.Add(this.dtp_start);
            this.Production.Controls.Add(this.label4);
            this.Production.Controls.Add(this.dtp_end);
            this.Production.Controls.Add(this.label5);
            this.Production.Location = new System.Drawing.Point(34, 47);
            this.Production.Name = "Production";
            this.Production.Size = new System.Drawing.Size(710, 304);
            this.Production.TabIndex = 37;
            this.Production.TabStop = false;
            this.Production.Text = "Production";
            // 
            // Production_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1274, 833);
            this.Controls.Add(this.Production);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btn_Clearall);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.groupBox1);
            this.Name = "Production_Manager";
            this.Text = "Production_Manager";
            this.Load += new System.EventHandler(this.Production_Manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Production.ResumeLayout(false);
            this.Production.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProdID;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Clearall;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cmbClntName;
        private System.Windows.Forms.ComboBox cmbProdType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbProdPPS;
        private System.Windows.Forms.ComboBox cmbStaffPPS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbPropPPL;
        private System.Windows.Forms.ComboBox cmbProdPPL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbLocPPL;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox Production;
    }
}