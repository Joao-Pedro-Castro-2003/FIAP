using System;
using System.Collections.Generic;

namespace Infrasctructure.Scaffold;

public partial class Cliente
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public DateTime? DataDeNascimento { get; set; }

    public DateTime DataCriacao { get; set; }

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
