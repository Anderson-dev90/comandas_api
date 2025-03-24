namespace Comandas.Api.Models
{
    public class ComandaItem
    {
        public int Id { get; set; }
        public int CardapioItemId { get; set; }
        public virtual CardapioItem CardapioItem { get; set; }
        public int ComandaId { get; set; }
        public virtual Comanda Comanda { get; set; }
    }
}
