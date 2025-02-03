using System.ComponentModel;

namespace ShellDotSp.Plugin.GariglioCore.Model
    {
    public class LabelProduzioneDTO
        {

        public string Descrizione { get; set; }
        public string CodiceProduzione { get; set; }

        }

    public class LabelProduzioneDTOCollection :
        BindingList<LabelProduzioneDTO>
        {

        }


    }
