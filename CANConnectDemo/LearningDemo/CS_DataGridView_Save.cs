using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Application = System.Windows.Forms.Application;
using Rectangle = System.Drawing.Rectangle;
using TextBox = System.Windows.Forms.TextBox;

namespace LearningDemo
{
    public partial class CS_DataGridView_Save : Form
    {
        public CS_DataGridView_Save()
        {
            InitializeComponent();
            dataGridView1.ClearSelection();
        }

        private void button6Edit_Click(object sender, EventArgs e)
        {
           // MeExit();
           this.Close();
        }
        /// <summary>
        /// 自定义退出函数
        /// </summary>
        private void MeExit()
        {
          
            DialogResult iExit = MessageBox.Show("Confim if you want to Exit?","Save DataGridView",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (iExit  == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
          //  button6Edit_Click(null,null);
            //MeExit();
        }
        /// <summary>
        /// 窗体将要关闭之前事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CS_DataGridView_Save_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult iExit = MessageBox.Show("Confim if you want to Exit?", "Save DataGridView", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
/*
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();  这种写法不对
            }*/

            if (iExit != DialogResult.Yes )
            {
                e.Cancel = true;
            }
        }

        private void button1AddNew_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Add(textBox1StudentId.Text, textBox3FirstName.Text, textBox5SurName.Text,
                textBox2Address.Text, textBox4DOB.Text, textBox6Tel.Text);
           dataGridView1.ClearSelection();
        }

        private void iDelete()
        {
            foreach (DataGridViewRow selectedRow in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(selectedRow.Index);
            }
        }
        private void button4Delete_Click(object sender, EventArgs e)
        {
            iDelete();
        }

        public void iReset()
        {
            // =========================Clear All the Data on TextBox==========

            foreach (Control control in this.Controls)
            {
                if (control is TextBox  textBox)
                {
                    textBox.Text = string.Empty;
                }
            }

            // =================Clears the DataGridView =========================
            int numsRow = dataGridView1.RowCount;
            for (int i = 0; i < numsRow; i++)
            {
                try
                {
                    int max = dataGridView1.RowCount-1;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[max]);
                }
                catch (Exception e)
                {
                    MessageBox.Show("All Rows are to be deleted "+e,"DataGridView Delete",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    
                }
            }
        }
        private void button2Reset_Click(object sender, EventArgs e)
        {
            iReset();
        }

        private Bitmap bitmap;
        private void button3Print_Click(object sender, EventArgs e)
        {
            var height = dataGridView1.Height;
            dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
             bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);
             dataGridView1.DrawToBitmap(bitmap,new Rectangle(0,0,dataGridView1.Width,dataGridView1.Height));

             printPreviewDialog1.PrintPreviewControl.Zoom = 1;
             printPreviewDialog1.ShowDialog();
             dataGridView1.Height = height;

        }
        /// <summary>
        /// Save to Excel 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5Save_Click(object sender, EventArgs e)
        {
            iSave();
        }

        private void iSave()
        {
           Microsoft.Office.Interop.Excel._Application  app=new Microsoft.Office.Interop.Excel.Application();
           Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
           Microsoft.Office.Interop.Excel._Worksheet  worksheet= null;

           app.Visible = true;
           worksheet = workbook.Sheets["sheet1"];
           worksheet = workbook.ActiveSheet;
           worksheet.Name = "Exported from GridView";

           for (int i = 1; i < dataGridView1.Columns.Count+1; i++)
           {
               worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
           }

           for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
           {
               for (int j = 0; j < dataGridView1.Columns.Count; j++)
               {
                   worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
               }
           }

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iDelete();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iReset();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap,0,0);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button3Print_Click(null,null);
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();

        }

        
        
        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
           
            //e.Row.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            //e.Row.HeaderCell.Value = (object)string.Format("{0}", (object)(e.Row.Index + 1));
            
        }

        private void CS_DataGridView_Save_Load(object sender, EventArgs e)
        {
           
        }
    }
}
