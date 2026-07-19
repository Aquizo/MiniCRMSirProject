namespace MiniCRM.Application.DTOs.Contato
{
    public class ContatoResponseDto
    {
        public Guid Id { get; set; }

        public Guid ClienteId { get; set; }

        public string Assunto { get; set; } = string.Empty;

        public string Descricao { get; set; } = string.Empty;

        public DateTime DataContato { get; set; }
    }
}