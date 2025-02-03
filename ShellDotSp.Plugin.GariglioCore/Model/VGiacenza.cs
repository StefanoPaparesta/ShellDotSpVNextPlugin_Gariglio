using System.ComponentModel;

namespace ShellDotSp.Plugin.GariglioCore.Model
    {
    public class VGiacenza
        {
        public string Lotto { get; set; }
        public int IdArticolo { get; set; }
        public string Descrizione { get; set; }
        public string Categoria { get; set; }
        public decimal Giacenza { get; set; }
        }

    public class VGiacenzaCollection
           : BindingList<VGiacenza>
        {

        }
    }
