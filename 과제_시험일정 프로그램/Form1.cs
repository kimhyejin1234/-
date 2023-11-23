using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 과제_시험일정_프로그램
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.adt.Fill(ds1, "tblPaln1");
            this.dataGridView1.SetDataBinding(ds1, "tblPlan1");

            CalendarBolding();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sDT = this.monthCalendar1.SelectionStart.ToString();
            string sTitle = this.textBox1.Text;
            string sComment = this.textBox2.Text;
            string slmp = "";

            if (this.radioButton1.Checked)
                slmp = this.radioButton1.Text;
            else if (this.radioButton2.Checked)
                slmp = this.radioButton2.Text;
            else
                slmp = "없음";

            DataRow row = ds1.tblPlan1.NewRow();
            row["title"] = sTitle;
            row["comment"] = sComment;
            row["dt"] = sDT;
            row["imp"] = slmp;

            ds1.tblPlan1.Rows.Add(row);

            adt.Update(ds1.tblPlan1);

            CalendarBolding();
        }

        private void CalendarBolding()
        {
            
        }
    }
}
