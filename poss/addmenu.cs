using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace poss
{

    public partial class addmenu : Form
    {   //빤스런 흔적 main m2;
        public delegate void FormSendDataHandlar(string sendstring);
        public event FormSendDataHandlar FormSendEvent;

        
        public addmenu()
        {
            InitializeComponent();
        }
        /*빤스런 흔적
        public addmenu(main _main)
        {
            InitializeComponent();
            m2 = _main;
        }빤스런 흔적*/
        private static int a;
        private static int a1;
        private static int a2;
        private static int a3;
        private static int a4;
        private static int a5;
        private static int a6;

        bool isSelected1 = false;
        bool isSelected2 = false;
        bool isSelected3 = false;
        bool isSelected4 = false;
        bool isSelected5 = false;
        bool isSelected6 = false;
        bool isSelected7 = false;
        double g;

        /* private string addMenu;
         public string PassMenu
         {
             get { return this.addMenu; }
             set { this.addMenu = value; }
         }*/
        private string allMenu;
        public string PassMenu
        {
            get { return this.allMenu; }
            set { this.allMenu = value; }
        }


        private void button1_Click(object sender, EventArgs e)
        {

            a++;

            textBox8.Text = a.ToString();
            label2_Text(); // 더하기
            isSelected1 = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a1++;

            textBox9.Text = a1.ToString();   //더하기
            label2_Text();
            isSelected2 = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a2++;

            textBox10.Text = a2.ToString();  //더하기
            label2_Text();
            isSelected3 = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a3++;

            textBox11.Text = a3.ToString();  //더하기
            label2_Text();
            isSelected4 = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            a4++;

            textBox12.Text = a4.ToString(); //더하기
            label2_Text();
            isSelected5 = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            a5++;

            textBox13.Text = a5.ToString();  //더하기
            label2_Text();
            isSelected6 = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            a6++;

            textBox14.Text = a6.ToString();   //더하기
            label2_Text();
            isSelected7 = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (a > 0)
                a--;

            textBox8.Text = a.ToString(); //빼기
            label2_Text();
            isSelected1 = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (a1 > 0)
                a1--;

            textBox9.Text = a1.ToString();  //빼기
            label2_Text();
            isSelected2 = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (a2 > 0)
                a2--;

            textBox10.Text = a2.ToString(); //빼기
            label2_Text();
            isSelected3 = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (a3 > 0)
                a3--;

            textBox11.Text = a3.ToString(); //빼기
            label2_Text();
            isSelected4 = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (a4 > 0)
                a4--;

            textBox12.Text = a4.ToString(); //빼기
            label2_Text();
            isSelected5 = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (a5 > 0)
                a5--;

            textBox13.Text = a5.ToString(); //빼기
            label2_Text();
            isSelected6 = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (a6 > 0)
                a6--;

            textBox14.Text = a6.ToString(); //빼기
            label2_Text();
            isSelected7 = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {

            if (a > 0)
            {
                allMenu += "돼지생삼겹살:\t" + a + "개     " + (a * 10000) + "원" + Environment.NewLine + Environment.NewLine;
               
            }
            if (a1 > 0)
            {
                allMenu += "돼지생목살:\t" + a1 + "개     " + (a1 * 10000) + "원\n" + Environment.NewLine + Environment.NewLine;
            }
            if (a2 > 0)
            {
                allMenu += "돼지왕갈비:\t" + a2 + "개     " + (a2 * 10000) + "원\n" + Environment.NewLine + Environment.NewLine;
            }
            if (a3 > 0)
            {
                allMenu += "계란찜:\t\t" + a3 + "개     " + (a3 * 2000) + "원\n" + Environment.NewLine + Environment.NewLine;
            }
            if (a4 > 0)
            {
                allMenu += "된장찌개:\t\t" + a4 + "개     " + (a4 * 1000) + "원\n" + Environment.NewLine + Environment.NewLine;
            }
            if (a5 > 0)
            {
                allMenu += "소주:\t\t" + a5 + "개     " + (a5 * 4000) + "원\n" + Environment.NewLine + Environment.NewLine;
            }
            if (a6 > 0)
            {
                allMenu += "맥주:\t\t" + a6 + "개     " + (a6 * 4000) + "원\n" + Environment.NewLine + Environment.NewLine;
            }
            
           

            this.FormSendEvent(allMenu);//확인
            Close();
        }//메뉴추가

        private void button16_Click(object sender, EventArgs e)
        {
            Close(); //닫기
        }
        private void label2_Text()
        {
            g = (10000 * double.Parse(textBox8.Text)) + (10000 * double.Parse(textBox9.Text)) + (10000 * double.Parse(textBox10.Text))
                + (2000 * double.Parse(textBox11.Text)) + (1000 * double.Parse(textBox12.Text)) + (4000 * double.Parse(textBox13.Text)) + (4000 * double.Parse(textBox14.Text));
            label2.Text = g.ToString();
        }
        private void SelectClear()
        {
            isSelected1 = false;
            isSelected2 = false;
            isSelected3 = false;
            isSelected4 = false;
            isSelected5 = false;
            isSelected6 = false;
            isSelected7 = false;
        }

        private void addmenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            a = 0;
            a1 = 0;
            a2 = 0;
            a3 = 0;
            a4 = 0;
            a5 = 0;
            a6 = 0;
        }

        private void addmenu_Load(object sender, EventArgs e)
        {

        }
    }
}
