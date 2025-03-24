using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Comandas.Api.Models
{
    public class Comanda
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int NumeroMesa { get; set; }

        public string NomeCliente { get; set; }

        public int SituacaoComanda { get; set; }
        public virtual ICollection<ComandaItem> ComandaItems { get; set; }
    }
}
