using System.ComponentModel;
using NPoco;

namespace ShellDotSp.Plugin.GariglioCore.Model
{
    [TableName("UnitaMisura")]
    [PrimaryKey("Id", AutoIncrement = true)]
    public class UnitaMisura
    {
        public int Id { get; set; }
        public string Codice { get; set; }
        public string Descrizione { get; set; }
    }

    public class UnitaMisuraCollection :
        BindingList<UnitaMisura>
    {

    }

}
