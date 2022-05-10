namespace Proeventos.Domain
{
    public class RedeSocial
    {
        public int Id { get; set; }
        public int Nome { get; set; }
        public int Url { get; set; }
        public int? EventoId { get; set; }
        public Evento Evento { get; set; }
        public int? PalestranteId { get; set; }
        public Palestrante Palestrante { get; set; }
    }
}