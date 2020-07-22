﻿namespace Scarletglory.YellowPoppy.EasyScenarioConverter.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.importFilePathsTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.convertStartButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // importFilePathsTextBox
            // 
            this.importFilePathsTextBox.AllowDrop = true;
            this.importFilePathsTextBox.Location = new System.Drawing.Point(6, 27);
            this.importFilePathsTextBox.Multiline = true;
            this.importFilePathsTextBox.Name = "importFilePathsTextBox";
            this.importFilePathsTextBox.Size = new System.Drawing.Size(600, 133);
            this.importFilePathsTextBox.TabIndex = 0;
            this.importFilePathsTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnImportFilePathTextBoxDragDropped);
            this.importFilePathsTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnImportFilePathTextBoxDragEntered);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.importFilePathsTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 166);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "入力ファイル";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(12, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(612, 209);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "設定";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(144, 166);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(284, 24);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "入力ファイルと同じ保存先に出力します。";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(6, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(372, 133);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "シート変換設定";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(292, 90);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(67, 28);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "C";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(292, 59);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(67, 28);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "B";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(292, 27);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(67, 28);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Advコマンドのデータインデックスの行位置：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Advコマンドのデータバリューの行位置：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Advコマンドのコマンド名の行位置：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "ファイルの出力先：";
            // 
            // convertStartButton
            // 
            this.convertStartButton.Font = new System.Drawing.Font("Meiryo UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.convertStartButton.Location = new System.Drawing.Point(12, 399);
            this.convertStartButton.Name = "convertStartButton";
            this.convertStartButton.Size = new System.Drawing.Size(628, 204);
            this.convertStartButton.TabIndex = 3;
            this.convertStartButton.Text = "変換開始";
            this.convertStartButton.UseVisualStyleBackColor = true;
            this.convertStartButton.Click += new System.EventHandler(this.OnConvertStartButtonClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 615);
            this.Controls.Add(this.convertStartButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(668, 654);
            this.MinimumSize = new System.Drawing.Size(668, 654);
            this.Name = "MainForm";
            this.Text = "黄泉桜Project　安易シナリオ変換ソフト　※対応拡張子（.xlsx）";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox importFilePathsTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button convertStartButton;
    }
}