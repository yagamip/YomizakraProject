namespace Scarletglory.YellowPoppy.EasyScenarioConverter.Forms
{
    using System;
    using System.IO;
    using System.Windows.Forms;
    using System.Collections.Generic;
    using Scarletglory.YellowPoppy.Scenarios;
    using Scarletglory.YellowPoppy.Commands;
    using Scarletglory.YellowPoppy.EasyScenarioConverter.Excels;
    using Scarletglory.YellowPoppy.EasyScenarioConverter.Factorys;
    using Scarletglory.YellowPoppy.EasyScenarioConverter.Files;

    /// <summary>
    /// メインフォームクラスです。
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// 入力ファイルパスのリストです。
        /// </summary>
        private string[] ImportFilePaths
        {
            get
            {
                return this.importFilePathsTextBox.Lines;
            }
            set
            {
                this.importFilePathsTextBox.Lines = value;
            }
        }

        /// <summary>
        /// メインフォームのコンストラクタです。
        /// </summary>
        public MainForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// 入力ファイルパステキストボックスにドラッグエンターされた際の処理です。
        /// </summary>
        /// <param name="sender">呼び出し元です。</param>
        /// <param name="dragEventArgs">ドラッグイベントデータです。</param>
        public void OnImportFilePathTextBoxDragEntered(object sender, DragEventArgs dragEventArgs)
        {
            DragEventArgsUtils dragEventArgsUtils = new DragEventArgsUtils();
            dragEventArgsUtils.SetDragDropEffectsToAll(dragEventArgs);
        }

        /// <summary>
        /// 入力ファイルパステキストボックスにドラッグドロップされた際の処理です。
        /// </summary>
        /// <param name="sender">呼び出し元です。</param>
        /// <param name="dragEventArgs">ドラッグイベントデータです。</param>
        public void OnImportFilePathTextBoxDragDropped(object sender, DragEventArgs dragEventArgs)
        {
            bool fileDropDataExists = false;
            string[] fileDropData = new string[] { };
            DragEventArgsUtils dragEventArgsUtils = new DragEventArgsUtils();
            dragEventArgsUtils.CheckFileDropDataExists(dragEventArgs, out fileDropDataExists);
            dragEventArgsUtils.GetFileDropData(dragEventArgs, out fileDropData);
            this.ImportFilePaths = fileDropData;
        }

        /// <summary>
        /// 変換開始ボタンがクリックされた際の処理です。
        /// </summary>
        /// <param name="sender">呼び出し元のオブジェクトです。</param>
        /// <param name="eventArgs">イベントに関するデータです。</param>
        private void OnConvertStartButtonClicked (object sender, EventArgs eventArgs)
        {
            for (int i = 0; i < this.ImportFilePaths.Length; i++)
            {
                AdvCommandXLWorkBook advCommandXLWorkBook = new AdvCommandXLWorkBook(this.ImportFilePaths[i]);
                foreach (AdvCommandXLWorkSheet advCommandXLWorkSheet in advCommandXLWorkBook.GetWorkSheets())
                {
                    AdvCommandsFactory advCommandsFactory = new AdvCommandsFactory();
                    List<FrameAdvCommand> advCommands = advCommandsFactory.Create(advCommandXLWorkSheet.GetRows());

                    ScenarioFactory scenarioFactory = new ScenarioFactory();
                    Scenario scenario = scenarioFactory.Create(advCommandXLWorkSheet.GetName(), advCommands);

                    JsonFileExporter jsonFileExporter = new JsonFileExporter(advCommandXLWorkSheet.GetName(), Path.GetDirectoryName(this.ImportFilePaths[i]));
                    jsonFileExporter.Export(ScenarioConverter.ToJson(scenario));

                    string messageBoxCaption = "シナリオJsonファイル出力結果";
                    string messageBoxText = String.Format("シナリオJsonファイルの出力に成功しました。\n入力Xlsxファイル：{0}\n出力Jsonファイル：{1}", 
                        this.ImportFilePaths[i], 
                        jsonFileExporter.GetFilePath());
                    MessageBox.Show(messageBoxText, messageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
