namespace coursework
{
    partial class InputForm
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
            this.txtpplv = new System.Windows.Forms.TextBox();
            this.txtftlv = new System.Windows.Forms.TextBox();
            this.txtpplp = new System.Windows.Forms.TextBox();
            this.txtdclp = new System.Windows.Forms.TextBox();
            this.bntcomp = new System.Windows.Forms.Button();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtvkill = new System.Windows.Forms.TextBox();
            this.txtftlp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txttime = new System.Windows.Forms.TextBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Начальная величина популяции жертв:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Начальная величина популяции хищников:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Коэффициент рождаемости жертв:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Коэффициент убыли хищников:";
            // 
            // txtpplv
            // 
            this.txtpplv.Location = new System.Drawing.Point(305, 16);
            this.txtpplv.Name = "txtpplv";
            this.txtpplv.Size = new System.Drawing.Size(100, 22);
            this.txtpplv.TabIndex = 4;
            // 
            // txtftlv
            // 
            this.txtftlv.Location = new System.Drawing.Point(305, 46);
            this.txtftlv.Name = "txtftlv";
            this.txtftlv.Size = new System.Drawing.Size(100, 22);
            this.txtftlv.TabIndex = 5;
            // 
            // txtpplp
            // 
            this.txtpplp.Location = new System.Drawing.Point(305, 77);
            this.txtpplp.Name = "txtpplp";
            this.txtpplp.Size = new System.Drawing.Size(100, 22);
            this.txtpplp.TabIndex = 6;
            // 
            // txtdclp
            // 
            this.txtdclp.Location = new System.Drawing.Point(305, 107);
            this.txtdclp.Name = "txtdclp";
            this.txtdclp.Size = new System.Drawing.Size(100, 22);
            this.txtdclp.TabIndex = 7;
            // 
            // bntcomp
            // 
            this.bntcomp.Location = new System.Drawing.Point(348, 145);
            this.bntcomp.Name = "bntcomp";
            this.bntcomp.Size = new System.Drawing.Size(111, 27);
            this.bntcomp.TabIndex = 9;
            this.bntcomp.Text = "Рассчитать";
            this.bntcomp.UseVisualStyleBackColor = true;
            this.bntcomp.Click += new System.EventHandler(this.bntcomp_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(438, 109);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(176, 21);
            this.checkBox3.TabIndex = 12;
            this.checkBox3.Text = "Фазовая зависимость";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(435, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Коэффициент убийства жертв:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(435, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(289, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Коэффициент воспроизводства хищников:";
            // 
            // txtvkill
            // 
            this.txtvkill.Location = new System.Drawing.Point(730, 16);
            this.txtvkill.Name = "txtvkill";
            this.txtvkill.Size = new System.Drawing.Size(100, 22);
            this.txtvkill.TabIndex = 15;
            // 
            // txtftlp
            // 
            this.txtftlp.Location = new System.Drawing.Point(730, 46);
            this.txtftlp.Name = "txtftlp";
            this.txtftlp.Size = new System.Drawing.Size(100, 22);
            this.txtftlp.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(435, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Время:";
            // 
            // txttime
            // 
            this.txttime.Location = new System.Drawing.Point(730, 77);
            this.txttime.Name = "txttime";
            this.txttime.Size = new System.Drawing.Size(100, 22);
            this.txttime.TabIndex = 18;
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(366, 193);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 28);
            this.btnexit.TabIndex = 19;
            this.btnexit.Text = "Выход";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 240);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.txttime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtftlp);
            this.Controls.Add(this.txtvkill);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.bntcomp);
            this.Controls.Add(this.txtdclp);
            this.Controls.Add(this.txtpplp);
            this.Controls.Add(this.txtftlv);
            this.Controls.Add(this.txtpplv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ввод";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.input_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpplv;
        private System.Windows.Forms.TextBox txtftlv;
        private System.Windows.Forms.TextBox txtpplp;
        private System.Windows.Forms.TextBox txtdclp;
        private System.Windows.Forms.Button bntcomp;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtvkill;
        private System.Windows.Forms.TextBox txtftlp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttime;
        private System.Windows.Forms.Button btnexit;
    }
}