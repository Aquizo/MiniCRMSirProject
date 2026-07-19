namespace MiniCRM.Application.DTOs.Contato
{
    public class ContatoCreateDto
    {
        public Guid ClienteId { get; set; }

        public string Assunto { get; set; } = string.Empty;

        public string Descricao { get; set; } = string.Empty;
    }
}