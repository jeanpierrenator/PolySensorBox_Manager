using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polysensor_boxManager
{
    public partial class PhysicalSelectForm : Form
    {
        public PhysicalSelectForm()
        {
            InitializeComponent();
        }
        public PhysicalSelectForm(int remove)
        {
            
            InitializeComponent();
            if(remove == 1)
            {
                this.bt_ajouterPhysical.Text = "remove";
            }
        }
        public ComboBox GetComboBox()
        {
            return cb_capteur;
        }

        private void bt_ajouterPhysical_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
