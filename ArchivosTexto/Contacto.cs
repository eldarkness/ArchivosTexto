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

    }
}
