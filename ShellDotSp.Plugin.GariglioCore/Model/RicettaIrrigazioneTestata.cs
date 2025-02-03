using System;
using System.ComponentModel;
using NPoco;

namespace ShellDotSp.Plugin.GariglioCore.Model
    {
    [TableName("RicetteIrrigazioneTestate")]
    [PrimaryKey("Id", AutoIncrement = true)]
    public class RicettaIrrigazioneTestata
        {
        public int Id { get; set; }
        public string Descrizione { get; set; }
        public DateTime? DataInizioUtilizzo { get; set; }
        public DateTime? DataFineUtilizzo { get; set; }
        }
    public class RicettaIrrigazioneTestataCollection
           : BindingList<RicettaIrrigazioneTestata>
        {

        }
    }
