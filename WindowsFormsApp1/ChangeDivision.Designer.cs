namespace WindowsFormsApp1
{
    partial class ChangeDivision
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbOldDivision = new System.Windows.Forms.ComboBox();
            this.tbNewDivision = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(211, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберете подразделение которое хотите изменить:";
            // 
            // cbOldDivision
            // 
            this.cbOldDivision.FormattingEnabled = true;
            this.cbOldDivision.Location = new System.Drawing.Point(15, 35);
            this.cbOldDivision.Name = "cbOldDivision";
            this.cbOldDivision.Size = new System.Drawing.Size(121, 21);
            this.cbOldDivision.TabIndex = 3;
            // 
            // tbNewDivision
            // 
            this.tbNewDivision.Location = new System.Drawing.Point(15, 111);
            this.tbNewDivision.Name = "tbNewDivision";
            this.tbNewDivision.Size = new System.Drawing.Size(206, 20);
            this.tbNewDivision.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Введите новое название подразделения:";
            // 
            // ChangeDivision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 235);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNewDivision);
            this.Controls.Add(this.cbOldDivision);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "ChangeDivision";
            this.Text = "ChangeDivision";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbOldDivision;
        private System.Windows.Forms.TextBox tbNewDivision;
        private System.Windows.Forms.Label label2;
    }
}