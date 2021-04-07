using System;
using Negocio;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmClientes : Form
    {
        String var;
        int contador = 0;
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (contador == 10)
            {
                return;
            }
            else
            {
                var = var + "0"; TxtId.Text = var; contador++;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (contador == 10)
            {
                return;
            }
            else
            {
                var = var + "1"; TxtId.Text = var; contador++;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (contador == 10)
            {
                return;
            }
            else
            {
                var = var + "2"; TxtId.Text = var; contador++;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (contador == 10)
            {
                return;
            }
            else
            {
                var = var + "3"; TxtId.Text = var; contador++;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (contador == 10)
            {
                return;
            }
            else
            {
                var = var + "4"; TxtId.Text = var; contador++;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (contador == 10)
            {
                return;
            }
            else
            {
                var = var + "5"; TxtId.Text = var; contador++;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (contador == 10)
            {
                return;
            }
            else
            {
                var = var + "6"; TxtId.Text = var; contador++;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (contador == 10)
            {
                return;
            }
            else
            {
                var = var + "7"; TxtId.Text = var; contador++;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (contador == 10)
            {
                return;
            }
            else
            {
                var = var + "8"; TxtId.Text = var; contador++;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (contador == 10)
            {
                return;
            }
            else
            {
                var = var + "9"; TxtId.Text = var; contador++;
            }
        }

        private void btnSupri_Click(object sender, EventArgs e)
        {
            TxtId.Clear();
            contador = 0;
            var = "";
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dB_CreditosDataSet2.TblSexo' Puede moverla o quitarla según sea necesario.
            this.tblSexoTableAdapter.Fill(this.dB_CreditosDataSet2.TblSexo);
            // TODO: esta línea de código carga datos en la tabla 'dB_CreditosDataSet1.TblEstadoCivil' Puede moverla o quitarla según sea necesario.
            this.tblEstadoCivilTableAdapter.Fill(this.dB_CreditosDataSet1.TblEstadoCivil);

        }

        private void TxtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void TxtConEmpre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void TxtContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

        }

        private void TxtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtIngresos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
           if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }
        protected void Fnt_AgregarClientes()
        {
            ClsClientes_Negocios ObjCliente = new ClsClientes_Negocios();
            ObjCliente.Fnt_AgregarCliente(TxtId.Text, TxtNombre.Text, TxtContacto.Text, TxtCorreo.Text, TxtEdad.Text,
                TxtIngresos.Text, TxtEmpresa.Text, TxtConEmpre.Text,
                Convert.ToString(CbxSexo.SelectedValue),
                Convert.ToString(CbxEstado.SelectedValue));
            lblMensaje.Text = ObjCliente.msn;
        }
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fnt_AgregarClientes();
        }
    }
}
