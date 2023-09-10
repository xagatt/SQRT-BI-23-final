using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Numerics;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SQRT_BI_23
{
    public partial class Form2 : Form
    {

        private System.Windows.Forms.TextBox activeTextBox;
        public Form2()
        {
            InitializeComponent();
            precision_label.Text = "Precision:";
            LangueMenu.Text = "language";
            SupportMenu.Text = "support";
            Arithmetic_Button.Text = "arithmetic";
            Complex_Button.Text = "complex";
            Analitic_button.Text = "analytical";
            SaitToolStripMenuItem.Text = "Website";
        }

        private void Arithmetic_Button_Click(object sender, EventArgs e)
        {
            form1 form1 = new form1();
            form1.Show();
            this.Hide();
        }

        private void Analitic_button_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void Complex_Button_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (activeTextBox is null) 
            {
                activeTextBox = MainTextRl;
            }
            activeTextBox.Text += (sender as System.Windows.Forms.Button).Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (activeTextBox is null) 
            {
                activeTextBox = MainTextRl;
            }
            activeTextBox.Text += (sender as System.Windows.Forms.Button).Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (activeTextBox is null) 
            {
                activeTextBox = MainTextRl;
            }
            activeTextBox.Text += (sender as System.Windows.Forms.Button).Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (activeTextBox is null) 
            {
                activeTextBox = MainTextRl;
            }
            activeTextBox.Text += (sender as System.Windows.Forms.Button).Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (activeTextBox is null) 
            {
                activeTextBox = MainTextRl;
            }
            activeTextBox.Text += (sender as System.Windows.Forms.Button).Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (activeTextBox is null) 
            {
                activeTextBox = MainTextRl;
            }
            activeTextBox.Text += (sender as System.Windows.Forms.Button).Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (activeTextBox is null) 
            {
                activeTextBox = MainTextRl;
            }
            activeTextBox.Text += (sender as System.Windows.Forms.Button).Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (activeTextBox is null) 
            {
                activeTextBox = MainTextRl;
            }
            activeTextBox.Text += (sender as System.Windows.Forms.Button).Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (activeTextBox is null)
            {
                activeTextBox = MainTextRl;
            }
            activeTextBox.Text += (sender as System.Windows.Forms.Button).Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (activeTextBox is null)
            {
                activeTextBox = MainTextRl;
            }
            activeTextBox.Text += (sender as System.Windows.Forms.Button).Text;
        }

        private void button_SQRT_Click(object sender, EventArgs e)
        {
            if (MainTextRl.Text != "")
                if (MainTextIm.Text != "")
                    if (textBox_PrecisionCom.Text != "")
                    {
                    double numberRl = double.Parse(MainTextRl.Text);
                    double numberIm = double.Parse(MainTextIm.Text);

                    int precision = int.Parse(textBox_PrecisionCom.Text);
                    Complex complexNumber = new Complex(numberRl, numberIm);

                    Complex SQRTcomplex = Complex.Sqrt(complexNumber);

                    double realPart = Math.Round(SQRTcomplex.Real, precision); // Действительная часть
                    double imaginaryPart = Math.Round(SQRTcomplex.Imaginary, precision); // Мнимая часть

                    MainTextRl.Text = realPart.ToString();
                    MainTextIm.Text = imaginaryPart.ToString();
                    }
        }

        private void button_Del_Click(object sender, EventArgs e)
        {
            if ((activeTextBox != null) && (activeTextBox.Text != ""))
            {
                activeTextBox.Text = activeTextBox.Text.Remove(activeTextBox.Text.Length - 1, 1);
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            MainTextRl.Text = "";
            MainTextIm.Text = "";
            textBox_PrecisionCom.Text = "";
        }

        private void MainTextRl_MouseDown(object sender, MouseEventArgs e)
        {
            activeTextBox = sender as System.Windows.Forms.TextBox;
        }

        private void MainTextIm_MouseDown(object sender, MouseEventArgs e)
        {
            activeTextBox = sender as System.Windows.Forms.TextBox;
        }

        private void textBox_PrecisionCom_MouseDown(object sender, MouseEventArgs e)
        {
            activeTextBox = sender as System.Windows.Forms.TextBox;
        }

        private void русскийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupportMenu.Text = "поддержка";
            precision_label.Text = "Точность:";
            LangueMenu.Text = "язык";
            Arithmetic_Button.Text = "арифметическое";
            Complex_Button.Text = "комплексное";
            Analitic_button.Text = "аналитическое";
            SaitToolStripMenuItem.Text = "Вебсайт";
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            precision_label.Text = "Precision:";
            LangueMenu.Text = "language";
            SupportMenu.Text = "support";
            Arithmetic_Button.Text = "arithmetic";
            Complex_Button.Text = "complex";
            Analitic_button.Text = "analytical";
            SaitToolStripMenuItem.Text = "Website";
        }

        private void عربToolStripMenuItem_Click(object sender, EventArgs e)
        {
            precision_label.Text = "دقة" + ":";
            LangueMenu.Text = "لغة";
            SupportMenu.Text = "يدعم";
            Arithmetic_Button.Text = "عل الحساب ";
            Complex_Button.Text = "شامل";
            Analitic_button.Text = "تحليلي";
            SaitToolStripMenuItem.Text = "موقع إلكتروني";
        }

        private void 中國人ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            precision_label.Text = "準確性:";
            LangueMenu.Text = "語言";
            SupportMenu.Text = "支持";
            Arithmetic_Button.Text = "算術";
            Complex_Button.Text = "綜合的";
            Analitic_button.Text = "分析性的";
            SaitToolStripMenuItem.Text = "網站";
        }

        private void españolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            precision_label.Text = "exactitud:";
            LangueMenu.Text = "idioma";
            SupportMenu.Text = "apoyo";
            Arithmetic_Button.Text = "aritmética";
            Complex_Button.Text = "integral";
            Analitic_button.Text = "analítico";
            SaitToolStripMenuItem.Text = "Sitio web";
        }

        private void SaitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = "http://project7790398.tilda.ws/";
            Process.Start(url);
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MainTextRl_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainTextIm_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainTextRl_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is not a digit or a control key (Backspace, Delete)
            if (!char.IsDigit(e.KeyChar))
            {
                // Block the input by setting Handled to true
                e.Handled = true;
            }
        }

        private void MainTextIm_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is not a digit or a control key (Backspace, Delete)
            if (!char.IsDigit(e.KeyChar))
            {
                // Block the input by setting Handled to true
                e.Handled = true;
            }
        }

        private void textBox_PrecisionCom_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is not a digit or a control key (Backspace, Delete)
            if (!char.IsDigit(e.KeyChar))
            {
                // Block the input by setting Handled to true
                e.Handled = true;
            }
        }
    }
}
