namespace PR4_1_2_WF
{
	partial class Practic4
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.task1 = new System.Windows.Forms.GroupBox();
			this.task2 = new System.Windows.Forms.GroupBox();
			this.n_label = new System.Windows.Forms.Label();
			this.N = new System.Windows.Forms.TextBox();
			this.a_label = new System.Windows.Forms.Label();
			this.A = new System.Windows.Forms.Label();
			this.calculate = new System.Windows.Forms.Button();
			this.numder_label = new System.Windows.Forms.Label();
			this.difference_label = new System.Windows.Forms.Label();
			this.sum_label = new System.Windows.Forms.Label();
			this.value_label = new System.Windows.Forms.Label();
			this.number = new System.Windows.Forms.TextBox();
			this.value = new System.Windows.Forms.TextBox();
			this.difference = new System.Windows.Forms.TextBox();
			this.summ = new System.Windows.Forms.TextBox();
			this.calculate2 = new System.Windows.Forms.Button();
			this.task1.SuspendLayout();
			this.task2.SuspendLayout();
			this.SuspendLayout();
			// 
			// task1
			// 
			this.task1.Controls.Add(this.calculate);
			this.task1.Controls.Add(this.A);
			this.task1.Controls.Add(this.a_label);
			this.task1.Controls.Add(this.N);
			this.task1.Controls.Add(this.n_label);
			this.task1.Location = new System.Drawing.Point(10, 8);
			this.task1.Name = "task1";
			this.task1.Size = new System.Drawing.Size(312, 103);
			this.task1.TabIndex = 0;
			this.task1.TabStop = false;
			this.task1.Text = "Задание 1";
			// 
			// task2
			// 
			this.task2.Controls.Add(this.calculate2);
			this.task2.Controls.Add(this.summ);
			this.task2.Controls.Add(this.difference);
			this.task2.Controls.Add(this.value);
			this.task2.Controls.Add(this.number);
			this.task2.Controls.Add(this.value_label);
			this.task2.Controls.Add(this.sum_label);
			this.task2.Controls.Add(this.difference_label);
			this.task2.Controls.Add(this.numder_label);
			this.task2.Location = new System.Drawing.Point(328, 12);
			this.task2.Name = "task2";
			this.task2.Size = new System.Drawing.Size(312, 174);
			this.task2.TabIndex = 1;
			this.task2.TabStop = false;
			this.task2.Text = "Задание 2";
			// 
			// n_label
			// 
			this.n_label.AutoSize = true;
			this.n_label.Location = new System.Drawing.Point(6, 35);
			this.n_label.Name = "n_label";
			this.n_label.Size = new System.Drawing.Size(28, 17);
			this.n_label.TabIndex = 0;
			this.n_label.Text = "n:  ";
			// 
			// N
			// 
			this.N.Location = new System.Drawing.Point(40, 32);
			this.N.Name = "N";
			this.N.Size = new System.Drawing.Size(76, 22);
			this.N.TabIndex = 1;
			this.N.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.N_KeyPress);
			// 
			// a_label
			// 
			this.a_label.AutoSize = true;
			this.a_label.Location = new System.Drawing.Point(6, 66);
			this.a_label.Name = "a_label";
			this.a_label.Size = new System.Drawing.Size(24, 17);
			this.a_label.TabIndex = 2;
			this.a_label.Text = "a: ";
			// 
			// A
			// 
			this.A.AutoSize = true;
			this.A.Location = new System.Drawing.Point(37, 66);
			this.A.Name = "A";
			this.A.Size = new System.Drawing.Size(0, 17);
			this.A.TabIndex = 3;
			// 
			// calculate
			// 
			this.calculate.Location = new System.Drawing.Point(180, 35);
			this.calculate.Name = "calculate";
			this.calculate.Size = new System.Drawing.Size(102, 34);
			this.calculate.TabIndex = 4;
			this.calculate.Text = "Рассчитать";
			this.calculate.UseVisualStyleBackColor = true;
			this.calculate.Click += new System.EventHandler(this.calculate_Click);
			// 
			// numder_label
			// 
			this.numder_label.AutoSize = true;
			this.numder_label.Location = new System.Drawing.Point(24, 40);
			this.numder_label.Name = "numder_label";
			this.numder_label.Size = new System.Drawing.Size(118, 17);
			this.numder_label.TabIndex = 0;
			this.numder_label.Text = "Номер элемента";
			// 
			// difference_label
			// 
			this.difference_label.AutoSize = true;
			this.difference_label.Location = new System.Drawing.Point(24, 65);
			this.difference_label.Name = "difference_label";
			this.difference_label.Size = new System.Drawing.Size(64, 17);
			this.difference_label.TabIndex = 1;
			this.difference_label.Text = "Разница";
			// 
			// sum_label
			// 
			this.sum_label.AutoSize = true;
			this.sum_label.Location = new System.Drawing.Point(24, 114);
			this.sum_label.Name = "sum_label";
			this.sum_label.Size = new System.Drawing.Size(50, 17);
			this.sum_label.TabIndex = 2;
			this.sum_label.Text = "Сумма";
			// 
			// value_label
			// 
			this.value_label.AutoSize = true;
			this.value_label.Location = new System.Drawing.Point(24, 91);
			this.value_label.Name = "value_label";
			this.value_label.Size = new System.Drawing.Size(140, 17);
			this.value_label.TabIndex = 3;
			this.value_label.Text = "Значение элемента";
			// 
			// number
			// 
			this.number.Location = new System.Drawing.Point(170, 37);
			this.number.Name = "number";
			this.number.Size = new System.Drawing.Size(100, 22);
			this.number.TabIndex = 4;
			this.number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.N_KeyPress);
			// 
			// value
			// 
			this.value.Enabled = false;
			this.value.Location = new System.Drawing.Point(170, 88);
			this.value.Name = "value";
			this.value.Size = new System.Drawing.Size(100, 22);
			this.value.TabIndex = 5;
			// 
			// difference
			// 
			this.difference.Location = new System.Drawing.Point(170, 62);
			this.difference.Name = "difference";
			this.difference.Size = new System.Drawing.Size(100, 22);
			this.difference.TabIndex = 6;
			this.difference.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.N_KeyPress);
			// 
			// summ
			// 
			this.summ.Enabled = false;
			this.summ.Location = new System.Drawing.Point(170, 114);
			this.summ.Name = "summ";
			this.summ.Size = new System.Drawing.Size(100, 22);
			this.summ.TabIndex = 7;
			// 
			// calculate2
			// 
			this.calculate2.Location = new System.Drawing.Point(98, 141);
			this.calculate2.Name = "calculate2";
			this.calculate2.Size = new System.Drawing.Size(103, 27);
			this.calculate2.TabIndex = 8;
			this.calculate2.Text = "Рассчитать";
			this.calculate2.UseVisualStyleBackColor = true;
			this.calculate2.Click += new System.EventHandler(this.calculate2_Click);
			// 
			// Practic4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(647, 194);
			this.Controls.Add(this.task2);
			this.Controls.Add(this.task1);
			this.Name = "Practic4";
			this.Text = "Практикум 4";
			this.task1.ResumeLayout(false);
			this.task1.PerformLayout();
			this.task2.ResumeLayout(false);
			this.task2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox task1;
		private System.Windows.Forms.GroupBox task2;
		private System.Windows.Forms.TextBox N;
		private System.Windows.Forms.Label n_label;
		private System.Windows.Forms.Button calculate;
		private System.Windows.Forms.Label A;
		private System.Windows.Forms.Label a_label;
		private System.Windows.Forms.Button calculate2;
		private System.Windows.Forms.TextBox summ;
		private System.Windows.Forms.TextBox difference;
		private System.Windows.Forms.TextBox value;
		private System.Windows.Forms.TextBox number;
		private System.Windows.Forms.Label value_label;
		private System.Windows.Forms.Label sum_label;
		private System.Windows.Forms.Label difference_label;
		private System.Windows.Forms.Label numder_label;
	}
}

