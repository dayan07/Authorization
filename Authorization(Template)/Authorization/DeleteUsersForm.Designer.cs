namespace Authorization
{
    partial class DeleteUsersForm
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
            this.lbcountUsers = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnYesDelete = new System.Windows.Forms.Button();
            this.btnNoDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вы собираетесь удалить ";
            // 
            // lbcountUsers
            // 
            this.lbcountUsers.AutoSize = true;
            this.lbcountUsers.Location = new System.Drawing.Point(234, 13);
            this.lbcountUsers.Name = "lbcountUsers";
            this.lbcountUsers.Size = new System.Drawing.Size(35, 13);
            this.lbcountUsers.TabIndex = 1;
            this.lbcountUsers.Text = "label2";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(95, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(264, 108);
            this.listBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Вы уверены, что их следует удалить?";
            // 
            // btnYesDelete
            // 
            this.btnYesDelete.Location = new System.Drawing.Point(194, 195);
            this.btnYesDelete.Name = "btnYesDelete";
            this.btnYesDelete.Size = new System.Drawing.Size(75, 23);
            this.btnYesDelete.TabIndex = 4;
            this.btnYesDelete.Text = "Да";
            this.btnYesDelete.UseVisualStyleBackColor = true;
            this.btnYesDelete.Click += new System.EventHandler(this.btnYesDelete_Click);
            // 
            // btnNoDelete
            // 
            this.btnNoDelete.Location = new System.Drawing.Point(275, 195);
            this.btnNoDelete.Name = "btnNoDelete";
            this.btnNoDelete.Size = new System.Drawing.Size(75, 23);
            this.btnNoDelete.TabIndex = 4;
            this.btnNoDelete.Text = "Нет";
            this.btnNoDelete.UseVisualStyleBackColor = true;
            this.btnNoDelete.Click += new System.EventHandler(this.btnNoDelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "пользователей";
            // 
            // DeleteUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 272);
            this.Controls.Add(this.btnNoDelete);
            this.Controls.Add(this.btnYesDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbcountUsers);
            this.Controls.Add(this.label1);
            this.Name = "DeleteUsersForm";
            this.Text = "DeleteUsersForm";
            this.Load += new System.EventHandler(this.DeleteUsersForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbcountUsers;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnYesDelete;
        private System.Windows.Forms.Button btnNoDelete;
        private System.Windows.Forms.Label label4;
    }
}