namespace Scarletglory.YellowPoppy.EasyScenarioConverter.Excels
{
    using System.Collections.Generic;
    using ClosedXML.Excel;

    /// <summary>
    /// AdvコマンドExcel行クラスです。
    /// </summary>
    public class AdvCommandXLRow
    {
        /// <summary>
        /// Advコマンドの名前を有する列の番号です。
        /// </summary>
        protected const int NAME_COLUMN_NUMBER = 1;

        /// <summary>
        /// Advコマンドのデータを有する最初の列の番号です。
        /// </summary>
        protected const int DATA_FIRST_COLUMN_NUMBER = 2;

        /// <summary>
        /// Advコマンドのデータを有する最後の列の番号です。
        /// </summary>
        protected const int DATA_LAST_COLUMN_NUMBER = 12;

        /// <summary>
        /// Advコマンドの名前です。
        /// </summary>
        protected readonly string name = null;

        /// <summary>
        /// Advコマンドのデータのディクショナリのインスタンスです。
        /// </summary>
        protected readonly Dictionary<string, string> datas = null;

        /// <summary>
        /// <see cref="AdvCommandXLRow"/>のコンストラクタです。
        /// </summary>
        /// <param name="xlRow">基となる<see cref="IXLRow"/>です。</param>
        public AdvCommandXLRow(IXLRow xlRow)
        {
            this.datas = new Dictionary<string, string>();
            foreach (IXLCell xlCell in xlRow.CellsUsed())
            {
                if (xlCell.Address.ColumnNumber == NAME_COLUMN_NUMBER)
                {
                    this.name = xlCell.GetValue<string>();
                }
                else if (xlCell.Address.ColumnNumber >= DATA_FIRST_COLUMN_NUMBER && xlCell.Address.ColumnNumber <= DATA_LAST_COLUMN_NUMBER)
                {
                    this.datas.Add((xlCell.Address.ColumnNumber - DATA_FIRST_COLUMN_NUMBER).ToString(), xlCell.GetValue<string>());
                }
            }
        }

        /// <summary>
        /// Advコマンドの名前を取得します。
        /// </summary>
        /// <returns>取得したAdvコマンドの名前です。</returns>
        public string GetName()
        {
            return this.name;
        }

        /// <summary>
        /// Advコマンドのデータのディクショナリを取得します。
        /// </summary>
        /// <returns>取得したAdvコマンドのデータのディクショナリです。</returns>
        public Dictionary<string, string> GetDatas()
        {
            return this.datas;
        }
    }
}
