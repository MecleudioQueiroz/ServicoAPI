using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ServicoAPI.Models
{
    [Table("produto")]
    public class produto
    {
        [Key]
        public int ProdutoId { get; set; }
        public int FornecedorId { get; set; }
        public int CategoriaId { get; set; }
        public int SubCategoriaId { get; set; }
        public int MarcaId { get; set; }
        public int GrupoTribSaidaId { get; set; }
        //public int LinhasId { get; set; }
        public string Nome { get; set; }
        public string CodBarras { get; set; }
        public string CodOriginal { get; set; }
        public string Descricao { get; set; }

        //Variaveis valores do produto
        public decimal? VlrCompra { get; set; }
        public decimal? VlrMedio { get; set; }
        public decimal? VlrCusFinal { get; set; }
        public decimal VlrVenda { get; set; }

        public decimal? MargemLucro { get; set; }
        public decimal? DescMaximo { get; set; }
        public string Unidade { get; set; }
        public bool Ativo { get; set; }
        public bool PodeDesc { get; set; }
        public bool Fracionado { get; set; }
        public bool Perecivel { get; set; }
        public bool Comissao { get; set; }
        public string TipoProduto { get; set; }

        //Variaveis de Estoque
        public decimal QtdEstoque { get; set; }
        public decimal? EstoqMinimo { get; set; }
        public decimal? EstoqMaximo { get; set; }
        public decimal? EstoqAtu { get; set; }

        public string Embalagem { get; set; }
        public decimal? PesoLiq { get; set; }
        public decimal? PesoBru { get; set; }
        public string Locacao { get; set; }
        public byte[] ImagemUrl { get; set; }
        public string NomeImagem { get; set; }
        public DateTime? DtCompra { get; set; }
        public DateTime? DtVenda { get; set; }
        public DateTime? DtAcerto { get; set; }
        public DateTime? DtCadastro { get; set; }
        public DateTime? DtValidade { get; set; }

        //Variaveis de tributação
        public string CST { get; set; }
        public string CFOP { get; set; }
        public int ORIGEM { get; set; }
        public string COD_NCM { get; set; }
        public string CEST { get; set; }
        public decimal? ICMS_SAIDA { get; set; }
        public decimal? REDU_BASE_CALC { get; set; }
        public decimal? FCP { get; set; }
        public decimal? AliquotaIPI { get; set; }
        public string PIS { get; set; }
        public string COFINS { get; set; }
        public string IPI { get; set; }
    }
}