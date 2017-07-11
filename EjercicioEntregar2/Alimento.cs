using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntregar2
{
    public class Alimento
    {
        public float Peso { get; set; }
        public bool Calentado { get; set; }

        public Alimento()
        {
            Peso = 0;
            Calentado = false;
        }

        public Alimento(float _Peso, bool _Calentado)
        {
            this.Peso = _Peso;
            this.Calentado = _Calentado;
        }
    }
}
