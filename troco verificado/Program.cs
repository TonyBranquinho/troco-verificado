using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace troco_verificado {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int quantidade;
            double preco, dinheiro, troco, total, falta;

            Console.Write("Preço unitario do poduto: ");
            preco = double.Parse(Console.ReadLine(), CI);
            Console.Write("Quantidade comprada: ");
            quantidade = int.Parse(Console.ReadLine());
            Console.Write("Dinheiro recebido: ");
            dinheiro = double.Parse(Console.ReadLine(), CI);

            total = quantidade * preco;
            troco = dinheiro - total;
            
            if (troco > 0) {
                Console.WriteLine("TROCO = " + troco.ToString("F2"), CI);
            }
            else {
                falta = total - dinheiro;
                Console.WriteLine("DINHEIRO INSUFICIENTE. FALTAM " + 
                    falta.ToString("F2"), CI);
            }

        }
    }
}
