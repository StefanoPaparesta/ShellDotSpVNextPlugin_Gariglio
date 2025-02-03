using ShellDotSp.Contract.View;
using ShellDotSp.Plugin.GariglioCore.Core.Util;

namespace ShellDotSp.Plugin.GariglioGiacenze.Interfaces
{
    public interface IMainView : IView
    {
        void UpdateUI(Function functionName);
    }
}
