using System.ComponentModel;

namespace ShellDotSp.Plugin.GariglioCore.Model
{

    public class VArticolo
    {

        public int Id { get; set; }
        public string CodiceArticoloFor { get; set; }
        public string DescrizioneArticolo { get; set; }
        public string Um { get; set; }
        public string UmDiluizione { get; set; }
        public decimal Diluizione { get; set; }
        public string Note { get; set; }
        public string Categoria { get; set; }
        public decimal QtaRifDiluizione { get; set; }
        public bool Acquisto { get; set; }
        public bool Vendita { get; set; }
        public string ClassificazionePericolo { get; set; }
        public string MotivoTrattamento { get; set; }
        public string Tipo { get; set; }
        public string Codice { get; set; }
        public string DescrizioneCategoria { get; set; }

    }

    public class VArticoloCollection
        : BindingList<VArticolo>
    {

    }

}
