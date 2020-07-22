namespace Scarletglory.YellowPoppy.EasyScenarioConverter
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// プログラムクラスです。
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// <para>メインエントリポイントです。</para>
        /// <para>プログラム実行時に、最初に呼び出されるメソッドです。</para>
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.MainForm());
        }
    }
}
