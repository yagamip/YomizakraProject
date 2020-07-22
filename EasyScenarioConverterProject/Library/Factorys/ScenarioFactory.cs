namespace Scarletglory.YellowPoppy.EasyScenarioConverter.Factorys
{
    using System.Collections.Generic;
    using Scarletglory.YellowPoppy.Scenarios;
    using Scarletglory.YellowPoppy.Commands;

    /// <summary>
    /// シナリオ生成クラスです。
    /// </summary>
    public class ScenarioFactory
    {
        /// <summary>
        /// シナリオを生成します。
        /// </summary>
        /// <param name="title">生成するシナリオのタイトルです。</param>
        /// <param name="advCommands">生成するシナリオのAdvコマンドのリストです。</param>
        /// <returns>生成したシナリオです。</returns>
        public Scenario Create(string title, List<FrameAdvCommand> advCommands)
        {
            Scenario scenario = new Scenario();
            scenario.title = title;
            foreach (FrameAdvCommand advCommand in advCommands)
            {
                scenario.AddAdvCommand(advCommand);
            }
            return scenario;
        }
    }
}
