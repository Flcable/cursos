using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio_banco
{
    class Conta
    {
        private int _numero;
        private string _nome;
        private bool _deposito;

        public Conta()
        {
        }

        public Conta(int numero, string nome, bool deposito)
        {
            _numero = numero;
            _nome = nome;
            _deposito = deposito;
        }

        public int Numero
        {
            get { return _numero; }
            set {
                if (value != null && value > 1)
                {
                    _numero = Numero;

                }

            }
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1 )
                {
                    _nome = Nome;

                }
            }

        }
    }


     
   

   
}
