using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;

namespace SQRT_BI_23
{
    public partial class Form3 : Form
    {
        private System.Windows.Forms.TextBox activeTextBox;

        string textInfo;
        public Form3()
        {
            InitializeComponent();
            SaitToolStripMenuItem.Text = "Website";
            LangueMenu.Text = "language";
            Info.Text = "info";
            SupportMenu.Text = "support";
            Arithmetic_Button.Text = "arithmetic";
            Complex_Button.Text = "complex";
            Analitic_button.Text = "analytical";
            textInfo = "An analytical square root (or exact square root) is the root of a number that can be expressed as an exact decimal or fractional decimal decimal fraction, and not just as an approximate decimal decimal fraction or floating point number.\r\n\r\nFor example, the square root of 4 is analytic and exact because it is 2 (an exact integer), while the square root of 2 is not analytic and its value is approximately 1.4142135623730951 and so on (infinite decimal).";
        }

        private void Arithmetic_Button_Click(object sender, EventArgs e)
        {
            form1 form1 = new form1();
            form1.Show();
            this.Hide();
        }

        private void Complex_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            MainText.Text = "";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (activeTextBox is null)
            {
                activeTextBox = MainText;
            }
            activeTextBox.Text += (sender as System.Windows.Forms.Button).Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (activeTextBox is null)
            {
                activeTextBox = MainText;
            }
            activeTextBox.Text += (sender as System.Windows.Forms.Button).Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (activeTextBox is null)
            {
                activeTextBox = MainText;
            }
            activeTextBox.Text += (sender as System.Windows.Forms.Button).Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (activeTextBox is null)
            {
                activeTextBox = MainText;
            }
            activeTextBox.Text += (sender as System.Windows.Forms.Button).Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (activeTextBox is null)
            {
                activeTextBox = MainText;
            }
            activeTextBox.Text += (sender as System.Windows.Forms.Button).Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (activeTextBox is null)
            {
                activeTextBox = MainText;
            }
            activeTextBox.Text += (sender as System.Windows.Forms.Button).Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (activeTextBox is null)
            {
                activeTextBox = MainText;
            }
            activeTextBox.Text += (sender as System.Windows.Forms.Button).Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (activeTextBox is null)
            {
                activeTextBox = MainText;
            }
            activeTextBox.Text += (sender as System.Windows.Forms.Button).Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (activeTextBox is null)
            {
                activeTextBox = MainText;
            }
            activeTextBox.Text += (sender as System.Windows.Forms.Button).Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            activeTextBox.Text += (sender as System.Windows.Forms.Button).Text;
        }

        private void Analitic_button_Click(object sender, EventArgs e)
        {

        }

        private void button_Del_Click(object sender, EventArgs e)
        {
            if ((activeTextBox != null) && (activeTextBox.Text != ""))
            {
                activeTextBox.Text = activeTextBox.Text.Remove(activeTextBox.Text.Length - 1, 1);
            }
        }

        private void button_SQRT_Click(object sender, EventArgs e)
        {
            if (MainText.Text != "")
            {
                double number = double.Parse(MainText.Text);

                double sqrt = AnalyticalSquareRoot(number);
                if (!double.IsNaN(sqrt))
                {
                    MainText.Text = sqrt.ToString();
                }
                else
                {
                    MessageBox.Show($"Квадратный корень из {number} не является аналитическим.");
                }
            }
        }

        static double AnalyticalSquareRoot(double number)
        {
            if (number < 0)
            {
                return double.NaN; // Ошибка: отрицательное число
            }

            double sqrt = Math.Sqrt(number);

            // Проверяем, является ли квадрат числа целым числом
            if (Math.Abs(sqrt - Math.Floor(sqrt)) < double.Epsilon)
            {
                return sqrt; // Число является аналитическим квадратным корнем
            }
            else
            {
                return double.NaN; // Число не является аналитическим квадратным корнем
            }
        }

        private void MainText_MouseDown(object sender, MouseEventArgs e)
        {
            activeTextBox = sender as System.Windows.Forms.TextBox;
        }

