using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace juego
{
    internal class Piedra:Tirada
    {
        public override string dotirar()
        {
            return "Tira piedra";
        }
    }
}
