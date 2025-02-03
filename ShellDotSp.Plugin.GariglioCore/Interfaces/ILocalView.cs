namespace ShellDotSp.Plugin.GariglioCore.Interfaces
    {
    public interface ILocalView
        {
        void OnInit();
        void OnFinalize();
        void UpdateUI(string functionName);
        }
    }
