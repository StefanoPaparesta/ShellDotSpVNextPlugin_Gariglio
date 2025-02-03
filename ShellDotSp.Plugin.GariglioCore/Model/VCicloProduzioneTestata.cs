using System;
using System.ComponentModel;

namespace ShellDotSp.Plugin.GariglioCore.Model
{
    public class VCicloProduzioneTestata
    {

        public int Id { get; set; }
        public string Tipo { get; set; }
        public string CicloProduzione { get; set; }
        public string DescrizioneCicloProduzione { get; set; }
        public DateTime DataDocumento { get; set; }
        public string Lotto { get; set; }
        public string CodiceVarieta { get; set; }
        public string LottoSeme { get; set; }
        public string CodiceFormato { get; set; }
        public decimal? PesoSemente { get; set; }
        public string CodiceTrattamento { get; set; }
        public string LottoTratt { get; set; }
        public decimal LitriAcquaTrattamento { get; set; }
        public string CodiceTorba { get; set; }
        public string LottoTorba { get; set; }

    }

    public class VCicloProduzioneTestataCollection
           : BindingList<VCicloProduzioneTestata>
    {

    }

}
