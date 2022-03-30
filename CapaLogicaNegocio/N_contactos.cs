using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using System.Data.SqlClient;
using CapaDatos;
using System.Data;

namespace CapaLogicaNegocio
{
    public class N_contactos
    {
        D_Contacto d_Contacto = new D_Contacto();
        //Metodo que se utiliza para buscar Contacto
        public List<E_Contacto> listarContacton(string buscar)
        {
            return d_Contacto.ListarContactos(buscar);

        }
        //Metodo para insertar Contacto
        public void insertarContactoN(E_Contacto e_Contacto)
        {
            d_Contacto.insertarContacto(e_Contacto);
        }
        //Metodo para editar Contacto
        public void editarContactoN(E_Contacto e_Contacto)
        {
            d_Contacto.editarContacto(e_Contacto);

            //Metodo para eliminar Contacto
            public void eliminarContactoN(E_Contacto e_Contacto)
        {
                d_Contacto.eliminarContacto(e_Contacto);
        }
            //Metodo para mostrar todos los datos de la tabla
            public DataSet mostrarDatosN()
        {
            return d_Contacto.mostrarDatos();
        

    }
        }
    }
}


