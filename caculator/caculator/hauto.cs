using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caculator
{
    class hauto
    {        
        private static int UuTien(char c)
        {
            if (c == '(') return 0;
            if (c == '+' || c == '-') return 1;
            if (c == 'x' || c == '/' || c == '%') return 2;
            return 15;
        }

        public static string Hauto(string str)
        {
            Stack<char> s = new Stack<char>();
            string btht = "";
            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (c != ' ')
                {
                    if ((c - '0' >= 0 && c - '9' <= 9)||c=='.')
                    {
                        btht += c.ToString();
                    }
                    else
                    {
                        btht += " ";
                        if (c == '(')
                        {
                            s.Push(c);
                        }
                        else
                        {
                            if (c == ')')
                            {
                                while (s.Peek() != '(')
                                {
                                    btht += s.Pop().ToString();
                                }
                                s.Pop();
                            }
                            else
                            {
                                while (s.Count() != 0 && UuTien(c) <= UuTien(s.Peek()))
                                {
                                    btht += s.Pop().ToString();
                                    btht += " ";

                                }
                                s.Push(c);
                            }
                        }



                    }
                }
            }
            while (s.Count() != 0)
            {
                btht += " ";
                btht += s.Pop().ToString();

            }
            return btht;
        }
       
        private static bool ktspace(string str)
        {
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                    return true;
            }
            return false;
        }
        public static string chuyenhauto(string str)
        {
            Stack<double> s = new Stack<double>();
            string kq = Hauto(str);
            
            s.Push(0);
            string st = "";
            for(int i = 0; i < kq.Length; i++)
            {
                if ((kq[i] - '0' >= 0 && kq[i] - '9' <= 9) || kq[i] == '.')
                {
                    if (ktspace(kq))
                    {
                        for (int j = i; j < kq.Length; j++)
                        {
                            if ((kq[j] - '0' < 0 || kq[j] - '0' > 9) && kq[j] != '.')
                            {

                                st = kq.Substring(i, j - i);
                                i = j;

                                break;
                            }
                        }
                    }else
                    {
                        st = kq;
                    }
                    double t = double.Parse(st);
                    s.Push(t);
                    
                    
                }
                else
                    if (kq[i] != ' ' && s.Count() != 0 && kq[i] != '.')
                    {
                    double b = s.Pop(); 
                    double a = s.Pop(); 
                    if (kq[i] == '+') s.Push(a + b);
                    if (kq[i] == '-') s.Push(a - b);
                    if (kq[i] == 'x') s.Push(a * b);
                    if (kq[i] == '/') s.Push(a / b);
                    if (kq[i] == '%') s.Push(a % b);                   
                    }
                
            }
            if (s.Count() != 0)
                kq = s.Peek().ToString();
                return kq;
        }
    }
}

