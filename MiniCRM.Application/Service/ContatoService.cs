using MiniCRM.Application.DTOs.Contato;
using MiniCRM.Application.Interfaces;

namespace MiniCRM.Application.Services
{
    public class ContatoService : IContatoService
    {
        public async Task<IEnumerable<ContatoResponseDto>> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ContatoResponseDto>> ObterPorCliente(Guid clienteId)
        {
            throw new NotImplementedException();
        }

        public async Task Criar(ContatoCreateDto dto)
        {
            // DataContato = DateTime.Now
        }

        public async Task Atualizar(Guid id, ContatoUpdateDto dto)
        {
            // Atualizar contato
        }

        public async Task Excluir(Guid id)
        {
            // Excluir contato
        }
    }
}