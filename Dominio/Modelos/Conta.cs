using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Modelos
{
    public class Conta : ObjetoBase
    {
        public Agencia Agencia;
        public String NumeroConta;
        public char DigitoVerificador;
    }
}
