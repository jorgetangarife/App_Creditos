using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Cls_Clientes_Datos1
    {
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
            ClsConexion objconect = new ClsConexion();
            SqlCommand con = new SqlCommand("SP_AgregarCliente", objconect.connection);
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
            objconect.connection.Open();
            con.ExecuteNonQuery();
            objconect.connection.Close();
        }
    }
}
