using System;
using System.Collections.Generic;
using System.ComponentModel;
using ShellDotSp.Plugin.GariglioCore.Util;

namespace ShellDotSp.Plugin.GariglioCore.Model
{

    public class GiacenzaMovimento
    {
        [XlsIgnore()]
        public int Id { get; set; }

        [XlsColumn("Data Documento", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center, Style = "dd/MM/yyyy")]
        public DateTime DataDocumento { get; set; }

        [XlsIgnore()]
        public int IdArticolo { get; set; }

        [XlsColumn("Materiale", Width = 250)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Left)]
        public string DescrizioneArticolo { get; set; }

        [XlsColumn("Categoria", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center)]
        public string DescrizioneCategoria { get; set; }

        [XlsColumn("Lotto", Width = 200)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center)]
        public string Lotto { get; set; }

        //[XlsColumn("Codice Causale", Width = 150)]
        //[XlsRow(HorizontallAlignment = HorizontalAlignment.Center)]
        [XlsIgnore()]
        public string Causale { get; set; }

        [XlsColumn("Causale", Width = 250)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Left)]
        public string DescrizioneCausale { get; set; }

        [XlsColumn("UM", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center)]
        public string UM { get; set; }

        [XlsColumn("QTA", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center, Style = "n3")]
        public decimal Qta { get; set; }

    }

    public class GiacenzaMovimentoCollection
        : BindingList<GiacenzaMovimento>
    {
        public GiacenzaMovimentoCollection()
        {

        }
        public GiacenzaMovimentoCollection(IList<GiacenzaMovimento> Items)
           : base(Items)
        {

        }
    }

}
