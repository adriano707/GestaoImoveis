using Dominio.Entidades.Enum;

namespace Dominio.Entidades
{
    public class Imovel
    {       
        public int Id { get; set; }
        public TipoNegocio TipoNegocio { get; set; }
        public decimal Valor { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual int ClienteId { get; set; }
    }
}
