using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchivosTexto
{
    class Contacto
    {
        public static int ID = 1;
        public int ID_Ind;
        public string Nombre { get; set; }
        public double Telefono { get; set; }

        public Contacto(string nombre, double telefono)
        {
            this.Nombre = nombre;
            this.Telefono = telefono;
            this.ID_Ind = ID;
            ID++;
        }

        public Contacto()
        {
            this.Nombre = "nombre por defecto";
            this.Telefono = 012345678;
            this.ID_Ind = ID;
            ID++;
        }

        public void MostarTelefono(string nombre)
        {
            if (this.Nombre.Equals(nombre))
            {
                Console.WriteLine("Numero de telefono de {0}: {1}",this.Nombre,this.Telefono);
            }

        }

        public void MostrarDatos(int ID)
        {
            if (this.ID_Ind == ID)
            {
                Console.WriteLine("ID {0}- Nombre: {0}, Telefono: {1}", this.Nombre, this.Nombre);
            }
        }

        public char MostarPorInicial()
        {
            return this.Nombre[0];    
        }
        

    }
}
