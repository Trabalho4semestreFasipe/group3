using System;
using System.Collections.Generic;
using System.Text;

namespace Atimir.Model
{
    public class Desejo
    {
        public int codigo { get; set; }
        public String Produto { get; set; }
        public String Categoria { get; set; }
        public String Loja { get; set; }
        public float PrecoMin { get; set; }
        public float PrecoMax { get; set; }
    }
}
