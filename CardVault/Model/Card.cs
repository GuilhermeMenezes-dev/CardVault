using CardVault.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardVault.Model
{
    public class Card : IColecionavel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Numero { get; set; }
        public string Raridade { get; set; }
        public string Descricao { get; set; }
        public int IdAlbum { get; set; }
    }
}
