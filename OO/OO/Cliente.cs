using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OO
{
    class Cliente
    {
        private string nome;

        private float limiteCredito;

        private bool estaBloqueado;

        public float LimiteCredito
        {
            get { return this.limiteCredito; }
        }

        public Boolean EstaBloqueado
        {
            get { return this.estaBloqueado; }
        }

        public void AumentaLimiteDeCredito(float aumento)
        {
            this.limiteCredito += aumento;
        }

        public void DiminuiLimiteCredito(float valor)
        {
            this.limiteCredito -= valor;
        }

        public void DiminuiLimiteCredito(float valor, bool bloquear)
        {
            this.limiteCredito -= valor;
            this.estaBloqueado = bloquear;
        }
    }
}
