using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoExercicioAulaClassesUml {
    internal class Produto {

        CultureInfo CI = CultureInfo.InvariantCulture;

        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque() {
            return Quantidade * Preco;
        }

        public void AdicionarProduto(int quantidade) {
            Quantidade = Quantidade + quantidade;
        }

        public void RemoverProdutos(int quantidade) {
            Quantidade = Quantidade - quantidade;
        }

        public override string ToString() {
            return Nome 
                + ", $ " 
                + Preco.ToString("F2", CI) 
                + ", "
                + Quantidade 
                + "unidades, Total: $ " 
                + ValorTotalEmEstoque().ToString("F2", CI);
        }

        
        
    }
}
