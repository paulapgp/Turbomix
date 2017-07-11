using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntregar2
{
    public class Plato
    {
        private Alimento mAlimento1;
        private Alimento mAlimento2;
        public String NombrePlato;
        public Plato(Alimento mAlimento1, Alimento mAlimento2)
        {
            this.mAlimento1 = mAlimento1;
            this.mAlimento2 = mAlimento2;
            NombrePlato = "" + mAlimento1 + mAlimento2;
    }

        
    }
}
