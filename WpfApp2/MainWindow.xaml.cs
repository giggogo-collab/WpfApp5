using Lib_2;
using System;
using System.Windows;

namespace PracticalWork4
{
    public partial class MainWindow : Window
    {
        Pair pair1 = new Pair();
        Pair pair2 = new Pair();
        Pair pair3 = new Pair();

        public MainWindow()
        {
            InitializeComponent();
        }

        // Считываем данные из полей
        private bool ChitatPari()
        {
            try
            {
                pair1.Pervoe = Convert.ToInt32(tbPervoe1.Text);
                pair1.Vtoroe = Convert.ToInt32(tbVtoroe1.Text);
                pair2.Pervoe = Convert.ToInt32(tbPervoe2.Text);
                pair2.Vtoroe = Convert.ToInt32(tbVtoroe2.Text);
                pair3.Pervoe = Convert.ToInt32(tbPervoe3.Text);
                pair3.Vtoroe = Convert.ToInt32(tbVtoroe3.Text);
                return true;
            }
            catch
            {
                MessageBox.Show("Введите целые числа во все поля!");
                return false;
            }
        }

        // Сумма полей каждой пары
        private void btnSumPolei_Click(object sender, RoutedEventArgs e)
        {
            if (!ChitatPari()) return;
            tbResultat.Text = "1 пара: " + pair1 + " сумма = " + pair1.Summa() + "\n" + "2 пара: " + pair2 + " сумма = " + pair2.Summa() + "\n" + "3 пара: " + pair3 + " сумма = " + pair3.Summa();
        }

        // Сложение двух пар
        private void btnDobavitpary_Click(object sender, RoutedEventArgs e)
        {
            if (!ChitatPari()) return;
            Pair rez = pair1 + pair2;
            tbResultat.Text = pair1 + " + " + pair2 + " = " + rez;
        }

        // Увеличение на 1
        private void btnYvelichitna1_Click(object sender, RoutedEventArgs e)
        {
            if (!ChitatPari()) return;
            pair1.Yvelech_1();
            pair2.Yvelech_1();
            pair3.Yvelech_1();

            tbPervoe1.Text = pair1.Pervoe.ToString();
            tbVtoroe1.Text = pair1.Vtoroe.ToString();
            tbPervoe2.Text = pair2.Pervoe.ToString();
            tbVtoroe2.Text = pair2.Vtoroe.ToString();
            tbPervoe3.Text = pair3.Pervoe.ToString();
            tbVtoroe3.Text = pair3.Vtoroe.ToString();
            tbResultat.Text = "После увеличения на 1:\n" + "1 пара = " + pair1 + "\n" + "2 пара = " + pair2 + "\n" +"3 пара = " + pair3;
        }

        // Уменьшение на 1
        private void btnYmenshitna1_Click(object sender, RoutedEventArgs e)
        {
            if (!ChitatPari()) return;
            pair1.Ymenshit_1();
            pair2.Ymenshit_1();
            pair3.Ymenshit_1();

            tbPervoe1.Text = pair1.Pervoe.ToString();
            tbVtoroe1.Text = pair1.Vtoroe.ToString();
            tbPervoe2.Text = pair2.Pervoe.ToString();
            tbVtoroe2.Text = pair2.Vtoroe.ToString();
            tbPervoe3.Text = pair3.Pervoe.ToString();
            tbVtoroe3.Text = pair3.Vtoroe.ToString();
            tbResultat.Text = "После уменьшения на 1:\n" + "1 пара = " + pair1 + "\n" + "2 пара = " + pair2 + "\n" + "3 пара = " + pair3;
        }

        // Сложение трёх пар
        private void btnSummaTreh_Click(object sender, RoutedEventArgs e)
        {
            if (!ChitatPari()) return;
            Pair rez = Pair.Summatreh(pair1, pair2, pair3);
            tbResultat.Text = pair1 + " + " + pair2 + " + " + pair3 + " = " + rez;
        }

        private void btnbtnOproge_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа №5 Вариант 2\n" + "Использовать класс Pair (пара чисел). Разработать операцию сложения пар (а, b) + \r\n(с, d) = (а + c, b + d). Разработать операцию для уменьшения полей на 1." + "Сделал Антипов А.А.", "О программе");
        }

        private void btnVihod_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}