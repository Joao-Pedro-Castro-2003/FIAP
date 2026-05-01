using Core.Dto;
using Core.Repository;

namespace Infrastructure.Repository
{ 
    public class BibliotecaRepository : IBibliotecaRepository
    {
        private readonly ApplicationDbContext _context;

        public BibliotecaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AdicionarJogo(int usuarioId, int jogoId)
        {
            throw new NotImplementedException();
        }

        public IList<JogoDisponivelDto> ObterBibliotecaUsuario(int usuarioId)
        {
            throw new NotImplementedException();
        }
    }
}
