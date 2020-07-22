namespace Scarletglory.YellowPoppy.EasyScenarioConverter.Excels
{
    using System.Collections;
    using System.Collections.Generic;
    using ClosedXML.Excel;

    /// <summary>
    /// 複数の<see cref="AdvCommandXLRow"/>を保持するクラスです。
    /// </summary>
    public class AdvCommandXLRows : IEnumerable<AdvCommandXLRow>
    {
        /// <summary>
        /// <see cref="AdvCommandXLRow"/>のリストのインスタンスです。
        /// </summary>
        protected readonly List<AdvCommandXLRow> advCommandXLRows = null;

        /// <summary>
        /// <see cref="AdvCommandXLRows"/>のコンストラクタです。
        /// </summary>
        /// <param name="xlRows">基となる<see cref="IXLRows"/>です。</param>
        public AdvCommandXLRows(IXLRows xlRows)
        {
            this.advCommandXLRows = new List<AdvCommandXLRow>();
            foreach (IXLRow xlRow in xlRows)
            {
                this.advCommandXLRows.Add(new AdvCommandXLRow(xlRow));
            }
        }

        public IEnumerator<AdvCommandXLRow> GetEnumerator()
        {
            return this.advCommandXLRows.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
