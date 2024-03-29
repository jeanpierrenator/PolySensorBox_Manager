using System.Diagnostics;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Polysensor_boxManager
{
    public partial class Form1 : Form
    {
       
        private ConfigXMLManager myConfigXMLManager;
        private ConfigModel myConfigModel;
        SerialManager _serialManager;
        private List<GroupBox> listSensorView;
        private DataModel myDataModel;
        public Form1()
        {
            
            InitializeComponent();
            _serialManager = SerialManager.GetInstance();
            listSensorView = new List<GroupBox>();
            myDataModel = DataModel.getInstance();
            myConfigXMLManager = new ConfigXMLManager();
            myConfigModel = new ConfigModel();
            this.TB_appUUID.KeyPress += this.TB_appUUID_KeyPress;
            this.TB_AppKey.KeyPress += this.TB_AppKey_KeyPress;
            this.Tb_DevUUID.KeyPress += this.Tb_DevUUID_KeyPress;
        }
        private void promptError(string msg)
        {
            MessageBox.Show(msg);
        }

        private void bpReadParameterFromFile_Click(object sender, EventArgs e)
        {
            string path;
            OpenFileDialog file = new OpenFileDialog();
            
            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
                myConfigModel = myConfigXMLManager.parseData(path);
            }
            printConfig();

        }

        private void bpWriteParameterToFile_Click(object sender, EventArgs e)
        {
            string path;
            updateConfigModel();
            if (myConfigModel.validateConfig() != -1)
            {
                SaveFileDialog file = new SaveFileDialog();
                file.DefaultExt = "xml";
                if (file.ShowDialog() == DialogResult.OK)
                {
                    path = file.FileName;
                    myConfigXMLManager.saveConfig(path, myConfigModel);
                }
            }
            else
            {
                string message = "Bad line configuration";
                promptError(message);
            }

        }

        private void Cb_ComPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            _serialManager.SetPortName(Cb_ComPort.Text);
            Bt_openPort.Enabled = true;
        }

        private void Cb_ComPort_Click(object sender, EventArgs e)
        {
            Cb_ComPort.Items.Clear();
            foreach (string s in SerialManager.GetAvailablePort())
            {
                Cb_ComPort.Items.Add(s);
            }
        }
     
        

        private void Bt_openPort_Click(object sender, EventArgs e)
        {
            if (!SerialManager.isOpen)
            {
                Bt_openPort.Text = "Open";
               
                try
                {
                    _serialManager.OpenPort();
                    Bt_openPort.Text = "Close";
                    Cb_ComPort.Enabled = false;
                    lb_comPortText.Text = "Openned";
                    bpWriteParameterToBox.Enabled = true;
                    bpReadParameterFromBox.Enabled = true;
                    if (SerialProtocol.sendConnectionFrame() == -1)
                    {
                        lb_comPortText.ForeColor = System.Drawing.Color.Red;
                        lb_comPortText.Text = "close";
                        _serialManager.ClosePort();
                        Bt_openPort.Text = "Open";
                        Cb_ComPort.Enabled = true;
                        bpWriteParameterToBox.Enabled = false;
                        bpReadParameterFromBox.Enabled = false;
                        string message = "Not connected to a PolySensorBox";
                        promptError(message);
                    }
                }
                catch (Exception ex)
                {
                    lb_comPortText.ForeColor = System.Drawing.Color.Red;
                    lb_comPortText.Text = "Error";
                    string message = "Alredy openned port";
                    promptError(message);
                }
               
                
               
            }
            else
            {
                try
                {
                    _serialManager.ClosePort();
                    Bt_openPort.Text = "Open";
                    Cb_ComPort.Enabled = true;
                    lb_comPortText.Text = "ferm�e";
                    bpWriteParameterToBox.Enabled = false;
                    bpReadParameterFromBox.Enabled = false;
                }
                catch (Exception ex)
                {
                    lb_comPortText.ForeColor = System.Drawing.Color.Red;
                    lb_comPortText.Text = "Erreur fermeture";
                }

            }
            }

        private void bt_addPhysical_Click(object sender, EventArgs e)
        {
            PhysicalSelectForm form = new PhysicalSelectForm();

            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(this.Location.X + this.Width / 2 - form.Width/2, this.Location.Y + this.Height / 2 - form.Height/2);
            foreach (string physical in myDataModel.physicalStringToId.Keys)
            {
                form.GetComboBox().Items.Add(physical);
            }
            form.GetComboBox().SelectedIndex = 0;
            form.ShowDialog();
            form.Dispose();
            if (form.confirm == 1)
            {
                GroupBox physicalWindows = GetPhysicalBox(form.GetComboBox().Text, 0, myDataModel.physicals[myDataModel.physicalStringToId[form.GetComboBox().Text]].sensors);
                flp_Physical.Controls.Add(physicalWindows);
                listSensorView.Add(physicalWindows);
            }
        }

        private void bt_removePhysical_Click(object sender, EventArgs e)
        {
            PhysicalSelectForm form = new PhysicalSelectForm(1);
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(this.Location.X + this.Width / 2 - form.Width / 2, this.Location.Y + this.Height / 2 - form.Height / 2);
            foreach (GroupBox gb in listSensorView)
            {
                form.GetComboBox().Items.Add(gb.Text);
            }
            form.ShowDialog();
        
            form.Dispose();
            if (form.confirm == 1)
            {
                GroupBox gbtoRemove = new GroupBox();
                foreach (GroupBox gb in listSensorView)
                {
                    if (form.GetComboBox().Text == gb.Text)
                    {
                        gbtoRemove = gb;
                    }

                }
                listSensorView.Remove(gbtoRemove);
                flp_Physical.Controls.Remove(gbtoRemove);
                gbtoRemove.Dispose();
            }
            
        }


        private GroupBox GetPhysicalBox(string physicalName, int period, List<Sensor> sensorlist)
        {
            GroupBox g = new GroupBox();
            g.Size = new Size(250, 100);
            g.Text = physicalName;

            ComboBox cb = new ComboBox();
            cb.Location = new Point(100, 20);
            foreach (Sensor sensor in sensorlist)
            {
                cb.Items.Add(sensor.name);
            }
            if(cb.Items.Count >0)
            cb.SelectedIndex = 0;
            cb.Name = "Sensor";

            Label lbl = new Label();
            lbl.Text = "Capteur :";
            lbl.Location = new Point(5, 20);

            Label lbl1 = new Label();
            lbl1.Text = "Periode :";
            lbl1.Location = new Point(5, 60);

            TextBox txt = new TextBox();
            txt.Location = new Point(100, 60);
            txt.Text = period.ToString();
            txt.Name = "Periode";

            g.Controls.Add(cb);
            g.Controls.Add(txt);
            g.Controls.Add(lbl);
            g.Controls.Add(lbl1);



            return g;
        }

        private void printConfig()
        {
            listSensorView.Clear();
            flp_Physical.Controls.Clear();

            if (myConfigModel.TempSensor != 0)
            {
                GroupBox physicalWindows = GetPhysicalBox(DataConstant.STRING_TEMP, myConfigModel.TempPeriode, myDataModel.physicals[myDataModel.physicalStringToId[DataConstant.STRING_TEMP]].sensors); 
                flp_Physical.Controls.Add(physicalWindows);
                listSensorView.Add(physicalWindows);
                ComboBox comboBox = physicalWindows.Controls.OfType<ComboBox>().FirstOrDefault();
                comboBox.SelectedIndex = comboBox.FindStringExact(myDataModel.sensors[myConfigModel.TempSensor].name);
            }
            if (myConfigModel.HumidSensor != 0)
            {
                GroupBox physicalWindows = GetPhysicalBox(DataConstant.STRING_HUMIDITY, myConfigModel.HumidPeriode, myDataModel.physicals[myDataModel.physicalStringToId[DataConstant.STRING_HUMIDITY]].sensors);
                flp_Physical.Controls.Add(physicalWindows);
                listSensorView.Add(physicalWindows);
                ComboBox comboBox = physicalWindows.Controls.OfType<ComboBox>().FirstOrDefault();
                comboBox.SelectedIndex = comboBox.FindStringExact(myDataModel.sensors[myConfigModel.HumidSensor].name);
            }
            if (myConfigModel.Co2Sensor != 0)
            {
                GroupBox physicalWindows = GetPhysicalBox(DataConstant.STRING_CO2, myConfigModel.Co2Periode, myDataModel.physicals[myDataModel.physicalStringToId[DataConstant.STRING_CO2]].sensors);
                flp_Physical.Controls.Add(physicalWindows);
                listSensorView.Add(physicalWindows);
                ComboBox comboBox = physicalWindows.Controls.OfType<ComboBox>().FirstOrDefault();
                comboBox.SelectedIndex = comboBox.FindStringExact(myDataModel.sensors[myConfigModel.Co2Sensor].name);
            }
            if (myConfigModel.LuxSensor != 0)
            {
                GroupBox physicalWindows = GetPhysicalBox(DataConstant.STRING_LUX, myConfigModel.LuxPeriode, myDataModel.physicals[myDataModel.physicalStringToId[DataConstant.STRING_LUX]].sensors);
                flp_Physical.Controls.Add(physicalWindows);
                listSensorView.Add(physicalWindows);
                ComboBox comboBox = physicalWindows.Controls.OfType<ComboBox>().FirstOrDefault();
                comboBox.SelectedIndex = comboBox.FindStringExact(myDataModel.sensors[myConfigModel.LuxSensor].name);
            }
            if (myConfigModel.eCo2Sensor != 0)
            {
                GroupBox physicalWindows = GetPhysicalBox(DataConstant.STRING_ECO2, myConfigModel.eCo2Periode, myDataModel.physicals[myDataModel.physicalStringToId[DataConstant.STRING_ECO2]].sensors);
                flp_Physical.Controls.Add(physicalWindows);
                listSensorView.Add(physicalWindows);
                ComboBox comboBox = physicalWindows.Controls.OfType<ComboBox>().FirstOrDefault();
                comboBox.SelectedIndex = comboBox.FindStringExact(myDataModel.sensors[myConfigModel.eCo2Sensor].name);
            }
            if (myConfigModel.TovcSensor != 0)
            {
                GroupBox physicalWindows = GetPhysicalBox(DataConstant.STRING_TOVC, myConfigModel.TovcPeriode, myDataModel.physicals[myDataModel.physicalStringToId[DataConstant.STRING_TOVC]].sensors);
                flp_Physical.Controls.Add(physicalWindows);
                listSensorView.Add(physicalWindows);
                ComboBox comboBox = physicalWindows.Controls.OfType<ComboBox>().FirstOrDefault();
                comboBox.SelectedIndex = comboBox.FindStringExact(myDataModel.sensors[myConfigModel.TovcSensor].name);
            }
            if (myConfigModel.PressionSensor != 0)
            {
                GroupBox physicalWindows = GetPhysicalBox(DataConstant.STRING_PRESS, myConfigModel.PressionPeriode, myDataModel.physicals[myDataModel.physicalStringToId[DataConstant.STRING_PRESS]].sensors);
                flp_Physical.Controls.Add(physicalWindows);
                listSensorView.Add(physicalWindows);
                ComboBox comboBox = physicalWindows.Controls.OfType<ComboBox>().FirstOrDefault();
                comboBox.SelectedIndex = comboBox.FindStringExact(myDataModel.sensors[myConfigModel.PressionSensor].name);
            }
            if (myConfigModel.UvSensor != 0)
            {
                GroupBox physicalWindows = GetPhysicalBox(DataConstant.STRING_UV, myConfigModel.UvPeriode, myDataModel.physicals[myDataModel.physicalStringToId[DataConstant.STRING_UV]].sensors);
                flp_Physical.Controls.Add(physicalWindows);
                listSensorView.Add(physicalWindows);
                ComboBox comboBox = physicalWindows.Controls.OfType<ComboBox>().FirstOrDefault();
                comboBox.SelectedIndex = comboBox.FindStringExact(myDataModel.sensors[myConfigModel.UvSensor].name);
            }
            if (myConfigModel.line1 != 0)
            {
                cb_line1.Items.Clear();
                cb_line1.Items.Add(myDataModel.sensors[myConfigModel.line1].name);
                cb_line1.SelectedIndex = 0;
            }
            if (myConfigModel.line2 != 0)
            {
                cb_line2.Items.Clear();
                cb_line2.Items.Add(myDataModel.sensors[myConfigModel.line2].name);
                cb_line2.SelectedIndex = 0;
            }
            if (myConfigModel.line3 != 0)
            {
                cb_line3.Items.Clear();
                cb_line3.Items.Add(myDataModel.sensors[myConfigModel.line3].name);
                cb_line3.SelectedIndex = 0;
            }

        }


        public void updateConfigModel()
        {
            myConfigModel.clear();
            foreach(GroupBox gb in listSensorView)
            {
                myConfigModel.updateValue(myDataModel.physicalStringToId[gb.Text], myDataModel.sensorStringToId[gb.Controls.OfType<ComboBox>().FirstOrDefault().Text], int.Parse(gb.Controls.OfType<TextBox>().FirstOrDefault().Text));
            }
            if(cb_line1.Text != "")
                myConfigModel.line1 = myDataModel.sensorStringToId[cb_line1.Text];
            if(cb_line2.Text != "")
                myConfigModel.line2 = myDataModel.sensorStringToId[cb_line2.Text];
            if(cb_line3.Text != "")
                myConfigModel.line3 = myDataModel.sensorStringToId[cb_line3.Text];

        }

        private void cb_line1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }
        private void cb_line1_Click(object sender, EventArgs e)
        {
            cb_line1.Items.Clear();
            foreach(String s in getAllActiveSensor())
                cb_line1.Items.Add(s);
            cb_line1.Items.Add("");
        }
        private void cb_line2_Click(object sender, EventArgs e)
        {
            cb_line2.Items.Clear();
            foreach (String s in getAllActiveSensor())
                cb_line2.Items.Add(s);
            cb_line2.Items.Add("");
        }
        private void cb_line3_Click(object sender, EventArgs e)
        {
            cb_line3.Items.Clear();

            foreach (String s in getAllActiveSensor())
                cb_line3.Items.Add(s);
            cb_line3.Items.Add("");

        }

        private List<String> getAllActiveSensor()
        {
            List<String> activeSensor = new List<String>();
            foreach(GroupBox gb in listSensorView)
            {
                activeSensor.Add(gb.Controls.OfType<ComboBox>().FirstOrDefault().Text);
            }
            activeSensor = activeSensor.Distinct().ToList();
            return activeSensor;
        }

        private void bpWriteParameterToBox_Click(object sender, EventArgs e)
        {

            if (SensorTab.SelectedIndex == 1)
            {
                try
                {
                    int period = 0;
                    if(this.cb_loraMode.Checked == true)
                    {
                        period = 0;
                    }
                    else
                    {
                        period = int.Parse(Tb_LoraPeriod.Text);
                    }
                    // on Tab lora
                    byte[] appKey = Enumerable.Range(0, TB_AppKey.Text.Length)
                    .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(TB_AppKey.Text.Substring(x, 2), 16))
                             .ToArray();
                    byte[] appUUID = Enumerable.Range(0, TB_appUUID.Text.Length)
                    .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(TB_appUUID.Text.Substring(x, 2), 16))
                             .ToArray();
                    byte[] devUUID = Enumerable.Range(0, Tb_DevUUID.Text.Length)
                    .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(Tb_DevUUID.Text.Substring(x, 2), 16))
                             .ToArray();
                    SerialProtocol.sendLora(appKey, appUUID, devUUID, period);
                }
                catch
                {
                    string message = "champs lora mal configur�";
                    MessageBox.Show(message);
                }
            }
            else
            {
                // on tab sensor 
                updateConfigModel();
                SerialProtocol.SendConfig(myConfigModel);
            }
            
        }

        private void bpReadParameterFromBox_Click(object sender, EventArgs e)
        {
            ConfigModel temp = SerialProtocol.readConfigFromBox();
            if(temp != null)
            {
                myConfigModel = temp;
                printConfig();
            }
        }


        private void SensorTab_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (SensorTab.SelectedIndex == 1)
            {
                bpWriteParameterToFile.Enabled = false;
                bpReadParameterFromFile.Enabled = false;
            }
            else
            {
                bpWriteParameterToFile.Enabled = true;
                bpReadParameterFromFile.Enabled = true;
            }
            
        }
        private bool isHexaInput(char key)
        {
            if(((key >= '0' && key <= '9') ||
                      (key >= 'A' && key <= 'F') ||
                      (key >= 'a' && key <= 'f') ||
                      (key == (char)Keys.Back)))
            {
                return false;
            }
            return true;
        }

        private void TB_appUUID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check for a hexadecimal character
            Debug.WriteLine("in key press");
            if (TB_appUUID.Text.Length < 16 || (e.KeyChar == (char)Keys.Back))
            {
                if (isHexaInput(e.KeyChar))
                {
                    e.Handled = true;
                }
            }else
            {
                e.Handled = true;
            }
        }

        private void Tb_DevUUID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check for a hexadecimal character
            if (Tb_DevUUID.Text.Length < 16 || (e.KeyChar == (char)Keys.Back))
            {
                if (isHexaInput(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }
        }
        private void TB_AppKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check for a hexadecimal character
            if (TB_AppKey.Text.Length < 32 || (e.KeyChar == (char)Keys.Back))
            {
                if (isHexaInput(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void cb_loraMode_CheckedChanged(object sender, EventArgs e)
        {
            if(this.cb_loraMode.Checked == true)
            {
                Tb_LoraPeriod.Enabled = false;
            }
            else
            {
                Tb_LoraPeriod.Enabled = true;
            }
        }
    }
}