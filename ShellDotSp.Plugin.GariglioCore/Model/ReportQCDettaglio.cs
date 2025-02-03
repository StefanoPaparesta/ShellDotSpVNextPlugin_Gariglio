using System;
using System.ComponentModel;

namespace ShellDotSp.Plugin.GariglioCore.Model
{

    public class ReportQCDettaglio
    {

        public int IdTestata { get; set; }
        public DateTime DataDocumento { get; set; }
        public string DescArticolo { get; set; }
        public DateTime DataCreazione { get; set; }
        public DateTime DataChiusura { get; set; }
        public string Ubicazione { get; set; }
        public string UbicazioneCat { get; set; }
        public string Lotto { get; set; }
        public decimal Superficie { get; set; }
        public string TipoRiga { get; set; }
    }

    public class ReportQCDettaglioCollection
        : BindingList<ReportQCDettaglio>
    {

    }

}
