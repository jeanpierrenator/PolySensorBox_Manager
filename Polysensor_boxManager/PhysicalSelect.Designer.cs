namespace Polysensor_boxManager
{
    partial class PhysicalSelectForm
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
            this.bt_ajouterPhysical = new System.Windows.Forms.Button();
            this.cb_capteur = new System.Windows.Forms.ComboBox();
            this.lb_capteur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_ajouterPhysical
            // 
            this.bt_ajouterPhysical.Location = new System.Drawing.Point(180, 116);
            this.bt_ajouterPhysical.Name = "bt_ajouterPhysical";
            this.bt_ajouterPhysical.Size = new System.Drawing.Size(94, 29);
            this.bt_ajouterPhysical.TabIndex = 0;
            this.bt_ajouterPhysical.Text = "add";
            this.bt_ajouterPhysical.UseVisualStyleBackColor = true;
            this.bt_ajouterPhysical.Click += new System.EventHandler(this.bt_ajouterPhysical_Click);
            // 
            // cb_capteur
            // 
            this.cb_capteur.FormattingEnabled = true;
            this.cb_capteur.Location = new System.Drawing.Point(123, 58);
            this.cb_capteur.Name = "cb_capteur";
            this.cb_capteur.Size = new System.Drawing.Size(151, 28);
            this.cb_capteur.TabIndex = 1;
            // 
            // lb_capteur
            // 
            this.lb_capteur.AutoSize = true;
            this.lb_capteur.Location = new System.Drawing.Point(12, 61);
            this.lb_capteur.Name = "lb_capteur";
            this.lb_capteur.Size = new System.Drawing.Size(107, 20);
            this.lb_capteur.TabIndex = 2;
            this.lb_capteur.Text = "Physical value: ";
            // 
            // PhysicalSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 157);
            this.Controls.Add(this.lb_capteur);
            this.Controls.Add(this.cb_capteur);
            this.Controls.Add(this.bt_ajouterPhysical);
            this.Name = "PhysicalSelectForm";
            this.Text = "PhysicalSelectForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bt_ajouterPhysical;
        private ComboBox cb_capteur;
        private Label lb_capteur;
    }
}