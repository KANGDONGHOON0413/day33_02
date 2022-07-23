using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day33_02
{
    public partial class Form1 : Form
    {
        DataTable table01;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table01 = new DataTable("table01");
            var Col01 = new DataColumn("Name", typeof(string));
            table01.Columns.Add(Col01);
            Col01 = new DataColumn("age", typeof(int));
            table01.Columns.Add(Col01);
            Col01 = new DataColumn("sex", typeof(bool));
            table01.Columns.Add(Col01);
            Col01 = new DataColumn("phone", typeof(string));
            table01.Columns.Add(Col01);

            // Row 입력(생성)
            DataRow row = table01.NewRow();
            row["Name"] = "강동훈";
            row["age"] = 23;
            row["sex"] = true;
            row["phone"] = "010-1234-5678";
            table01.Rows.Add(row);

            row = table01.NewRow();
            row["Name"] = "김훈";
            row["age"] = 21;
            row["sex"] = true;
            row["phone"] = "010-3334-5448";
            table01.Rows.Add(row);

            row = table01.NewRow();
            row[0] = "김민재";
            row[1] = 12;
            row[2] = true;
            row[3] = "010-1334-4448";
            table01.Rows.Add(row);

            row = table01.NewRow();
            row[0] = "서윤이";
            row[1] = 22;
            row[2] = false;
            row[3] = "010-9334-4448";
            table01.Rows.Add(row);

            table01.AcceptChanges();
            dataGridView1.DataSource = table01;
            dataGridView1.MultiSelect = false; // 한행만 선택할 수 있도록 만들어준다.
        }

        private void BTN_INPUT_Click(object sender, EventArgs e)
        {   //입력 부분
            
            
                DataRow row = table01.NewRow();
                row["Name"] = INPUT_NAME.Text;
                row["age"] = int.Parse(INPUT_AGE.Text);
                row["sex"] = RBTN_MALE.Checked;
                row["phone"] = INPUT_PHONENUM.Text;
                table01.Rows.Add(row);
            
        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {   //삭제 2가지 방법
            /* 1. 선택한 행 가져오기
            DataGridViewSelectedRowCollection Rows = dataGridView1.SelectedRows;
            int SelectedRowIndex = Rows[0].Index;
            DataRow row = table01.Rows[SelectedRowIndex];
            row.Delete();
            table01.AcceptChanges();
            */
            
            //2. data gridview에서 가져오기
            DataGridViewRow row1 = dataGridView1.SelectedRows[0];
            dataGridView1.Rows.Remove(row1);

            /*2.5 여러개를 처리하기(multi select가 켜져있는 경우)
            foreach(DataGridView row2 in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row1);
            }
            */
        }
       
    }
}
