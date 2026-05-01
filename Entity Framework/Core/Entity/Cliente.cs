namespace Core.Entity
{
    public class Cliente : EntityBase
    {
        public required string Nome { get; set; }
        public DateTime? DataDeNascimento { get; set; }
        public required string CPF { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
