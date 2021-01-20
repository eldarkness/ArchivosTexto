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
            /*
             * Para la maquina virtual de clase
             * string unalinea = @"C:\Users\eldarkness\Documents\unalinea.txt";     
             * string variaslineas = @"C:\Users\eldarkness\Documents\variaslineas.txt";             *  
             */

            listaTelefonos.Add(new Contacto("Pedro Martinez", 968261234));
            listaTelefonos.Add(new Contacto("Clara Vergara", 664402154));
            listaTelefonos.Add(new Contacto("Sofia Mazagatos", 968261547));
            listaTelefonos.Add(new Contacto("Juan Cuesta", 678451245));
            listaTelefonos.Add(new Contacto("Paloma Sotelo", 6163154748));                               
                        
            Boolean numCorrecto = false;
            int opcion = 1;
            while (opcion != 0)
            {
                string fraseMenu="Bienvenido al programa de gestion de contactos Telefonicos, indica que deseas hacer: \n1. Dar de alta un contacto " +
                "\n2. Guardar el listin telefono en archivo \"Agenda.txt\" \n3. Guardar contactos por Inicial \n4. Mostar por inicial \n0. Salir";
                
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
                        GuardarListinTelefonico();
                        break;
                    case 3:
                        GuardarPorInicial();
                        break;
                    case 4:
                        //MostrarPorInicial();
                        break;
                    case 0:
                        Console.WriteLine("Saliendo del programa");
                        break;
                }
            }

            /*
             * 
             * string unalinea = @"C:\Users\el_ar\Documents\unalinea.txt";
             * string variaslineas = @"C:\Users\el_ar\Documents\variaslineas.txt";
             * 
             * Console.WriteLine(File.Exists(unalinea) ? "File Existe." : "File no existe");
             * Console.WriteLine(File.Exists(variaslineas) ? "File Existe." : "File no existe")
             * 
             * File.WriteAllText(path, crearTexto)
             * string lineaTotal = "";
             * 
             * for (int i = 0; i < listaTelefonos.Count(); i++)
             * {
             *      lineaTotal+=listaTelefonos[i].Nombre +listaTelefonos[i].Telefono;
             * }
             * File.WriteAllText(unalinea, lineaTotal);
             * 
             * File.WriteAllLines(path, arrayLineas);
             * string[] arrayLineas = new string[listaTelefonos.Count()];   
             * 
             */
             

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
            
            string str="Dime el telefono del contacto";
            double telefono = ComprobarDouble(str);

            listaTelefonos.Add(new Contacto(nombre, telefono));

        }

        public static double ComprobarDouble(String str)
        {
            Boolean isDouble = false;
            double numero = 0;
            while (isDouble == false)
            {
                Console.WriteLine(str);
                isDouble = double.TryParse(Console.ReadLine(), out numero);
            }
            return numero;
        }

        public static void GuardarListinTelefonico()
        {
            string path= @"C:\Users\el_ar\Documents\agenda.txt";
            string[] arrayLineas = new string[listaTelefonos.Count()];

            for (int i = 0; i < listaTelefonos.Count(); i++)
            {
                arrayLineas[i]= "Nombre del contacto: " +listaTelefonos[i].Nombre + ". Telefono: "+ listaTelefonos[i].Telefono;
            }
            File.WriteAllLines(path, arrayLineas);


        }
        
        public static void GuardarPorInicial()
        {
            string str="Dime la inicial del contacto el cual quieres guardar en la \"agenda por inicial\"";
            char ch= ComprobarChar(str);
            string path = @"C:\Users\el_ar\Documents\AgendaPorInicial.txt";
            List<string> listaLineas = new List<string>();
           
            for (int i = 0; i < listaTelefonos.Count(); i++)
            {
                if (ch.Equals(listaTelefonos[i].Nombre[0]))
                {
                    listaLineas.Add("Nombre del contacto: " + listaTelefonos[i].Nombre + ". Telefono: " + listaTelefonos[i].Telefono);
                }
            }
            File.WriteAllLines(path, listaLineas);
            
        }
        public static void MostrarDatos()
        {
            for (int i = 0; i < listaTelefonos.Count(); i++)
            {
                Console.WriteLine(listaTelefonos[i].Nombre + listaTelefonos[i].Telefono);
            }
        }

        public static char ComprobarChar(string str)
        {
            Console.WriteLine(str);
            string cadena = Console.ReadLine();
            
            if (cadena.Length == 1)
            {
                char ch = cadena[0];
                return ch;
            }
            else
            {
                Console.WriteLine("Has introducido mas de un caracter");
                ComprobarChar(str);
            }
            return 'a';
        }
    }
}
 