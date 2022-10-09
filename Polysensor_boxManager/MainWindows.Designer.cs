namespace Polysensor_boxManager
{
    partial class MainWindows
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBPortCom = new System.Windows.Forms.ComboBox();
            this.bpOpen = new System.Windows.Forms.Button();
            this.bpReadFromFile = new System.Windows.Forms.Button();
            this.bpWritetoFile = new System.Windows.Forms.Button();
            this.bpReadParamFromBox = new System.Windows.Forms.Button();
            this.bpWriteParamToBox = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bpWriteParamToBox);
            this.groupBox1.Controls.Add(this.bpReadParamFromBox);
            this.groupBox1.Controls.Add(this.bpWritetoFile);
            this.groupBox1.Controls.Add(this.bpReadFromFile);
            this.groupBox1.Controls.Add(this.bpOpen);
            this.groupBox1.Controls.Add(this.CBPortCom);
            this.groupBox1.Location = new System.Drawing.Point(0, 486);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(984, 68);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // CBPortCom
            // 
            this.CBPortCom.FormattingEnabled = true;
            this.CBPortCom.Location = new System.Drawing.Point(12, 27);
            this.CBPortCom.Name = "CBPortCom";
            this.CBPortCom.Size = new System.Drawing.Size(151, 28);
            this.CBPortCom.TabIndex = 0;
            this.CBPortCom.Text = "COM1";
            // 
            // bpOpen
            // 
            this.bpOpen.Location = new System.Drawing.Point(182, 26);
            this.bpOpen.Name = "bpOpen";
            this.bpOpen.Size = new System.Drawing.Size(94, 29);
            this.bpOpen.TabIndex = 1;
            this.bpOpen.Text = "Open";
            this.bpOpen.UseVisualStyleBackColor = true;
            // 
            // bpReadFromFile
            // 
            this.bpReadFromFile.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bpReadFromFile.Location = new System.Drawing.Point(324, 26);
            this.bpReadFromFile.Name = "bpReadFromFile";
            this.bpReadFromFile.Size = new System.Drawing.Size(153, 29);
            this.bpReadFromFile.TabIndex = 2;
            this.bpReadFromFile.Text = "Read parameter from file";
            this.bpReadFromFile.UseVisualStyleBackColor = true;
            // 
            // bpWritetoFile
            // 
            this.bpWritetoFile.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bpWritetoFile.Location = new System.Drawing.Point(483, 26);
            this.bpWritetoFile.Name = "bpWritetoFile";
            this.bpWritetoFile.Size = new System.Drawing.Size(153, 29);
            this.bpWritetoFile.TabIndex = 3;
            this.bpWritetoFile.Text = "Write parameters to file";
            this.bpWritetoFile.UseVisualStyleBackColor = true;
            // 
            // bpReadParamFromBox
            // 
            this.bpReadParamFromBox.AllowDrop = true;
            this.bpReadParamFromBox.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bpReadParamFromBox.Location = new System.Drawing.Point(649, 26);
            this.bpReadParamFromBox.Name = "bpReadParamFromBox";
            this.bpReadParamFromBox.Size = new System.Drawing.Size(162, 29);
            this.bpReadParamFromBox.TabIndex = 4;
            this.bpReadParamFromBox.Text = "Read parameters from box";
            this.bpReadParamFromBox.UseVisualStyleBackColor = true;
            // 
            // bpWriteParamToBox
            // 
            this.bpWriteParamToBox.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bpWriteParamToBox.Location = new System.Drawing.Point(817, 26);
            this.bpWriteParamToBox.Name = "bpWriteParamToBox";
            this.bpWriteParamToBox.Size = new System.Drawing.Size(153, 29);
            this.bpWriteParamToBox.TabIndex = 5;
            this.bpWriteParamToBox.Text = "Write parameters to box";
            this.bpWriteParamToBox.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(5, 45);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox8);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox7);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox6);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox5);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Size = new System.Drawing.Size(971, 446);
            this.splitContainer1.SplitterDistance = 323;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Location = new System.Drawing.Point(7, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 117);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Line1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sensor:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(94, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "SCD30";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Location = new System.Drawing.Point(3, 177);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(274, 117);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Line2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sensor:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(94, 47);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(151, 28);
            this.comboBox2.TabIndex = 0;
            this.comboBox2.Text = "Empty";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.comboBox3);
            this.groupBox4.Location = new System.Drawing.Point(7, 318);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(274, 117);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Line3";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sensor:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(94, 47);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(151, 28);
            this.comboBox3.TabIndex = 0;
            this.comboBox3.Text = "BME280";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lines configuration";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(518, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Measure";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.comboBox4);
            this.groupBox5.Location = new System.Drawing.Point(15, 16);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(300, 120);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Temperature";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Sensor:";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(85, 34);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(151, 28);
            this.comboBox4.TabIndex = 0;
            this.comboBox4.Text = "SCD30";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 27);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "300";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Period:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(206, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button3);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.textBox2);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.comboBox5);
            this.groupBox6.Location = new System.Drawing.Point(15, 153);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(300, 120);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Humidity";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(206, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 4;
            this.button3.Text = "Remove";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Period:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(85, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 27);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "1200";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Sensor:";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(85, 34);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(151, 28);
            this.comboBox5.TabIndex = 0;
            this.comboBox5.Text = "SCD30";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button4);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.textBox3);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.comboBox6);
            this.groupBox7.Location = new System.Drawing.Point(338, 16);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(300, 120);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Pressure";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(206, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 4;
            this.button4.Text = "Remove";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Period:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(85, 73);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(151, 27);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "4800";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Sensor:";
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(85, 34);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(151, 28);
            this.comboBox6.TabIndex = 0;
            this.comboBox6.Text = "BME280";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.button5);
            this.groupBox8.Controls.Add(this.label11);
            this.groupBox8.Controls.Add(this.textBox4);
            this.groupBox8.Controls.Add(this.label12);
            this.groupBox8.Controls.Add(this.comboBox7);
            this.groupBox8.Location = new System.Drawing.Point(338, 153);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(300, 120);
            this.groupBox8.TabIndex = 6;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "C02";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(206, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 29);
            this.button5.TabIndex = 4;
            this.button5.Text = "Remove";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "Period:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(85, 73);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(151, 27);
            this.textBox4.TabIndex = 2;
            this.textBox4.Text = "120";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "Sensor:";
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(85, 34);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(151, 28);
            this.comboBox7.TabIndex = 0;
            this.comboBox7.Text = "SCD30";
            // 
            // MainWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainWindows";
            this.Text = "PolySensorBox Manager";
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button bpWriteParamToBox;
        private Button bpReadParamFromBox;
        private Button bpWritetoFile;
        private Button bpReadFromFile;
        private Button bpOpen;
        private ComboBox CBPortCom;
        private SplitContainer splitContainer1;
        private GroupBox groupBox4;
        private Label label3;
        private ComboBox comboBox3;
        private GroupBox groupBox3;
        private Label label2;
        private ComboBox comboBox2;
        private GroupBox groupBox2;
        private Label label1;
        private ComboBox comboBox1;
        private Label label4;
        private GroupBox groupBox8;
        private Button button5;
        private Label label11;
        private TextBox textBox4;
        private Label label12;
        private ComboBox comboBox7;
        private GroupBox groupBox7;
        private Button button4;
        private Label label9;
        private TextBox textBox3;
        private Label label10;
        private ComboBox comboBox6;
        private GroupBox groupBox6;
        private Button button3;
        private Label label7;
        private TextBox textBox2;
        private Label label8;
        private ComboBox comboBox5;
        private GroupBox groupBox5;
        private Button button2;
        private Label label6;
        private TextBox textBox1;
        private Label label5;
        private ComboBox comboBox4;
        private Button button1;
    }
}