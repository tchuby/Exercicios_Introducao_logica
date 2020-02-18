using System;
using System.Collections.Generic;

namespace RegexTest
{
    public class Vendas
    {
        public DateTime Data { get; set; }
        public decimal Total { get; set; }
        public TipoVenda Tipo { get; set; }
        public List<ItemVenda> Itens { get; set; }
    }

    public class ItemVenda
    {
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
    }

    public enum TipoVenda
    {
           Corporativa = 1,
           Consignada = 2,
           Direta = 3
    }
}
