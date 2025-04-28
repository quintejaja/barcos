namespace Barcos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrecargarDatos();
            
            int opcion; //acá vamos a guardar la opción elegida
            do
            {
                opcion = Menu();

                switch (opcion)
                {
                    case 1:
                        Persona.HablarCon(Persona.Personas);
                        break;
                    case 2:
                        bool estado = Barco.valeLaPenaSaquear(Barco.Barcos);
                        if (estado)
                            Console.WriteLine("¡Vale la pena saquear el barco!");
                        else
                            Console.WriteLine("No conviene saquear este barco.");
                        break;
                    case 3:
                        Tanque.Batalla(Tanque.Tanques);
                        break;
                    case 4:
                        Bloque.MenuBloques();
                        break;
                }

                Console.WriteLine("\n\nToque una tecla para continuar..");
                Console.ReadKey();
                Console.Clear();
            } while (opcion != 0);
        }

        private static void PrecargarDatos() 
        {

            Barco b = new Barco(100, 20);
            b.Guardar();

            Barco barco2 = new Barco(20, 10);
            barco2.Guardar();

            Barco barco3 = new Barco(150, 30);
            barco3.Guardar();

            Persona p1 = new Persona("Lautaro", 20, "Hombre");
            p1.Guardar();

            Persona p2 = new Persona("Camila", 25, "Mujer");
            p2.Guardar();

            Persona p3 = new Persona("Franco", 30, "Hombre");
            p3.Guardar();

            Tanque tanque = new Tanque("Chozero", "Argentina", 2004, 10000, new List<string> { "Choxzer", "Ala" });
            tanque.Guardar();

            Tanque tanque2 = new Tanque("Blas Esjueves", "Japon", 1998, 1000, new List<string> { "Luchito", "Lucaco" });
            tanque2.Guardar();

            Tanque tanque3 = new Tanque("Destructor", "EEUU", 2010, 5000, new List<string> { "Eagle", "Falcon" });
            tanque3.Guardar();

            Tanque tanque4 = new Tanque("Titan", "Alemania", 2015, 7500, new List<string> { "Blitz", "Kraken" });
            tanque4.Guardar();
            
            Bloque bloque = new Bloque(5, 5, 5);
            bloque.Guardar();

            Bloque bloque2 = new Bloque(10, 10, 10);
            bloque2.Guardar();

            Bloque bloque3 = new Bloque(2, 3, 4);
            bloque3.Guardar();

        }

        private static int Menu()
        {
            int opcion;

            Console.WriteLine("Ingrese el número de la opción y luego enter:\n");
            Console.WriteLine("1 - Hablar con.");
            Console.WriteLine("2 - Vale la pena saquear?");
            Console.WriteLine("3 - Batalla de tanques.");
            Console.WriteLine("4 - Calcular bloque.");


            Console.WriteLine("0 - Salir\n");

            opcion = Validaciones.LeerInt(0, 4);
            return opcion;
        }
    }
}
