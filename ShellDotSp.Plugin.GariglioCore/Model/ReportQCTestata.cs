using NPoco;

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ShellDotSp.Plugin.GariglioCore.Model
{

    public class ReportQCTestata
    {

        public ReportQCTestata()
        {
            Dettaglio = new List<ReportQCDettaglio>();
        }

        public int Id { get; set; }
        public string CicloProduzione { get; set; }
        public DateTime DataDocumento { get; set; }
        public string NomeProdotto { get; set; }
        public string Lotto { get; set; }
        public string ClassificazionePericolo { get; set; }
        public string MotivoTrattamento { get; set; }
        public decimal LitriAcquaTrattamento { get; set; }
        public string UM { get; set; }
        public decimal Qta { get; set; }
        public decimal Superficie { get; set; }
        public string TipoRiga { get; set; }

        [Ignore]
        public List<ReportQCDettaglio> Dettaglio { get; set; }

    }

    public class ReportQCTestataCollection
        : BindingList<ReportQCTestata>
    {

    }

}
