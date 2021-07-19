using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Conta : ObjetoBase
    {
        public Agencia Agencia;
        public String NumeroConta;
        public char DigitoVerificador;
    }
}
