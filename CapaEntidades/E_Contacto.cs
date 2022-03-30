using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Contacto
    {
        //Atributos
        private int idContacto;
        private string codigoContacto;
        private string nombre;
        private string descripcion;
        private string direccion;

        //Metodos get y set
        public int IdCategoria { get => idContacto; set => idContacto = value; }
        public string CodigoCategoria { get => codigoContacto; set => codigoContacto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public object IdContacto { get; set; }

        //Constructor Vacio
        public E_Contacto()
        {
        }




        //Constructor con todos los atributos
        public E_Contacto(int idContacto, string codigoContacto, string nombre, string descripcion)
        {
            this.idContacto = idContacto;
            this.codigoContacto = codigoContacto;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }
        //Constructor con tres argumentos
        public E_Contacto(int idContacto, string nombre, string descripcion)
        {
            this.idContacto = idContacto;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }
        //Constructor con dos argumentos
        public E_Contacto(string nombre, string descripcion)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
        }
        //Constructor con un argumento
        public E_Contacto(int idContacto)
        {
            this.idContacto = idContacto;
        }

        //Metodos get y set Creados de otra manera para practicar
        public int getId()
        {
            return this.idContacto;

        }

        public void setCodigoCategoria(string codigoContacto)
        {
            this.codigoContacto = codigoContacto;

        }
        public string getCodigoCategoria()
        {
            return this.codigoContacto;

        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;

        }
        public string getNombre()
        {
            return this.nombre;
        }

        public void setDireccion(string direccion)
        {
            this.direccion = direccion;

        }

        public string getDireccion()
        {
            return this.direccion;
        }

    }
}
