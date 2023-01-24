namespace Polysensor_boxManager
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
            this.bpReadParameterFromFile = new System.Windows.Forms.Button();
            this.Cb_ComPort = new System.Windows.Forms.ComboBox();
            this.lb_comPortText = new System.Windows.Forms.Label();
            this.Bt_openPort = new System.Windows.Forms.Button();
            this.gb_Line = new System.Windows.Forms.GroupBox();
            this.gb_line3 = new System.Windows.Forms.GroupBox();
            this.cb_line3 = new System.Windows.Forms.ComboBox();
            this.gb_line2 = new System.Windows.Forms.GroupBox();
            this.cb_line2 = new System.Windows.Forms.ComboBox();
            this.gb_line1 = new System.Windows.Forms.GroupBox();
            this.cb_line1 = new System.Windows.Forms.ComboBox();
            this.gb_physical = new System.Windows.Forms.GroupBox();
            this.bt_removePhysical = new System.Windows.Forms.Button();
            this.flp_Physical = new System.Windows.Forms.FlowLayoutPanel();
            this.bt_addPhysical = new System.Windows.Forms.Button();
            this.bpWriteParameterToFile = new System.Windows.Forms.Button();
            this.bpWriteParameterToBox = new System.Windows.Forms.Button();
            this.bpReadParameterFromBox = new System.Windows.Forms.Button();
            this.gb_Line.SuspendLayout();
            this.gb_line3.SuspendLayout();
            this.gb_line2.SuspendLayout();
            this.gb_line1.SuspendLayout();
            this.gb_physical.SuspendLayout();
            this.SuspendLayout();
            // 
            // bpReadParameterFromFile
            // 
            this.bpReadParameterFromFile.Location = new System.Drawing.Point(991, 447);
            this.bpReadParameterFromFile.Name = "bpReadParameterFromFile";
            this.bpReadParameterFromFile.Size = new System.Drawing.Size(236, 29);
            this.bpReadParameterFromFile.TabIndex = 0;
            this.bpReadParameterFromFile.Text = "Read Parameter from file";
            this.bpReadParameterFromFile.UseVisualStyleBackColor = true;
            this.bpReadParameterFromFile.Click += new System.EventHandler(this.bpReadParameterFromFile_Click);
            // 
            // Cb_ComPort
            // 
            this.Cb_ComPort.FormattingEnabled = true;
            this.Cb_ComPort.Location = new System.Drawing.Point(77, 444);
            this.Cb_ComPort.Name = "Cb_ComPort";
            this.Cb_ComPort.Size = new System.Drawing.Size(135, 28);
            this.Cb_ComPort.TabIndex = 1;
            this.Cb_ComPort.SelectedIndexChanged += new System.EventHandler(this.Cb_ComPort_SelectedIndexChanged);
            this.Cb_ComPort.Click += new System.EventHandler(this.Cb_ComPort_Click);
            // 
            // lb_comPortText
            // 
            this.lb_comPortText.AutoSize = true;
            this.lb_comPortText.Location = new System.Drawing.Point(3, 447);
            this.lb_comPortText.Name = "lb_comPortText";
            this.lb_comPortText.Size = new System.Drawing.Size(68, 20);
            this.lb_comPortText.TabIndex = 2;
            this.lb_comPortText.Text = "Port com";
            // 
            // Bt_openPort
            // 
            this.Bt_openPort.Enabled = false;
            this.Bt_openPort.Location = new System.Drawing.Point(227, 443);
            this.Bt_openPort.Name = "Bt_openPort";
            this.Bt_openPort.Size = new System.Drawing.Size(94, 29);
            this.Bt_openPort.TabIndex = 3;
            this.Bt_openPort.Text = "open";
            this.Bt_openPort.UseVisualStyleBackColor = true;
            this.Bt_openPort.Click += new System.EventHandler(this.Bt_openPort_Click);
            // 
            // gb_Line
            // 
            this.gb_Line.Controls.Add(this.gb_line3);
            this.gb_Line.Controls.Add(this.gb_line2);
            this.gb_Line.Controls.Add(this.gb_line1);
            this.gb_Line.Location = new System.Drawing.Point(10, 53);
            this.gb_Line.Name = "gb_Line";
            this.gb_Line.Size = new System.Drawing.Size(315, 381);
            this.gb_Line.TabIndex = 4;
            this.gb_Line.TabStop = false;
            this.gb_Line.Text = "lines";
            // 
            // gb_line3
            // 
            this.gb_line3.Controls.Add(this.cb_line3);
            this.gb_line3.Location = new System.Drawing.Point(23, 262);
            this.gb_line3.Name = "gb_line3";
            this.gb_line3.Size = new System.Drawing.Size(236, 79);
            this.gb_line3.TabIndex = 2;
            this.gb_line3.TabStop = false;
            this.gb_line3.Text = "line 3";
            // 
            // cb_line3
            // 
            this.cb_line3.FormattingEnabled = true;
            this.cb_line3.Location = new System.Drawing.Point(44, 26);
            this.cb_line3.Name = "cb_line3";
            this.cb_line3.Size = new System.Drawing.Size(151, 28);
            this.cb_line3.TabIndex = 2;
            this.cb_line3.Click += new System.EventHandler(this.cb_line3_Click);
            // 
            // gb_line2
            // 
            this.gb_line2.Controls.Add(this.cb_line2);
            this.gb_line2.Location = new System.Drawing.Point(23, 145);
            this.gb_line2.Name = "gb_line2";
            this.gb_line2.Size = new System.Drawing.Size(236, 78);
            this.gb_line2.TabIndex = 1;
            this.gb_line2.TabStop = false;
            this.gb_line2.Text = "line 2";
            // 
            // cb_line2
            // 
            this.cb_line2.FormattingEnabled = true;
            this.cb_line2.Location = new System.Drawing.Point(43, 26);
            this.cb_line2.Name = "cb_line2";
            this.cb_line2.Size = new System.Drawing.Size(151, 28);
            this.cb_line2.TabIndex = 3;
            this.cb_line2.Click += new System.EventHandler(this.cb_line2_Click);
            // 
            // gb_line1
            // 
            this.gb_line1.Controls.Add(this.cb_line1);
            this.gb_line1.Location = new System.Drawing.Point(23, 51);
            this.gb_line1.Name = "gb_line1";
            this.gb_line1.Size = new System.Drawing.Size(236, 70);
            this.gb_line1.TabIndex = 0;
            this.gb_line1.TabStop = false;
            this.gb_line1.Text = "line1";
            // 
            // cb_line1
            // 
            this.cb_line1.FormattingEnabled = true;
            this.cb_line1.Location = new System.Drawing.Point(44, 26);
            this.cb_line1.Name = "cb_line1";
            this.cb_line1.Size = new System.Drawing.Size(151, 28);
            this.cb_line1.TabIndex = 1;
            this.cb_line1.SelectedIndexChanged += new System.EventHandler(this.cb_line1_SelectedIndexChanged);
            this.cb_line1.Click += new System.EventHandler(this.cb_line1_Click);
            // 
            // gb_physical
            // 
            this.gb_physical.Controls.Add(this.bt_removePhysical);
            this.gb_physical.Controls.Add(this.flp_Physical);
            this.gb_physical.Controls.Add(this.bt_addPhysical);
            this.gb_physical.Location = new System.Drawing.Point(331, 53);
            this.gb_physical.Name = "gb_physical";
            this.gb_physical.Size = new System.Drawing.Size(853, 381);
            this.gb_physical.TabIndex = 5;
            this.gb_physical.TabStop = false;
            this.gb_physical.Text = "Physical ";
            // 
            // bt_removePhysical
            // 
            this.bt_removePhysical.Location = new System.Drawing.Point(653, 346);
            this.bt_removePhysical.Name = "bt_removePhysical";
            this.bt_removePhysical.Size = new System.Drawing.Size(94, 29);
            this.bt_removePhysical.TabIndex = 2;
            this.bt_removePhysical.Text = "remove";
            this.bt_removePhysical.UseVisualStyleBackColor = true;
            this.bt_removePhysical.Click += new System.EventHandler(this.bt_removePhysical_Click);
            // 
            // flp_Physical
            // 
            this.flp_Physical.Location = new System.Drawing.Point(6, 26);
            this.flp_Physical.Name = "flp_Physical";
            this.flp_Physical.Size = new System.Drawing.Size(841, 315);
            this.flp_Physical.TabIndex = 1;
            // 
            // bt_addPhysical
            // 
            this.bt_addPhysical.Location = new System.Drawing.Point(753, 346);
            this.bt_addPhysical.Name = "bt_addPhysical";
            this.bt_addPhysical.Size = new System.Drawing.Size(94, 29);
            this.bt_addPhysical.TabIndex = 0;
            this.bt_addPhysical.Text = "Add";
            this.bt_addPhysical.UseVisualStyleBackColor = true;
            this.bt_addPhysical.Click += new System.EventHandler(this.bt_addPhysical_Click);
            // 
            // bpWriteParameterToFile
            // 
            this.bpWriteParameterToFile.Location = new System.Drawing.Point(809, 447);
            this.bpWriteParameterToFile.Name = "bpWriteParameterToFile";
            this.bpWriteParameterToFile.Size = new System.Drawing.Size(176, 29);
            this.bpWriteParameterToFile.TabIndex = 6;
            this.bpWriteParameterToFile.Text = "Write Parameter to file";
            this.bpWriteParameterToFile.UseVisualStyleBackColor = true;
            this.bpWriteParameterToFile.Click += new System.EventHandler(this.bpWriteParameterToFile_Click);
            // 
            // bpWriteParameterToBox
            // 
            this.bpWriteParameterToBox.Enabled = false;
            this.bpWriteParameterToBox.Location = new System.Drawing.Point(603, 447);
            this.bpWriteParameterToBox.Name = "bpWriteParameterToBox";
            this.bpWriteParameterToBox.Size = new System.Drawing.Size(200, 29);
            this.bpWriteParameterToBox.TabIndex = 7;
            this.bpWriteParameterToBox.Text = "Write Parameter to Box";
            this.bpWriteParameterToBox.UseVisualStyleBackColor = true;
            this.bpWriteParameterToBox.Click += new System.EventHandler(this.bpWriteParameterToBox_Click);
            // 
            // bpReadParameterFromBox
            // 
            this.bpReadParameterFromBox.Enabled = false;
            this.bpReadParameterFromBox.Location = new System.Drawing.Point(348, 447);
            this.bpReadParameterFromBox.Name = "bpReadParameterFromBox";
            this.bpReadParameterFromBox.Size = new System.Drawing.Size(249, 29);
            this.bpReadParameterFromBox.TabIndex = 8;
            this.bpReadParameterFromBox.Text = "Read Parameter from a box";
            this.bpReadParameterFromBox.UseVisualStyleBackColor = true;
            this.bpReadParameterFromBox.Click += new System.EventHandler(this.bpReadParameterFromBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 485);
            this.Controls.Add(this.bpReadParameterFromBox);
            this.Controls.Add(this.bpWriteParameterToBox);
            this.Controls.Add(this.bpWriteParameterToFile);
            this.Controls.Add(this.gb_physical);
            this.Controls.Add(this.gb_Line);
            this.Controls.Add(this.Bt_openPort);
            this.Controls.Add(this.lb_comPortText);
            this.Controls.Add(this.Cb_ComPort);
            this.Controls.Add(this.bpReadParameterFromFile);
            this.Name = "Form1";
            this.Text = "PolySensorBox Manager";
            this.gb_Line.ResumeLayout(false);
            this.gb_line3.ResumeLayout(false);
            this.gb_line2.ResumeLayout(false);
            this.gb_line1.ResumeLayout(false);
            this.gb_physical.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bpReadParameterFromFile;
        private ComboBox Cb_ComPort;
        private Label lb_comPortText;
        private Button Bt_openPort;
        private GroupBox gb_Line;
        private GroupBox gb_line3;
        private ComboBox cb_line3;
        private GroupBox gb_line2;
        private ComboBox cb_line2;
        private GroupBox gb_line1;
        private ComboBox cb_line1;
        private GroupBox gb_physical;
        private Button bt_addPhysical;
        private FlowLayoutPanel flp_Physical;
        private Button bt_removePhysical;
        private Button bpWriteParameterToFile;
        private Button bpWriteParameterToBox;
        private Button bpReadParameterFromBox;
    }
}