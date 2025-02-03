using System;
using System.ComponentModel;
using NPoco;

namespace ShellDotSp.Plugin.GariglioCore.Model
    {
    [TableName("MagazzinoGiacenze")]
    [PrimaryKey("Id", AutoIncrement = true)]
    public class MagazzinoGiacenza
        {
        public int Id { get; set; }
        public int IdArticolo { get; set; }
        public string Lotto { get; set; }
        public string UM { get; set; }
        public DateTime? DataGiacenza { get; set; }
        public Boolean Chiuso { get; set; }
        }

    public class MagazzinoGiacenzaCollection
       : BindingList<MagazzinoGiacenza>
        {

        }

    }
