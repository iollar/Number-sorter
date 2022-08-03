using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsAppMySort
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            MyResize();
        }
        static private int quantily, minn, maxx;
        static private int[] GenIn, mass;
        public int[] GenInGS
        {
            get { return GenIn; }
            set { GenIn = value; }
        }

        static private bool FGTest=false;
        public bool fgTestGS
        {
            get { return FGTest; }
            set { FGTest = value; }
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            if (!bwGenerate.IsBusy)
            {
                FormGen fg = new FormGen(this);
                fg.ShowDialog();
                if (FGTest)
                {
                    txtInput.Clear();
                    txtOutput.Clear();
                    btnClean.Enabled = false;
                    btnSort.Enabled = false;
                    btnGenerate.Enabled = false;
                    bwGenerate.RunWorkerAsync();
                    btnGenerate.Enabled = true;
                    btnGenerate.Text = "Стоп";
                }
                FGTest = false;
            }
            else
            {
                bwGenerate.CancelAsync();
                btnGenerate.Text = "Сгенерировать случайно";
            }
        }

        private void BtnSort_Click(object sender, EventArgs e)
        {
            if (!bwOutput.IsBusy)
            {
                txtOutput.Text="";
                if (txtInput.Text != "")
                {
                    btnClean.Enabled = false;
                    btnGenerate.Enabled = false;
                    btnSort.Enabled = false;
                    Sort();
                    btnSort.Enabled = true;
                    btnSort.Text = "Стоп"; 
                    bwOutput.RunWorkerAsync();
                }
                else
                    MessageBox.Show("Вы не ввели последовательность!");
            }
            else
            {
                bwOutput.CancelAsync();
                btnSort.Text = "Отсортировать";
            }
        }

        private void Sort()
        {
            mass = Array.ConvertAll(txtInput.Text.Split(' '), int.Parse);
            int quantily = mass.Length;

            int time = DateTime.Now.Millisecond;
            int max = mass[0], min = mass[0];

            for (int i = 1; i < quantily; i++)
            {
                if (max < mass[i])
                    max = mass[i];
                if (min > mass[i])
                    min = mass[i];
            }

            int index;
            int[] repeat = new int[max-min + 1];
            for (int i = 0; i < quantily; i++)
            {
                index = (mass[i]) - min;
                if (repeat[index] == 0)
                {
                    repeat[index] = 1;
                }
                else
                    repeat[index]++;
            }

            for (int i = 0, k = 0; i < repeat.Length; i++ )
            {
                if (repeat[i] != 0)
                {
                    index = i + min;
                    for (int j = 0; j < repeat[i]; j++)
                    {
                        mass[k] = index;
                        k++;
                    }
                }
            }
            int t = DateTime.Now.Millisecond;
            int timeS = t - time;
            labTacts.Text= string.Format("Кол-во тактов: {0:f4}", 16 * quantily + 4 *  repeat.Length);
            labTime.Text = string.Format( "Время работы: {0:f4} мс",timeS);
            repeat = null;
        }

        private void bwGenerate_DoWork(object sender, DoWorkEventArgs e)
        {
            maxx = GenIn[1];
            minn = GenIn[0];
            quantily = GenIn[2];
            var rand = new Random();
            for (int i = 0; i < GenIn[2]; i++)
            {
                if (!bwGenerate.CancellationPending)
                    txtInput.Invoke(new MethodInvoker(() => txtInput.Text += rand.Next(minn, maxx) + " "));
            }
            if (txtInput.Text.Length > 0)
                txtInput.Invoke(new MethodInvoker(() => txtInput.Text = txtInput.Text.Remove(txtInput.Text.Length - 1)));
        }

        private void bwGenerate_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bwGenerate.Dispose();
            btnGenerate.Text = "Сгенерировать случайно";
            btnClean.Enabled = true;
            btnSort.Enabled = true;
        }

        private void bwOutput_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < mass.Length; i++)
            {
                if(!bwOutput.CancellationPending)
                txtInput.Invoke(new MethodInvoker(() => txtOutput.Text += (mass[i] + " ")));
            }
        }

        private void bwOutput_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            mass = null;
            btnSort.Text = "Отсортировать";
            btnClean.Enabled = true;
            btnGenerate.Enabled = true;
        }

        private void Form1_Resize(object sender, EventArgs e)
        { MyResize(); }

        private void MyResize()
        {
            int per = 3, H = panMain.Height * per / 100, W = panMain.Width * per / 100;

            panBtns.Location = new Point((panMain.Width - panBtns.Width) / 2, panMain.Height - 2 * H - panBtns.Height);

            //Vertical
            if (panMain.Height > 5 * panMain.Width / 6)
            {
                panIn.Location = new Point(2 * W, 2 * H);
                panIn.Size = new Size(panMain.Width - 4 * W, (panBtns.Location.Y - 5 * H) / 2);
                txtInput.Size = panIn.Size - new Size(6, 6 + txtInput.Location.Y);

                panOut.Location = new Point(2 * W, H + panIn.Location.Y + panIn.Height);
                panOut.Size = panIn.Size;
                txtOutput.Size = txtInput.Size;
            }
            //Horisontal
            else
            {
                panIn.Location = new Point(2 * W, 2 * H);
                panIn.Size = new Size((panMain.Width - 5 * W) / 2, panBtns.Location.Y - 4 * H);
                txtInput.Size = panIn.Size - new Size(6, 6 + txtInput.Location.Y);

                panOut.Location = new Point(W + panIn.Location.X + panIn.Width, 2 * H);
                panOut.Size = panIn.Size;
                txtOutput.Size = txtInput.Size;
            }
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtOutput.Clear();
        }
    }
}
