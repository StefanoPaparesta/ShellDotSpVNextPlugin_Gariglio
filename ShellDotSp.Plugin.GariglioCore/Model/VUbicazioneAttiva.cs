using System.ComponentModel;
using NPoco;

namespace ShellDotSp.Plugin.GariglioCore.Model
{
    [TableName("vw_UbicazioniAttive")]
    [PrimaryKey("Id", AutoIncrement = false)]
    public class VUbicazioneAttiva
    {
        public int Id { get; set; }
        public string Codice { get; set; }
        public string Categoria { get; set; }
        public bool RichiediConfermaChiusura { get; set; }
        public bool RichiediQuantita { get; set; }
        public decimal QtaPredefinita { get; set; }
        public string Lotto { get; set; }
        public string Raggruppamento { get; set; }
        public decimal Superficie { get; set; }
        public string Descrizione { get; set; }
        public decimal Qta { get; set; }
    }

    public class VUbicazioneAttivaCollection
           : BindingList<VUbicazioneAttiva>
    {

    }

}
