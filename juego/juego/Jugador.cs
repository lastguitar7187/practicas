using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juego
{
    internal class Jugador
    {
       private Tirada tirada;

    public virtual void jugar(Tirada play)
        {
            play.dotirar();
            this.tirada=play;
        }
    }
}

