using MiniCRM.Application.DTOs.Contato;

namespace MiniCRM.Application.Interfaces
{
    public interface IContatoService
    {
        Task<IEnumerable<ContatoResponseDto>> ObterTodos();

        Task<IEnumerable<ContatoResponseDto>> ObterPorCliente(Guid clienteId);

        Task Criar(ContatoCreateDto dto);

        Task Atualizar(Guid id, ContatoUpdateDto dto);

        Task Excluir(Guid id);
    }
}