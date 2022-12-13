using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Ex1_Forms {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {
			YearTextBox.Text = DateTime.Now.Year.ToString();
		}

		private void ResultButton_Click(object sender, EventArgs e) {
			string str = StringTextBox.Text;
			string result = string.Empty;

			Regex extractDateRegex = new Regex(@"[0-9]{1,2}.[0-9]{1,2}.[0-9]{4}");

			MatchCollection extracted = extractDateRegex.Matches(str);

			result += $"Все даты, за текущий год [{DateTime.Now.Year}]:\n";
			foreach (var item in extracted) {
				DateTime date;
				DateTime.TryParse(item.ToString(), out date);

				if (date.Year == DateTime.Now.Year) result += item.ToString() + "\n";
			}

			MessageBox.Show(result, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);

		}
	}
}
