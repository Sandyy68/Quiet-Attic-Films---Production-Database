namespace DataBase_asssingment
{
    partial class Staff_Manager
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
            this.txt_StID = new System.Windows.Forms.TextBox();
            this.txt_StName = new System.Windows.Forms.TextBox();
            this.cbx_StStaffType = new System.Windows.Forms.ComboBox();
            this.btn_Clearall = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.dgv_StaffManager = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StaffManager)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(762, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(762, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Staff Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(762, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Staff Type :";
            // 
            // txt_StID
            // 
            this.txt_StID.Location = new System.Drawing.Point(858, 95);
            this.txt_StID.Name = "txt_StID";
            this.txt_StID.Size = new System.Drawing.Size(195, 26);
            this.txt_StID.TabIndex = 3;
            // 
            // txt_StName
            // 
            this.txt_StName.Location = new System.Drawing.Point(858, 135);
            this.txt_StName.Name = "txt_StName";
            this.txt_StName.Size = new System.Drawing.Size(195, 26);
            this.txt_StName.TabIndex = 4;
            // 
            // cbx_StStaffType
            // 
            this.cbx_StStaffType.FormattingEnabled = true;
            this.cbx_StStaffType.Location = new System.Drawing.Point(858, 177);
            this.cbx_StStaffType.Name = "cbx_StStaffType";
            this.cbx_StStaffType.Size = new System.Drawing.Size(195, 28);
            this.cbx_StStaffType.TabIndex = 5;
            // 
            // btn_Clearall
            // 
            this.btn_Clearall.Location = new System.Drawing.Point(937, 330);
            this.btn_Clearall.Name = "btn_Clearall";
            this.btn_Clearall.Size = new System.Drawing.Size(85, 40);
            this.btn_Clearall.TabIndex = 26;
            this.btn_Clearall.Text = "Clear all";
            this.btn_Clearall.UseVisualStyleBackColor = true;
            this.btn_Clearall.Click += new System.EventHandler(this.btn_Clearall_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(816, 330);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(78, 40);
            this.btn_Delete.TabIndex = 25;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(996, 265);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(73, 40);
            this.btn_Update.TabIndex = 24;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(883, 265);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(63, 40);
            this.btn_Add.TabIndex = 23;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(765, 265);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(71, 40);
            this.btn_Search.TabIndex = 22;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // dgv_StaffManager
            // 
            this.dgv_StaffManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_StaffManager.Location = new System.Drawing.Point(0, 12);
            this.dgv_StaffManager.Name = "dgv_StaffManager";
            this.dgv_StaffManager.RowHeadersWidth = 62;
            this.dgv_StaffManager.RowTemplate.Height = 28;
            this.dgv_StaffManager.Size = new System.Drawing.Size(719, 403);
            this.dgv_StaffManager.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(995, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 40);
            this.button1.TabIndex = 28;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Staff_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1084, 412);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_StaffManager);
            this.Controls.Add(this.btn_Clearall);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.cbx_StStaffType);
            this.Controls.Add(this.txt_StName);
            this.Controls.Add(this.txt_StID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Staff_Manager";
            this.Text = "Staff_Manager";
            this.Load += new System.EventHandler(this.Staff_Manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StaffManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_StID;
        private System.Windows.Forms.TextBox txt_StName;
        private System.Windows.Forms.ComboBox cbx_StStaffType;
        private System.Windows.Forms.Button btn_Clearall;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridView dgv_StaffManager;
        private System.Windows.Forms.Button button1;
    }
}