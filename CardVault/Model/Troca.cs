using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardVault.Model
{
    public class Troca
    {
        public int Id { get; set; }
        public int IdColecionador1 { get; set; }
        public int IdColecionador2 { get; set; }
        public DateTime DataTroca { get; set; }
        public string Observacao { get; set; }

        public List<Card> Cards { get; set; } = new List<Card>();
    }
}
