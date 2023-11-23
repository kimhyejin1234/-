using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 시안2
{
    public partial class Form1 : Form
    {
        TextBox[] subject;
        ComboBox[] num;
        ComboBox[] score;
        
        



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            subject = new TextBox[]
            {
                subject1, subject2, subject3, subject4, subject5, subject6, subject7, subject8
            };
            num = new ComboBox[]
            {
                num1, num2, num3, num4, num5, num6, num7, num8
            };
            score = new ComboBox[]
            {
                score1, score2, score3, score4, score5, score6, score7, score8 
            };

            // 년도콤보박스 와 학기콤보박스  초기화 - by k.d.h
            InitializeYearComboBox();
        }


        // 년도와 학기 콤보박스 생성  - by k.d.h
        private void InitializeYearComboBox()
        {
           
            // 현재 부터 가져오기
            int currentYear = DateTime.Now.Year ;

            // 10년치 연도를 콤보박스에 추가
            for (int i = 0; i < 10; i++)
            {
                int year = currentYear - i;
                yearComboBox.Items.Add(year.ToString());
            }

            // 기본 선택값 설정 (현재 년도)
            // 현재년도의 index 는 0 이다
            yearComboBox.SelectedIndex = 0;

            // termComboBox 초기화
            termComboBox.Items.Add(new ComboboxItem("1", "1학기")); // "1" 값을 선택하면 "1학기"가 표시됨
            termComboBox.Items.Add(new ComboboxItem("2", "2학기")); // 추가적인 학기 값도 필요하다면 이렇게 추가

            // 기본 선택값 설정 (1학기 index 는 0 이다)
            termComboBox.SelectedIndex = 0;

        }

        // ComboboxItem 클래스 정의 -  by k.d.h
        public class ComboboxItem
        {
            public string Value { get; set; }
            public string DisplayText { get; set; }

            public ComboboxItem(string value, string displayText)
            {
                Value = value;
                DisplayText = displayText;
            }

            public override string ToString()
            {
                return DisplayText;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int total_num = 0;
            double total_score = 0;
            for(int i=0; i<num.Length; i++)
            {
                if (subject[i].Text != "")
                {
                    int number = int.Parse(num[i].SelectedItem.ToString());
                    total_num += number;
                    total_score += number * All_Score(score[i].SelectedItem.ToString());
                }
                textBox1.Text = (total_score / total_num).ToString("0.00");
            }
        }

        private double All_Score(string text)
        {
            double grade = 0;
            if (text == "A+")
                grade = 4.5;
            else if (text == "A0")
                grade = 4.0;
            else if (text == "B+")
                grade = 3.5;
            else if (text == "B0")
                grade = 3.0;
            else if (text == "C+")
                grade = 2.5;
            else if (text == "C0")
                grade = 2.0;
            else if (text == "D+")
                grade = 1.5;
            else if (text == "D0")
                grade = 1.0;
            else if (text == "F")
                grade = 0.0;
            else grade = 0;

            return grade;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

            subject1.Text = "";
            subject2.Text = "";
            subject3.Text = "";
            subject4.Text = "";
            subject5.Text = "";
            subject6.Text = "";
            subject7.Text = "";
            subject8.Text = "";
            

            num1.Text = "";
            num2.Text = "";
            num3.Text = "";
            num4.Text = "";
            num5.Text = "";
            num6.Text = "";
            num7.Text = "";
            num8.Text = "";
            

            score1.Text = "";
            score2.Text = "";
            score3.Text = "";
            score4.Text = "";
            score5.Text = "";
            score6.Text = "";
            score7.Text = "";
            score8.Text = "";
            
        }

        private void select_Click(object sender, EventArgs e)
        {
            if(studentId.Text == "" )
            {
                MessageBox.Show("학번을 입력해 주세요","입력값 check");
                return;

            }

        }

        private void insert_Click(object sender, EventArgs e)
        {
            if (studentId.Text == "")
            {
                MessageBox.Show("학번을 입력해 주세요","입력값 check");
                return;

            }

        }

        private void update_Click(object sender, EventArgs e)
        {
            if (studentId.Text == "")
            {
                MessageBox.Show("학번을 입력해 주세요", "입력값 check");
                return;
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (studentId.Text == "")
            {
                MessageBox.Show("학번을 입력해 주세요","입력값 check");
                return;

            }
        }
    }
}
