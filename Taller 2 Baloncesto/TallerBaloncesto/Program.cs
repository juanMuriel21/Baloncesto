using System;

namespace BasketballTeamSelection
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo equipo = new Equipo();

            Console.WriteLine("Ingrese la cantidad de jugadores que desea agregar:");
            int cantidadJugadores = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidadJugadores; i++)
            {
                Console.WriteLine($"Ingrese los datos del jugador {i + 1}:");
                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();

                Console.Write("Altura (cm): ");
                double altura = double.Parse(Console.ReadLine() );

                Console.Write("Peso (kg): ");
                double peso = double.Parse(Console.ReadLine());

                Console.Write("Puntos por partido: ");
                int puntosPorPartido = int.Parse(Console.ReadLine());

                Jugador jugador = new Jugador(nombre, altura, peso, puntosPorPartido);
                equipo.AgregarJugador(jugador);
            }

            Console.WriteLine("¿Cuántos mejores jugadores desea seleccionar?");
            int cantidadSeleccionar = int.Parse(Console.ReadLine());

            var mejoresJugadores = equipo.ObtenerMejoresJugadores(cantidadSeleccionar);

            Console.WriteLine("\nMejores Jugadores Seleccionados:");
            foreach (var jugador in mejoresJugadores)
            {
                Console.WriteLine(jugador);
            }
        }
    }
}
