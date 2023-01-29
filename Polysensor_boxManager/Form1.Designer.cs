using System.Windows.Forms;

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
            this.SensorTab = new System.Windows.Forms.TabControl();
            this.SensorPage = new System.Windows.Forms.TabPage();
            this.LoraPage = new System.Windows.Forms.TabPage();
            this.Tb_LoraPeriod = new System.Windows.Forms.TextBox();
            this.cb_loraMode = new System.Windows.Forms.CheckBox();
            this.TB_AppKey = new System.Windows.Forms.TextBox();
            this.Tb_DevUUID = new System.Windows.Forms.TextBox();
            this.TB_appUUID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_Line.SuspendLayout();
            this.gb_line3.SuspendLayout();
            this.gb_line2.SuspendLayout();
            this.gb_line1.SuspendLayout();
            this.gb_physical.SuspendLayout();
            this.SensorTab.SuspendLayout();
            this.SensorPage.SuspendLayout();
            this.LoraPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // bpReadParameterFromFile
            // 
            this.bpReadParameterFromFile.Location = new System.Drawing.Point(1006, 456);
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
            this.Cb_ComPort.Location = new System.Drawing.Point(92, 453);
            this.Cb_ComPort.Name = "Cb_ComPort";
            this.Cb_ComPort.Size = new System.Drawing.Size(135, 28);
            this.Cb_ComPort.TabIndex = 1;
            this.Cb_ComPort.SelectedIndexChanged += new System.EventHandler(this.Cb_ComPort_SelectedIndexChanged);
            this.Cb_ComPort.Click += new System.EventHandler(this.Cb_ComPort_Click);
            // 
            // lb_comPortText
            // 
            this.lb_comPortText.AutoSize = true;
            this.lb_comPortText.Location = new System.Drawing.Point(18, 456);
            this.lb_comPortText.Name = "lb_comPortText";
            this.lb_comPortText.Size = new System.Drawing.Size(68, 20);
            this.lb_comPortText.TabIndex = 2;
            this.lb_comPortText.Text = "Port com";
            // 
            // Bt_openPort
            // 
            this.Bt_openPort.Enabled = false;
            this.Bt_openPort.Location = new System.Drawing.Point(242, 452);
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
            this.gb_Line.Location = new System.Drawing.Point(6, 6);
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
            this.gb_physical.Location = new System.Drawing.Point(327, 6);
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
            this.bpWriteParameterToFile.Location = new System.Drawing.Point(824, 456);
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
            this.bpWriteParameterToBox.Location = new System.Drawing.Point(618, 456);
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
            this.bpReadParameterFromBox.Location = new System.Drawing.Point(363, 456);
            this.bpReadParameterFromBox.Name = "bpReadParameterFromBox";
            this.bpReadParameterFromBox.Size = new System.Drawing.Size(249, 29);
            this.bpReadParameterFromBox.TabIndex = 8;
            this.bpReadParameterFromBox.Text = "Read Parameter from a box";
            this.bpReadParameterFromBox.UseVisualStyleBackColor = true;
            this.bpReadParameterFromBox.Click += new System.EventHandler(this.bpReadParameterFromBox_Click);
            // 
            // SensorTab
            // 
            this.SensorTab.Controls.Add(this.SensorPage);
            this.SensorTab.Controls.Add(this.LoraPage);
            this.SensorTab.Location = new System.Drawing.Point(11, 12);
            this.SensorTab.Name = "SensorTab";
            this.SensorTab.SelectedIndex = 0;
            this.SensorTab.Size = new System.Drawing.Size(1224, 434);
            this.SensorTab.TabIndex = 9;
            this.SensorTab.SelectedIndexChanged += new System.EventHandler(this.SensorTab_SelectedIndexChanged);
            // 
            // SensorPage
            // 
            this.SensorPage.Controls.Add(this.gb_Line);
            this.SensorPage.Controls.Add(this.gb_physical);
            this.SensorPage.Location = new System.Drawing.Point(4, 29);
            this.SensorPage.Name = "SensorPage";
            this.SensorPage.Padding = new System.Windows.Forms.Padding(3);
            this.SensorPage.Size = new System.Drawing.Size(1216, 401);
            this.SensorPage.TabIndex = 0;
            this.SensorPage.Text = "Sensor";
            this.SensorPage.UseVisualStyleBackColor = true;
            // 
            // LoraPage
            // 
            this.LoraPage.Controls.Add(this.Tb_LoraPeriod);
            this.LoraPage.Controls.Add(this.cb_loraMode);
            this.LoraPage.Controls.Add(this.TB_AppKey);
            this.LoraPage.Controls.Add(this.Tb_DevUUID);
            this.LoraPage.Controls.Add(this.TB_appUUID);
            this.LoraPage.Controls.Add(this.label4);
            this.LoraPage.Controls.Add(this.label3);
            this.LoraPage.Controls.Add(this.label2);
            this.LoraPage.Controls.Add(this.label1);
            this.LoraPage.Location = new System.Drawing.Point(4, 29);
            this.LoraPage.Name = "LoraPage";
            this.LoraPage.Padding = new System.Windows.Forms.Padding(3);
            this.LoraPage.Size = new System.Drawing.Size(1216, 401);
            this.LoraPage.TabIndex = 1;
            this.LoraPage.Text = "Lora";
            this.LoraPage.UseVisualStyleBackColor = true;
            // 
            // Tb_LoraPeriod
            // 
            this.Tb_LoraPeriod.Location = new System.Drawing.Point(133, 158);
            this.Tb_LoraPeriod.Name = "Tb_LoraPeriod";
            this.Tb_LoraPeriod.Size = new System.Drawing.Size(279, 27);
            this.Tb_LoraPeriod.TabIndex = 9;
            // 
            // cb_loraMode
            // 
            this.cb_loraMode.AutoSize = true;
            this.cb_loraMode.Location = new System.Drawing.Point(29, 205);
            this.cb_loraMode.Name = "cb_loraMode";
            this.cb_loraMode.Size = new System.Drawing.Size(176, 24);
            this.cb_loraMode.TabIndex = 8;
            this.cb_loraMode.Text = "send when data ready";
            this.cb_loraMode.UseVisualStyleBackColor = true;
            this.cb_loraMode.CheckedChanged += new System.EventHandler(this.cb_loraMode_CheckedChanged);
            // 
            // TB_AppKey
            // 
            this.TB_AppKey.Location = new System.Drawing.Point(133, 125);
            this.TB_AppKey.Name = "TB_AppKey";
            this.TB_AppKey.Size = new System.Drawing.Size(279, 27);
            this.TB_AppKey.TabIndex = 7;
            // 
            // Tb_DevUUID
            // 
            this.Tb_DevUUID.Location = new System.Drawing.Point(133, 85);
            this.Tb_DevUUID.Name = "Tb_DevUUID";
            this.Tb_DevUUID.Size = new System.Drawing.Size(279, 27);
            this.Tb_DevUUID.TabIndex = 6;
            // 
            // TB_appUUID
            // 
            this.TB_appUUID.Location = new System.Drawing.Point(133, 39);
            this.TB_appUUID.Name = "TB_appUUID";
            this.TB_appUUID.Size = new System.Drawing.Size(279, 27);
            this.TB_appUUID.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "SendPeriod:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "AppKey:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "DevUUID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "AppUUID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 501);
            this.Controls.Add(this.SensorTab);
            this.Controls.Add(this.bpReadParameterFromBox);
            this.Controls.Add(this.bpWriteParameterToBox);
            this.Controls.Add(this.bpWriteParameterToFile);
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
            this.SensorTab.ResumeLayout(false);
            this.SensorPage.ResumeLayout(false);
            this.LoraPage.ResumeLayout(false);
            this.LoraPage.PerformLayout();
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
        private TabControl SensorTab;
        private TabPage SensorPage;
        private TabPage LoraPage;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox TB_appUUID;
        private TextBox TB_AppKey;
        private TextBox Tb_DevUUID;
        private CheckBox cb_loraMode;
        private TextBox Tb_LoraPeriod;
    }
}