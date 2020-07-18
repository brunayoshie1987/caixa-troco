using System;
using System.Net.Http.Headers;

namespace caixa___eletronico

{
    class Program
    {
        static void Main(string[] args)
        {

            double valorProduto = 0;
            Console.WriteLine("Digite o valor do produto");
            valorProduto = Convert.ToDouble(Console.ReadLine());

            string ValorPago = "0";
            double dblValorPago = 0;

            while (ValorPago != "")
            {
                Console.WriteLine("Qual o valor pago");
                ValorPago = Console.ReadLine();

                if (ValorPago != "")
                {
                    dblValorPago += Convert.ToDouble(ValorPago);
                }
            }

            double troco = dblValorPago - valorProduto;

            if (troco > 0)
            {
                Console.WriteLine("O troco é de " + troco);
            }
            else if (troco < 0)
            {
                Console.WriteLine("Você ainda deve " + Math.Abs(troco));
            }
            else
            {
                Console.WriteLine("Não há troco");
            }

            Console.ReadKey();
        }
    }
}
//            string valorproduto = "";
//            Console.WriteLine("qual o valor do produto");
//            int valor =Convert.ToInt32(Console.ReadLine());

//            int valorpago;
//            while (valorproduto == "");
//            {
//                Console.WriteLine("qual o valor pago");
//                int saldo= Convert.ToInt32(Console.ReadLine());
//            }


//            bool valortroco = (valorproduto - valorpago);
//          int troco=Convert.ToDouble (valortroco);
//        }



//    }
//}
