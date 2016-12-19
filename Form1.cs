using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysSoft2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int findIdentidier(Tuple<string, short>[] mas, string name)
        {
            for (int i = 0; i < mas.Length; i ++)
            {
                if (mas[i].Item1.Equals(name))
                {
                    return i;
                }
            }
            return -1;
        }

        private void lexemAnalyzer(string input)
        {
            List<string> prog = new List<string>();
            string tmp = "";
            for (int i = 0; i < input.Length; i ++)
            {
                if (input[i].Equals(';'))
                {
                    prog.Add(tmp);
                    tmp = "";
                }
                else if(!input[i].Equals('\r') && !input[i].Equals('\n'))
                {
                    tmp += input[i];
                }
            }

            int keyWordCounter = 0;
            int identifiersCounter = 0;
            List<Tuple<int, string>> pairs = new List<Tuple<int, string>>();
            String tmpr;

            for (int i = 0; i < prog.Count; i ++)
            {
                List<string> tmp2 = separator(prog[i]);

                for (int j = 0; j < tmp2.Count; j ++)
                {
                    if (tmp2[j] == "eah" || tmp2[j] == "ebh" || tmp2[j] == "ech" || tmp2[j] == "edh" || tmp2[j] == "eal" || tmp2[j] == "ebl" || tmp2[j] == "ecl" || tmp2[j] == "edl")
                    {
                        bool flah = false;
                        for (int k = 0; k < pairs.Count; k ++)
                        {
                            if (pairs.Contains(new Tuple<int, string>(k + 1, tmp2[j])))
                            {
                                flah = true;
                                tmpr = tmp2[j] + " : " + pairs[k].Item1;
                                dataLexemes.Rows.Add(tmp2[j], "Identifier (register)", tmpr);
                            } 
                        }
                        if (flah == false)
                        {
                            tmpr = tmp2[j] + " : " + ++identifiersCounter;
                            pairs.Add(new Tuple<int, string>(identifiersCounter, tmp2[j]));
                            dataLexemes.Rows.Add(tmp2[j], "Identifier (register)", tmpr);
                        }
                        
                    }
                    else if (tmp2[j] == "mov" || tmp2[j] == "add" || tmp2[j] == "pop" || tmp2[j] == "inc" || tmp2[j] == "div" || tmp2[j] == "push")
                    {
                        tmpr = tmp2[j] + " " + ++keyWordCounter;
                        dataLexemes.Rows.Add(tmp2[j], "Keyword", tmpr);
                    }
                    else
                    {
                        dataLexemes.Rows.Add(tmp2[j], "Variable", tmp2[j]);
                    }
                }
            }

        }

        private List<string> separator(String input)
        {
            List<string> output = new List<string>();
            string putter = "";
            for (int i = 0; i < input.Length; i ++)
            {
                if (input[i].Equals(' '))
                {
                    output.Add(putter);
                    putter = "";
                }
                else if (input[i].Equals(';') == false)
                {
                    putter += input[i];
                    
                }
            }
            output.Add(putter);

            return output;
        }

        private void outputting(Tuple<string, short>[] registers, Stack<short> stack, int step)
        {
            tbOutp.AppendText("Step " + step + "-----------------------------");
            for (int i = 0; i < registers.Length; i ++)
            {
                tbOutp.AppendText(registers[i].Item1 + ": " + registers[i].Item2.ToString() + "; ");
            }

            tbOutp.AppendText("Stack:\n");

            for (int i = 0; i < stack.Count; i ++)
            {
                tbOutp.AppendText(stack.Pop().ToString());
            }
            
        }

        private Tuple<string, short>[] registers = new Tuple<string, short>[8];
        private Stack<short> stack = new Stack<short>();

        private void magic_Click_1(object sender, EventArgs e)
        {
            tbOutp.Clear();
            registers[0] = new Tuple<string, short>("eah", 0);
            registers[1] = new Tuple<string, short>("eal", 0);
            registers[2] = new Tuple<string, short>("ebh", 0);
            registers[3] = new Tuple<string, short>("ebl", 0);
            registers[4] = new Tuple<string, short>("ech", 0);
            registers[5] = new Tuple<string, short>("ecl", 0);
            registers[6] = new Tuple<string, short>("edh", 0);
            registers[7] = new Tuple<string, short>("edl", 0);

            string input = tbInput.Text;
            lexemAnalyzer(input);
            List<string> prog = new List<string>();
            string tmp = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Equals(';'))
                {
                    prog.Add(tmp);
                    tmp = "";
                }
                else if (!input[i].Equals('\r') && !input[i].Equals('\n'))
                {
                    tmp += input[i];
                }
            }

            for (int i = 0; i < prog.Count; i++)
            {
                List<string> parsed = separator(prog[i]);
                try
                {
                    int tmpIdent = -1;
                    int tmpIdent2 = -1;
                    short tmpValue = -1;
                    switch (parsed[0])
                    {
                        case "mov":
                            tmpIdent = findIdentidier(registers, parsed[1]);
                            try
                            {
                                registers[tmpIdent] = new Tuple<string, short>(registers[tmpIdent].Item1, Convert.ToInt16(parsed[2]));
                            }
                            catch
                            {
                                tmpIdent2 = findIdentidier(registers, parsed[2]);
                                registers[tmpIdent] = new Tuple<string, short>(registers[tmpIdent].Item1, registers[tmpIdent].Item2);

                            }

                            break;
                        case "push":
                            tmpIdent = findIdentidier(registers, parsed[0]);

                            stack.Push(registers[tmpIdent].Item2);

                            break;
                        case "pop":
                            tmpIdent = findIdentidier(registers, parsed[1]);

                            registers[tmpIdent] = new Tuple<string, short>(registers[tmpIdent].Item1, stack.Pop());

                            break;
                        case "inc":
                            tmpIdent = findIdentidier(registers, parsed[1]);

                            tmpValue = registers[tmpIdent].Item2;
                            tmpValue++;

                            registers[tmpIdent] = new Tuple<string, short>(registers[tmpIdent].Item1, tmpValue);

                            break;
                        case "add":
                            tmpIdent = findIdentidier(registers, parsed[1]);
                            try
                            {
                                tmpValue = Convert.ToInt16(parsed[2]);
                                tmpValue += registers[tmpIdent].Item2;
                                registers[tmpIdent] = new Tuple<string, short>(registers[tmpIdent].Item1, tmpValue);
                            }
                            catch
                            {
                                tmpIdent2 = findIdentidier(registers, parsed[2]);

                                tmpValue = registers[tmpIdent].Item2;
                                tmpValue += registers[tmpIdent2].Item2;

                                registers[tmpIdent] = new Tuple<string, short>(registers[tmpIdent].Item1, tmpValue);
                            }

                            break;
                        case "div":
                            tmpIdent = findIdentidier(registers, parsed[1]);
                            try
                            {
                                tmpValue = registers[tmpIdent].Item2;
                                tmpValue /= Convert.ToInt16(parsed[2]);
                                registers[tmpIdent] = new Tuple<string, short>(registers[tmpIdent].Item1, tmpValue);
                            }
                            catch
                            {
                                tmpIdent2 = findIdentidier(registers, parsed[2]);

                                tmpValue = registers[tmpIdent].Item2;
                                tmpValue /= registers[tmpIdent2].Item2;

                                registers[tmpIdent] = new Tuple<string, short>(registers[tmpIdent].Item1, tmpValue);
                            }

                            break;
                        default:
                            break;
                    }
                }
                catch
                {
                    MessageBox.Show("COMPILATION ERROR");
                    return;
                }

                outputting(registers, stack, i + 1);
            }

        }
    }
}
