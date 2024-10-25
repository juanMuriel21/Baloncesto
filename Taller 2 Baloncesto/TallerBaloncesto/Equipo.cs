using System;
using System.Collections.Generic;
using System.Linq;

namespace BasketballTeamSelection
{
    public class Equipo
    {
        public List<Jugador> Jugadores { get; private set; }

        public Equipo()
        {
            Jugadores = new List<Jugador>();
        }

        public void AgregarJugador(Jugador jugador)
        {
            Jugadores.Add(jugador);
        }

        public List<Jugador> ObtenerMejoresJugadores(int cantidad)
        {
            return Jugadores.OrderByDescending(j => j.PuntosPorPartido).Take(cantidad).ToList();
        }
    }
}