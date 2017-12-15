using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caculator
{
    public partial class Calculator : Form
    {
        private string st = "";
        private string Ans = "0";
        public Calculator()
        {
            InitializeComponent();
        }
        private void btn_AC_Click(object sender, EventArgs e)
        {
            st = "";
            lb_screen.Text = "";
            OFFtoanhang();
            btn_minus.Enabled = true;
            btn_add.Enabled = true;
        }
        private void btn_C_Click(object sender, EventArgs e)
        {
            if (st != "")
            {
                st = st.Remove(st.Length - 1);
                lb_screen.Text = st;
                ONtoanhang();
            }
            else
            {
                lb_screen.Text = "0";
            }

        }
        private void btn_period_Click(object sender, EventArgs e)
        {
            st += ".";
            lb_screen.Text += ".";
        }
        private void btn_0_Click(object sender, EventArgs e)
        {
            deleteSCreen();
            st += "0";
            lb_screen.Text += 0;
            ONtoanhang();
        }
        private void btn_1_Click(object sender, EventArgs e)
        {
            deleteSCreen();
            st += "1";
            lb_screen.Text += 1;
            ONtoanhang();
        }
        private void btn_2_Click(object sender, EventArgs e)
        {
            deleteSCreen();
            st += "2";
            lb_screen.Text += 2;
            ONtoanhang();
        }
        private void btn_3_Click(object sender, EventArgs e)
        {
            deleteSCreen();
            st += "3";
            lb_screen.Text += 3;
            ONtoanhang();
        }
        private void btn_4_Click(object sender, EventArgs e)
        {
            deleteSCreen();
            st += "4";
            lb_screen.Text += 4;
            ONtoanhang();
        }
        private void btn_5_Click(object sender, EventArgs e)
        {
            deleteSCreen();
            st += "5";
            lb_screen.Text += 5;
            ONtoanhang();
        }
        private void btn_6_Click(object sender, EventArgs e)
        {
            deleteSCreen();
            st += "6";
            lb_screen.Text += 6;
            ONtoanhang();
        }
        private void btn_7_Click(object sender, EventArgs e)
        {
            deleteSCreen();
            st += "7";
            lb_screen.Text += 7;
            ONtoanhang();
        }
        private void btn_8_Click(object sender, EventArgs e)
        {
            deleteSCreen();
            st += "8";
            lb_screen.Text += 8;
            ONtoanhang();
        }
        private void btn_9_Click(object sender, EventArgs e)
        {
            deleteSCreen();
            st += "9";
            lb_screen.Text += 9;
            ONtoanhang();
        }
        private void btn_pi_Click(object sender, EventArgs e)
        {
            deleteSCreen();
            st += "3.14";
            lb_screen.Text += "pi";
            ONtoanhang();
        }
        private void btn_MN_Click(object sender, EventArgs e)
        {
            deleteSCreen();
            st += "(";
            lb_screen.Text += "(";
            ONtoanhang();
        }
        private void btn_DN_Click(object sender, EventArgs e)
        {
            deleteSCreen();
            st += ")";
            lb_screen.Text += ")";
            ONtoanhang();
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            deleteSCreen();
            st += "+";
            lb_screen.Text += "+";
            OFFtoanhang();
        }
        private void btn_minus_Click(object sender, EventArgs e)
        {
            deleteSCreen();
            st += "-";
            lb_screen.Text += " -";
            OFFtoanhang();
        }
        private void btn_multiply_Click(object sender, EventArgs e)
        {
            deleteSCreen();
            st += "x";
            lb_screen.Text += "x";
            OFFtoanhang();
        }
        private void btn_devide_Click(object sender, EventArgs e)
        {
            deleteSCreen();
            st += "/";
            lb_screen.Text += "/";
            OFFtoanhang();
        }
        private void btn_equals_Click(object sender, EventArgs e)
        {
            if (st != "")
            {
                deleteSCreen();
                if (debugSymble(st) == 1 && ktratoanhang(st) == 1 && !ktdaucham(st)&&!ktdaungoac(st))
                {
                    lb_screen.Text += '\n';
                    lb_screen.Text += hauto.chuyenhauto(st);                    
                    Ans = hauto.chuyenhauto(st);
                    lb_screen.Text += '\n';
                }
                else
                {
                    lb_screen.Text = "";
                    lb_screen.Text = "Syntax Error";
                }
                st = "=";
                OFFtoanhang();
                btn_minus.Enabled = true;
                btn_add.Enabled = true;
            }
            else
            {
                lb_screen.Text = "0";
            }
        }
        private void btn_Ans_Click(object sender, EventArgs e)
        {
            st = Ans;
            lb_screen.Text = "Ans";
            ONtoanhang();
        }
        private void btn_OFF_Click(object sender, EventArgs e)
        {
            if (btn_0.Enabled == true)
            {
                btn_0.Enabled = false;
                btn_1.Enabled = false;
                btn_2.Enabled = false;
                btn_3.Enabled = false;
                btn_4.Enabled = false;
                btn_5.Enabled = false;
                btn_8.Enabled = false;
                btn_7.Enabled = false;
                btn_6.Enabled = false;
                btn_period.Enabled = false;
                btn_9.Enabled = false;
                btn_pi.Enabled = false;
                btn_Ans.Enabled = false;
                btn_C.Enabled = false;
                btn_AC.Enabled = false;
                OFFtoanhang();
                btn_MN.Enabled = false;
                btn_DN.Enabled = false;
                btn_Mod.Enabled = false;
                btn_OFF.Text = "ON";
                lb_screen.Text = "";
                st = "";
            }
            else
            {

                btn_0.Enabled = true;
                btn_1.Enabled = true;
                btn_2.Enabled = true;
                btn_3.Enabled = true;
                btn_4.Enabled = true;
                btn_5.Enabled = true;
                btn_8.Enabled = true;
                btn_7.Enabled = true;
                btn_6.Enabled = true;
                btn_period.Enabled = true;
                btn_9.Enabled = true;
                btn_pi.Enabled = true;
                btn_Ans.Enabled = true;
                btn_AC.Enabled = true;
                btn_MN.Enabled = true;
                btn_DN.Enabled = true;
                
                btn_OFF.Text = "OFF";
            }
        }
        private void btn_Mod_Click(object sender, EventArgs e)
        {
            deleteSCreen();
            st += "%";
            lb_screen.Text += "Mod";
            OFFtoanhang();
        }
        private void deleteSCreen()
        {
            if (st == "=")
            {
                lb_screen.Text = "";
                st = "";
            }
        }
        private int debugSymble(string st)
        {
            int len = st.Length;
            if ((st[len - 1] < '0' || st[len - 1] > '9') && st[len - 1] != ')')
                return 0;
            if (st[0] == '*' || st[0] == '/' || st[0] == '%')
                return 0;
            for(int i = 0; i < len; i++)
            {
                if ((st[i] < '0' || st[i] > '9') && st[i] != '(' && st[i] != ')')
                {
                    if (st[i + 1] == '*')
                        return 0;
                    if (st[i + 1] == '/')
                        return 0;
                    if (st[i + 1] == '%')
                        return 0;
                }
            }
            return 1;
        }
        private void ONtoanhang()
        {
            btn_add.Enabled = true;
            btn_minus.Enabled = true;
            btn_multiply.Enabled = true;
            btn_devide.Enabled = true;
            btn_Mod.Enabled = true;
            btn_equals.Enabled = true;
            btn_C.Enabled = true;
        }
        private void OFFtoanhang()
        {
            btn_add.Enabled = false;
            btn_minus.Enabled = false;
            btn_multiply.Enabled = false;
            btn_devide.Enabled = false;
            btn_Mod.Enabled = false;
            btn_equals.Enabled = false;
        }
        private int ktratoanhang(string s)
        {
            for(int i = 0; i < s.Length; i++)
            {
                if(s[i]=='+' || s[i] == '-' || s[i] == 'x' || s[i] == '/' || s[i] == '%')
                {
                    if(s[i+1]=='+'||s[i+1]=='-' || s[i + 1] == 'x' || s[i + 1] == '/' || s[i + 1] == '%')
                    {
                        return 0;
                    }
                }

            }
            return 1;
        }
        private bool ktdaucham(string s)
        {
            s += "+";
            int k = 0;
            for(int i = 0; i < s.Length; i++)
            {
                int count = 0;
                
                if ((s[i] > '9' || s[i] < '0') && s[i] != '.' && s[i] != '(' && s[i] != ')')
                {
                    int j;
                    for (j = k; j < i; j++)
                    {
                        if (s[j] == '.')
                        {
                            count++;
                            k = i;
                        }
                    }
                    if (count > 1) return true;
                    i = j + 1;
                }
            }
            
            return false;
        }
        private bool ktdaungoac(string s)
        {
            int ktm = 0;
            int ktd = 0;
            for(int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    ktm++;
                }
                if (s[i] == ')')
                {
                    ktd++;
                }
            }
            if (ktm != ktd)
                return true;
            return false;
        }
    }
}
