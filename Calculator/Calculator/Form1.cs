using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		double total1 = 0;
		double num2;
		double answer;
		string operation;

		private void btn1_Click(object sender, EventArgs e) {
            if (display.Text == "0") {
                display.Text = btn1.Text;
            } else {
                display.Text += btn1.Text;
            }
		}

		private void btn2_Click(object sender, EventArgs e) {
            if (display.Text == "0") {
                display.Text = btn2.Text;
            } else {
                display.Text += btn2.Text;
            }
		}

		private void btn3_Click(object sender, EventArgs e) {
            if (display.Text == "0") {
                display.Text = btn3.Text;
            } else {
                display.Text += btn3.Text;
            }
		}

		private void btn4_Click(object sender, EventArgs e) {
            if (display.Text == "0") {
                display.Text = btn4.Text;
            } else {
                display.Text += btn4.Text;
            }
		}

		private void btn5_Click(object sender, EventArgs e) {
            if (display.Text == "0") {
                display.Text = btn5.Text;
            } else {
                display.Text += btn5.Text;
            }
		}

		private void btn6_Click(object sender, EventArgs e) {
            if (display.Text == "0") {
                display.Text = btn6.Text;
            } else {
                display.Text += btn6.Text;
            }
		}

		private void btn7_Click(object sender, EventArgs e) {
            if (display.Text == "0") {
                display.Text = btn7.Text;
            } else {
                display.Text += btn7.Text;
            }
		}

		private void btn8_Click(object sender, EventArgs e) {
            if (display.Text == "0") {
                display.Text = btn8.Text;
            } else {
                display.Text += btn8.Text;
            }
		}

		private void btn9_Click(object sender, EventArgs e) {
            if (display.Text == "0") {
                display.Text = btn9.Text;
            } else {
                display.Text += btn9.Text;
            }
		}

		private void btn0_Click(object sender, EventArgs e) {
			if (display.Text != "0") {
				display.Text += btn0.Text;
			}
		}

		private void btnClear_Click(object sender, EventArgs e) {
			display.Text = "0";
		}

		private void btnPt_Click(object sender, EventArgs e) {
			if (display.Text == "") {
				display.Text = "0.";
			}
			if (!(display.Text.Contains("."))) {
				display.Text += btnPt.Text;
			}
		}

		private void btnPlus_Click(object sender, EventArgs e) {
			total1 += double.Parse(display.Text);
			display.Clear();
			operation = "+";
		}

		private void btnMinus_Click(object sender, EventArgs e) {
			if (total1 == 0) {
				total1 = double.Parse(display.Text);
				display.Clear();
				operation = "-";
			} else {
				total1 -= double.Parse(display.Text);
				display.Clear();
				operation = "-";
			}
		}

		private void btnMult_Click(object sender, EventArgs e) {
			if (total1 == 0) {
				total1 = double.Parse(display.Text);
				display.Clear();
				operation = "*";
			} else {
				total1 *= double.Parse(display.Text);
				display.Clear();
				operation = "*";
			}
		}

		private void btnDiv_Click(object sender, EventArgs e) {
			if (total1 == 0) {
				total1 = double.Parse(display.Text);
				display.Clear();
				operation = "/";
			} else {
				total1 /= double.Parse(display.Text);
				display.Clear();
				operation = "/";
			}
		}

		private void btnEq_Click(object sender, EventArgs e) {
			num2 = double.Parse(display.Text);

			switch (operation) {
				case "+":
					answer = total1 + num2;
					display.Text = answer.ToString();
					total1 = 0;
					break;
				case "-":
					answer = total1 - num2;
					display.Text = answer.ToString();
					total1 = 0;
					break;
				case "*":
					answer = total1 * num2;
					display.Text = answer.ToString();
					total1 = 0;
					break;
				case "/":
					answer = total1 / num2;
					display.Text = answer.ToString();
					total1 = 0;
					break;
				default:
					answer = 0;
					break;
			}
		}
	}
}
