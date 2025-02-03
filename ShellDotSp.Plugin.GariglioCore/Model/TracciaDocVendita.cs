using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ShellDotSp.Plugin.GariglioCore.Model
{
    public class TracciaDocVendita
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public DateTime DataDocumento { get; set; }
        public string Numero { get; set; }
        public int IdAnagrafica { get; set; }
        public string RagioneSociale { get; set; }
        public string Articolo { get; set; }
        public string Um { get; set; }
        public decimal Qta { get; set; }
    }

    public class TracciaDocVenditaCollection
       : BindingList<TracciaDocVendita>
    {
        public TracciaDocVenditaCollection()
        {

        }

        public TracciaDocVenditaCollection(IList<TracciaDocVendita> Items)
            : base(Items)
        {

        }
    }
}
