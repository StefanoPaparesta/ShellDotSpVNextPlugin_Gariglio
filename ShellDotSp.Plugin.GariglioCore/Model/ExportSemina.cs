using System;
using ShellDotSp.Plugin.GariglioCore.Util;

namespace ShellDotSp.Plugin.GariglioCore.Model
{
    public class ExportSemina
    {
        [XlsIgnore()]
        public int Id { get; set; }

        [XlsColumn("Tipo", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center)]
        public string Tipo { get; set; }

        [XlsColumn("Ciclo", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center)]
        public string CicloProduzione { get; set; }

        [XlsColumn("Data Documento", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center, Style = "dd/MM/yyyy")]
        public DateTime DataDocumento { get; set; }

        [XlsIgnore()]
        public int IdAnagrafica { get; set; }

        [XlsIgnore()]
        public string CodiceVarieta { get; set; }

        [XlsColumn("Varietà", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center)]
        public string DescVarieta { get; set; }

        [XlsColumn("Lotto Varietà", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center)]
        public string LottoVarieta { get; set; }

        [XlsColumn("N° Doc", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center)]
        public string NumeroDocumento { get; set; }

        [XlsColumn("Formato", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center)]
        public string CodiceFormato { get; set; }

        [XlsColumn("Peso Iniziale", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center, Style = "n3")]
        public decimal PesoInizialeSemente { get; set; }

        [XlsColumn("Peso Finale", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center, Style = "n3")]
        public decimal PesoFinaleSemente { get; set; }

        [XlsIgnore()]
        public string CodiceTrattamento { get; set; }

        [XlsColumn("Trattamento", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center)]
        public string DescrizioneTrattamento { get; set; }

        [XlsColumn("Lotto Trattamento", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center)]
        public string LottoTrattamento { get; set; }

        [XlsColumn("Lt acqua", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center, Style = "n3")]
        public decimal LitriAcquaTrattamento { get; set; }

        [XlsIgnore()]
        public string CodiceTorba { get; set; }

        [XlsColumn("Torba", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center)]
        public string DescrizioneTorba { get; set; }

        [XlsColumn("Lotto Torba", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center)]
        public string LottoTorba { get; set; }

        [XlsColumn("Materia Prima", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center)]
        public string DescrizioneMateriaPrima { get; set; }

        [XlsColumn("Lotto Materia Prima", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center)]
        public string LottoMateriaPrima { get; set; }

        [XlsColumn("UM Materia Prima", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center)]
        public string UmMateriaPrima { get; set; }

        [XlsColumn("Qta Materia Prima", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center, Style = "n3")]
        public decimal QtaMateriaPrima { get; set; }

        [XlsColumn("Ubicazione Materia Prima", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center)]
        public string UbicazioneMateriaPrima { get; set; }

    }
}
