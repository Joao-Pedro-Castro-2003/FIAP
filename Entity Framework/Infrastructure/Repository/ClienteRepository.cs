using Core.Entity;
using Core.Input;
using Core.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Infrastructure.Repository
{
    public class ClienteRepository : EFRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(ApplicationDbContext context) : base(context)
        {   
        }

        public ClienteDto ObterPedidosSeisMeses(int id)
        {
            var cliente = _context.Cliente
                .FirstOrDefault(c => c.Id == id)
                ?? throw new Exception("Esse cliente não existe");

            return new ClienteDto()
            {
                Id = cliente.Id,
                DataCriacao = cliente.DataCriacao,
                Nome = cliente.Nome,
                DataDeNascimento = cliente.DataDeNascimento,
                CPF = cliente.CPF,
                Pedidos = cliente.Pedidos
                .Where(c => c.DataCriacao >= DateTime.Now.AddMonths(-6))
                .Select(p => new PedidoDto()
                {
                    Id = p.Id,
                    DataCriacao = p.DataCriacao,
                    LivroId = p.LivroId,
                    ClienteId = p.ClienteId,
                    Livro = new LivroDto()
                    {
                        Id = p.Livro.Id,
                        DataCriacao = p.Livro.DataCriacao,
                        Nome = p.Livro.Nome,
                        Editora = p.Livro.Editora
                    }
                }).ToList()
            };
        }
    }
}
