using System.ComponentModel;
using ShellDotSp.Plugin.GariglioCore.Util;

namespace ShellDotSp.Plugin.GariglioCore.Model
{
    public class VTracciaMateriePrime
    {
        [XlsIgnore()]
        public int IdMovimento { get; set; }
        [XlsIgnore()]
        public int IdDocTestata { get; set; }

        [XlsColumn("Descrizione", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center)]
        public string Descrizione { get; set; }

        [XlsColumn("Lotto", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center)]
        public string Lotto { get; set; }

        [XlsColumn("UM", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center)]
        public string UM { get; set; }

        [XlsColumn("Qta", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center, Style = "n3")]
        public decimal Qta { get; set; }

        [XlsColumn("Ubicazione", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center)]
        public string Ubicazione { get; set; }

    }

    public class VTracciaMateriePrimeCollection
         : BindingList<VTracciaMateriePrime>
    {

    }
}
