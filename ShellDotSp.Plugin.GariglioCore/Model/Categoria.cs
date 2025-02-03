using System.ComponentModel;
using NPoco;

namespace ShellDotSp.Plugin.GariglioCore.Model
{

    [TableName("Categorie")]
    [PrimaryKey("Id", AutoIncrement = true)]
    public class Categoria
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Codice { get; set; }
        public string Descrizione { get; set; }
    }

    public class CategoriaCollection
       : BindingList<Categoria>
    {

    }

}
