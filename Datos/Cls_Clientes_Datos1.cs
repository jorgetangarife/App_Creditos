using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Cls_Clientes_Datos1
    {
        public ClsConexion objconect_select;
        public SqlDataReader Lectura;
        public int sw = 0;
        public String interes, monto2, pos_interes;
        public Decimal total, cuota2;
        public void Fnt_AgregarCliente(
            String id, 
            String nombre, 
            String contacto,
            String correo,
            String edad, 
            String ingresos, 
            String Empresa,
            String contactoE,
            String sexo,
            String estado)
        {
            Fnt_Agregar(id, nombre, contacto, correo, edad, ingresos, Empresa, contactoE, sexo, estado);
        }

      
        protected void Fnt_Agregar(
            String id,
            String nombre,
            String contacto,
            String correo,
            String edad,
            String ingresos,
            String Empresa,
            String contactoE,
            String sexo,
            String estado)
        {
            Fnt_ConsultarDatos(id);
            objconect_select.connection.Close();
            if(sw == 0)
            {
                ClsConexion objconect_insert = new ClsConexion();
                SqlCommand con = new SqlCommand("SP_AgregarCliente", objconect_insert.connection);
                con.CommandType = CommandType.StoredProcedure;
                con.Parameters.AddWithValue("@id", id);
                con.Parameters.AddWithValue("@nombres", nombre);
                con.Parameters.AddWithValue("@contacto", contacto);
                con.Parameters.AddWithValue("@correo", correo);
                con.Parameters.AddWithValue("@edad", edad);
                con.Parameters.AddWithValue("@ingresos", ingresos);
                con.Parameters.AddWithValue("@empresa", Empresa);
                con.Parameters.AddWithValue("@contactoE", contactoE);
                con.Parameters.AddWithValue("@sexo", sexo);
                con.Parameters.AddWithValue("@estado", estado);
                objconect_insert.connection.Open();
                con.ExecuteNonQuery();
                objconect_insert.connection.Close();
            }
            
        }
        public void Fnt_ConsultarDatos(String id)
        {
            objconect_select = new ClsConexion();
            SqlCommand con;
            con = new SqlCommand("SP_BuscarCliente", objconect_select.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@id", id);
            objconect_select.connection.Open();//abre la conexion con el servidor de Base de datos
            Lectura = con.ExecuteReader();
            if (Lectura.Read() == true)
            {
                //nombre = convert.ToString(Lectura[0]);
                sw = 1;
            }
            //objconect.connection.Close();
        }
        public void Fnt_Actualizar(String id,
            String contacto,
            String correo,
            String edad,
            String ingresos,
            String Empresa,
            String contactoE,
            String estado)
        {
            ClsConexion objconect_insert = new ClsConexion();
            SqlCommand con = new SqlCommand("SP_ActualizarCliente", objconect_insert.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@id", id);
            con.Parameters.AddWithValue("@Contacto", contacto);
            con.Parameters.AddWithValue("@Correo", correo);
            con.Parameters.AddWithValue("@Edad", edad);
            con.Parameters.AddWithValue("@Ingresos", ingresos);
            con.Parameters.AddWithValue("@Empresa_Labora", Empresa);
            con.Parameters.AddWithValue("@Contacto_Empesa", contactoE);
            con.Parameters.AddWithValue("@FKId_TblEstadoCivil", estado);
            objconect_insert.connection.Open();
            con.ExecuteNonQuery();
            objconect_insert.connection.Close();
        }
        public void Fnt_ConsultarCuota(String monto, int cuota)
        {
            objconect_select = new ClsConexion();
            SqlCommand con;
            con = new SqlCommand("SP_Calcularcuota", objconect_select.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@monto", monto);
            con.Parameters.AddWithValue("@plazo", cuota);
            con.Parameters.Add("@interes", 0);
            con.Parameters["@interes"].Direction = ParameterDirection.Output;

            con.Parameters.Add("@monto_int", 0);
            con.Parameters["@monto_int"].Direction = ParameterDirection.Output;

            con.Parameters.Add("@Total", SqlDbType.Decimal);
            con.Parameters["@Total"].Direction = ParameterDirection.Output;

            con.Parameters.Add("@cuota", 0);
            con.Parameters["@cuota"].Direction = ParameterDirection.Output;

            con.Parameters.Add("@pos_interes", 0);
            con.Parameters["@pos_interes"].Direction = ParameterDirection.Output;

            objconect_select.connection.Open();//abre la conexion con el servidor de Base de datos
            con.ExecuteNonQuery();
            monto2 = Convert.ToString(con.Parameters["@monto_int"].Value);
            interes = Convert.ToString(con.Parameters["@interes"].Value);
            cuota2 = Convert.ToDecimal(con.Parameters["@cuota"].Value);
            total = Convert.ToDecimal(con.Parameters["@Total"].Value);
            pos_interes = Convert.ToString(con.Parameters["@pos_interes"].Value);
            objconect_select.connection.Close();

        }
    }
}
