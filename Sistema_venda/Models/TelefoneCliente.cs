using System;
using System.Collections.Generic;
using System.Text;

namespace sistema_venda.Models
{
    class TelefoneCliente
    {

        public int CodTelefone { get; set; }

        public string DDD { get; set; }

        public string Numero { get; set; }

        public int FkCliente { get; set; }

        public Cliente Cliente { get; set; }





    }
}
