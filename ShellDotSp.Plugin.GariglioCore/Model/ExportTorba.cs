using System;
using ShellDotSp.Plugin.GariglioCore.Util;

namespace ShellDotSp.Plugin.GariglioCore.Model
{
    public class ExportTorba
    {
        [XlsIgnore()]
        public int Id { get; set; }

        [XlsIgnore()]
        public string Tipo { get; set; }

        [XlsIgnore()]
        public string CicloProduzione { get; set; }

        [XlsColumn("Data Documento", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center, Style = "dd/MM/yyyy")]
        public DateTime DataDocumento { get; set; }

        [XlsIgnore()]
        public int IdAnagrafica { get; set; }

        [XlsIgnore()]
        public string CodiceVarieta { get; set; }

        [XlsIgnore()]
        public string DescVarieta { get; set; }

        [XlsIgnore()]
        public string LottoVarieta { get; set; }

        [XlsIgnore()]
        public string NumeroDocumento { get; set; }

        [XlsIgnore()]
        public string CodiceFormato { get; set; }

        [XlsIgnore()]
        public decimal PesoInizialeSemente { get; set; }

        [XlsIgnore()]
        public decimal PesoFinaleSemente { get; set; }

        [XlsIgnore()]
        public string CodiceTrattamento { get; set; }

        [XlsIgnore()]
        public string DescrizioneTrattamento { get; set; }

        [XlsIgnore()]
        public string LottoTrattamento { get; set; }

        [XlsIgnore()]
        public decimal LitriAcquaTrattamento { get; set; }

        [XlsIgnore()]
        public string CodiceTorba { get; set; }

        [XlsIgnore()]
        public string DescrizioneTorba { get; set; }

        [XlsIgnore()]
        public string LottoTorba { get; set; }

        [XlsColumn("Materiale", Width = 250)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Left)]
        public string DescrizioneMateriaPrima { get; set; }

        [XlsColumn("Lotto", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center)]
        public string LottoMateriaPrima { get; set; }

        [XlsColumn("UM", Width = 80)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center)]
        public string UmMateriaPrima { get; set; }

        [XlsColumn("Qta", Width = 80)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center, Style = "n0")]
        public decimal QtaMateriaPrima { get; set; }

        [XlsColumn("Ubicazione", Width = 80)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center)]
        public string UbicazioneMateriaPrima { get; set; }

    }
}
