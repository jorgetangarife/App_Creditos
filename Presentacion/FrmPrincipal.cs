using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        protected void Fnt_ModuloClientes()
        {
            FrmClientes ObjCliente = new FrmClientes();
            ObjCliente.lblUsuario.Text = lblUsuario.Text;
            ObjCliente.ShowDialog();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Fnt_ModuloClientes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLogin ObjLogin = new FrmLogin();
            ObjLogin.Show();
            this.Close();
        }
    }
}
