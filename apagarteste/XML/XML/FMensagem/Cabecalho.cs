
namespace XML.FMensagem
{
    /// <summary>
    /// Definição do cabeçalho das mensagens
    /// </summary>
    public class Cabecalho 
    {

        public int IdentificacaoPadrao { get; set; }
        public int Origem { get; set; }
        public int Destino { get; set; }
        public string VersaoPadrao { get; set; } = "2.00";

    }
}
