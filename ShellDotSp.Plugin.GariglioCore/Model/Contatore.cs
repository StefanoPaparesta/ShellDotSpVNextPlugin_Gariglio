using NPoco;

namespace ShellDotSp.Plugin.GariglioCore.Model
    {
    [TableName("Contatori")]
    [PrimaryKey("Id", AutoIncrement = true)]
    public class Contatore
        {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Descrizione { get; set; }
        public int Valore { get; set; }
        public int Anno { get; set; }
        }
    }
