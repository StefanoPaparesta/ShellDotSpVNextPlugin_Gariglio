using System.ComponentModel;
using NPoco;

namespace ShellDotSp.Plugin.GariglioCore.Model
    {
    [TableName("DocumentiRighe")]
    [PrimaryKey("Id", AutoIncrement = true)]
    public class DocumentoRiga
        {

        public int Id { get; set; }
        public int IdTestata { get; set; }
        public int IdArticolo { get; set; }
        public string Um { get; set; }
        public decimal Qta { get; set; }
        public string Lotto { get; set; }
        public decimal PrezzoAcquisto { get; set; }

        }
    public class DocumentoRigaCollection
      : BindingList<DocumentoRiga>
        {

        }
    }
