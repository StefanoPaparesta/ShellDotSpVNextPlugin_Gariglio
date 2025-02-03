using System;
using ShellDotSp.Plugin.GariglioCore.Util;

namespace ShellDotSp.Plugin.GariglioCore.Model
{
    public class ExportQC
    {

        [XlsIgnore()]
        public int Id { get; set; }

        [XlsColumn("Ciclo", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center)]
        public string CicloProduzione { get; set; }

        [XlsColumn("Data Documento", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center, Style = "dd/MM/yyyy")]
        public DateTime DataDocumento { get; set; }

        [XlsColumn("Prodotto", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center)]
        public string NomeProdotto { get; set; }

        [XlsColumn("Lotto", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center)]
        public string Lotto { get; set; }

        [XlsColumn("Classificazione", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center)]
        public string ClassificazionePericolo { get; set; }

        [XlsColumn("Motivo Tratt.", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center)]
        public string MotivoTrattamento { get; set; }

        [XlsColumn("Litri Acqua", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center)]
        public decimal LitriAcquaTrattamento { get; set; }

        [XlsColumn("UM", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center)]
        public string UM { get; set; }

        [XlsColumn("Qta", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center, Style = "n3")]
        public decimal Qta { get; set; }

        [XlsColumn("Superificie", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center, Style = "n3")]
        public decimal Superficie { get; set; }

        [XlsIgnore()]
        public int IdTestata { get; set; }

        [XlsIgnore()]
        public DateTime DataDocumentoUbicazione { get; set; }

        [XlsColumn("Descrizione Ubicazione", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center)]
        public string DescArticolo { get; set; }

        [XlsColumn("Data Apertura", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center, Style = "dd/MM/yyyy")]
        public DateTime DataCreazione { get; set; }

        [XlsColumn("Data Chiusura", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center, Style = "dd/MM/yyyy")]
        public DateTime? DataChiusura { get; set; }

        [XlsColumn("Ubicazione", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center)]
        public string Ubicazione { get; set; }

        [XlsColumn("Ubicazione Cat", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center)]
        public string UbicazioneCat { get; set; }

        [XlsColumn("Lotto Ubicazione", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center)]
        public string LottoUbicazione { get; set; }

        [XlsIgnore()]
        public decimal SuperficieUbicazione { get; set; }

    }
}
