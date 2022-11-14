using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMarconiejerciciopararesolver3
{
    public partial class main : Form
    {
        public struct structRepuestos
        {
            public string strMarca;
            public string strOrigen;
            public int intNumeroRepuesto;
            public string strDescripcion;
            public float floPrecio;
        }
        structRepuestos[] vecRepuestos = new structRepuestos[100];
        public int intIndiceRegistro = 0;
        public int intIndiceConsulta = 0;

        public void limpiarControles()
        {
            cmbMarca.SelectedIndex = -1;
            optNacional.Checked = true;
            txtRepuesto.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
        }
        public main()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
         
        }

        private void optImportado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMarca.SelectedIndex != -1)
            {
                lblRepuesto.Enabled = true;
                txtRepuesto.Enabled = true;
            }
            else
            {
                lblRepuesto.Enabled = false;
                txtRepuesto.Enabled = false;
            }
        }

        private void txtRepuesto_TextChanged(object sender, EventArgs e)
        {
            if (txtRepuesto.Text != "")
            {
                lblDescripcion.Enabled = true;
                txtDescripcion.Enabled = true;
            }
            else
            {
                lblDescripcion.Enabled = false;
                txtDescripcion.Enabled = false;
            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            if (txtDescripcion.Text != "")
            {
                lblPrecio.Enabled = true;
                txtPrecio.Enabled = true;
            }
            else
            {
                lblPrecio.Enabled = false;
                txtPrecio.Enabled = false;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            bool existeNroRepuesto = false;
            intIndiceConsulta = 0;
            while (intIndiceConsulta < vecRepuestos.Length)
            {
                if (vecRepuestos[intIndiceConsulta].intNumeroRepuesto == int.Parse(txtRepuesto.Text))
                {
                    existeNroRepuesto = true;
                    MessageBox.Show("El Nº de Repuesto " + txtRepuesto.Text + " ya está registrado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                intIndiceConsulta++;
            }
            if (existeNroRepuesto == false)
            {
                vecRepuestos[intIndiceRegistro].strMarca = cmbMarca.Text;
                if (optNacional.Checked == true)
                {
                    vecRepuestos[intIndiceRegistro].strOrigen = "Nacional";
                }
                else
                {
                    vecRepuestos[intIndiceRegistro].strOrigen = "Importado";
                }
                vecRepuestos[intIndiceRegistro].intNumeroRepuesto = int.Parse(txtRepuesto.Text);
                vecRepuestos[intIndiceRegistro].strDescripcion = txtDescripcion.Text;
                vecRepuestos[intIndiceRegistro].floPrecio = float.Parse(txtPrecio.Text);
                intIndiceRegistro++;
                MessageBox.Show("Repuesto Ingresado Correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mrcConsulta.Enabled = true;
                limpiarControles();
            }

        }

        private void cmbMarca2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMarca2.SelectedIndex != -1)
            {
                btnConsultar.Enabled = true;
            }
            else
            {
                btnConsultar.Enabled = false;
            }
        }

        private void mrcOrigenconsulta_Enter(object sender, EventArgs e)
        {

        }

        private void txtRepuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Ingrese únicamente números!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Ingrese únicamente números!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtDescripcion.Text.Length == 50)
            {
                MessageBox.Show("Límite de caracteres alcanzado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstDatosdeRepuesto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

