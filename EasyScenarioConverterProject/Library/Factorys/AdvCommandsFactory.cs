namespace Scarletglory.YellowPoppy.EasyScenarioConverter.Factorys
{
    using System.Collections.Generic;
    using Scarletglory.YellowPoppy.EasyScenarioConverter.Excels;
    using Scarletglory.YellowPoppy.Commands;

    /// <summary>
    /// Advコマンドのコレクションの生成クラスです。
    /// </summary>
    public class AdvCommandsFactory
    {
        /// <summary>
        /// Advコマンドのリストを生成します。
        /// </summary>
        /// <param name="advCommandXLRows">基となる<see cref="AdvCommandXLRows"/>です。</param>
        /// <returns>生成したAdvコマンドのリストです。</returns>
        public List<FrameAdvCommand> Create(AdvCommandXLRows advCommandXLRows)
        {
            List<FrameAdvCommand> advCommands = new List<FrameAdvCommand>();
            foreach (AdvCommandXLRow advCommandXLRow in advCommandXLRows)
            {
                if (advCommandXLRow.GetName() != string.Empty)
                {
                    FrameAdvCommand advCommand = new FrameAdvCommand();
                    advCommand.name = advCommandXLRow.GetName();
                    advCommand.data = advCommandXLRow.GetDatas();
                    advCommands.Add(advCommand);
                }
            }
            return advCommands;
        }
    }
}
