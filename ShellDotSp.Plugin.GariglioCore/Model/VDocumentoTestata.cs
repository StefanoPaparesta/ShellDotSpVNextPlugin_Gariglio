using System;
using System.ComponentModel;
using NPoco;

namespace ShellDotSp.Plugin.GariglioCore.Model
    {
    [TableName("vw_DocumentiTestata")]
    [PrimaryKey("Id", AutoIncrement = false)]
    public class VDocumentoTestata
        {
        public int IdTestata { get; set; }
        public string TipoDocumento { get; set; }
        public DateTime DataDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public int IdAnagrafica { get; set; }
        public string RagioneSociale { get; set; }
        }

    public class VDocumentoTestataCollection
           : BindingList<VDocumentoTestata>
        {

        }

    }
