using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOAP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 加法按钮点击事件 (Событие нажатия кнопки сложения)
        private void button1_Click(object sender, EventArgs e)
        {
            // 读取输入框中的分子和分母 (Считывание числителя и знаменателя из текстовых полей)
            int num1 = int.Parse(numerator1.Text);
            int den1 = int.Parse(denominator1.Text);
            int num2 = int.Parse(numerator2.Text);
            int den2 = int.Parse(denominator2.Text);

            // 检查分母是否为零 (Проверка, не равен ли знаменатель нулю)
            if (den1 == 0 || den2 == 0)
            {
                MessageBox.Show("分母不能为零！ (Знаменатель не может быть равен нулю!)");
                return;
            }

            // 执行加法运算 (Выполнение операции сложения)
            int resultNum = num1 * den2 + num2 * den1;
            int resultDen = den1 * den2;

            // 显示结果 (Отображение результата)
            labelResult.Text = $"{resultNum} / {resultDen}";
        }

        // 减法按钮点击事件 (Событие нажатия кнопки вычитания)
        private void button5_Click(object sender, EventArgs e)
        {
            // 尝试读取输入框中的值并检查有效性 (Попытка считать значения и проверить их корректность)
            if (!int.TryParse(numerator1.Text, out int num1) ||
     !int.TryParse(denominator1.Text, out int den1) || den1 == 0 ||
     !int.TryParse(numerator2.Text, out int num2) ||
     !int.TryParse(denominator2.Text, out int den2) || den2 == 0)
            {
                MessageBox.Show("所有输入必须是有效的非零整数！ (Все вводимые значения должны быть допустимыми и ненулевыми!)");
                return;
            }

            // 执行减法运算 (Выполнение операции вычитания)
            int resultNum = num1 * den2 - num2 * den1;
            int resultDen = den1 * den2;

            // 显示结果 (Отображение результата)
            labelResult.Text = $"{resultNum} / {resultDen}";
        }

        // 除法按钮点击事件 (Событие нажатия кнопки деления)
        private void button3_Click(object sender, EventArgs e)
        {
            // 读取输入框中的分子和分母 (Считывание числителя и знаменателя из текстовых полей)
            int num1 = int.Parse(numerator1.Text);
            int den1 = int.Parse(denominator1.Text);
            int num2 = int.Parse(numerator2.Text);
            int den2 = int.Parse(denominator2.Text);

            // 检查分母是否为零 (Проверка, не равен ли знаменатель нулю)
            if (den1 == 0 || den2 == 0)
            {
                MessageBox.Show("分母不能为零！ (Знаменатель не может быть равен нулю!)");
                return;
            }

            // 执行除法运算 (Выполнение операции деления)
            int resultNum = num1 * den2;
            int resultDen = den1 * num2;

            // 显示结果 (Отображение результата)
            labelResult.Text = $"{resultNum} / {resultDen}";

        }

        // 约简按钮点击事件 (Событие нажатия кнопки сокращения дроби)
        private void button2_Click(object sender, EventArgs e)
        {
            // 读取输入框中的分子和分母 (Считывание числителя и знаменателя из текстовых полей)
            int num = int.Parse(numerator1.Text);
            int den = int.Parse(denominator1.Text);

            // 检查分母是否为零 (Проверка, не равен ли знаменатель нулю)
            if (den == 0)
            {
                MessageBox.Show("分母不能为零！ (Знаменатель не может быть равен нулю!)");
                return;
            }

            // 计算最大公约数并约简 (Вычисление НОД и сокращение дроби)
            int gcd = GCD(num, den);

            // 显示结果 (Отображение результата)
            labelResult.Text = $"{num / gcd} / {den / gcd}";
        }

        // 计算最大公约数的辅助函数 (Функция для вычисления НОД)
        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        // 乘法按钮点击事件 (Событие нажатия кнопки умножения)
        private void button4_Click(object sender, EventArgs e)
        {
            // 读取输入框中的分子和分母 (Считывание числителя и знаменателя из текстовых полей)
            int num1 = int.Parse(numerator1.Text);
            int den1 = int.Parse(denominator1.Text);
            int num2 = int.Parse(numerator2.Text);
            int den2 = int.Parse(denominator2.Text);

            // 检查分母是否为零 (Проверка, не равен ли знаменатель нулю)
            if (den1 == 0 || den2 == 0)
            {
                MessageBox.Show("分母不能为零！ (Знаменатель не может быть равен нулю!)");
                return;
            }

            // 执行乘法运算 (Выполнение операции умножения)
            int resultNum = num1 * num2;
            int resultDen = den1 * den2;

            // 显示结果 (Отображение результата)
            labelResult.Text = $"{resultNum} / {resultDen}";
        }

        private void labelResult_Click(object sender, EventArgs e)
        {

        }
    }

    // 添加 Rational 类来支持任务要求 (Добавление класса Rational для выполнения требований задачи)
    public class Rational
    {
        private int numerator;
        private int denominator;

        // 构造函数，初始化分子和分母 (Конструктор для инициализации числителя и знаменателя)
        public Rational(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("分母不能为零！ (Знаменатель не может быть равен нулю!)");
            }

            this.numerator = numerator;
            this.denominator = denominator;
            Reduce();
        }

        // 将分数转为字符串格式 (Преобразование дроби в строковый формат)
        public override string ToString()
        {
            return $"{numerator} / {denominator}";
        }

        // 约简分数 (Сокращение дроби)
        public void Reduce()
        {
            int gcd = GCD(numerator, denominator);
            numerator /= gcd;
            denominator /= gcd;
        }

        // 加法操作符重载 (Перегрузка оператора сложения)
        public static Rational operator +(Rational r1, Rational r2)
        {
            int num = r1.numerator * r2.denominator + r2.numerator * r1.denominator;
            int den = r1.denominator * r2.denominator;
            return new Rational(num, den);
        }

        // 减法操作符重载 (Перегрузка оператора вычитания)
        public static Rational operator -(Rational r1, Rational r2)
        {
            int num = r1.numerator * r2.denominator - r2.numerator * r1.denominator;
            int den = r1.denominator * r2.denominator;
            return new Rational(num, den);
        }

        // 乘法操作符重载 (Перегрузка оператора умножения)
        public static Rational operator *(Rational r1, Rational r2)
        {
            int num = r1.numerator * r2.numerator;
            int den = r1.denominator * r2.denominator;
            return new Rational(num, den);
        }

        // 除法操作符重载 (Перегрузка оператора деления)
        public static Rational operator /(Rational r1, Rational r2)
        {
            if (r2.numerator == 0)
            {
                throw new DivideByZeroException("不能除以零！ (Нельзя делить на ноль!)");
            }

            int num = r1.numerator * r2.denominator;
            int den = r1.denominator * r2.numerator;
            return new Rational(num, den);
        }

        // 计算最大公约数的辅助函数 (Функция для вычисления НОД)
        private static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return Math.Abs(a);
        }
    }
}
