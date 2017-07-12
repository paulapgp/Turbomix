using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntregar2
{
    public class Receta
    {
        public Alimento alimentoNecesario1;
        public Alimento alimentoNecesario2;

        public Receta(Alimento _aNecesario1, Alimento _aNecesario2)
        {
            this.alimentoNecesario1 = _aNecesario1;
            this.alimentoNecesario2 = _aNecesario2;
        }

        
    }
}
