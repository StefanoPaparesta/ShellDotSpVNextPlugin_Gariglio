using System;
using System.ComponentModel;

namespace ShellDotSp.Plugin.GariglioCore.Model
{
    public class VReportCaricoScarico
    {
        public int Ordinale { get; set; }
        public string RagioneSociale { get; set; }
        public int IdAnagrafica { get; set; }
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Numero { get; set; }
        public DateTime DataDocumento { get; set; }
        public string Lotto { get; set; }
        public string UM { get; set; }
        public decimal TotQta { get; set; }
    }

    public class VReportCaricoScaricoCollection
       : BindingList<VReportCaricoScarico>
    {

    }

}
