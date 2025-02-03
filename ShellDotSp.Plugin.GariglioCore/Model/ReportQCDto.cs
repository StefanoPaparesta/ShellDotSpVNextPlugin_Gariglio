using System.Collections.Generic;
using System.ComponentModel;

namespace ShellDotSp.Plugin.GariglioCore.Model
{
    public class ReportQCDto
    {
        public List<ReportQCTestata> Testate { get; set; }
    }

    public class ReportQCCollection
        : BindingList<ReportQCDto>
    {
        public ReportQCCollection()
        {

        }

        public ReportQCCollection(IList<ReportQCDto> Items)
            : base(Items)
        {

        }
    }

}
