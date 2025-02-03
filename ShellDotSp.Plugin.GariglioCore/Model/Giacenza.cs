using System;
using System.Collections.Generic;
using System.ComponentModel;
using ShellDotSp.Plugin.GariglioCore.Util;

namespace ShellDotSp.Plugin.GariglioCore.Model
{

    public class Giacenza
    {
        [XlsColumn("Data DocumGiacenzaento", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center, Style = "dd/MM/yyyy")]
        public DateTime DataGiacenza { get; set; }

        [XlsColumn("Lotto", Width = 200)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center)]
        public string Lotto { get; set; }

        [XlsIgnore()]
        public int IdArticolo { get; set; }

        [XlsColumn("Materiale", Width = 250)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Left)]
        public string DescrizioneArticolo { get; set; }

        [XlsIgnore()]
        public string Categoria { get; set; }

        [XlsColumn("Categoria", Width = 200)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center)]
        public string CategoriaDescrizione { get; set; }

        [XlsColumn("UM", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center)]
        public string UM { get; set; }

        [XlsColumn("QTA", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center, Style = "n3")]
        public string Qta { get; set; }
    }

    public class GiacenzaCollection
        : BindingList<Giacenza>
    {
        public GiacenzaCollection()
        {

        }
        public GiacenzaCollection(IList<Giacenza> Items)
            : base(Items)
        {

        }
    }

}
