using System;
using System.Collections.Generic;
using System.ComponentModel;
using NPoco;

namespace ShellDotSp.Plugin.GariglioCore.Model
    {
    [TableName("vw_Documenti")]
    [PrimaryKey("Id", AutoIncrement = false)]
    public class VDocumento
        {

        public int IdTestata { get; set; }
        public string TipoDocumento { get; set; }
        public DateTime DataDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public int IdAnagrafica { get; set; }
        public int IdRiga { get; set; }
        public int IdArticolo { get; set; }
        public string DescArticolo { get; set; }
        public string Um { get; set; }
        public decimal Qta { get; set; }
        public string CodiceProduzione { get; set; }

        [Ignore]
        public List<DocumentoRiga> Dettaglio { get; set; }

        }
    public class VDocumentoCollection
           : BindingList<VDocumento>
        {

        }
    }
