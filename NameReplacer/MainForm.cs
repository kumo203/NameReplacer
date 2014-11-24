using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameReplacer
{
    public partial class MainForm : Form
    {
        List<string[]> csvRecords;
        readonly int encordingNumber = Properties.Settings.Default.EncordingNumber;
        ViewerForm vf;


        public MainForm()
        {
            
            InitializeComponent();
            csvRecords = new List<string[]>();
            vf = new ViewerForm();
            vf.Size = Properties.Settings.Default.ViewerSize;
            vf.StartPosition = FormStartPosition.Manual;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox1.Text = openFileDialog.FileName;

                //初期化
                csvRecords.Clear();
                dataGridView1.Rows.Clear();

                //CSVファイル名
                string csvFileName = textBox1.Text;

                //Shift JISで読み込む
                TextFieldParser tfp =
                    new Microsoft.VisualBasic.FileIO.TextFieldParser(
                        csvFileName,
                        System.Text.Encoding.GetEncoding(encordingNumber));
                //フィールドが文字で区切られているとする
                //デフォルトでDelimitedなので、必要なし
                tfp.TextFieldType = Microsoft.VisualBasic.FileIO.FieldType.Delimited;
                //区切り文字を,とする
                tfp.Delimiters = new string[] { "," };
                //フィールドを"で囲み、改行文字、区切り文字を含めることができるか
                //デフォルトでtrueなので、必要なし
                tfp.HasFieldsEnclosedInQuotes = true;
                //フィールドの前後からスペースを削除する
                //デフォルトでtrueなので、必要なし
                tfp.TrimWhiteSpace = true;

                int num = 0;
                while (!tfp.EndOfData)
                {
                    //フィールドを読み込む
                    string[] fields = tfp.ReadFields();
                    //フィールドのチェック
                    if (fields != null && fields[0][0] != ':' && fields.Length >= 2)
                    {
                        //保存
                        csvRecords.Add(fields);

                        //表示
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[num].Cells[0].Value = num + 1;
                        dataGridView1.Rows[num].Cells[1].Value = fields[0];
                        dataGridView1.Rows[num].Cells[2].Value = fields[1];
                        dataGridView1.Rows[num].ReadOnly = true;
                        num++;
                    }
                }

                //後始末
                tfp.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                textBox2.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(textBox2.Text))
            {
                foreach ( string file in Directory.GetFiles(textBox2.Text, Properties.Settings.Default.ReplaceFileType) ) {
                    string newName = Path.GetDirectoryName(file) + Path.DirectorySeparatorChar + Path.GetFileNameWithoutExtension(file)
                        + "_" + DateTime.Now.ToLongDateString() + DateTime.Now.ToLongTimeString().Replace(':', '-') 
                        + ".backup";
                    string content = File.ReadAllText(file, Encoding.GetEncoding(encordingNumber));

                    bool exist=false;
                    foreach (string[] pair in csvRecords) {
                        Regex reg = new Regex("^(.*?)" + Regex.Escape(pair[0]) + "(.*?)$", RegexOptions.Multiline);   //マッチング用(行指定)
                        Regex rep = new Regex(Regex.Escape(pair[0]), RegexOptions.Multiline);                   //置換用(ワード指定)
                        Match m = reg.Match(content);
                        if (m.Success)
                        {
                            if (exist == false)
                            {
                                exist = true;
                                //バックアップ生成
                                File.Copy(file, newName);
                            }

                            //逐次置換
                            do {
                                //マッチ行までの行数計算
                                string sub = content.Substring(0,m.Index);
                                int lineNo = sub.Length - sub.Replace("\n", "").Length + 1;
                                vf.SetParams(file, lineNo, pair[0], pair[1], m.Value, 
                                    m.Groups[1] + pair[1] + m.Groups[2], m.Groups[1].Length);

                                if (vf.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                                {
                                    //置換中止
                                    goto CANCEL;
                                }
                                content = rep.Replace(content, pair[1], 1);
                                m = reg.Match(content);
                            } while (m.Success);
                            //ファイル更新
                            File.WriteAllText(file, content, Encoding.GetEncoding(encordingNumber));
                        }
                    }
                }
            CANCEL:
                ;
            }
            else
            {
                MessageBox.Show("Target Folder doesn't exist", "Folder Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
