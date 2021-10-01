using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversionesMedidas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*----------Variables-----------*/
        float result = 0; 
        float convert;

        private void button1_Click(object sender, EventArgs e)
        {
            convert = float.Parse(txtValores.Text);
            

            if(cboList_c.Text != "" && txtValores.Text != "")//verificasión de datos
            {
            if(cboList_c.SelectedIndex == 0)
            {
                
                result = convert * 39.3701f; 
                lblRetult.Text = (" " + result + " ");
            }if (cboList_c.SelectedIndex == 1) 
                {
                    result = convert / 39.37f;
                    lblRetult.Text = (" " + result + " ");
                }if(cboList_c.SelectedIndex == 2)
                {
                    result = convert * 3.2808399f;
                    lblRetult.Text = (" " + result + " ");
                }if(cboList_c.SelectedIndex == 3)
                {
                    result = convert / 3.2808399f;
                    lblRetult.Text = (" " + result + " "); 
                }
            }
            else
            {

                if (cboList_c.Text != "") MessageBox.Show("Error: EL campo numerico esta vacio");
                if (txtValores.Text != "") MessageBox.Show("Error: EL campo converisión esta vacio");
            }
        }

        /*Entrada al iniciar el programa*/
        private void Form1_Load(object sender, EventArgs e)
        {
            cboList_c.SelectedIndex = 0;
        }
    }
}
