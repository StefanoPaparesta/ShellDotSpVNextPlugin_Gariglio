using System.Collections.Generic;
using System.ComponentModel;

namespace ShellDotSp.Plugin.GariglioCore.Model
{
    public class ReportCicloProduzione
    {

        public VTracciaTestata TracciaTestata { get; set; }
        public List<MagazzinoMovimento> CicliProduzioneUbi { get; set; }
        public List<VTracciaMateriePrime> CicliProduzioneMP { get; set; }

    }

    public class ReportCicloProduzioneCollection
           : BindingList<ReportCicloProduzione>
    {

    }
}
