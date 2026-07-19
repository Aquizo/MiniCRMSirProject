using MiniCRM.Application.DTOs.Cliente;

namespace MiniCRM.Application.Interfaces
{
    public interface IClienteService
    {
        Task<IEnumerable<ClienteResponseDto>> ObterTodos();

        Task<ClienteResponseDto?> ObterPorId(Guid id);

        Task Criar(ClienteCreateDto dto);

        Task Atualizar(Guid id, ClienteUpdateDto dto);

        Task Excluir(Guid id);
    }
}