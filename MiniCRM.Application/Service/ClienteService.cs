using MiniCRM.Application.DTOs.Cliente;
using MiniCRM.Application.Interfaces;

namespace MiniCRM.Application.Services
{
    public class ClienteService : IClienteService
    {
        public async Task<IEnumerable<ClienteResponseDto>> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public async Task<ClienteResponseDto?> ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task Criar(ClienteCreateDto dto)
        {
            // Validar CPF/CNPJ duplicado
            // Salvar cliente
        }

        public async Task Atualizar(Guid id, ClienteUpdateDto dto)
        {
            // Atualizar cliente
        }

        public async Task Excluir(Guid id)
        {
            // Não permitir excluir cliente que possui contatos
        }
    }
}