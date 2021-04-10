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
        protected void Fnt_LimpiarControles()
        {
            TxtNombre.Clear();
            TxtContacto.Clear();
            TxtCorreo.Clear();
            TxtEdad.Clear();
            TxtEmpresa.Clear();
            TxtIngresos.Clear();
            TxtConEmpre.Clear();
            CbxEstado.SelectedIndex = 0;
            CbxSexo.SelectedIndex = 0;
            TxtId.Clear();
            contador = 0;
            var = "";
            Fnt_HabilitarTeclaso();
            TxtId.Focus();          
        }
        protected void Fnt_HabilitarTeclaso()
        {
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            BtnEnter.Enabled = true;
            TxtNombre.Enabled = true;
            CbxSexo.Enabled = true;
        }

        private void btnSupri_Click(object sender, EventArgs e)
        {        
            Fnt_LimpiarControles();
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

        protected void Fnt_ConsultarCliente()
        {
            ClsClientes_Negocios ObjConsultar = new ClsClientes_Negocios();
            ObjConsultar.Fnt_ConsultarClinte(TxtId.Text);
            TxtNombre.Text = ObjConsultar.aux[0];
            TxtContacto.Text = ObjConsultar.aux[1];
            TxtCorreo.Text = ObjConsultar.aux[2];
            TxtEdad.Text = ObjConsultar.aux[3];
            TxtIngresos.Text = ObjConsultar.aux[4];
            TxtEmpresa.Text = ObjConsultar.aux[5];
            TxtConEmpre.Text = ObjConsultar.aux[6];
            CbxSexo.SelectedIndex = Convert.ToInt32(ObjConsultar.aux[7]);
            CbxEstado.SelectedIndex = Convert.ToInt32(ObjConsultar.aux[8]);       
            lblMensaje.Text = ObjConsultar.msn;
            if (lblMensaje.Text == "")
            {
                Fnt_BloqueoTeclado();
            }
        }
        protected void Fnt_BloqueoTeclado()
        {
            btn0.Enabled = false;
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
            BtnEnter.Enabled = false;
            TxtNombre.Enabled = false;
            CbxSexo.Enabled = false;
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            Fnt_ConsultarCliente();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fnt_LimpiarControles();
        }
        private void Fnt_ActualizarCliente()
        {
            ClsClientes_Negocios ObjActualizar = new ClsClientes_Negocios();
            ObjActualizar.Fnt_Actualizar
            (
            TxtId.Text, TxtContacto.Text, TxtCorreo.Text, TxtEdad.Text,
            TxtIngresos.Text,
            TxtEmpresa.Text, TxtConEmpre.Text,
            Convert.ToString(CbxEstado.SelectedValue)
            );
            lblMensaje.Text = ObjActualizar.msn;
        }
        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fnt_ActualizarCliente();
        }
    }
}
