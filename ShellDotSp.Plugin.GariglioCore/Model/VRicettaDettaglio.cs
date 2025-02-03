using System.ComponentModel;
using NPoco;

namespace ShellDotSp.Plugin.GariglioCore.Model
{
    [TableName("vw_RicetteDettaglio")]
    [PrimaryKey("Id", AutoIncrement = false)]
    public class VRicettaDettaglio
    {
        public int Id { get; set; }
        public int IdTestata { get; set; }
        public int IdArticolo { get; set; }
        public string DescrizioneArticolo { get; set; }
        public decimal Qta { get; set; }
        public string CodiceTanica { get; set; }
        public string DescrizioneUbicazione { get; set; }
    }

    public class VRicettaDettaglioCollection
           : BindingList<VRicettaDettaglio>
    {

    }

}