        private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textInfo);
        }

        private void SaitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = "http://project7790398.tilda.ws/";
            Process.Start(url);
        }

        private void русскийToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            SupportMenu.Text = "поддержка";
            LangueMenu.Text = "язык";
            Info.Text = "справка";
            Arithmetic_Button.Text = "арифметическое";
            textInfo = "Аналитический квадратный корень (или точный квадратный корень) - это корень числа, который может быть выражен в виде точной десятичной или дробной десятичной десятичной дроби, а не только в виде приближенной десятичной десятичной дроби или числа с плавающей точкой.\r\n\r\nНапример, квадратный корень из 4 является аналитическим и точным, потому что он равен 2 (точное целое число), в то время как квадратный корень из 2 не является аналитическим, и его значение приближенно равно 1,4142135623730951 и так далее (бесконечная десятичная дробь).";
            Complex_Button.Text = "комплексное";
            Analitic_button.Text = "аналитическое";
            SaitToolStripMenuItem.Text = "Вебсайт";
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LangueMenu.Text = "language";
            SupportMenu.Text = "support";
            Info.Text = "info";
            textInfo = "An analytical square root (or exact square root) is the root of a number that can be expressed as an exact decimal or fractional decimal decimal fraction, and not just as an approximate decimal decimal fraction or floating point number.\r\n\r\nFor example, the square root of 4 is analytic and exact because it is 2 (an exact integer), while the square root of 2 is not analytic and its value is approximately 1.4142135623730951 and so on (infinite decimal).";
            Arithmetic_Button.Text = "arithmetic";
            Complex_Button.Text = "complex";
            Analitic_button.Text = "analytical";
            SaitToolStripMenuItem.Text = "Website";
        }

        private void عربToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LangueMenu.Text = "لغة";
            SupportMenu.Text = "يدعم";
            Info.Text = "المعلومات";
            textInfo = "الجذر التربيعي التحليلي (أو الجذر التربيعي الدقيق) هو جذر رقم يمكن التعبير عنه ككسر عشري عشري دقيق أو كسري عشري ، وليس فقط ككسر عشري تقريبي أو رقم فاصلة عائمة.\r\n\r\nعلى سبيل المثال ، الجذر التربيعي لـ 4 تحليلي ودقيق لأنه 2 (عدد صحيح دقيق) ، بينما الجذر التربيعي لـ 2 ليس تحليليا وقيمته حوالي 1.4142135623730951 وهكذا (عشري لانهائي).";
            Arithmetic_Button.Text = "عل الحساب ";
            Complex_Button.Text = "شامل";
            Analitic_button.Text = "تحليلي";
            SaitToolStripMenuItem.Text = "موقع إلكتروني";
        }

        private void 中國人ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LangueMenu.Text = "語言";
            SupportMenu.Text = "支持";
            Info.Text = "信息";
            textInfo = "解析平方根（或精确平方根）是可以表示为精确小数或小数小数小数小数的数字的根，而不仅仅是近似小数小数小数或浮点数。\r\n\r\n例如，4的平方根是解析的和精确的，因为它是2（一个精确的整数），而2的平方根不是解析的，它的值大约是1.4142135623730951等（无限十进制）。";
            Arithmetic_Button.Text = "算術";
            Complex_Button.Text = "綜合的";
            Analitic_button.Text = "分析性的";
            SaitToolStripMenuItem.Text = "網站";
        }

        private void españolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LangueMenu.Text = "idioma";
            SupportMenu.Text = "apoyo";
            Info.Text = "Información";
            textInfo = "La raíz cuadrada analítica (o raíz cuadrada exacta) es la raíz de un número que se puede expresar como un decimal exacto o un decimal fraccionario, no solo como un decimal Aproximado o un número de punto flotante.\r\n\r\nPor ejemplo, la raíz cuadrada de 4 es analítica y precisa porque es igual a 2 (entero exacto), mientras que la raíz cuadrada de 2 no es analítica y su valor es aproximadamente 1.4142135623730951 y así sucesivamente (decimal infinito).";
            Arithmetic_Button.Text = "aritmética";
            Complex_Button.Text = "integral";
            Analitic_button.Text = "analítico";
            SaitToolStripMenuItem.Text = "Sitio web";
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MainText_KeyPress(object sender, KeyPressEventArgs e)
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
