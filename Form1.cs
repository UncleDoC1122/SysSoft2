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

        private int findIdentidier(List<Tuple<string, short>> mas, string name)
        {
            for (int i = 0; i < mas.Count; i ++)
            {
                if (mas[i].Item1.Equals(name))
                {
                    return i;
                }
            }
            return -1;
        }

        private Tuple<string, short>[] registers = new Tuple<string, short>[8];

        private void magic_Click(object sender, EventArgs e)
        {
            registers[0] = new Tuple<string, short>("eah", 0);
            registers[1] = new Tuple<string, short>("eal", 0);
            registers[2] = new Tuple<string, short>("ebh", 0);
            registers[3] = new Tuple<string, short>("ebl", 0);
            registers[4] = new Tuple<string, short>("ech", 0);
            registers[5] = new Tuple<string, short>("ecl", 0);
            registers[6] = new Tuple<string, short>("edh", 0);
            registers[7] = new Tuple<string, short>("edl", 0);

            string input = tbInput.Text;
            List<string> prog = new List<string>();
            string tmp = "";

            for (int i = 0; i < input.Length; i ++)
            {
                if (input[i].Equals('\n'))
                {
                    prog.Add(tmp);
                    tmp = "";
                }
                else
                {
                    tmp += input[i];
                }
            }

            for (int i = 0; i < prog.Count; i ++)
            {

            }

        }
    }
}
