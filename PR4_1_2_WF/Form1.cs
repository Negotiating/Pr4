using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR4_1_2_WF
{
	public partial class Practic4 : Form
	{
		public Practic4()
		{
			InitializeComponent();
		}

		private void N_KeyPress(object sender, KeyPressEventArgs e)
		{
			char symbol = e.KeyChar;
			if (!Char.IsDigit(symbol))
			{
				e.Handled = true;
			}
		}
		private float a(int n)
		{
			if (n == 1) return 1;
			else return (a(n / 2) + 1);
		}
		private void calculate_Click(object sender, EventArgs e)
		{
			int n = Convert.ToInt32(N.Text);
			try
			{
				if (n <= 0) throw new Exception();
				else
					A.Text = a(n).ToString();
			}
			catch
			{
				MessageBox.Show("n не натуральное число");
			}
		}
		private void Rec(int count, ref int current, int difference, ref int sum)
		{
			if (count > 0)
				sum += current;
			if (count > 1)
			{
				current += difference;
				Rec(count - 1, ref current, difference, ref sum);
			}
		}
		private void calculate2_Click(object sender, EventArgs e)
		{
			int n = Convert.ToInt32(number.Text);
			if (n > 0)
			{
				int xn = 0;
				int sum = 0;
				int d = Convert.ToInt32(difference.Text);
				if (d == 0)
				{
					MessageBox.Show("Разница элементов не может быть 0");
				}
				else
				{
					Rec(n, ref xn, d, ref sum);
					summ.Text = sum.ToString();
					value.Text = xn.ToString();
				}			}
			else MessageBox.Show("Некорректный номер элемента");
		}
	}
}
