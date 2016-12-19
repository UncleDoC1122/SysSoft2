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

        private Tuple<string, short>[] registers = new Tuple<string, short>[8];

        private short[] mov(string dst, string src, Tuple<string, short>[] mas)
        {
            short[] outp = new short[2];
            short tmp = -1;
            for (short i = 0; i < mas.Length; i++)
            {
                if (dst.Equals(mas[i].Item1))
                {
                    tmp = i;
                    outp[0] = tmp;
                }
            }
            try
            {
                outp[1] = Convert.ToInt16(src);
                return outp;
            }
            catch
            {
                for (short i = 0; i < mas.Length; i++)
                {
                    if (src.Equals(mas[i].Item1))
                    {
                        outp[1] = i;
                        return outp;
                    }
                }
                outp[1] = -1;
                return outp;
            }
            
        }

        private short push(string src, Tuple<string, short>[] mas)
        {
            try
            {
                return Convert.ToInt16(src);
            }
            catch
            {
                for (short i = 0; i < mas.Length; i++)
                {
                    if (src.Equals(mas[i].Item1))
                    {
                        return i;
                    }
                }
                return -1;
            }
        }

        private short pop(string dst, Tuple<string, short>[] mas)
        {
            
            for (short i = 0; i < mas.Length; i++)
            {
                if (dst.Equals(mas[i].Item1))
                {
                    return i;
                }
            }
                return -1;
            
        }

        private short inc(string dst, Tuple<string, short>[] mas)
        {
            for (short i = 0; i < mas.Length; i ++)
            {
                if (dst.Equals(mas[i].Item1))
                {
                    return i;
                }
            }
            return -1;
        }


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


        }
    }
}
