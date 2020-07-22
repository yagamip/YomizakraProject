namespace Scarletglory.YellowPoppy.EasyScenarioConverter.Excels
{
    using System.Collections;
    using System.Collections.Generic;
    using ClosedXML.Excel;

    /// <summary>
    /// 複数の<see cref="AdvCommandXLWorkSheet"/>を保持するクラスです。
    /// </summary>
    public class AdvCommandXLWorkSheets : IEnumerable<AdvCommandXLWorkSheet>
    {
        /// <summary>
        /// <see cref="AdvCommandXLWorkSheet"/>のリストのインスタンスです。
        /// </summary>
        protected readonly List<AdvCommandXLWorkSheet> advCommandXLWorkSheets = null;

        /// <summary>
        /// 複数の<see cref="AdvCommandXLWorkSheet"/>を保持するクラスのコンストラクタです。
        /// </summary>
        /// <param name="xlWorkSheets">基となる<see cref="IXLWorksheets"/>です。</param>
        public AdvCommandXLWorkSheets(IXLWorksheets xlWorkSheets)
        {
            this.advCommandXLWorkSheets = new List<AdvCommandXLWorkSheet>();
            foreach (IXLWorksheet xlWorkSheet in xlWorkSheets)
            {
                this.advCommandXLWorkSheets.Add(new AdvCommandXLWorkSheet(xlWorkSheet));
            }
        }

        public IEnumerator<AdvCommandXLWorkSheet> GetEnumerator()
        {
            return this.advCommandXLWorkSheets.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
