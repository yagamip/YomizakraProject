namespace Scarletglory.YellowPoppy.EasyScenarioConverter.Excels
{
    using ClosedXML.Excel;

    /// <summary>
    /// AdvコマンドExcelワークブッククラスです。
    /// </summary>
    public class AdvCommandXLWorkBook
    {
        /// <summary>
        /// 全ての<see cref="AdvCommandXLWorkSheet"/>を保持するインスタンスです。
        /// </summary>
        protected readonly AdvCommandXLWorkSheets advCommandXLWorkSheets = null;

        /// <summary>
        /// <see cref="AdvCommandXLWorkBook"/>のコンストラクタです。
        /// </summary>
        /// <param name="workBookFilePath">基となる<see cref="XLWorkbook"/>のファイルパスです。</param>
        public AdvCommandXLWorkBook(string workBookFilePath)
        {
            XLWorkbook xlWorkBook = new XLWorkbook(workBookFilePath);
            this.advCommandXLWorkSheets = new AdvCommandXLWorkSheets(xlWorkBook.Worksheets);
        }

        /// <summary>
        /// 全ての<see cref="AdvCommandXLWorkSheet"/>を取得します。
        /// </summary>
        /// <returns>取得した全ての<see cref="AdvCommandXLWorkSheet"/>を保持するインスタンスです。</returns>
        public AdvCommandXLWorkSheets GetWorkSheets()
        {
            return this.advCommandXLWorkSheets;
        }
    }
}
