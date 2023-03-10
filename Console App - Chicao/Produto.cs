using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App___Chicao
{
    internal class Produto
    {
        private int Id;
        private decimal Valor;
        private string Descricao;
        
        public Produto(int id, decimal valor, string descricao)
        {
            Id = id;
            Valor = valor; 
            Descricao = descricao;  
        }
        public string getDescricao() => Descricao;

        public void setDescricao(string descricao)
        {
            Descricao = descricao;
        }
        public int getId() => Id;

        public void setId(int id)
        {
            Id = id;
        }
        public decimal getValor() => Valor;

        public void setValor(decimal valor)
        {
            Valor = valor;
        }

    }
}
