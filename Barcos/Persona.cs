using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcos
{
    public class Persona
    {
        private static List<Persona> personas = new List<Persona>(); //Para poder precargar datos y probar el programa mas facil.
        private string nombre;
        private int edad;
        private string genero;

        public static List<Persona> Personas { get => personas; set => personas = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Genero { get => genero; set => genero = value; }

        public Persona(string nombre, int edad, string genero)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.genero = genero;
        }

        public Persona() 
        {
            nombre = string.Empty;
            edad = 0;
            genero = string.Empty;
        }

        public void Guardar() 
        {
            Persona.Personas.Add(this);
        }

        public string Hablar() 
        {
            return "Me llamo " + this.nombre + ", me considero " + this.genero + " y tengo " + this.edad + " años.";
        }

        public static Persona Seleccionar(List<Persona> lista)
        {
            Console.WriteLine("\nSeleccione la persona con la que quiera hablar:");
            int i = 1;
            foreach (Persona x in lista)
            {
                Console.WriteLine(i+ " - " +x.nombre);
                i++;
            }

            int numSel = int.Parse(Console.ReadLine());
            return lista[numSel - 1];
        }

        public static void HablarCon(List<Persona> lista) 
        {
            Persona seleccionado = Seleccionar(lista);

            Console.WriteLine(seleccionado.Hablar());
        }
    }
}
