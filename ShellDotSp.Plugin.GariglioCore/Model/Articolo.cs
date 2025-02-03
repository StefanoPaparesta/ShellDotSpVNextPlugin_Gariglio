using System.ComponentModel;
using NPoco;

namespace ShellDotSp.Plugin.GariglioCore.Model
{
    [TableName("Articoli")]
    [PrimaryKey("Id", AutoIncrement = true)]
    public class Articolo
    {

        public int Id { get; set; }
        public string Descrizione { get; set; }
        public string Um { get; set; }
        public string UmDiluizione { get; set; }
        public decimal Diluizione { get; set; }
        public string Note { get; set; }
        public string Categoria { get; set; }
        public decimal QtaRifDiluizione { get; set; }
        public string CodiceArticoloFor { get; set; }
        public string ClassificazionePericolo { get; set; }
        public string MotivoTrattamento { get; set; }

    }

    public class ArticoloCollection
        : BindingList<Articolo>
    {

    }
}
