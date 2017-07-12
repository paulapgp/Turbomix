using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntregar2
{
    public class CocinaService : ICocina
    {
        public void Calentar(Alimento mAlimento1, Alimento mAlimento2) {
            mAlimento1.Calentado = true;
            mAlimento2.Calentado = true;
        }

        public bool ComprobarAlimentos(Receta r, Alimento mAlimento1, Alimento mAlimento2)
        {
            bool coincidenAlimentos = false;

            if (mAlimento1.Calentado == true && mAlimento2.Calentado == true)
            {
                if (r.alimentoNecesario1.Equals(mAlimento1) && r.alimentoNecesario2.Equals(mAlimento2))
                {
                    coincidenAlimentos = true;
                }
                else
                {
                    coincidenAlimentos = false;
                }
            }
            else
            {
                coincidenAlimentos = false;
            }
            return coincidenAlimentos;
        }
    }
}
