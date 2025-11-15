namespace Innovatec
{
    partial class FrmPrincipal
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Jerarquia = new System.Windows.Forms.TabPage();
            this.gbJerarquia = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblAgregar = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Jerarquia.SuspendLayout();
            this.gbJerarquia.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.Jerarquia);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1240, 657);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::Innovatec.Properties.Resources.innovatec;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1232, 624);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Jerarquia
            // 
            this.Jerarquia.Controls.Add(this.gbJerarquia);
            this.Jerarquia.Location = new System.Drawing.Point(4, 29);
            this.Jerarquia.Name = "Jerarquia";
            this.Jerarquia.Padding = new System.Windows.Forms.Padding(3);
            this.Jerarquia.Size = new System.Drawing.Size(1232, 624);
            this.Jerarquia.TabIndex = 1;
            this.Jerarquia.Text = "Jerarquía Organizativa";
            this.Jerarquia.UseVisualStyleBackColor = true;
            // 
            // gbJerarquia
            // 
            this.gbJerarquia.Controls.Add(this.textBox1);
            this.gbJerarquia.Controls.Add(this.lblAgregar);
            this.gbJerarquia.Location = new System.Drawing.Point(6, 6);
            this.gbJerarquia.Name = "gbJerarquia";
            this.gbJerarquia.Size = new System.Drawing.Size(669, 517);
            this.gbJerarquia.TabIndex = 0;
            this.gbJerarquia.TabStop = false;
            this.gbJerarquia.Text = "Jerarquía";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 26);
            this.textBox1.TabIndex = 1;
            // 
            // lblAgregar
            // 
            this.lblAgregar.AutoSize = true;
            this.lblAgregar.Location = new System.Drawing.Point(30, 41);
            this.lblAgregar.Name = "lblAgregar";
            this.lblAgregar.Size = new System.Drawing.Size(117, 20);
            this.lblAgregar.TabIndex = 0;
            this.lblAgregar.Text = "Agregar Rama:";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1232, 624);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sistema de Rutas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmPrincipal";
            this.Text = "Innovatec";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.Jerarquia.ResumeLayout(false);
            this.gbJerarquia.ResumeLayout(false);
            this.gbJerarquia.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage Jerarquia;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox gbJerarquia;
        private System.Windows.Forms.Label lblAgregar;
        private System.Windows.Forms.TextBox textBox1;
    }
}

