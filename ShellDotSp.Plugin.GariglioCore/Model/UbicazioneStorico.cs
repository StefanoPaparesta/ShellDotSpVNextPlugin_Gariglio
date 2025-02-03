using System;
using System.ComponentModel;
using NPoco;

namespace ShellDotSp.Plugin.GariglioCore.Model
{
    [TableName("UbicazioniStorico")]
    [PrimaryKey("Id", AutoIncrement = true)]
    public class UbicazioneStorico
    {
        public int Id { get; set; }
        public DateTime DataCreazione { get; set; }
        public DateTime? DataChiusura { get; set; }
        public string Ubicazione { get; set; }
        public string Lotto { get; set; }
    }

    public class UbicazioneStoricoCollection
         : BindingList<UbicazioneStorico>
    {

    }

}
