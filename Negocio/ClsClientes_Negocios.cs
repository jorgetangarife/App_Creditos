using System;
using Datos;

namespace Negocio
{
    public class ClsClientes_Negocios
    {
        public String msn;
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
                msn = "El Cliente: " + nombre + " ha sido registrado con exito";
            }
        }
    }
}
