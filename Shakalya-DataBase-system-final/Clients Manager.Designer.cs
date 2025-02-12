namespace DataBase_asssingment
{
    partial class Clients_Manager
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
            this.text_ClntID = new System.Windows.Forms.TextBox();
            this.text_ClntName = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Clearall = new System.Windows.Forms.Button();
            this.dgv_clnt_Manager = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clnt_Manager)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(649, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(649, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Client Name :";
            // 
            // text_ClntID
            // 
            this.text_ClntID.Location = new System.Drawing.Point(750, 99);
            this.text_ClntID.Name = "text_ClntID";
            this.text_ClntID.Size = new System.Drawing.Size(204, 26);
            this.text_ClntID.TabIndex = 2;
            this.text_ClntID.TextChanged += new System.EventHandler(this.text_ClientID_TextChanged);
            // 
            // text_ClntName
            // 
            this.text_ClntName.Location = new System.Drawing.Point(750, 145);
            this.text_ClntName.Name = "text_ClntName";
            this.text_ClntName.Size = new System.Drawing.Size(204, 26);
            this.text_ClntName.TabIndex = 3;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(672, 217);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(71, 32);
            this.btn_Search.TabIndex = 11;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(778, 217);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(63, 32);
            this.btn_Add.TabIndex = 12;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(876, 217);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(73, 32);
            this.btn_Update.TabIndex = 13;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(707, 300);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(78, 34);
            this.btn_Delete.TabIndex = 14;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Clearall
            // 
            this.btn_Clearall.Location = new System.Drawing.Point(820, 300);
            this.btn_Clearall.Name = "btn_Clearall";
            this.btn_Clearall.Size = new System.Drawing.Size(76, 34);
            this.btn_Clearall.TabIndex = 15;
            this.btn_Clearall.Text = "Clear all";
            this.btn_Clearall.UseVisualStyleBackColor = true;
            this.btn_Clearall.Click += new System.EventHandler(this.btn_Clearall_Click);
            // 
            // dgv_clnt_Manager
            // 
            this.dgv_clnt_Manager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clnt_Manager.Location = new System.Drawing.Point(0, 12);
            this.dgv_clnt_Manager.Name = "dgv_clnt_Manager";
            this.dgv_clnt_Manager.RowHeadersWidth = 62;
            this.dgv_clnt_Manager.RowTemplate.Height = 28;
            this.dgv_clnt_Manager.Size = new System.Drawing.Size(636, 370);
            this.dgv_clnt_Manager.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(876, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 38);
            this.button1.TabIndex = 17;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Clients_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(966, 387);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_clnt_Manager);
            this.Controls.Add(this.btn_Clearall);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.text_ClntName);
            this.Controls.Add(this.text_ClntID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Clients_Manager";
            this.Text = "Clients_Manager";
            this.Load += new System.EventHandler(this.Clients_Manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clnt_Manager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_ClntID;
        private System.Windows.Forms.TextBox text_ClntName;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Clearall;
        private System.Windows.Forms.DataGridView dgv_clnt_Manager;
        private System.Windows.Forms.Button button1;
    }
}