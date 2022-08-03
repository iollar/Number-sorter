using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsAppMySort
{
    public partial class FormGen : Form
    {
        public FormGen(FormMain fm)
        {
            InitializeComponent();
        }
        static private bool test, test2;
        private void BtnIn_Click(object sender, EventArgs e)
        {
            test2 = true;
            FormMain fm = new FormMain();
            
            int[] GenIn = new int[3];
            Label[] lab = { labMinn, labMaxx, labQuantily };
            TextBox[] txt = { txtMinn, txtMaxx, txtQuantily };

            for (int i = 0; i < GenIn.Length; i++)
            {
                lab[i].ForeColor = SystemColors.ControlText;
                GenIn[i] = CheckGenIn(txt[i].Text);
                if (!test)
                {
                    test2 = false;
                    lab[i].ForeColor = Color.Red;
                }
            }
            if (!test2)
            {
                MessageBox.Show("Некоторые значения введены некорректно, отредактируйте их.");
                return;
            }
            if (GenIn[0] > GenIn[1])
            {
                lab[0].ForeColor = Color.Red;
                lab[1].ForeColor = Color.Red;
                MessageBox.Show("ВНИМАНИЕ: Минимальный элемент не может быть больше максимального!");
                return;
            }
            fm.GenInGS = GenIn;
            fm.fgTestGS = true;
            Close();
        }

        private int CheckGenIn(string txt)
        {
            test = true;
            int num = 0;
            if (string.IsNullOrEmpty(txt) || !Int32.TryParse(txt, out num))
                test = false;
            return num;
        }
    }
}
