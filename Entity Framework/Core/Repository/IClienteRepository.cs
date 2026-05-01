using Core.Entity;
using Core.Input;

namespace Core.Repository
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        ClienteDto ObterPedidosSeisMeses(int id);
    }
}
