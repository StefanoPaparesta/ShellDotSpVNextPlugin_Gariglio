using System.ComponentModel;

namespace ShellDotSp.Plugin.GariglioCore.Model
{

    public class TipoDocumento
    {
        public string Codice { get; set; }
        public string Descrizione { get; set; }
    }

    public class TipoDocumentoCollection
        : BindingList<TipoDocumento>
    {

        public TipoDocumentoCollection()
        {

            this.Add(new TipoDocumento()
            {
                Codice = "DDT",
                Descrizione = "DDT"
            });

            this.Add(new TipoDocumento()
            {
                Codice = "FIM",
                Descrizione = "Fattura Immediata"
            });

        }

    }

}
