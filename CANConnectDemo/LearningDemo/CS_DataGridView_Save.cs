using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningDemo
{
    public partial class CS_DataGridView_Save : Form
    {
        public CS_DataGridView_Save()
        {
            InitializeComponent();
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

        private void button3Print_Click(object sender, EventArgs e)
        {

        }

        private void button5Save_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iDelete();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iReset();
        }
    }
}
