using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ShellDotSp.Plugin.GariglioCore.Model
{
    public class Traccia
    {

        public int Id { get; set; }
        public string CicloProduzione { get; set; }
        public string CicloProduzioneDesc { get; set; }
        public DateTime DataDocumento { get; set; }
        public string NomeProdotto { get; set; }
        public string Lotto { get; set; }
        public string Descrizione1 { get; set; }
        public string Descrizione2 { get; set; }
        public string UM { get; set; }
        public decimal Qta { get; set; }
    }

    public class TracciaCollection
        : BindingList<Traccia>
    {
        public TracciaCollection()
        {

        }

        public TracciaCollection(IList<Traccia> Items)
            : base(Items)
        {

        }
    }

}
