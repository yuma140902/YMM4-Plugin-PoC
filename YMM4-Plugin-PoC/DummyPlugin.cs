namespace YMM4_Plugin_PoC
{
    public class DummyPlugin : YukkuriMovieMaker.Plugin.IPlugin
    {
        static DummyPlugin()
        {
            System.Windows.Forms.MessageBox.Show("Hello from DLL");
        }

        public string Name => "My Dummy Plugin";
    }
}