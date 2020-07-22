namespace Scarletglory.YellowPoppy.EasyScenarioConverter.Files
{ 
    using System;
    using System.IO;

    /// <summary>
    /// Jsonファイル出力クラスです。
    /// </summary>
    public class JsonFileExporter
    {
        /// <summary>
        /// 出力するJsonファイルの拡張子です。
        /// </summary>
        protected const string FILE_EXTENSION = ".json";

        /// <summary>
        /// 出力するJsonファイルの文字エンコード形式です。
        /// </summary>
        protected const string FILE_TEXT_ENCODING = "UTF-8";

        /// <summary>
        /// 出力するJsonファイルに対するファイルアクセスです。
        /// </summary>
        protected const FileAccess FILE_ACCESS = FileAccess.ReadWrite;

        /// <summary>
        /// 出力するJsonファイルに対するファイルモードです。
        /// </summary>
        protected const FileMode FILE_MODE = FileMode.Create;

        /// <summary>
        /// 出力するJsonファイルの名前です。
        /// </summary>
        protected readonly string fileName = null;

        /// <summary>
        /// 出力するJsonファイルのディレクトリです。
        /// </summary>
        protected readonly string fileDirectory = null;

        /// <summary>
        /// Jsonファイル出力のコンストラクタです。
        /// </summary>
        /// <param name="fileName">出力するJsonファイルの名前です。</param>
        /// <param name="fileDirectory">出力するJsonファイルのディレクトリです。</param>
        public JsonFileExporter(string fileName, string fileDirectory)
        {
            this.fileName = fileName;
            this.fileDirectory = fileDirectory;
        }

        /// <summary>
        /// 出力するファイルのパスを取得します。
        /// </summary>
        /// <returns>取得したファイルのパスです。</returns>
        public string GetFilePath()
        {
            return String.Format(@"{0}\{1}{2}", this.fileDirectory, this.fileName, FILE_EXTENSION);
        }

        /// <summary>
        /// Jsonファイルの出力を実行します。
        /// </summary>
        /// <param name="content">出力するJsonファイルの内容です。</param>
        public void Export(string content)
        {
            Console.WriteLine(this.GetFilePath());
            byte[] contentBinarys = System.Text.Encoding.GetEncoding(FILE_TEXT_ENCODING).GetBytes(content);
            using (FileStream fileStream = new FileStream(this.GetFilePath(), FILE_MODE, FILE_ACCESS))
            {
                fileStream.Write(contentBinarys, 0, contentBinarys.Length);
                fileStream.Close();
                fileStream.Dispose();
            }
        }
    }
}
