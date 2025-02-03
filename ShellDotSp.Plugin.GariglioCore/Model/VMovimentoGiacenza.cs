using System;
using System.ComponentModel;
using NPoco;

namespace ShellDotSp.Plugin.GariglioCore.Model
{

    [TableName("vw_MovimentiGiacenza")]
    [PrimaryKey("Id", AutoIncrement = false)]
    public class VMovimentoGiacenza
    {
        public int Id { get; set; }
        public DateTime DataCreazione { get; set; }
        public string Causale { get; set; }
        public string Lotto { get; set; }
        public string LottoOrigine { get; set; }
        public decimal Qta { get; set; }
        public decimal QtaPrecedente { get; set; }
        public string Ubicazione { get; set; }
        public string UbicazionePrecedente { get; set; }
        public string Formato { get; set; }
        public decimal QtaGiacenza { get; set; }
    }

    public class VMovimentoGiacenzaCollection :
        BindingList<VMovimentoGiacenza>
    {

    }

}
