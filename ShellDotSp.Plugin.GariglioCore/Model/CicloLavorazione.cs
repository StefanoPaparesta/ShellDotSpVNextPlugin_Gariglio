using System.ComponentModel;
using NPoco;

namespace ShellDotSp.Plugin.GariglioCore.Model
{

    [TableName("CicliLavorazione")]
    [PrimaryKey("Id", AutoIncrement = true)]
    public class CicloLavorazione
    {
        public int Id { get; set; }
        public string Codice { get; set; }
        public string Descrizione { get; set; }
    }

    public class CicloLavorazioneCollection
       : BindingList<CicloLavorazione>
    {

    }

}
