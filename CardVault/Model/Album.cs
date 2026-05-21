using CardVault.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardVault.Model
{
    public class Album : IColecionavel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Tema { get; set; }
        public int AnoLancamento { get; set; }
        public int TotalCards { get; set; }
        public int IdColecionador { get; set; }

        public List<Card> Cards { get; set; } = new List<Card>();
    }
}
