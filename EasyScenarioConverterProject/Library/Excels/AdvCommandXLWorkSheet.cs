namespace Scarletglory.YellowPoppy.EasyScenarioConverter.Excels
{
    using ClosedXML.Excel;

    /// <summary>
    /// AdvコマンドExcelワークシートクラスです。
    /// </summary>
    public class AdvCommandXLWorkSheet
    {
        /// <summary>
        /// <see cref="AdvCommandXLWorkSheet"/>の名前です。
        /// </summary>
        protected readonly string name = null;

        /// <summary>
        /// 全ての<see cref="AdvCommandXLRow"/>を保持するインスタンスです。
        /// </summary>
        protected readonly AdvCommandXLRows rows = null;

        /// <summary>
        /// <see cref="AdvCommandXLWorkSheet"/>のコンストラクタです。
        /// </summary>
        /// <param name="xlWorksheet">基となる<see cref="IXLWorksheet"/>です。</param>
        public AdvCommandXLWorkSheet(IXLWorksheet xlWorksheet)
        {
            this.name = xlWorksheet.Name;
            this.rows = new AdvCommandXLRows(xlWorksheet.RowsUsed());
        }

        /// <summary>
        /// <see cref="AdvCommandXLWorkSheet"/>の名前を取得します。
        /// </summary>
        /// <returns>取得した<see cref="AdvCommandXLWorkSheet"/>の名前です。</returns>
        public string GetName()
        {
            return this.name;
        }

        /// <summary>
        /// 全ての<see cref="AdvCommandXLWorkSheet"/>を保持するインスタンスを取得します。
        /// </summary>
        /// <returns>取得した全ての<see cref="AdvCommandXLWorkSheet"/>を保持するインスタンスです。</returns>
        public AdvCommandXLRows GetRows()
        {
            return this.rows;
        }
    }
}
