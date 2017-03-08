namespace Authorization
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.tbto = new System.Windows.Forms.TextBox();
            this.tbLimit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.lstReport1 = new System.Windows.Forms.ListBox();
            this.btnGo2 = new System.Windows.Forms.Button();
            this.btnGo3 = new System.Windows.Forms.Button();
            this.btnGo4 = new System.Windows.Forms.Button();
            this.btnReport3 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вы вошли в систему";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ваши данные:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 54);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(386, 24);
            this.textBox1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(404, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 306);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tbFrom
            // 
            this.tbFrom.Location = new System.Drawing.Point(36, 108);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(107, 20);
            this.tbFrom.TabIndex = 8;
            this.tbFrom.Visible = false;
            // 
            // tbto
            // 
            this.tbto.Location = new System.Drawing.Point(174, 108);
            this.tbto.Name = "tbto";
            this.tbto.Size = new System.Drawing.Size(103, 20);
            this.tbto.TabIndex = 9;
            this.tbto.Visible = false;
            // 
            // tbLimit
            // 
            this.tbLimit.Enabled = false;
            this.tbLimit.Location = new System.Drawing.Point(327, 108);
            this.tbLimit.Name = "tbLimit";
            this.tbLimit.Size = new System.Drawing.Size(71, 20);
            this.tbLimit.TabIndex = 10;
            this.tbLimit.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "от";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "до";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "лимит";
            this.label5.Visible = false;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(15, 134);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(90, 58);
            this.btnGo.TabIndex = 15;
            this.btnGo.Text = "Формировать отчет1";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Visible = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lstReport1
            // 
            this.lstReport1.FormattingEnabled = true;
            this.lstReport1.Location = new System.Drawing.Point(15, 198);
            this.lstReport1.Name = "lstReport1";
            this.lstReport1.Size = new System.Drawing.Size(383, 134);
            this.lstReport1.TabIndex = 16;
            this.lstReport1.Visible = false;
            // 
            // btnGo2
            // 
            this.btnGo2.Location = new System.Drawing.Point(111, 134);
            this.btnGo2.Name = "btnGo2";
            this.btnGo2.Size = new System.Drawing.Size(88, 58);
            this.btnGo2.TabIndex = 15;
            this.btnGo2.Text = "Формировать отчет 2";
            this.btnGo2.UseVisualStyleBackColor = true;
            this.btnGo2.Visible = false;
            this.btnGo2.Click += new System.EventHandler(this.btnGo2_Click);
            // 
            // btnGo3
            // 
            this.btnGo3.Location = new System.Drawing.Point(205, 134);
            this.btnGo3.Name = "btnGo3";
            this.btnGo3.Size = new System.Drawing.Size(90, 58);
            this.btnGo3.TabIndex = 15;
            this.btnGo3.Text = "Формировать отчет3";
            this.btnGo3.UseVisualStyleBackColor = true;
            this.btnGo3.Visible = false;
            this.btnGo3.Click += new System.EventHandler(this.btnGo3_Click);
            // 
            // btnGo4
            // 
            this.btnGo4.Location = new System.Drawing.Point(301, 134);
            this.btnGo4.Name = "btnGo4";
            this.btnGo4.Size = new System.Drawing.Size(97, 58);
            this.btnGo4.TabIndex = 15;
            this.btnGo4.Text = "Формировать отчет4";
            this.btnGo4.UseVisualStyleBackColor = true;
            this.btnGo4.Visible = false;
            this.btnGo4.Click += new System.EventHandler(this.btnGo4_Click);
            // 
            // btnReport3
            // 
            this.btnReport3.Location = new System.Drawing.Point(15, 84);
            this.btnReport3.Name = "btnReport3";
            this.btnReport3.Size = new System.Drawing.Size(383, 23);
            this.btnReport3.TabIndex = 17;
            this.btnReport3.Text = "Хочу сформировать отчет 3";
            this.btnReport3.UseVisualStyleBackColor = true;
            this.btnReport3.Visible = false;
            this.btnReport3.Click += new System.EventHandler(this.btnReport3_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(16, 336);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(382, 23);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Удалить пользователей, не заходивших в систему за этот период.";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 372);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnReport3);
            this.Controls.Add(this.lstReport1);
            this.Controls.Add(this.btnGo4);
            this.Controls.Add(this.btnGo3);
            this.Controls.Add(this.btnGo2);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbLimit);
            this.Controls.Add(this.tbto);
            this.Controls.Add(this.tbFrom);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Главное окно приложения";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.TextBox tbto;
        private System.Windows.Forms.TextBox tbLimit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.ListBox lstReport1;
        private System.Windows.Forms.Button btnGo2;
        private System.Windows.Forms.Button btnGo3;
        private System.Windows.Forms.Button btnGo4;
        private System.Windows.Forms.Button btnReport3;
        private System.Windows.Forms.Button btnDelete;
    }
}