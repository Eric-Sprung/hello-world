using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class oberflaeche : Form
    {
        private double sln = 0.0;
        String p = "Verlauf.txt";
        private List<char> operants = new List<char>();
        private List<double> values = new List<double>();
        public oberflaeche()
        {
            InitializeComponent();
        }

        private void verlaufLöschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Verlauf speichern");
            try {

                FileStream fs = new FileStream(Path.GetFullPath(this.p), FileMode.OpenOrCreate, FileAccess.ReadWrite);
                TextWriter tw = new StreamWriter(fs);
                //foreach (String txt in display.Lines) {
                //    sw.WriteLine(txt);
                //}
                tw.Write("hallo File");
                fs.Close();
            } catch (Exception ee){
                Console.WriteLine(ee.Message);
            }
        }

        private void verlaufLöschenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            deleteAll();
            String textHelp = "";
            try
            {
                var fs = File.Open("Verlauf.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                var sr = new StreamReader(fs);
                textHelp = sr.ReadToEnd();
                fs.Close();
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.Message);
            }
            String[] text = textHelp.Split('\n');
            int changer = 0;
            try
            {
                foreach (String txt in text)
                {
                    if ((changer%2) == 0)
                    {
                        Convert.ToDouble(txt);
                    }
                    if ((changer % 2) == 1)
                    {
                        Convert.ToChar(txt.ToCharArray()[0]);
                    }
                    changer++;
                }
                display.Text = textHelp;
            }
            catch (FormatException) {
                MessageBox.Show("Invalid File");
                deleteAll();
            }
        }

        private void verlaufLöschenToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Verlauf löschen");
            deleteAll();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            display.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            display.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            display.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            display.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            display.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            display.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            display.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            display.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            display.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            display.Text += "0";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (ListenHandling('+'))
            {
                display.Text += "\n+\n";
            }
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            if (ListenHandling('-'))
            {
                display.Text += "\n-\n";
            }
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            if (ListenHandling('*')) {
                display.Text += "\n*\n";
            }
            
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            if (ListenHandling('/'))
            {
                display.Text += "\n/\n";
            }
        }

        private void btnsln_Click(object sender, EventArgs e)
        {
            this.calculate();
            display.Text +="\n=\n"+this.sln+"\n";
           
        }
        private void calculate() {
            //still buggy
            double operat1 = 0.0;
            double operat2 = 0.0;
            try
            {
                if (ListenHandling('='))
                {
                    operat1 = values.ElementAt((values.Count() - 2));
                    operat2 = values.ElementAt((values.Count() - 1));
                    char o = operants.ElementAt((operants.Count - 2));
                    switch (o)
                    {
                        case '+':
                            sln += operat1 + operat2;
                            break;
                        case '-':
                            sln += operat1 - operat2;
                            break;
                        case '*':
                            sln += operat1 * operat2;
                            break;
                        case '/':
                            sln += operat1 / operat2;
                            break;
                        default:
                            Console.WriteLine("Command unkown!");
                            break;
                    }
                }
            }
            catch (Exception ee) {
                Console.WriteLine(ee.Message);
            }

        }

        private bool ListenHandling(char c) {
            bool sucess = false;
            double value = 0.0;
            try
            {
                value = Convert.ToDouble(display.Lines[(display.Lines.Count()-1)]);
                values.Add(value);
                operants.Add(c);
                sucess = true;
                return sucess;
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.Message);
                return sucess;
            } 

        }
        private void deleteAll() {
            display.Text = "";
            values.Clear();
            operants.Clear();
            sln = 0.0;
        }
    }
}
