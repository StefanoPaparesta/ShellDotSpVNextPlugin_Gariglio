using System;
using System.ComponentModel;
using NPoco;

namespace ShellDotSp.Plugin.GariglioCore.Model
{
    [TableName("ProgIrrigazioni")]
    [PrimaryKey("Id", AutoIncrement = true)]
    public class ProgIrrigazione
    {

        public int Id { get; set; }
        public string CodiceProgramma { get; set; }
        public string Descrizione { get; set; }
        public int PartiA { get; set; }
        public int PartiB { get; set; }
        public int PartiC { get; set; }
        public int PartiD { get; set; }
        public decimal Conducibilita { get; set; }
        public decimal Ph { get; set; }
        public int AperturaEVPh { get; set; }
        public int Ev1 { get; set; }
        public int Ev2 { get; set; }
        public int Ev3 { get; set; }
        public int Ev4 { get; set; }
        public int Ev5 { get; set; }
        public int Ev6 { get; set; }
        public int Durata { get; set; }
        public DateTime? DataInizioUtilizzo { get; set; }
        public DateTime? DataFineUtilizzo { get; set; }

    }

    public class ProgIrrigazioneCollection
         : BindingList<ProgIrrigazione>
    {

    }
}
