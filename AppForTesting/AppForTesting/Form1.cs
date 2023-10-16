using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppForTesting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBoxLen_KeyPress(object sender, KeyPressEventArgs e)  //Контроль ввода данных
        {
            if ((sender as TextBox).Text == "0" && e.KeyChar != ',')
            {
                (sender as TextBox).Clear();
            }

            if (e.KeyChar == ',')
            {
                if ((sender as TextBox).Text.Contains(","))
                {
                    MessageBox.Show("Знак ',' уже стоит.", "Запрет на ввод", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Handled = true;
                }
                if ((sender as TextBox).Text == "")
                {
                    MessageBox.Show("Перед знаком ',' должно быть число.", "Запрет на ввод", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Handled = true;
                }
            }
        }

        private void ButtonCheck_Click(object sender, EventArgs e)
        {
            if (TextBoxLen1.Text == "" || TextBoxLen2.Text == "" || TextBoxLen3.Text == "")
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Convert.ToDouble(TextBoxLen1.Text);
                Convert.ToDouble(TextBoxLen2.Text);
                Convert.ToDouble(TextBoxLen3.Text);
            }
            catch
            {
                MessageBox.Show("Проверьте правильность данных. Запрещено использование букв и любых знаков кроме ',' (точка не является запятой). Также знак ',' должен быть только один и не должен стоять в начале числа", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            double Len1, Len2, Len3, Max;

            Len1 = Convert.ToDouble(TextBoxLen1.Text);
            Len2 = Convert.ToDouble(TextBoxLen2.Text);
            Len3 = Convert.ToDouble(TextBoxLen3.Text);

            Max = Len1;
            if (Len2 > Max)
            {
                Max = Len2;
            }
            if (Len3 > Max)
            {
                Max = Len3;
            }

            if (Len1 + Len2 <= Max || Len2 + Len3 <= Max || Len1 + Len3 <= Max)
            {
                MessageBox.Show("Треугольник невозможен: 1 из сторон больше суммы 2 других", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Len1 == Len2 && Len2 == Len3)
            {
                MessageBox.Show("Все стороны равны, следовательно это равносторонний треугольник", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
 
            if (Len1 == Len2 || Len2 == Len3 || Len1 == Len3)
            {
                MessageBox.Show("Две стороны равны, значит этот треугольник равнобедренный", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            else
            {
                MessageBox.Show("Все стороны разные, стало быть этот треугольник разносторонний", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
}
