using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcos
{
    public class Bloque
    {
        private static List<Bloque> bloques = new List<Bloque>();
        private int largo;
        private int ancho;
        private int alto;

        public static List<Bloque> Bloques { get => bloques; set => bloques = value; }
        public int Largo { get => largo; set => largo = value; }
        public int Ancho { get => ancho; set => ancho = value; }
        public int Alto { get => alto; set => alto = value; }

        public Bloque(int largo, int ancho, int alto)
        {
            this.largo = largo;
            this.ancho = ancho;
            this.alto = alto;
        }

        public Bloque() 
        {
            largo = 0;
            ancho = 0;
            alto = 0;
        }

        public void Guardar() 
        {
            Bloque.Bloques.Add(this);
        }
        public static int ObtenerLargo(Bloque bloque)
        {
            return bloque.largo;
        }

        public static int ObtenerAncho(Bloque bloque)
        {
            return bloque.ancho;
        }

        public static int ObtenerAlto(Bloque bloque)
        {
            return bloque.alto;
        }

        public static int ObtenerVolumen(Bloque bloque)
        {
            return bloque.largo * bloque.ancho * bloque.alto;
        }

        public static int ObtenerAreaSuperficie(Bloque bloque)
        {
            return 2 * (bloque.largo * bloque.ancho + bloque.largo * bloque.alto + bloque.ancho * bloque.alto);
        }

        public static Bloque Seleccionar(List<Bloque> lista)
        {
            Console.WriteLine("\nSeleccione el barco que quiera saquear:");
            int i = 1;
            foreach (Bloque x in lista)
            {
                Console.WriteLine("Bloque " +i);
                i++;
            }

            int numSel = int.Parse(Console.ReadLine());
            return lista[numSel - 1];
        }

        public static void MenuBloques()
        {
            Console.WriteLine("Seleccione una opción sobre los bloques:");
            Console.WriteLine("1 - Obtener largo.");
            Console.WriteLine("2 - Obtener ancho.");
            Console.WriteLine("3 - Obtener alto.");
            Console.WriteLine("4 - Obtener volumen.");
            Console.WriteLine("5 - Obtener área de superficie.");

            int subOpcion = Validaciones.LeerInt(1, 5);

            Bloque bloqueSeleccionado = Seleccionar(Bloque.Bloques);

            switch (subOpcion)
            {
                case 1:
                    Console.WriteLine("Largo: " + bloqueSeleccionado.Largo);
                    break;
                case 2:
                    Console.WriteLine("Ancho: " + bloqueSeleccionado.Ancho);
                    break;
                case 3:
                    Console.WriteLine("Alto: " + bloqueSeleccionado.Alto);
                    break;
                case 4:
                    Console.WriteLine("Volumen: " + Bloque.ObtenerVolumen(bloqueSeleccionado));
                    break;
                case 5:
                    Console.WriteLine("Área de superficie: " + Bloque.ObtenerAreaSuperficie(bloqueSeleccionado));
                    break;
            }

        }


    }
}
