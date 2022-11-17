using System.Xml.Serialization;
using XML.FMensagem;

namespace XML 
{
    /// <summary>
    /// Define as propriedades da mensagem que comporá o arquivo da ABI
    /// </summary>

    [Serialize]
    [XmlRoot("MensagemABI")]

    public class Mensagem 
    {
        [XmlElement("cabecalho")]
        public Cabecalho Cabecalho { get; set; }

        [XmlElement("corpoMensagem")]
        public int Corpo { get; set; }

        [XmlElement("epilogo")]
        public Epilogo Epilogo { get; set; }

    }
}
