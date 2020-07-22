namespace Scarletglory.YellowPoppy.EasyScenarioConverter.Forms
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// <see cref="DragEventArgs"/>ユーティリティクラスです。
    /// </summary>
    public class DragEventArgsUtils
    {
        /// <summary>
        /// <see cref="DragEventArgs"/>ユーティリティのコンストラクタです。
        /// </summary>
        public DragEventArgsUtils()
        {

        }

        /// <summary>
        /// <see cref="DragEventArgs"/>の、エフェクトをAllにセットします。
        /// </summary>
        /// <param name="dragEventArgs">セット対象となる、<see cref="DragEventArgs"/>です。</param>
        public void SetDragDropEffectsToAll(DragEventArgs dragEventArgs)
        {
            dragEventArgs.Effect = DragDropEffects.All;
        }

        /// <summary>
        /// FileDropデータが存在するかを確認します。
        /// </summary>
        /// <param name="dragEventArgs">確認対象となる、<see cref="DragEventArgs"/>です。</param>
        /// <param name="fileDropDataExists">FileDropデータが存在するかの真偽値です。</param>
        public void CheckFileDropDataExists(DragEventArgs dragEventArgs, out bool fileDropDataExists)
        {
            fileDropDataExists = Array.Exists(dragEventArgs.Data.GetFormats(), (dataFormat) =>
            {
                if (dataFormat == DataFormats.FileDrop)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            });
        }

        /// <summary>
        /// FileDropデータを取得します。
        /// </summary>
        /// <param name="dragEventArgs">取得対象となる、<see cref="DragEventArgs"/>です。</param>
        /// <param name="fileDropData">取得したFileDropデータです。</param>
        public void GetFileDropData(DragEventArgs dragEventArgs, out string[] fileDropData)
        {
            fileDropData = (string[])dragEventArgs.Data.GetData(DataFormats.FileDrop);
        }
    }
}
