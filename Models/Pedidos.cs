using System;
using System.ComponentModel.DataAnnotations;

namespace uc4.Models
{
    public class Pedidos
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        public string ItemPedido {get; set;}
        public string Endereço {get; set;}

        public int Valor {get; set;}
        
        public string FormaPag {get; set;}
        
    }
}