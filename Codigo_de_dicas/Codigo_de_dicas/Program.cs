using System;

namespace Codigo_de_dicas
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1º - Inicializadores de Objetos - 
            Ao invés de ocupar várias linhas ‘setando’ valores e possível utilizar inicializadores de objeto */

            //ANTES
            Cliente c = new Cliente();
            c.Nome = "Jose";
            c.Endereco = "Rua Luiz Souza 604";

            //DEPOIS 
            Cliente c = new Cliente { Nome = "Jose", Endereco = "Rua Luiz Souza 604" };

            /*Deixando claro que inicializadores e recomendado para uso desde a programação inicial,
            pois tem um nível de complexidade baixo*/

            /* 2º - Operador Ternário - 
             Ele poderá ser usado em funções básicas de decisões, o uso indevido causa um prejuízo na legibilidade de seu código
             */
            //ANTES

            int x = 55;
            int y = 65;
            int max;

            if (x > y)
                max = x;
            else
                max = y;

            //DEPOIS
            int x = 55;
            int y = 65;
            int max = (x > y) ? x : y;

            /* 3º - Propriedades Automáticas GET / SET - 
             No C# 3.0 é possível o uso de propriedades automáticas onde facilita a vida do programador*/

            //ANTES
            public class Pessoa
        {
            private string _primeiroNome;
            public string PrimeiroNome
            {
                get { return _primeiroNome; }
                set { _primeiroNome = value; }
            }
        }

        //DEPOIS
        public class Pessoa
        {
            public string PrimeiroNome { get; set; }
        }
        //Para criar automaticamente é necessário apenas criar a classe e o atributo e definir os get / set

    }
}

