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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
        bool isSelected = false; // 누르고 다른게 눌리면 
        bool isSelected1 = false;
        bool isSelected2 = false;
        bool isSelected3 = false;
        bool isSelected4 = false;
        bool isSelected5 = false;
        bool isSelected6 = false;

        menu menu2 = new menu();

        static int tablenum = 0; // 테이블 번호를 기억할 정적 변수

        public static int send_tn() {
            return tablenum;
        }

        private void main_Load(object sender, EventArgs e)
        {

        }
        private void DieaseUpdateEventMethod(object sender)
        {
            if (isSelected1)
            {
                textBox1.Text = sender.ToString();

            }
            else if (isSelected2)
            {
                textBox2.Text = sender.ToString();

            }
            else if (isSelected3)
            {
                textBox3.Text = sender.ToString();

            }
            else if (isSelected4)
            {
                textBox4.Text = sender.ToString();

            }
            else if (isSelected5)
            {
                textBox5.Text = sender.ToString();

            }
            else if (isSelected6)
            {
                textBox6.Text = sender.ToString();

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (isSelected1)
            {
                menu menu2 = new menu();
                menu2.FormSendEvent += new menu.FormSendDataHandlar(DieaseUpdateEventMethod);
                menu2.recieveTable = 1;
                menu2.ShowDialog();
                textBox1.ScrollBars = ScrollBars.Vertical;

                isSelected1 = false;
            }
            else if (isSelected2)
            {
                menu menu2 = new menu();
                menu2.FormSendEvent += new menu.FormSendDataHandlar(DieaseUpdateEventMethod);
                menu2.recieveTable = 2;
                menu2.ShowDialog();
                textBox2.ScrollBars = ScrollBars.Vertical;
                isSelected2 = false;
            }
            else if (isSelected3)
            {
                menu menu2 = new menu();
                menu2.FormSendEvent += new menu.FormSendDataHandlar(DieaseUpdateEventMethod);
                menu2.recieveTable = 3;
                menu2.ShowDialog();
                textBox3.ScrollBars = ScrollBars.Vertical;
                isSelected3 = false;
            }
            else if (isSelected4)
            {
                menu menu2 = new menu();
                menu2.FormSendEvent += new menu.FormSendDataHandlar(DieaseUpdateEventMethod);
                menu2.recieveTable = 4;
                menu2.ShowDialog();
                textBox4.ScrollBars = ScrollBars.Vertical;
                isSelected4 = false;
            }
            else if (isSelected5)
            {
                menu menu2 = new menu();
                menu2.FormSendEvent += new menu.FormSendDataHandlar(DieaseUpdateEventMethod);
                menu2.recieveTable = 5;
                menu2.ShowDialog();
                textBox5.ScrollBars = ScrollBars.Vertical;
                isSelected5 = false;
            }
            else if (isSelected6)
            {
                menu menu2 = new menu();
                menu2.FormSendEvent += new menu.FormSendDataHandlar(DieaseUpdateEventMethod);
                menu2.recieveTable = 6;
                menu2.ShowDialog();
                textBox6.ScrollBars = ScrollBars.Vertical;
                isSelected6 = false;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*if (isSelected)
            {
                
                isSelected = false;
            }*/

            if (this.textBox1.BackColor == Color.White && isSelected1)
            {
                this.textBox1.BackColor = Color.Red;
                isSelected1 = false;
            }

            else if (this.textBox2.BackColor == Color.White && isSelected2)
            {
                this.textBox2.BackColor = Color.Red;
                isSelected2 = false;

            }
            else if (this.textBox3.BackColor == Color.White && isSelected3)
            {
                this.textBox3.BackColor = Color.Red;
                isSelected3 = false;
            }
            else if (this.textBox4.BackColor == Color.White && isSelected4)
            {
                this.textBox4.BackColor = Color.Red;
                isSelected4 = false;
            }
            else if (this.textBox5.BackColor == Color.White && isSelected5)
            {
                this.textBox5.BackColor = Color.Red;
                isSelected5 = false;
            }
            else if (this.textBox6.BackColor == Color.White && isSelected6)
            {
                this.textBox6.BackColor = Color.Red;
                isSelected6 = false;
            }



        }

       

        private void button4_Click(object sender, EventArgs e) // 상치우기
        {

            if (isSelected1)
            {
             if(MessageBox.Show("삭제하시겠습니까?", "삭제확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
               {
                    this.textBox1.BackColor = Color.White;
                    textBox1.Clear();
                    textBox1.ScrollBars = ScrollBars.None;
                    textBox1.Text = ("1번");
                    isSelected1 = false;  //yes 이벤트

                    if (tablenum == 1)
                    {
                        menu.reset_menu(tablenum);
                    }
                    else if (tablenum == 2)
                    {
                        menu.reset_menu(tablenum);
                    }
                    else if (tablenum == 3)
                    {
                        menu.reset_menu(tablenum);
                    }
                    else if (tablenum == 4)
                    {
                        menu.reset_menu(tablenum);
                    }
                    else if (tablenum == 5)
                    {
                        menu.reset_menu(tablenum);
                    }
                    else if (tablenum == 6)
                    {
                        menu.reset_menu(tablenum);
                    }
                }
                else 
                {
                    //no 이벤트
                }
                
            }
            else if (isSelected2)
            {
                if (MessageBox.Show("삭제하시겠습니까?", "삭제확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.textBox2.BackColor = Color.White;
                    textBox2.Clear();
                    textBox2.ScrollBars = ScrollBars.None;
                    textBox2.Text = ("2번");
                    isSelected2 = false;  //yes 이벤트
                }
                else
                {
                    //no 이벤트
                }
            }
            else if (isSelected3)
            {
                if (MessageBox.Show("삭제하시겠습니까?", "삭제확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.textBox3.BackColor = Color.White;
                    textBox3.Clear();
                    textBox3.ScrollBars = ScrollBars.None;
                    textBox3.Text = ("3번");
                    isSelected3 = false;  //yes 이벤트
                }
                else
                {
                    //no 이벤트
                }
            }
            else if (isSelected4)
            {
                if (MessageBox.Show("삭제하시겠습니까?", "삭제확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.textBox4.BackColor = Color.White;
                    textBox4.Clear();
                    textBox4.ScrollBars = ScrollBars.None;
                    textBox4.Text = ("4번");
                    isSelected4 = false;  //yes 이벤트
                }
                else
                {
                    //no 이벤트
                }
            }
            else if (isSelected5)
            {
                if (MessageBox.Show("삭제하시겠습니까?", "삭제확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.textBox5.BackColor = Color.White;
                    textBox5.Clear();
                    textBox5.ScrollBars = ScrollBars.None;
                    textBox5.Text = ("5번");
                    isSelected5 = false;  //yes 이벤트
                }
                else
                {
                    //no 이벤트
                }
            }
            else if (isSelected6)
            {
                if (MessageBox.Show("삭제하시겠습니까?", "삭제확인", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.textBox6.BackColor = Color.White;
                    textBox6.Clear();
                    textBox6.ScrollBars = ScrollBars.None;
                    textBox6.Text = ("6번");
                    isSelected6 = false;  //yes 이벤트
                }
                else
                {
                    //no 이벤트
                }
            }
            else
            {

            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

            isSelected = true;
        }

        public void textBox1_Click(object sender, EventArgs e)
        {
            SelectClear();
            isSelected1 = true;
            tablenum = 1;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            SelectClear();
            isSelected2 = true;
            tablenum = 2;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            SelectClear();
            isSelected3 = true;
            tablenum = 3;
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            SelectClear();
            isSelected4 = true;
            tablenum = 4;
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            SelectClear();
            isSelected5 = true;
            tablenum = 5;
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            SelectClear();
            isSelected6 = true;
            tablenum = 6;
        }

        private void SelectClear()
        {
            isSelected1 = false;
            isSelected2 = false;
            isSelected3 = false;
            isSelected4 = false;
            isSelected5 = false;
            isSelected6 = false;

        }

       

    }
}