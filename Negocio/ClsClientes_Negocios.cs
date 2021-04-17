using System;
using Datos;

namespace Negocio
{
    public class ClsClientes_Negocios
    {
        public String[] aux = new string[9];
        public int pos; public Decimal total, cuota2;
        public String msn, ruta;
        public String
            id_,
            nombre_,
            contacto,
            correo_,
            edad_,
            ingresos_,
            Empresa_, contactoE_, sexo_, estado_;
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
            if((((((((id == "") ||(nombre == "") ||(contacto == "") ||(correo == "") ||(edad == "") ||(ingresos == "") 
               ||(Empresa == "") ||(contactoE == ""))))))))
            {
                msn = "Debe diligencoir toda la informacion mi so,no sea bago";
            }
            else
            {
                Cls_Clientes_Datos1 ObjClientes = new Cls_Clientes_Datos1();
                ObjClientes.Fnt_AgregarCliente(
                id,
                nombre,
                contacto,
                correo,
                edad,
                ingresos,
                Empresa,
                contactoE,
                sexo,
                estado);
                if (ObjClientes.sw == 0)
                {
                    msn = "El Cliente: " + nombre + " ha sido registrado con exito";
                }
                else
                {
                    msn = "la Identicicacion: " + id + " Ya se encientra Registrada";
                }
                
            }
        }
        public void Fnt_ConsultarClinte(String id)
        {
            if(id != "")
            {
                Cls_Clientes_Datos1 ObjConsultar = new Cls_Clientes_Datos1();
                ObjConsultar.Fnt_ConsultarDatos(id);

                if (ObjConsultar.sw == 1)
                {
                    for (int i = 0; i <= 8; i++)
                    {
                        aux[i] = Convert.ToString(ObjConsultar.Lectura[i]);
                    }
                    ObjConsultar.objconect_select.connection.Close();
                    msn = "";
                }
                else
                {
                    msn = "No se encontraron registros para el dato: " + id;
                }
                
                
            }
        }
        public void Fnt_Actualizar(
           String id,
           String contacto,
           String correo,
           String edad,
           String ingresos,
           String Empresa,
           String contactoE,
           String estado)
        {
            if (((((((id == "") || (contacto == "") || (correo == "") || (edad == "") || (ingresos == "")
               || (Empresa == "") || (contactoE == "")))))))
            {
                msn = "Debe diligencoir toda la informacion mi so,no sea bago";
            }
            else
            {
                Cls_Clientes_Datos1 ObjClientes = new Cls_Clientes_Datos1();
                ObjClientes.Fnt_Actualizar(id,
                contacto,
                correo,
                edad,
                ingresos,
                Empresa,
                contactoE,
                estado);
                msn = "Datos Actualizados con éxito mi so";
            }
        }
        public void Fnt_CalcularCuota(String monto, int cuota)
        {
            Cls_Clientes_Datos1 ObjCalcular = new Cls_Clientes_Datos1();
            ObjCalcular.Fnt_ConsultarCuota(monto, cuota);
            cuota2 = Convert.ToDecimal(ObjCalcular.cuota2);
            total = Convert.ToDecimal(ObjCalcular.total);
            pos = Convert.ToInt32(ObjCalcular.pos_interes);
        }
    }
}
