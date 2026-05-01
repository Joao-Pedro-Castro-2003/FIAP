using Core.Dto;

namespace Core.Repository
{
    public interface IBibliotecaRepository 
    {
        void AdicionarJogo(int usuarioId, int jogoId);
        IList<JogoDisponivelDto> ObterBibliotecaUsuario(int usuarioId);
    }
}
