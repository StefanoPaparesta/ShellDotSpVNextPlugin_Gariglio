using System;
using System.ComponentModel;
using NPoco;

namespace ShellDotSp.Plugin.GariglioCore.Model
{
    [TableName("vw_StatsPivotVendite")]
    [PrimaryKey("IdTestata,IdRiga", AutoIncrement = false)]
    public class VStatsPivotVendita
    {
        public int IdTestata { get; set; }
        public int IdRiga { get; set; }
        public string Tipo { get; set; }
        public string TipoDescrizione { get; set; }
        public DateTime DataDocumento { get; set; }
        public string Numero { get; set; }
        public int IdAnagrafica { get; set; }
        public string RagioneSociale { get; set; }
        public int IdArticolo { get; set; }
        public string DescrizioneArticolo { get; set; }
        public string Um { get; set; }
        public decimal Qta { get; set; }
    }

    public class VStatsPivotVenditaCollection
          : BindingList<VStatsPivotVendita>
    {

    }

}
