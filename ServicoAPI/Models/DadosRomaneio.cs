using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ServicoAPI.Models
{
    public partial class DadosRomaneio
    {
        [Key]
        public int Id { get; set; }
        public int Arvore { get; set; }
        public int Picada { get; set; }
        public int Upa { get; set; }
        public string Nome { get; set; }
        public double Cap { get; set; }
        public double Dap { get; set; }
        public double Altura { get; set; }
        public double Volume { get; set; }
    }
}