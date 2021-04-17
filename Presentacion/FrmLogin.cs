using System;
using System.Windows.Forms;
using Negocio;

namespace Presentacion
{
    public partial class FrmLogin : Form
    {
        String var;
        int contador = 0;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (contador == 4)
            {
                return;
            }
            else
            {
                var = var + "3"; txtClave.Text = var; contador++;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (contador == 4) 
            { 
                return;
            }
            else 
            {
                var = var + "1"; txtClave.Text = var; contador++; 
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (contador == 4)
            {
                return;
            }
            else
            {
                var = var + "2"; txtClave.Text = var; contador++;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (contador == 4)
            {
                return;
            }
            else
            {
                var = var + "4"; txtClave.Text = var; contador++;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (contador == 4)
            {
                return;
            }
            else
            {
                var = var + "5"; txtClave.Text = var; contador++;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (contador == 4)
            {
                return;
            }
            else
            {
                var = var + "6"; txtClave.Text = var; contador++;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (contador == 4)
            {
                return;
            }
            else
            {
                var = var + "7"; txtClave.Text = var; contador++;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (contador == 4)
            {
                return;
            }
            else
            {
                var = var + "8"; txtClave.Text = var; contador++;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (contador == 4)
            {
                return;
            }
            else
            {
                var = var + "9"; txtClave.Text = var; contador++;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (contador == 4)
            {
                return;
            }
            else
            {
                var = var + "0"; txtClave.Text = var; contador++;
            }
        }

        private void ChMostar_CheckedChanged(object sender, EventArgs e)
        {
            if (ChMostar.Checked == true)
            {
                txtClave.PasswordChar = '\0';
            }
            else
            {
                txtClave.PasswordChar = '*';
            }
        }

        private void btnSupri_Click(object sender, EventArgs e)
        {
            txtClave.Clear();
            contador = 0;
            var = "";
        }

        private void btn1_MouseHover(object sender, EventArgs e)
        {
            btn1.Text = "*";
            btn2.Text = "*";
            btn3.Text = "*";
            btn4.Text = "*";
            btn5.Text = "*";
            btn6.Text = "*";
            btn7.Text = "*";
            btn8.Text = "*";
            btn9.Text = "*";
            btn0.Text = "*";
        }

        private void btn1_MouseLeave(object sender, EventArgs e)
        {
            btn1.Text = "1";
            btn2.Text = "2";
            btn3.Text = "3";
            btn4.Text = "4";
            btn5.Text = "5";
            btn6.Text = "6";
            btn7.Text = "7";
            btn8.Text = "8";
            btn9.Text = "9";
            btn0.Text = "0";
        }

        private void btn2_MouseHover(object sender, EventArgs e)
        {
            btn1.Text = "*";
            btn2.Text = "*";
            btn3.Text = "*";
            btn4.Text = "*";
            btn5.Text = "*";
            btn6.Text = "*";
            btn7.Text = "*";
            btn8.Text = "*";
            btn9.Text = "*";
            btn0.Text = "*";
        }

        private void btn2_MouseLeave(object sender, EventArgs e)
        {
            btn1.Text = "1";
            btn2.Text = "2";
            btn3.Text = "3";
            btn4.Text = "4";
            btn5.Text = "5";
            btn6.Text = "6";
            btn7.Text = "7";
            btn8.Text = "8";
            btn9.Text = "9";
            btn0.Text = "0";
        }

        private void btn3_MouseHover(object sender, EventArgs e)
        {
            btn1.Text = "*";
            btn2.Text = "*";
            btn3.Text = "*";
            btn4.Text = "*";
            btn5.Text = "*";
            btn6.Text = "*";
            btn7.Text = "*";
            btn8.Text = "*";
            btn9.Text = "*";
            btn0.Text = "*";
        }

        private void btn3_MouseLeave(object sender, EventArgs e)
        {
            btn1.Text = "1";
            btn2.Text = "2";
            btn3.Text = "3";
            btn4.Text = "4";
            btn5.Text = "5";
            btn6.Text = "6";
            btn7.Text = "7";
            btn8.Text = "8";
            btn9.Text = "9";
            btn0.Text = "0";
        }

        private void btn4_MouseHover(object sender, EventArgs e)
        {
            btn1.Text = "*";
            btn2.Text = "*";
            btn3.Text = "*";
            btn4.Text = "*";
            btn5.Text = "*";
            btn6.Text = "*";
            btn7.Text = "*";
            btn8.Text = "*";
            btn9.Text = "*";
            btn0.Text = "*";
        }

        private void btn4_MouseLeave(object sender, EventArgs e)
        {
            btn1.Text = "1";
            btn2.Text = "2";
            btn3.Text = "3";
            btn4.Text = "4";
            btn5.Text = "5";
            btn6.Text = "6";
            btn7.Text = "7";
            btn8.Text = "8";
            btn9.Text = "9";
            btn0.Text = "0";
        }

        private void btn5_MouseHover(object sender, EventArgs e)
        {
            btn1.Text = "*";
            btn2.Text = "*";
            btn3.Text = "*";
            btn4.Text = "*";
            btn5.Text = "*";
            btn6.Text = "*";
            btn7.Text = "*";
            btn8.Text = "*";
            btn9.Text = "*";
            btn0.Text = "*";
        }

        private void btn5_MouseLeave(object sender, EventArgs e)
        {
            btn1.Text = "1";
            btn2.Text = "2";
            btn3.Text = "3";
            btn4.Text = "4";
            btn5.Text = "5";
            btn6.Text = "6";
            btn7.Text = "7";
            btn8.Text = "8";
            btn9.Text = "9";
            btn0.Text = "0";
        }

        private void btn6_MouseHover(object sender, EventArgs e)
        {
            btn1.Text = "*";
            btn2.Text = "*";
            btn3.Text = "*";
            btn4.Text = "*";
            btn5.Text = "*";
            btn6.Text = "*";
            btn7.Text = "*";
            btn8.Text = "*";
            btn9.Text = "*";
            btn0.Text = "*";
        }

        private void btn6_MouseLeave(object sender, EventArgs e)
        {
            btn1.Text = "1";
            btn2.Text = "2";
            btn3.Text = "3";
            btn4.Text = "4";
            btn5.Text = "5";
            btn6.Text = "6";
            btn7.Text = "7";
            btn8.Text = "8";
            btn9.Text = "9";
            btn0.Text = "0";
        }

        private void btn7_MouseHover(object sender, EventArgs e)
        {
            btn1.Text = "*";
            btn2.Text = "*";
            btn3.Text = "*";
            btn4.Text = "*";
            btn5.Text = "*";
            btn6.Text = "*";
            btn7.Text = "*";
            btn8.Text = "*";
            btn9.Text = "*";
            btn0.Text = "*";
        }

        private void btn7_MouseLeave(object sender, EventArgs e)
        {
            btn1.Text = "1";
            btn2.Text = "2";
            btn3.Text = "3";
            btn4.Text = "4";
            btn5.Text = "5";
            btn6.Text = "6";
            btn7.Text = "7";
            btn8.Text = "8";
            btn9.Text = "9";
            btn0.Text = "0";
        }

        private void btn8_MouseHover(object sender, EventArgs e)
        {
            btn1.Text = "*";
            btn2.Text = "*";
            btn3.Text = "*";
            btn4.Text = "*";
            btn5.Text = "*";
            btn6.Text = "*";
            btn7.Text = "*";
            btn8.Text = "*";
            btn9.Text = "*";
            btn0.Text = "*";
        }

        private void btn8_MouseLeave(object sender, EventArgs e)
        {
            btn1.Text = "1";
            btn2.Text = "2";
            btn3.Text = "3";
            btn4.Text = "4";
            btn5.Text = "5";
            btn6.Text = "6";
            btn7.Text = "7";
            btn8.Text = "8";
            btn9.Text = "9";
            btn0.Text = "0";
        }

        private void btn9_MouseHover(object sender, EventArgs e)
        {
            btn1.Text = "*";
            btn2.Text = "*";
            btn3.Text = "*";
            btn4.Text = "*";
            btn5.Text = "*";
            btn6.Text = "*";
            btn7.Text = "*";
            btn8.Text = "*";
            btn9.Text = "*";
            btn0.Text = "*";
        }

        private void btn9_MouseLeave(object sender, EventArgs e)
        {
            btn1.Text = "1";
            btn2.Text = "2";
            btn3.Text = "3";
            btn4.Text = "4";
            btn5.Text = "5";
            btn6.Text = "6";
            btn7.Text = "7";
            btn8.Text = "8";
            btn9.Text = "9";
            btn0.Text = "0";
        }

        private void btn0_MouseHover(object sender, EventArgs e)
        {
            btn1.Text = "*";
            btn2.Text = "*";
            btn3.Text = "*";
            btn4.Text = "*";
            btn5.Text = "*";
            btn6.Text = "*";
            btn7.Text = "*";
            btn8.Text = "*";
            btn9.Text = "*";
            btn0.Text = "*";
        }

        private void btn0_MouseLeave(object sender, EventArgs e)
        {
            btn1.Text = "1";
            btn2.Text = "2";
            btn3.Text = "3";
            btn4.Text = "4";
            btn5.Text = "5";
            btn6.Text = "6";
            btn7.Text = "7";
            btn8.Text = "8";
            btn9.Text = "9";
            btn0.Text = "0";
        }
        protected void Fnt_EnviarParametros()
        {
            ClsLogin_Negocio ObjEnviar = new ClsLogin_Negocio();
            ObjEnviar.Fnt_Ingresar(CbxUsuario.Text, txtClave.Text);
            if (ObjEnviar.sw == 1)
            {
                FrmPrincipal ObjPrincipal = new FrmPrincipal();
                ObjPrincipal.lblUsuario.Text = ObjEnviar.nombre;
                ObjPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usted no tiene permiso de acceso, consulte con el admin mi so");
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Fnt_EnviarParametros();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dB_CreditosDataSet.TblCredenciales' Puede moverla o quitarla según sea necesario.
            this.tblCredencialesTableAdapter.Fill(this.dB_CreditosDataSet.TblCredenciales);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
