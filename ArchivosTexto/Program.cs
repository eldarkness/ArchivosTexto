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
            
            Console.WriteLine(File.Exists(unalinea) ? "File Existe." : "File no existe");
            Console.WriteLine(File.Exists(variaslineas) ? "File Existe." : "File no existe");

            
            Boolean numCorrecto = false;
            int opcion = 1;
            while (opcion != 0)
            {
                string fraseMenu="Bienvenido al programa de gestion de contactos Telefonicos, indica que deseas hacer: \n1. Dar de alta un contacto " +
                "\n2. Consultar un Telefono de la agenda \n3. Mostar un contacto especifico \n4. Mostar por inicial \n0. Salir";
                opcion = Convert.ToInt32(Console.ReadLine());

                opcion = ComprobarEntero(fraseMenu); ;
                if (opcion < 0 || opcion > 5)
                {
                    Console.WriteLine("Introduce una opcion del 0 al 5");
                }
                switch (opcion)
                {
                    case 1:
                        AnadirContacto();
                        break;
                    case 2:
                        MostrarTelefono();
                        break;
                    case 3:
                        MostrarDatos();
                        break;
                    case 4:
                        MostrarPorInicial();
                        break;
                    case 0:
                        break;
                }
            }



            listaTelefonos.Add(new Contacto("Pedro Martinez", 968261234));
            listaTelefonos.Add(new Contacto("Clara Vergara", 664402154));
            listaTelefonos.Add(new Contacto("Sofia Mazagatos", 968261547));
            listaTelefonos.Add(new Contacto("Juan Cuesta", 678451245));
            listaTelefonos.Add(new Contacto("Paloma Sotelo", 6163154748));

            
            // File.WriteAllText(path, crearTexto)
            string lineaTotal = "";            
            for (int i = 0; i < listaTelefonos.Count(); i++)
            {
                lineaTotal+=listaTelefonos[i].Nombre +listaTelefonos[i].Telefono;
            }
            File.WriteAllText(unalinea, lineaTotal);

            //File.WriteAllLines(path, arrayLineas);
            

            
            string[] arrayLineas = new string[listaTelefonos.Count()];            
                        
            Console.ReadKey();

        }
        public static int ComprobarEntero(String str)
        {
            Boolean isInteger = false;
            int numero = 0;
            while (isInteger == false)
            {
                Console.WriteLine(str);
                isInteger = int.TryParse(Console.ReadLine(), out numero);
            }
            return numero;
        }
        public static void AnadirContacto()
        {
            Console.WriteLine("Dime un nombre para el contacto");
            string nombre = Console.ReadLine();
            
            Console.WriteLine("Dime el telefono del contacto");
            double telefono = Convert.ToDouble(Console.ReadLine());

            listaTelefonos.Add(new Contacto(nombre, telefono));

        }
        public static void MostrarTelefono()
        {

        }
        public static void MostrarDatos()
        {

        }
        public static void MostrarPorInicial()
        {

        }
    }
}
 