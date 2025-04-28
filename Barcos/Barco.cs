using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcos
{
    public class Barco
    {
        private static List<Barco> barcos = new List<Barco>();
        private double cargamento;
        private int tripulacion;

        public static List<Barco> Barcos { get => barcos; set => barcos = value; }
        public double Cargamento { get => cargamento; set => cargamento = value; }
        public int Tripulacion { get => tripulacion; set => tripulacion = value; }

        public Barco(double cargamento, int tripulacion) 
        {
            this.cargamento = cargamento;
            this.tripulacion = tripulacion;
        }

        public Barco() 
        {
            cargamento = 0;
            tripulacion = 0;
        }

        public void Guardar() 
        {
            Barco.Barcos.Add(this);
        }
        public static Barco Seleccionar(List<Barco> lista)
        {
            Console.WriteLine("\nSeleccione el barco que quiera saquear:");
            int i = 1;
            foreach (Barco x in lista)
            {
                Console.WriteLine("Barco " +i);
                i++;
            }

            int numSel = int.Parse(Console.ReadLine());
            return lista[numSel - 1];
        }

        //Esta clase deberá tener un método valeLaPenaSaquear() que devuelve true si, después de eliminar el peso de la tripulación, el cargamento sigue siendo superior a 20 (lo que indica que vale la pena saquear el barco).

        public static bool valeLaPenaSaquear(List<Barco> lista) //recibe una lsita como parametro, asi esta puede ser usada en la seleccion de barcos el cual va a utilizar el metodo
        {
            Barco barcoSeleccionado = Seleccionar(lista);

            if ((barcoSeleccionado.cargamento - barcoSeleccionado.tripulacion) > 20)
                return true;
            else
                return false;
        }
    }
}
