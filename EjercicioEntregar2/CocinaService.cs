﻿using System;
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
                if (r.alimentoNecesario1.Nombre.Equals(mAlimento1.Nombre) && r.alimentoNecesario2.Nombre.Equals(mAlimento2.Nombre))
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
