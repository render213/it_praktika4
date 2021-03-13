using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktika4
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
    double Factorial(double n)
    {
      double sum=1;
      while (n>1)
      {
        sum = sum * n;
        n = n - 1;
      }
      return sum;
    }
    private void button1_Click(object sender, EventArgs e)
    {
      int check = 0;
      int n = 1;
      double i = 1;
      double s = 0;
      double epsilon = Convert.ToDouble(textBox1.Text);
      if (radioButton2.Checked) check = 1;
      switch (check)
      {
        case 0:
          double exitcheck = (5 + i) / (3 * Factorial(i) - 1); ;
          while(exitcheck >=epsilon)
          {
            exitcheck = (5 + i) / (3 * Factorial(i) - 1);
            s += (5 + i) / (3 * Factorial(i) - 1);
            i++;
          }
          textBox2.Text += "сумма ряда равна=" + Convert.ToDouble(s) + Environment.NewLine;

          break;
        case 1:
          double proiz = 1;
          for(i=1;i<n;i++)
          {

            double number = i;
            proiz =proiz* (Factorial(number)*0.5)/(0.1*number+1);
          }
          break;
        default:
          textBox2.Text += "решение не найдено" + Environment.NewLine;
          break;
      }
    }
  }
}
