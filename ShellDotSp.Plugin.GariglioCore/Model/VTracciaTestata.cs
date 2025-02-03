using System;
using System.ComponentModel;

namespace ShellDotSp.Plugin.GariglioCore.Model
{
    public class VTracciaTestata
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string CicloProduzione { get; set; }
        public string CicloDescrizione { get; set; }
        public DateTime DataDocumento { get; set; }
        public int IdAnagrafica { get; set; }
        public string CodiceVarieta { get; set; }
        public string DescVarieta { get; set; }
        public string LottoVarieta { get; set; }
        public string NumeroDocumento { get; set; }
        public string CodiceFormato { get; set; }
        public decimal PesoInizialeSemente { get; set; }
        public decimal PesoFinaleSemente { get; set; }
        public string CodiceTrattamento { get; set; }
        public string DescrizioneTrattamento { get; set; }
        public string LottoTrattamento { get; set; }
        public decimal LitriAcquaTrattamento { get; set; }
        public string CodiceTorba { get; set; }
        public string DescrizioneTorba { get; set; }
        public string LottoTorba { get; set; }
        public decimal Qta { get; set; }
    }

    public class VTracciaTestataCollection
           : BindingList<VTracciaTestata>
    {

    }

}
