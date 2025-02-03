using System.ComponentModel;
using NPoco;

namespace ShellDotSp.Plugin.GariglioCore.Model
    {
    [TableName("RicetteIrrigazioneDettaglio")]
    [PrimaryKey("Id", AutoIncrement = true)]
    public class RicettaIrrigazioneDettaglio
        {

        public int Id { get; set; }
        public int IdTestata { get; set; }
        public int IdArticolo { get; set; }
        public decimal Qta { get; set; }
        public string CodiceTanica { get; set; }

        }
    public class RicettaIrrigazioneDettaglioCollection
           : BindingList<RicettaIrrigazioneDettaglio>
        {

        }
    }
