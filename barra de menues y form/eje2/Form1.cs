using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eje2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbcolor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbcolor.Items.Add("rojo");
            cmbcolor.Items.Add("verde");
            cmbcolor.Items.Add("amarillo");
            cmbcolor.Items.Add("violeta");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnperfil_Click(object sender, EventArgs e)
        {
            string nombre = txttextnombre.Text;
            DateTime fecha = dtpnacimiento.Value;
            string independiente = chboxhincha.Checked == true ? " hincha del rey  " : " amargo ";
            string profesion;
            if (rbestudiante.Checked == true)
                profesion = " estudiante ";
            else if (rboperario.Checked == true)
                profesion = " operario ";
            else
                profesion = "profesional";

            string colorfavorito = cmbcolor.SelectedItem.ToString();
            string numerofavorito = numeric.Value.ToString();


            MessageBox.Show(" nombre: " + nombre + " ,fecha: " + fecha + " , " + independiente + ", es " + profesion +
                             ", color favorito: " + colorfavorito + " , numero favorito: " + numerofavorito);



        
        
        }

    }
}
