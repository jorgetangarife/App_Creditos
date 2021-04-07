
namespace Presentacion
{
    partial class FrmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.CbxUsuario = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ChMostar = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnSupri = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dB_CreditosDataSet = new Presentacion.DB_CreditosDataSet();
            this.tblCredencialesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCredencialesTableAdapter = new Presentacion.DB_CreditosDataSetTableAdapters.TblCredencialesTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_CreditosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCredencialesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CbxUsuario
            // 
            this.CbxUsuario.DataSource = this.tblCredencialesBindingSource;
            this.CbxUsuario.DisplayMember = "PKCorreo";
            this.CbxUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CbxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxUsuario.FormattingEnabled = true;
            this.CbxUsuario.Location = new System.Drawing.Point(1, 33);
            this.CbxUsuario.Name = "CbxUsuario";
            this.CbxUsuario.Size = new System.Drawing.Size(394, 32);
            this.CbxUsuario.TabIndex = 0;
            this.CbxUsuario.ValueMember = "PKCorreo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 31);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione Su Usuario";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Aqua;
            this.panel2.Controls.Add(this.ChMostar);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(2, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(392, 43);
            this.panel2.TabIndex = 2;
            // 
            // ChMostar
            // 
            this.ChMostar.AutoSize = true;
            this.ChMostar.Location = new System.Drawing.Point(313, 10);
            this.ChMostar.Name = "ChMostar";
            this.ChMostar.Size = new System.Drawing.Size(58, 17);
            this.ChMostar.TabIndex = 1;
            this.ChMostar.Text = "Mostar";
            this.ChMostar.UseVisualStyleBackColor = true;
            this.ChMostar.CheckedChanged += new System.EventHandler(this.ChMostar_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Seleccione Su Usuario";
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Cyan;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(1, 150);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(52, 41);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            this.btn1.MouseLeave += new System.EventHandler(this.btn1_MouseLeave);
            this.btn1.MouseHover += new System.EventHandler(this.btn1_MouseHover);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Cyan;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(74, 150);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(52, 41);
            this.btn2.TabIndex = 4;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            this.btn2.MouseLeave += new System.EventHandler(this.btn2_MouseLeave);
            this.btn2.MouseHover += new System.EventHandler(this.btn2_MouseHover);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Cyan;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(147, 150);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(52, 41);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.button3_Click);
            this.btn3.MouseLeave += new System.EventHandler(this.btn3_MouseLeave);
            this.btn3.MouseHover += new System.EventHandler(this.btn3_MouseHover);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Cyan;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(2, 197);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(52, 41);
            this.btn4.TabIndex = 6;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            this.btn4.MouseLeave += new System.EventHandler(this.btn4_MouseLeave);
            this.btn4.MouseHover += new System.EventHandler(this.btn4_MouseHover);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Cyan;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(74, 197);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(52, 41);
            this.btn5.TabIndex = 7;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            this.btn5.MouseLeave += new System.EventHandler(this.btn5_MouseLeave);
            this.btn5.MouseHover += new System.EventHandler(this.btn5_MouseHover);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Cyan;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(147, 197);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(52, 41);
            this.btn6.TabIndex = 8;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            this.btn6.MouseLeave += new System.EventHandler(this.btn6_MouseLeave);
            this.btn6.MouseHover += new System.EventHandler(this.btn6_MouseHover);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Cyan;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(2, 244);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(52, 41);
            this.btn7.TabIndex = 9;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            this.btn7.MouseLeave += new System.EventHandler(this.btn7_MouseLeave);
            this.btn7.MouseHover += new System.EventHandler(this.btn7_MouseHover);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Cyan;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(74, 244);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(52, 41);
            this.btn8.TabIndex = 10;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            this.btn8.MouseLeave += new System.EventHandler(this.btn8_MouseLeave);
            this.btn8.MouseHover += new System.EventHandler(this.btn8_MouseHover);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Cyan;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(147, 244);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(52, 41);
            this.btn9.TabIndex = 11;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            this.btn9.MouseLeave += new System.EventHandler(this.btn9_MouseLeave);
            this.btn9.MouseHover += new System.EventHandler(this.btn9_MouseHover);
            // 
            // btnSupri
            // 
            this.btnSupri.BackColor = System.Drawing.Color.Red;
            this.btnSupri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupri.ForeColor = System.Drawing.Color.White;
            this.btnSupri.Location = new System.Drawing.Point(2, 291);
            this.btnSupri.Name = "btnSupri";
            this.btnSupri.Size = new System.Drawing.Size(52, 41);
            this.btnSupri.TabIndex = 12;
            this.btnSupri.Text = "Supr";
            this.btnSupri.UseVisualStyleBackColor = false;
            this.btnSupri.Click += new System.EventHandler(this.btnSupri_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.Cyan;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(74, 291);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(52, 41);
            this.btn0.TabIndex = 13;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            this.btn0.MouseLeave += new System.EventHandler(this.btn0_MouseLeave);
            this.btn0.MouseHover += new System.EventHandler(this.btn0_MouseHover);
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.Black;
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.ForeColor = System.Drawing.Color.White;
            this.btnEnter.Location = new System.Drawing.Point(147, 291);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(52, 41);
            this.btnEnter.TabIndex = 14;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(1, 109);
            this.txtClave.MaxLength = 4;
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.ReadOnly = true;
            this.txtClave.Size = new System.Drawing.Size(393, 29);
            this.txtClave.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(225, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // dB_CreditosDataSet
            // 
            this.dB_CreditosDataSet.DataSetName = "DB_CreditosDataSet";
            this.dB_CreditosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCredencialesBindingSource
            // 
            this.tblCredencialesBindingSource.DataMember = "TblCredenciales";
            this.tblCredencialesBindingSource.DataSource = this.dB_CreditosDataSet;
            // 
            // tblCredencialesTableAdapter
            // 
            this.tblCredencialesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(399, 336);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnSupri);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CbxUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modulo - Credenciales";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_CreditosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCredencialesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbxUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnSupri;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox ChMostar;
        private DB_CreditosDataSet dB_CreditosDataSet;
        private System.Windows.Forms.BindingSource tblCredencialesBindingSource;
        private DB_CreditosDataSetTableAdapters.TblCredencialesTableAdapter tblCredencialesTableAdapter;
    }
}