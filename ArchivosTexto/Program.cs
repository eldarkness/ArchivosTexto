using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ArchivosTexto
{
    class Program
    {
        public static List<Contacto> listaTelefonos = new List<Contacto>();
        public static void Main(string[] args)
        {
            string unalinea = @"C:\Users\eldarkness\Documents\unalinea.txt";
            string variaslineas = @"C:\Users\eldarkness\Documents\variaslineas.txt";
            //File.WriteAllText(path, "Hola que tal \n");

            listaTelefonos.Add(new Contacto("Pedro Martinez", 968261234));
            listaTelefonos.Add(new Contacto("Clara Vergara", 664402154));
            listaTelefonos.Add(new Contacto("Sofia Mazagatos", 968261547));
            listaTelefonos.Add(new Contacto("Juan Cuesta", 678451245));
            listaTelefonos.Add(new Contacto("Paloma Sotelo", 6163154748));

            Console.WriteLine(File.Exists(unalinea) ? "File Existe." : "File no existe");
            Console.WriteLine(File.Exists(variaslineas) ? "File Existe." : "File no existe");
            string lineaTotal = "";
            
            for (int i = 0; i < listaTelefonos.Count(); i++)
            {
                lineaTotal+=listaTelefonos[i].Nombre +listaTelefonos[i].Telefono;
            }

            File.WriteAllText(unalinea, lineaTotal);
            //File.WriteAllLines(path, arrayLineas);
            string[] arrayLineas = new string[listaTelefonos.Count()];
            // File.WriteAllText(path, crearTexto)
            // publicstaticvoidWriteAllLines (string path, string[] contents);
            Console.ReadKey();

        }
    }
}
