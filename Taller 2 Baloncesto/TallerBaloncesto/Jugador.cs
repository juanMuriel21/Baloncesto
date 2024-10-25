using System;

namespace BasketballTeamSelection
{
    public class Jugador
    {
        public string Nombre { get; set; }
        public double Altura { get; set; } // En centímetros
        public double Peso { get; set; } // En kilogramos
        public int PuntosPorPartido { get; set; }

        public Jugador(string nombre, double altura, double peso, int puntosPorPartido)
        {
            Nombre = nombre;
            Altura = altura;
            Peso = peso;
            PuntosPorPartido = puntosPorPartido;
        }

        public override string ToString()
        {
            return $"{Nombre} - Altura: {Altura} cm, Peso: {Peso} kg, Puntos por Partido: {PuntosPorPartido}";
        }
    }
}