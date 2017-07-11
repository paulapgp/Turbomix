using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntregar2
{
    public class Turbomix
    {
        public Plato PesarYCocinar(Alimento mAlimento1, Alimento mAlimento2)
        {
            float Peso1 = Pesar(mAlimento1);
            float Peso2 = Pesar(mAlimento2);
            CocinarUtils mCocinarUtils = new CocinarUtils();
            mCocinarUtils.Calentar(mAlimento1, mAlimento2);

            return new Plato(mAlimento1, mAlimento2);
        }
        public float Pesar(Alimento mAlimento)
        {
            return mAlimento.Peso;
        }
        
    }
}
