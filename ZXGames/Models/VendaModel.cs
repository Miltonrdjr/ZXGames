namespace ZXGames.Models
{
    public class VendaModel
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public string Jogo { get; set; }
        public string Vendedor { get; set; }
        public DateTime DataDeVenda { get; set; } = DateTime.Now;
    }
}
