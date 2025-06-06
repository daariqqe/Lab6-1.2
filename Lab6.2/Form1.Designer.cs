namespace Lab6._2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCalculate = new Button();
            groupBox1 = new GroupBox();
            nudA = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            nudD = new TextBox();
            nudC = new TextBox();
            nudH = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            lblRectVolume = new TextBox();
            lblCubeVolume = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(127, 388);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(155, 39);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "Обчислити";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nudA);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(395, 123);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Дані куба";
            // 
            // nudA
            // 
            nudA.Location = new Point(156, 50);
            nudA.Name = "nudA";
            nudA.Size = new Size(146, 27);
            nudA.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 53);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 3;
            label1.Text = "довжина ребра";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(nudD);
            groupBox2.Controls.Add(nudC);
            groupBox2.Controls.Add(nudH);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(12, 160);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(395, 206);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Дані прямокутного паралелепіпеда";
            // 
            // nudD
            // 
            nudD.Location = new Point(156, 134);
            nudD.Name = "nudD";
            nudD.Size = new Size(146, 27);
            nudD.TabIndex = 8;
            // 
            // nudC
            // 
            nudC.Location = new Point(156, 94);
            nudC.Name = "nudC";
            nudC.Size = new Size(146, 27);
            nudC.TabIndex = 7;
            // 
            // nudH
            // 
            nudH.Location = new Point(156, 50);
            nudH.Name = "nudH";
            nudH.Size = new Size(146, 27);
            nudH.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 134);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 6;
            label4.Text = "ширина";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 94);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 5;
            label3.Text = "довжина";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 50);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 4;
            label2.Text = "висота";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(429, 22);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 4;
            label5.Text = "об'єм куба";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(429, 172);
            label6.Name = "label6";
            label6.Size = new Size(267, 20);
            label6.TabIndex = 5;
            label6.Text = "об'єм прямокутного паралелепіпеда";
            // 
            // lblRectVolume
            // 
            lblRectVolume.Location = new Point(429, 222);
            lblRectVolume.Name = "lblRectVolume";
            lblRectVolume.Size = new Size(146, 27);
            lblRectVolume.TabIndex = 9;
            // 
            // lblCubeVolume
            // 
            lblCubeVolume.Location = new Point(429, 62);
            lblCubeVolume.Name = "lblCubeVolume";
            lblCubeVolume.Size = new Size(146, 27);
            lblCubeVolume.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 450);
            Controls.Add(lblCubeVolume);
            Controls.Add(lblRectVolume);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnCalculate);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox nudA;
        private Label label1;
        private TextBox nudD;
        private TextBox nudC;
        private TextBox nudH;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label6;
        private TextBox lblRectVolume;
        private TextBox lblCubeVolume;
    }
}
