
namespace ConversionesMedidas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConvert = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboList_c = new System.Windows.Forms.ComboBox();
            this.txtValores = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRetult = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnConvert.FlatAppearance.BorderSize = 0;
            this.btnConvert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConvert.Location = new System.Drawing.Point(9, 320);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(286, 58);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "Convertir";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.cboList_c);
            this.panel1.Controls.Add(this.btnConvert);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(666, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 502);
            this.panel1.TabIndex = 1;
            // 
            // cboList_c
            // 
            this.cboList_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboList_c.FormattingEnabled = true;
            this.cboList_c.Items.AddRange(new object[] {
            "Metros a pulgadas",
            "Pulgadas a metros",
            "Metros a Pies",
            "Pies a Metros"});
            this.cboList_c.Location = new System.Drawing.Point(9, 65);
            this.cboList_c.Name = "cboList_c";
            this.cboList_c.Size = new System.Drawing.Size(286, 37);
            this.cboList_c.TabIndex = 1;
            // 
            // txtValores
            // 
            this.txtValores.Location = new System.Drawing.Point(24, 214);
            this.txtValores.Name = "txtValores";
            this.txtValores.Size = new System.Drawing.Size(258, 31);
            this.txtValores.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(317, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "=";
            // 
            // lblRetult
            // 
            this.lblRetult.AutoSize = true;
            this.lblRetult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRetult.Location = new System.Drawing.Point(396, 214);
            this.lblRetult.Name = "lblRetult";
            this.lblRetult.Size = new System.Drawing.Size(0, 25);
            this.lblRetult.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(973, 502);
            this.Controls.Add(this.lblRetult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValores);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboList_c;
        private System.Windows.Forms.TextBox txtValores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRetult;
    }
}

