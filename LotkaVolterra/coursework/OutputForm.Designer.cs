namespace coursework
{
    partial class OutputForm
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
            this.dataSet1 = new System.Data.DataSet();
            this.ant = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.PointInGrap = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // ant
            // 
            this.ant.AccumBits = ((byte)(0));
            this.ant.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ant.AutoCheckErrors = false;
            this.ant.AutoFinish = false;
            this.ant.AutoMakeCurrent = true;
            this.ant.AutoSwapBuffers = true;
            this.ant.BackColor = System.Drawing.Color.White;
            this.ant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ant.ColorBits = ((byte)(32));
            this.ant.DepthBits = ((byte)(16));
            this.ant.Location = new System.Drawing.Point(1, 7);
            this.ant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ant.Name = "ant";
            this.ant.Size = new System.Drawing.Size(637, 436);
            this.ant.StencilBits = ((byte)(0));
            this.ant.TabIndex = 0;
            // 
            // PointInGrap
            // 
            this.PointInGrap.Interval = 30;
            this.PointInGrap.Tick += new System.EventHandler(this.PointInGrap_Tick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(666, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(666, 57);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 26);
            this.button2.TabIndex = 2;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // OutputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(779, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ant);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OutputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "График";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.output_FormClosing);
            this.SizeChanged += new System.EventHandler(this.output_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet dataSet1;
        public Tao.Platform.Windows.SimpleOpenGlControl ant;
        private System.Windows.Forms.Timer PointInGrap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}