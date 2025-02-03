using System;
using System.ComponentModel;
using NPoco;
using ShellDotSp.Plugin.GariglioCore.Util;

namespace ShellDotSp.Plugin.GariglioCore.Model
{

    public class ReportBilancioMassaDto
    {

        [XlsColumn("Lotto", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center)]
        public string Lotto { get; set; }

        [XlsColumn("Data Semina", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center, Style = "dd/MM/yyyy")]
        public DateTime DataSemina { get; set; }

        [XlsColumn("Varietà", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center)]
        public string DescVarieta { get; set; }

        [XlsColumn("Formato Semina", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center)]
        public string CodiceFormato { get; set; }

        [XlsIgnore]
        public string DescrizioneTrattamento { get; set; }

        [XlsIgnore]
        public decimal LitriAcquaTrattamento { get; set; }

        [XlsIgnore]
        public string LottoTorma { get; set; }

        [XlsColumn("Torba", Width = 200)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Left)]
        public string DescrizioneTorba { get; set; }

        [XlsColumn("Data Trapianto", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center, Style = "dd/MM/yyyy")]
        public DateTime? DataTrapianto { get; set; }

        [XlsColumn("Formato Trapianto", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center)]
        public string FormatoConf { get; set; }

        [XlsIgnore]
        public string Formato { get; set; }

        [XlsIgnore]
        public string LottoProduzione { get; set; }

        [Ignore]
        [XlsColumn("Qta Trapiantata", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center, Style = "n0")]
        public decimal QtaTrapiantata
        {
            get { return QtaCarico + QtaDist; }

        }

        [XlsColumn("Qta Carico", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center, Style = "n0")]
        public decimal QtaCarico { get; set; }

        [XlsColumn("Qta Distruzione", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center, Style = "n0")]
        public decimal QtaDist { get; set; }

        [XlsColumn("Qta Scarico", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center, Style = "n0")]
        public decimal QtaScarico { get; set; }
    }

    public class ReportBilancioMassaDtoCollection
        : BindingList<ReportBilancioMassaDto>
    {

    }

}
