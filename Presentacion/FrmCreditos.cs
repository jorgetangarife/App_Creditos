using System;
using System.Windows.Forms;
using Negocio;

namespace Presentacion
{
    public partial class FrmCreditos : Form
    {
        public FrmCreditos()
        {
            InitializeComponent();
            cbxInteres.Enabled = false;
        }

        private void FrmCreditos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dB_CreditosDataSet4.TblInteres' Puede moverla o quitarla según sea necesario.
            this.tblInteresTableAdapter.Fill(this.dB_CreditosDataSet4.TblInteres);
            // TODO: esta línea de código carga datos en la tabla 'dB_CreditosDataSet3.TblPlazo' Puede moverla o quitarla según sea necesario.
            this.tblPlazoTableAdapter.Fill(this.dB_CreditosDataSet3.TblPlazo);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        protected void Fnt_CalcularCuota() 
        { 
            ClsClientes_Negocios ObjCalcularCuota = new ClsClientes_Negocios(); 
            ObjCalcularCuota.Fnt_CalcularCuota(txtMonto.Text, Convert.ToInt32(cbxPlazo.Text)); 
            txtCuota.Text = Convert.ToString(ObjCalcularCuota.cuota2); 
            txtTotal.Text = Convert.ToString(ObjCalcularCuota.total); 
            cbxInteres.SelectedIndex = Convert.ToInt32(ObjCalcularCuota.pos); 
        }
        private void txtMonto_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Fnt_CalcularCuota();
            }
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void cbxPlazo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fnt_CalcularCuota();
        }
    }
}
