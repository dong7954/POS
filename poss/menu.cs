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
    public partial class menu : Form
    {
        public delegate void FormSendDataHandlar(string sendstring);
        public event FormSendDataHandlar FormSendEvent;

        static string[] now_menu_info = now_menu_info = Enumerable.Repeat("", 1000).ToArray();

        static int tn; // 테이블 번호를 기억할 변수

        int [] m_num = new int[7];

        private int _recieveTable;
        public int recieveTable
        {
            get { return _recieveTable; }
            set { _recieveTable = value; }
        }

        public menu()
        {
            InitializeComponent();
            table1.tNumber = "1번";
            table2.tNumber = "2번";
            table3.tNumber = "3번";
            table4.tNumber = "4번";
            table5.tNumber = "5번";
            table6.tNumber = "6번";
        }

        public static void menu_info(string m1, string m2, string m3, string m4, string m5, string m6, string m7, int tn)
        {
            string menu_info = m1.ToString() + '\x01' + m2.ToString() + '\x01' + m3.ToString() + '\x01' + m4.ToString() 
                + '\x01' + m5.ToString() + '\x01' + m6.ToString() + '\x01' + m7.ToString();
            now_menu_info[tn] = menu_info;
        }

        public static void reset_menu(int tn)
        {
            now_menu_info[tn] = "";
        }

        public void set_menu_info(int tn)
        {
            string [] menu = now_menu_info[tn].Split('\x01');
            textBox8.Text = menu[0];
            textBox9.Text = menu[1];
            textBox10.Text = menu[2];
            textBox11.Text = menu[3];
            textBox12.Text = menu[4];
            textBox13.Text = menu[5];
            textBox14.Text = menu[6];
        }

        //메뉴판
        private static int a;  //돼지생삼겹살
        private static int a1; //돼지갈비
        private static int a2; //돼지생목살
        private static int a3; //계란찜
        private static int a4; //된장찌개
        private static int a5; //소주
        private static int a6; //맥주

        bool isSelected1 = false;
        bool isSelected2 = false;
        bool isSelected3 = false;
        bool isSelected4 = false;
        bool isSelected5 = false;
        bool isSelected6 = false;

        Table table1 = new Table();
        Table table2 = new Table();
        Table table3 = new Table();
        Table table4 = new Table();
        Table table5 = new Table();
        Table table6 = new Table();

        double g;

        private string allMenu;
        private string menunumber;

        private void menu_Load(object sender, EventArgs e)
        {
            tn = main.send_tn();

            if (now_menu_info[tn] =="")
            {
            }
            else
            {
                set_menu_info(tn);
            }

            if (recieveTable == 1)
                isSelected1 = true;
            else if (recieveTable == 2)
                isSelected2 = true;
            else if (recieveTable == 3)
                isSelected3 = true;
            else if (recieveTable == 4)
                isSelected4 = true;
            else if (recieveTable == 5)
                isSelected5 = true;
            else if (recieveTable == 6)
                isSelected6 = true;
           
        }

        //메뉴추가
        //1번 메뉴 추가
        public void button1_Click(object sender, EventArgs e)
        {
            /*if (isSelected1)
            {
                AddMenu1(table1);
                a = int.Parse(sendCount1(table1));

            }
            else if (isSelected2)
            {
                AddMenu1(table2);
                a = int.Parse(sendCount1(table2));
            }
            else if (isSelected3)
            {
                AddMenu1(table3);
                a = int.Parse(sendCount1(table3));
            }
            else if (isSelected4)
            {
                AddMenu1(table4);
                a = int.Parse(sendCount1(table4));
            }
            else if (isSelected5)
            {
                AddMenu1(table5);
                a = int.Parse(sendCount1(table5));
            }
            else if (isSelected6)
            {
                AddMenu1(table6);
                a = int.Parse(sendCount1(table6));
            }*/

            m_num[0] = Int32.Parse(textBox8.Text);
            m_num[0]++;
            textBox8.Text = m_num[0].ToString();
        }
        //2번 메뉴 추가
        private void button2_Click(object sender, EventArgs e)
        {
            /*if (isSelected1)
            {
                AddMenu2(table1);
                a1 = int.Parse(sendCount2(table1));
            }
            else if (isSelected3)
            {
                AddMenu2(table2);
                a1 = int.Parse(sendCount2(table2));
            }
            else if (isSelected4)
            {
                AddMenu2(table3);
                a1 = int.Parse(sendCount2(table3));
            }
            else if (isSelected4)
            {
                AddMenu2(table4);
                a1 = int.Parse(sendCount2(table4));
            }
            else if (isSelected5)
            {
                AddMenu2(table5);
                a1 = int.Parse(sendCount2(table5));
            }
            else if (isSelected6)
            {
                AddMenu2(table6);
                a1 = int.Parse(sendCount2(table6));
            }
            textBox9.Text = a1.ToString();   //더하기
            */
            m_num[1] = Int32.Parse(textBox9.Text);
            m_num[1]++;
            textBox9.Text = m_num[1].ToString();
        }
        //3번 메뉴 추가
        private void button3_Click(object sender, EventArgs e)
        {
            /*if (isSelected1)
            {
                AddMenu3(table1);
                a2 = int.Parse(sendCount3(table1));
            }
            else if (isSelected2)
            {
                AddMenu3(table2);
                a2 = int.Parse(sendCount3(table2));
            }
            else if (isSelected3)
            {
                AddMenu3(table3);
                a2 = int.Parse(sendCount3(table3));
            }
            else if (isSelected4)
            {
                AddMenu3(table4);
                a2 = int.Parse(sendCount3(table4));
            }
            else if (isSelected5)
            {
                AddMenu3(table5);
                a2 = int.Parse(sendCount3(table5));
            }
            else if (isSelected6)
            {
                AddMenu3(table6);
                a2 = int.Parse(sendCount3(table6));
            }
            textBox10.Text = a2.ToString();  //더하기
            */
            m_num[2] = Int32.Parse(textBox10.Text);
            m_num[2]++;
            textBox10.Text = m_num[2].ToString();
        }
        //4번 메뉴 추가
        private void button4_Click(object sender, EventArgs e)
        {
            /*if (isSelected1)
            {
                AddMenu4(table1);
                a3 = int.Parse(sendCount4(table1));
            }
            else if (isSelected2)
            {
                AddMenu4(table2);
                a3 = int.Parse(sendCount4(table2));
            }
            else if (isSelected3)
            {
                AddMenu4(table3);
                a3 = int.Parse(sendCount4(table3));
            }
            else if (isSelected4)
            {
                AddMenu4(table4);
                a3 = int.Parse(sendCount4(table4));
            }
            else if (isSelected5)
            {
                AddMenu4(table5);
                a3 = int.Parse(sendCount4(table5));
            }
            else if (isSelected6)
            {
                AddMenu4(table6);
                a3 = int.Parse(sendCount4(table6));
            }
            textBox11.Text = a3.ToString();  //더하기
            */
            m_num[3] = Int32.Parse(textBox11.Text);
            m_num[3]++;
            textBox11.Text = m_num[3].ToString();

        }
        //5번 메뉴 추가
        private void button5_Click(object sender, EventArgs e)
        {
            /*if (isSelected1)
            {
                AddMenu5(table1);
                a4 = int.Parse(sendCount5(table1));
            }
            else if (isSelected2)
            {
                AddMenu5(table2);
                a4 = int.Parse(sendCount5(table2));
            }
            else if (isSelected3)
            {
                AddMenu5(table3);
                a4 = int.Parse(sendCount5(table3));
            }
            else if (isSelected4)
            {
                AddMenu5(table4);
                a4 = int.Parse(sendCount5(table4));
            }
            else if (isSelected5)
            {
                AddMenu5(table5);
                a4 = int.Parse(sendCount5(table5));
            }
            else if (isSelected6)
            {
                AddMenu5(table6);
                a4 = int.Parse(sendCount5(table6));
            }
            textBox12.Text = a4.ToString(); //더하기
            */
            m_num[4] = Int32.Parse(textBox12.Text);
            m_num[4]++;
            textBox12.Text = m_num[4].ToString();
        }
        //6번 메뉴 추가
        private void button6_Click(object sender, EventArgs e)
        {
            /*
            if (isSelected1)
            {
                AddMenu6(table1);
                a5 = int.Parse(sendCount6(table1));
            }
            else if (isSelected2)
            {
                AddMenu6(table2);
                a5 = int.Parse(sendCount6(table2));
            }
            else if (isSelected3)
            {
                AddMenu6(table3);
                a5 = int.Parse(sendCount6(table3));
            }
            else if (isSelected4)
            {
                AddMenu6(table4);
                a5 = int.Parse(sendCount6(table4));
            }
            else if (isSelected5)
            {
                AddMenu6(table5);
                a5 = int.Parse(sendCount6(table5));
            }
            else if (isSelected6)
            {
                AddMenu6(table6);
                a5 = int.Parse(sendCount6(table6));
            }
            textBox13.Text = a5.ToString();  //더하기
            */
            m_num[5] = Int32.Parse(textBox13.Text);
            m_num[5]++;
            textBox13.Text = m_num[5].ToString();

        }
        //7번 메뉴 추가
        private void button7_Click(object sender, EventArgs e)
        {
            /*
            if (isSelected1)
            {
                AddMenu7(table1);
                a6 = int.Parse(sendCount7(table1));
            }
            else if (isSelected2)
            {
                AddMenu7(table2);
                a6 = int.Parse(sendCount7(table2));
            }
            else if (isSelected3)
            {
                AddMenu7(table3);
                a6 = int.Parse(sendCount7(table3));
            }
            else if (isSelected4)
            {
                AddMenu7(table4);
                a6 = int.Parse(sendCount7(table4));
            }
            else if (isSelected5)
            {
                AddMenu7(table5);
                a6 = int.Parse(sendCount7(table5));
            }
            else if (isSelected6)
            {
                AddMenu7(table6);
                a6 = int.Parse(sendCount7(table6));
            }

            textBox14.Text = a6.ToString();   //더하기
            */
            m_num[6] = Int32.Parse(textBox14.Text);
            m_num[6]++;
            textBox14.Text = m_num[6].ToString();
        }
        //메뉴빼기
        private void button8_Click(object sender, EventArgs e)
        {
            /*
            if (isSelected1)
            {
                SubMenu1(table1);
                a = int.Parse(sendCount1(table1));
            }
            else if (isSelected2)
            {
                SubMenu1(table2);
                a = int.Parse(sendCount1(table2));
            }
            else if (isSelected3)
            {
                SubMenu1(table3);
                a = int.Parse(sendCount1(table3));
            }
            else if (isSelected4)
            {
                SubMenu1(table4);
                a = int.Parse(sendCount1(table4));
            }
            else if (isSelected5)
            {
                SubMenu1(table5);
                a = int.Parse(sendCount1(table5));
            }
            else if (isSelected6)
            {
                SubMenu1(table6);
                a = int.Parse(sendCount1(table6));
            }
        
            

            textBox8.Text = a.ToString(); //빼기
            */

            m_num[0] = Int32.Parse(textBox8.Text);
            m_num[0]--;
            if (m_num[0] == -1)
            {
                MessageBox.Show("0밑으로는 내려 갈 수 없습니다!", "오류");
                m_num[0]++;
            }
            textBox8.Text = m_num[0].ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {/*
            if (isSelected1)
            {
                SubMenu2(table1);
                a1 = int.Parse(sendCount2(table1));
            }
            else if (isSelected2)
            {
                SubMenu2(table2);
                a1 = int.Parse(sendCount2(table2));
            }
            else if (isSelected3)
            {
                SubMenu2(table3);
                a1 = int.Parse(sendCount2(table3));
            }
            else if (isSelected4)
            {
                SubMenu2(table4);
                a1 = int.Parse(sendCount2(table4));
            }
            else if (isSelected5)
            {
                SubMenu2(table5);
                a1 = int.Parse(sendCount2(table5));
            }
            else if (isSelected6)
            {
                SubMenu2(table6);
                a1 = int.Parse(sendCount2(table6));
            }

            textBox9.Text = a1.ToString();  //빼기
            */
            m_num[1] = Int32.Parse(textBox9.Text);
            m_num[1]--;
            if (m_num[1] == -1)
            {
                MessageBox.Show("0밑으로는 내려 갈 수 없습니다!", "오류");
                m_num[1]++;
            }
            textBox9.Text = m_num[1].ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            /*
            if (isSelected1)
            {
                SubMenu3(table1);
                a2 = int.Parse(sendCount3(table1));
            }
            else if (isSelected2)
            {
                SubMenu3(table2);
                a2 = int.Parse(sendCount3(table2));
            }
            else if (isSelected3)
            {
                SubMenu3(table3);
                a2 = int.Parse(sendCount3(table3));
            }
            else if (isSelected4)
            {
                SubMenu3(table4);
                a2 = int.Parse(sendCount3(table4));
            }
            else if (isSelected5)
            {
                SubMenu3(table5);
                a2 = int.Parse(sendCount3(table5));
            }
            else if (isSelected6)
            {
                SubMenu3(table6);
                a2 = int.Parse(sendCount3(table6));
            }

            textBox10.Text = a2.ToString(); //빼기
            */

            m_num[2] = Int32.Parse(textBox10.Text);
            m_num[2]--;
            if (m_num[2] == -1)
            {
                MessageBox.Show("0밑으로는 내려 갈 수 없습니다!", "오류");
                m_num[2]++;
            }
            textBox10.Text = m_num[2].ToString();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            /*
            if (isSelected1)
            {
                SubMenu4(table1);
                a3 = int.Parse(sendCount4(table1));
            }
            else if (isSelected2)
            {
                SubMenu4(table2);
                a3 = int.Parse(sendCount4(table2));
            }
            else if (isSelected3)
            {
                SubMenu4(table3);
                a3 = int.Parse(sendCount4(table3));
            }
            else if (isSelected4)
            {
                SubMenu4(table4);
                a3 = int.Parse(sendCount4(table4));
            }
            else if (isSelected5)
            {
                SubMenu4(table5);
                a3 = int.Parse(sendCount4(table5));
            }
            else if (isSelected6)
            {
                SubMenu4(table6);
                a3 = int.Parse(sendCount4(table6));
            }

            textBox11.Text = a3.ToString(); //빼기
            */
            m_num[3] = Int32.Parse(textBox11.Text);
            m_num[3]--;
            if (m_num[3] == -1)
            {
                MessageBox.Show("0밑으로는 내려 갈 수 없습니다!", "오류");
                m_num[3]++;
            }
            textBox11.Text = m_num[3].ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            /*
            if (isSelected1)
            {
                SubMenu5(table1);
                a4 = int.Parse(sendCount5(table1));
            }
            else if (isSelected2)
            {
                SubMenu5(table2);
                a4 = int.Parse(sendCount5(table2));
            }
            else if (isSelected3)
            {
                SubMenu5(table3);
                a4 = int.Parse(sendCount5(table3));
            }
            else if (isSelected4)
            {
                SubMenu5(table4);
                a4 = int.Parse(sendCount5(table4));
            }
            else if (isSelected5)
            {
                SubMenu5(table5);
                a4 = int.Parse(sendCount5(table5));
            }
            else if (isSelected6)
            {
                SubMenu5(table6);
                a4 = int.Parse(sendCount5(table6));
            }

            textBox12.Text = a4.ToString(); //빼기
            */
            m_num[4] = Int32.Parse(textBox12.Text);
            m_num[4]--;
            if (m_num[4] == -1)
            {
                MessageBox.Show("0밑으로는 내려 갈 수 없습니다!", "오류");
                m_num[4]++;
            }
            textBox12.Text = m_num[2].ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            /*
            if (isSelected1)
            {
                SubMenu6(table1);
                a5 = int.Parse(sendCount6(table1));
            }
            else if (isSelected2)
            {
                SubMenu6(table2);
                a5 = int.Parse(sendCount6(table2));
            }
            else if (isSelected3)
            {
                SubMenu6(table3);
                a5 = int.Parse(sendCount6(table3));
            }
            else if (isSelected4)
            {
                SubMenu6(table4);
                a5 = int.Parse(sendCount6(table4));
            }
            else if (isSelected5)
            {
                SubMenu6(table5);
                a5 = int.Parse(sendCount6(table5));
            }
            else if (isSelected6)
            {
                SubMenu6(table6);
                a5 = int.Parse(sendCount6(table6));
            }

            textBox13.Text = a5.ToString(); //빼기
            */
            m_num[5] = Int32.Parse(textBox13.Text);
            m_num[5]--;
            if (m_num[5] == -1)
            {
                MessageBox.Show("0밑으로는 내려 갈 수 없습니다!", "오류");
                m_num[5]++;
            }
            textBox13.Text = m_num[5].ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            /*
            if (isSelected1)
            {
                SubMenu7(table1);
                a6 = int.Parse(sendCount7(table1));
            }
            else if (isSelected2)
            {
                SubMenu7(table2);
                a6 = int.Parse(sendCount7(table2));
            }
            else if (isSelected3)
            {
                SubMenu7(table3);
                a6 = int.Parse(sendCount7(table3));
            }
            else if (isSelected4)
            {
                SubMenu7(table4);
                a6 = int.Parse(sendCount7(table4));
            }
            else if (isSelected5)
            {
                SubMenu7(table5);
                a6 = int.Parse(sendCount7(table5));
            }
            else if (isSelected6)
            {
                SubMenu7(table6);
                a6 = int.Parse(sendCount7(table6));
            }

            textBox14.Text = a6.ToString(); //빼기
            */
            m_num[6] = Int32.Parse(textBox14.Text);
            m_num[6]--;
            if (m_num[6] == -1)
            {
                MessageBox.Show("0밑으로는 내려 갈 수 없습니다!", "오류");
                m_num[6]++;
            }
            textBox14.Text = m_num[6].ToString();
        }
        //메뉴 추가제거 끝


        //메뉴판 보내기
        private void button15_Click(object sender, EventArgs e)
        {
            if (isSelected1) //1번 테이블이 선택되었을때
            {
                SendMenu(table1); //1번 테이블의 메뉴판을 보낸다.
                SelectClear();
               // TextBox_Reset();
            }
            else if (isSelected2) //2번 테이블이 선택되었을때
            {
                SendMenu(table2); //2번 테이블의 메뉴판을 보낸다.
                SelectClear();
               // TextBox_Reset();
            }
            else if (isSelected3) //3번 테이블이 선택되었을때
            {
                SendMenu(table3); //3번 테이블의 메뉴판을 보낸다.
                SelectClear();
               // TextBox_Reset();
            }
            else if (isSelected4) //4번 테이블이 선택되었을때
            {
                SendMenu(table4); //4번 테이블의 메뉴판을 보낸다.
                SelectClear();
              //  TextBox_Reset();
            }
            else if (isSelected5) //5번 테이블이 선택되었을때
            {
                SendMenu(table5); //5번 테이블의 메뉴판을 보낸다.
                SelectClear();
              //  TextBox_Reset();
            }
            else if (isSelected6) //6번 테이블이 선택되었을때
            {
                SendMenu(table6); //6번 테이블의 메뉴판을 보낸다.
                SelectClear();
             //   TextBox_Reset();
            }
           

        }

        private void button16_Click(object sender, EventArgs e)
        {
            Close(); //닫기
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
       /* private void TextBox_Reset()
        {
            textBox8.Text = "0";
            textBox9.Text = "0";
            textBox10.Text = "0";
            textBox11.Text = "0";
            textBox12.Text = "0";
            textBox13.Text = "0";
            textBox14.Text = "0";
        }*/

        private void menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*a = 0;
            a1 = 0;
            a2 = 0;
            a3 = 0;
            a4 = 0;
            a5 = 0;
            a6 = 0;
            */
        }

        //각 메뉴의 개수를 추가
        private void AddMenu1(Table table)
        {
            table.add1();
        }
        private void AddMenu2(Table table)
        {
            table.add2();
        }
        private void AddMenu3(Table table)
        {
            table.add3();
        }
        private void AddMenu4(Table table)
        {
            table.add4();
        }
        private void AddMenu5(Table table)
        {
            table.add5();
        }
        private void AddMenu6(Table table)
        {
            table.add6();
        }
        private void AddMenu7(Table table)
        {
            table.add7();
        }

        //각 메뉴의 개수를 빼기
        private void SubMenu1(Table table)
        {
            table.sub1();
        }
        private void SubMenu2(Table table)
        {
            table.sub2();
        }
        private void SubMenu3(Table table)
        {
            table.sub3();
        }
        private void SubMenu4(Table table)
        {
            table.sub4();
        }
        private void SubMenu5(Table table)
        {
            table.sub5();
        }
        private void SubMenu6(Table table)
        {
            table.sub6();
        }
        private void SubMenu7(Table table)
        {
            table.sub7();
        }

        //각 메뉴의 개수를 나타냄
        private string sendCount1(Table table)
        {
            return table.menu1.ToString();
        }
        private string sendCount2(Table table)
        {
            return table.menu2.ToString();
        }
        private string sendCount3(Table table)
        {
            return table.menu3.ToString();
        }
        private string sendCount4(Table table)
        {
            return table.menu4.ToString();
        }
        private string sendCount5(Table table)
        {
            return table.menu5.ToString();
        }
        private string sendCount6(Table table)
        {
            return table.menu6.ToString();
        }
        private string sendCount7(Table table)
        {
            return table.menu7.ToString();
        }


        //메뉴판을 보내주는 함수
        private void SendMenu(Table table)
        {
            allMenu = "";

            allMenu += table.tNumber + Environment.NewLine;
            //StringBuilder allMenu = new StringBuilder();

            int sum = 0;

            if (textBox8.Text != "0")
            {
                int m1 = int.Parse(textBox8.Text);
                allMenu += "돼지생삼겹살:\t" + m1 + "개     " + (m1 * 10000) + "원" + Environment.NewLine + Environment.NewLine;
                sum += m1*10000;
            }
            if (textBox9.Text != "0")
            {
                int m2 = int.Parse(textBox9.Text);
                allMenu += "돼지갈비:\t" + m2 + "개     " + (m2 * 10000) + "원\n" + Environment.NewLine + Environment.NewLine;
                sum += m2 * 10000;
            }
            if (textBox10.Text != "0")
            {
                int m3 = int.Parse(textBox10.Text);
                allMenu += "돼지생목살:\t" + m3 + "개     " + (m3 * 10000) + "원\n" + Environment.NewLine + Environment.NewLine;
                sum += m3 * 10000;
            }
            if (textBox11.Text != "0")
            {
                int m4 = int.Parse(textBox11.Text);
                allMenu += "계란찜:\t\t" + m4 + "개     " + (m4 * 2000) + "원\n" + Environment.NewLine + Environment.NewLine;
                sum += m4 * 2000;
            }
            if (textBox12.Text != "0")
            {
                int m5 = int.Parse(textBox12.Text);
                allMenu += "된장찌개:\t" + m5 + "개     " + (m5 * 1000) + "원\n" + Environment.NewLine + Environment.NewLine;
                sum += m5 * 1000;
            }
            if (textBox13.Text != "0")
            {
                int m6 = int.Parse(textBox13.Text);
                allMenu += "소주:\t\t" +m6 + "개     " + (m6 * 4000) + "원\n" + Environment.NewLine + Environment.NewLine;
                sum += m6 * 4000;
            }
            if (textBox14.Text != "0")
            {
                int m7 = int.Parse(textBox14.Text);
                allMenu += "맥주:\t\t" + m7 + "개     " + (m7 * 4000) + "원\n" + Environment.NewLine + Environment.NewLine;
                sum += m7 * 4000;
            }
            table.summenu();
            if (textBox8.Text == "0" && textBox9.Text == "0" && textBox10.Text == "0" && textBox11.Text == "0" && textBox12.Text == "0" && 
                textBox13.Text == "0" && textBox14.Text == "0")
            {
               
            }
            else
            {
                allMenu += Environment.NewLine + "총합가격:" + sum;
               
            }
            
            this.FormSendEvent(allMenu);

            Close();//확인
        }
        private void menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            tn = main.send_tn();
            menu_info(textBox8.Text, textBox9.Text, textBox10.Text, textBox11.Text, textBox12.Text, textBox13.Text, textBox14.Text, tn);
            this.Close();
        }
    }
    class Table
    {
        public string tNumber;
        public int menu1 = 0;
        public int menu2 = 0;
        public int menu3 = 0;
        public int menu4 = 0;
        public int menu5 = 0;
        public int menu6 = 0;
        public int menu7 = 0;

        public int result = 0;
      
        //메뉴 추가
        public void add1()
        {
            menu1++;
        }
        public void add2()
        {
            menu2++;
        }
        public void add3()
        {
            menu3++;
        }
        public void add4()
        {
            menu4++;
        }
        public void add5()
        {
            menu5++;
        }
        public void add6()
        {
            menu6++;
        }
        public void add7()
        {
            menu7++;
        }

        //메뉴 뺴기
        public void sub1()
        {
            if (menu1 > 0)
                menu1--;
        }
        public void sub2()
        {
            if (menu2 > 0)
                menu2--;
        }
        public void sub3()
        {
            if (menu3 > 0)
                menu3--;
        }
        public void sub4()
        {
            if (menu4 > 0)
                menu4--;
        }
        public void sub5()
        {
            if (menu5 > 0)
                menu5--;
        }
        public void sub6()
        {
            if (menu6 > 0)
                menu6--;
        }
        public void sub7()
        {
            if (menu7 > 0)
                menu7--;
        }

        public void summenu()
        {
            result = (10000 * menu1) + (10000 * menu2) + (10000 * menu3)
             + (2000 * menu4) + (1000 * menu5) + (4000 * menu6) + (4000 * menu7);
        }
     
    }
    
}
