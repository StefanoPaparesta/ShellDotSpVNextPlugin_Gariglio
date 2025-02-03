using System.ComponentModel;
using NPoco;

namespace ShellDotSp.Plugin.GariglioCore.Model
    {
    [TableName("Anagrafiche")]
    [PrimaryKey("Id")]
    public class Anagrafica
        {

        public int Id { get; set; }
        public string Tipo { get; set; }
        public string RagioneSociale { get; set; }
        public string Indirizzo { get; set; }
        public string Localita { get; set; }
        public string Provincia { get; set; }
        public string Cap { get; set; }
        public string CodiceFiscale { get; set; }
        public string PartitaIva { get; set; }

        }

    public class AnagraficaCollection
            : BindingList<Anagrafica>
        {

        }
    }
