using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcos
{
    public class Tanque
    {
        private static List<Tanque> tanques = new List<Tanque>();
        private string nombre;
        private string pais;
        private int anio;
        private int peso;
        private List<string> aliados;

        public static List<Tanque> Tanques { get => tanques; set => tanques = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Pais { get => pais; set => pais = value; }
        public int Anio { get => anio; set => anio = value; }
        public int Peso { get => peso; set => peso = value; }
        public List<string> Aliados { get => aliados; set => aliados = value; }

        public Tanque(string nombre, string pais, int anio, int peso, List<string> aliados)
        {
            this.nombre = nombre;
            this.pais = pais;
            this.anio = anio;
            this.peso = peso;
            this.aliados = aliados;
        }

        public Tanque()
        {
            nombre = string.Empty;
            pais = string.Empty;
            anio = 0;
            peso = 0;
            aliados = new List<string>();
        }

        public void Guardar() 
        {
            Tanque.Tanques.Add(this);
        }

        private string MostrarDatos()
        {
            return "\nNombre: " + this.Nombre + "\nPais: " + this.pais + "\nAño: " + this.anio + "\nPeso: " + this.peso;
        }

        public static Tanque Seleccionar(List<Tanque> lista)
        {
            Console.WriteLine("\nSeleccione el barco que quiera saquear:");
            int i = 1;
            foreach (Tanque x in lista)
            {
                Console.WriteLine("Tanque " +i+ "- " +x.nombre);
                i++;
            }

            int numSel = int.Parse(Console.ReadLine());
            return lista[numSel - 1];
        }

        //Esta clase deberá tener un método batalla() que simule una batalla entre dos tanques. Este método debe comparar los atributos de cada tanque para determinar quién gana la batalla,
        //teniendo en cuenta el año de fabricación y el peso del tanque.Además, debe mostrar en pantalla la información de ambos tanques y el resultado de la batalla.

        public static void Batalla(List<Tanque> lista) 
        {
            Tanque primerTanque = Seleccionar(lista);
            Tanque segundoTanque;
            do
            {
                Console.WriteLine("Seleccione el segundo tanque:");
                segundoTanque = Seleccionar(lista);

                if (primerTanque == segundoTanque)
                    Console.WriteLine("No puedes seleccionar el mismo tanque. Elige uno diferente.");
            }
            while (primerTanque == segundoTanque);

            Console.WriteLine("\nReglas: " + "\nTanque con mayor peso que el otro suma 1 punto." + "\nTanque con año mas actual que el otro suma un punto.");
            
            Console.WriteLine("\nPrimer tanque:");
            Console.WriteLine(primerTanque.MostrarDatos());

            Console.WriteLine("\nSegundo tanque:");
            Console.WriteLine(segundoTanque.MostrarDatos());

            int puntosTanque = 0;
            int puntos2doTanque = 0;

            if (primerTanque.anio > segundoTanque.anio)
                puntosTanque++;
            else if (segundoTanque.anio > primerTanque.anio)
                puntos2doTanque++;

            if (primerTanque.peso > segundoTanque.peso)
                puntosTanque++;
            else if (segundoTanque.peso > primerTanque.peso)
                puntos2doTanque++;

            Console.WriteLine("\nResultado de la batalla:");
            if (puntosTanque > puntos2doTanque)
                Console.WriteLine("¡Gana el tanque " + primerTanque.nombre + "!");
            else if (puntos2doTanque > puntosTanque)
                Console.WriteLine("¡Gana el tanque " + segundoTanque.nombre + "!");
            else
                Console.WriteLine("¡Empate entre ambos tanques!");
        }
    }
}
