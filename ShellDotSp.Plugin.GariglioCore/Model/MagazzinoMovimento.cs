using System;
using System.ComponentModel;
using NPoco;

namespace ShellDotSp.Plugin.GariglioCore.Model
{
    [TableName("MagazzinoMovimenti")]
    [PrimaryKey("Id", AutoIncrement = true)]
    public class MagazzinoMovimento
    {

        public int Id { get; set; }
        public int IdArticolo { get; set; }
        public int IdDocTestata { get; set; }
        public int IdDocRiga { get; set; }
        public DateTime TsCreazione { get; set; }
        public decimal Qta { get; set; }
        public string CodiceMagazzino { get; set; }
        public string Causale { get; set; }
        public string Lotto { get; set; }
        public string LottoOrigine { get; set; }
        public string UM { get; set; }
        public string Ubicazione { get; set; }
        public string UbicazionePrecedente { get; set; }
        public string Formato { get; set; }
        public decimal AlveoliPerMazzetti { get; set; }
        public int ValutazioneMazzetti { get; set; }
        public int ValutazioneVaso { get; set; }
        public string FormatoConf { get; set; }
        public decimal QtaPrecedente { get; set; }

    }

    public class MagazzinoMovimentoCollection
           : BindingList<MagazzinoMovimento>
    {

    }

}
