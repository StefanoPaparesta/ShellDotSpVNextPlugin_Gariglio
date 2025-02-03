using System;
using System.ComponentModel;
using ShellDotSp.Plugin.GariglioCore.Util;

namespace ShellDotSp.Plugin.GariglioCore.Model
{
    public class VReportMateriaPrima
    {
        [XlsColumn("Data Documento", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center, Style = "dd/MM/yyyy")]
        public DateTime DataDocumento { get; set; }

        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center)]
        [XlsColumn("N° Documento", Width = 150)]
        public string Numero { get; set; }

        [XlsColumn("Ragione sociale", Width = 150)]
        public string RagioneSociale { get; set; }

        [XlsColumn("Partita iva", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center)]
        public string PartitaIva { get; set; }

        [XlsColumn("Qualifica", Width = 150)]
        public string Qualifica { get; set; }

        public string Descrizione { get; set; }

        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center)]
        public string Lotto { get; set; }

        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center)]
        public string Um { get; set; }

        [XlsColumn("Qta", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center)]
        public decimal Qta { get; set; }
    }

    public class VReportMateriaPrimaCollection
          : BindingList<VReportMateriaPrima>
    {

    }
}
