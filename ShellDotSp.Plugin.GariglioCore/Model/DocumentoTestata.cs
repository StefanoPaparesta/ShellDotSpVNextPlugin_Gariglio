using System;
using System.Collections.Generic;
using System.ComponentModel;
using NPoco;

namespace ShellDotSp.Plugin.GariglioCore.Model
{
    [TableName("DocumentiTestate")]
    [PrimaryKey("Id", AutoIncrement = true)]
    public class DocumentoTestata
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string CicloProduzione { get; set; }
        public DateTime DataDocumento { get; set; }
        public string Numero { get; set; }
        public int IdAnagrafica { get; set; }

        [Ignore]
        public List<DocumentoRiga> Dettaglio { get; set; } =
            new List<DocumentoRiga>();

    }
    public class DocumentoTestataCollection
        : BindingList<DocumentoTestata>
    {

    }
}
