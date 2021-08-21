using System;
using System.Collections;
using System.Windows.Forms;

namespace cs_form_datagridview_add_column_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "環境変数";
            dataGridView1.Columns[1].Name = "値";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 行をクリア
            dataGridView1.Rows.Clear();

            // 一行ぶんのデータの配列用
            ArrayList al = new ArrayList();

            // 環境変数の一覧
            foreach (DictionaryEntry de in Environment.GetEnvironmentVariables())
            {
                // １行のクリア
                al.Clear();
                // 環境変数
                al.Add(de.Key.ToString());
                // 値
                al.Add(de.Value.ToString());
                // １行をセット
                dataGridView1.Rows.Add(al.ToArray());
            }

            // 値の長さでカラム幅の自動調整
            dataGridView1.AutoResizeColumns();
        }
    }
}
