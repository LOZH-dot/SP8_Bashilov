namespace Ex1_Forms {
	partial class Form1 {
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent() {
			this.label1 = new System.Windows.Forms.Label();
			this.StringTextBox = new System.Windows.Forms.TextBox();
			this.ResultButton = new System.Windows.Forms.Button();
			this.YearTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(123, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Введите предложение:";
			// 
			// StringTextBox
			// 
			this.StringTextBox.Location = new System.Drawing.Point(141, 6);
			this.StringTextBox.Name = "StringTextBox";
			this.StringTextBox.Size = new System.Drawing.Size(330, 20);
			this.StringTextBox.TabIndex = 1;
			// 
			// ResultButton
			// 
			this.ResultButton.Location = new System.Drawing.Point(15, 40);
			this.ResultButton.Name = "ResultButton";
			this.ResultButton.Size = new System.Drawing.Size(75, 23);
			this.ResultButton.TabIndex = 2;
			this.ResultButton.Text = "Результат";
			this.ResultButton.UseVisualStyleBackColor = true;
			this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
			// 
			// YearTextBox
			// 
			this.YearTextBox.Location = new System.Drawing.Point(401, 40);
			this.YearTextBox.Name = "YearTextBox";
			this.YearTextBox.ReadOnly = true;
			this.YearTextBox.Size = new System.Drawing.Size(70, 20);
			this.YearTextBox.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(320, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Текущий год:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(491, 90);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.YearTextBox);
			this.Controls.Add(this.ResultButton);
			this.Controls.Add(this.StringTextBox);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox StringTextBox;
		private System.Windows.Forms.Button ResultButton;
		private System.Windows.Forms.TextBox YearTextBox;
		private System.Windows.Forms.Label label2;
	}
}

