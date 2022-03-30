using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaEntidades;
using System.Data;

namespace CapaDatos
{
    public class D_Contacto
    {
        //Objeto de la clase SqlConnection con el string conexion para abrir o cerrar la conexion
        SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=AGENDAA;Integrated Security=True");
        private object contacto;

        public static object Idcontacto { get; private set; }

        //Metodo que me trae una lista de la busqueda
        public List<E_Contacto> ListarContactos(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_BUSCARCONTACTO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@BUSCAR", buscar);
            LeerFilas = cmd.ExecuteReader();

            List<E_Contacto> Listar = new List<E_Contacto>();
            E_Contacto Contacto = null;
            while (LeerFilas.Read())
            {
                Listar.Add(Contacto = new E_Contacto(LeerFilas.GetInt32(0),
                    LeerFilas.GetString(1), LeerFilas.GetString(2),
                    LeerFilas.GetString(3)));

            }
            conexion.Close();
            return Listar;
        }

        
        //Metodo para insertar un contacto
        public void insertarContacto(E_Contacto contacto)
        {

            SqlCommand cmd = new SqlCommand("SP_INSERTARCONTACTO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@NOMBRE", contacto.Nombre);
            cmd.Parameters.AddWithValue("@APELLIDO", contacto.Descripcion);
            cmd.Parameters.AddWithValue("@DIRECCION", contacto.Descripcion);
            cmd.Parameters.AddWithValue("@TELEFONO", contacto.Descripcion);
            cmd.Parameters.AddWithValue("@FECHA_NAC", contacto.Descripcion);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        //Metodo para editar un contacto
        public void editarContacto(E_Contacto contacto)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SP_EDITARCONTACTO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IDContacto", D_Contacto.Idcontacto);
            cmd.Parameters.AddWithValue("@NOMBRE", contacto.Nombre);
            cmd.Parameters.AddWithValue("@DESCRIPCION", contacto.Descripcion);
            cmd.Parameters.AddWithValue("@APELLIDO", contacto.Descripcion);
            cmd.Parameters.AddWithValue("@DIRECCION", contacto.Descripcion);
            cmd.Parameters.AddWithValue("@TELEFONO", contacto.Descripcion);
            cmd.Parameters.AddWithValue("@FECHA_NAC", contacto.Descripcion);
            cmd.ExecuteNonQuery();
            conexion.Close();

        }
        //Metodo para eliminar una Contacto
        public void eliminarContacto(E_Contacto contacto)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINARContacto", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@IDContacto", contacto.IdContacto);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        //Metodo que me devuelve un Objeto de tipo DataSet con todos los datos de la tabla Contacto
        public DataSet mostrarDatos()
        {

            conexion.Open();
            string qwery = "select * from contactos";
            SqlDataAdapter adaptador = new SqlDataAdapter(qwery, conexion);
            DataSet datos = new DataSet();
            adaptador.Fill(datos);
            conexion.Close();
            return datos;

        }


    }
}
