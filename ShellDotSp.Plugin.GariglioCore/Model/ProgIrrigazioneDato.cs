using System;
using System.ComponentModel;
using NPoco;
using ShellDotSp.Plugin.GariglioCore.Util;

namespace ShellDotSp.Plugin.GariglioCore.Model
{
    [TableName("ProgIrrigazioniDati")]
    [PrimaryKey("Id", AutoIncrement = true)]
    public class ProgIrrigazioneDato
    {
        [XlsIgnore()]
        public int Id { get; set; }

        [XlsColumn("Data Irrigazione", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center, Style = "dd/MM/yyyy")]
        public DateTime DataIrrigazione { get; set; }

        [XlsColumn("Programma", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center)]
        public string CodiceProgramma { get; set; }

        [XlsColumn("Litri", Width = 150)]
        [XlsRow(HorizontallAlignment = HorizontalAlignment.Center, Style = "n0")]
        public int Litri { get; set; }
    }
    public class ProgIrrigazioneDatoCollection
         : BindingList<ProgIrrigazioneDato>
    {

    }
}
