namespace MiniCRM.Application.DTOs.Cliente
{
    public class ClienteResponseDto
    {
        public Guid Id { get; set; }

        public string Nome { get; set; } = string.Empty;

        public string CpfCnpj { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Telefone { get; set; } = string.Empty;
    }
}