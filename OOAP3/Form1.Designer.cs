namespace OOAP3
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.add = new System.Windows.Forms.Button();
            this.reduce = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Subtract = new System.Windows.Forms.Button();
            this.numerator1 = new System.Windows.Forms.TextBox();
            this.denominator1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numerator2 = new System.Windows.Forms.TextBox();
            this.labeResult = new System.Windows.Forms.Label();
            this.denominator2 = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(22, 12);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(147, 23);
            this.add.TabIndex = 0;
            this.add.Text = "Сложение";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.button1_Click);
            // 
            // reduce
            // 
            this.reduce.Location = new System.Drawing.Point(22, 317);
            this.reduce.Name = "reduce";
            this.reduce.Size = new System.Drawing.Size(147, 23);
            this.reduce.TabIndex = 1;
            this.reduce.Text = "Сократить";
            this.reduce.UseVisualStyleBackColor = true;
            this.reduce.Click += new System.EventHandler(this.button2_Click);
            // 
            // Divide
            // 
            this.Divide.Location = new System.Drawing.Point(22, 253);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(147, 23);
            this.Divide.TabIndex = 2;
            this.Divide.Text = "Деление";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.button3_Click);
            // 
            // Multiply
            // 
            this.Multiply.Location = new System.Drawing.Point(22, 176);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(147, 23);
            this.Multiply.TabIndex = 3;
            this.Multiply.Text = "Умножение";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.button4_Click);
            // 
            // Subtract
            // 
            this.Subtract.Location = new System.Drawing.Point(22, 89);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new System.Drawing.Size(147, 23);
            this.Subtract.TabIndex = 4;
            this.Subtract.Text = "Вычитание";
            this.Subtract.UseVisualStyleBackColor = true;
            this.Subtract.Click += new System.EventHandler(this.button5_Click);
            // 
            // numerator1
            // 
            this.numerator1.Location = new System.Drawing.Point(330, 43);
            this.numerator1.Name = "numerator1";
            this.numerator1.Size = new System.Drawing.Size(299, 21);
            this.numerator1.TabIndex = 5;
            this.numerator1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // denominator1
            // 
            this.denominator1.Location = new System.Drawing.Point(330, 91);
            this.denominator1.Name = "denominator1";
            this.denominator1.Size = new System.Drawing.Size(299, 21);
            this.denominator1.TabIndex = 6;
            this.denominator1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(635, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "Числитель1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(635, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "Знаменатель1";
            // 
            // numerator2
            // 
            this.numerator2.Location = new System.Drawing.Point(330, 145);
            this.numerator2.Name = "numerator2";
            this.numerator2.Size = new System.Drawing.Size(299, 21);
            this.numerator2.TabIndex = 9;
            // 
            // labeResult
            // 
            this.labeResult.AutoSize = true;
            this.labeResult.Location = new System.Drawing.Point(647, 262);
            this.labeResult.Name = "labeResult";
            this.labeResult.Size = new System.Drawing.Size(113, 12);
            this.labeResult.TabIndex = 10;
            this.labeResult.Text = "Результат";
            // 
            // denominator2
            // 
            this.denominator2.Location = new System.Drawing.Point(330, 197);
            this.denominator2.Name = "denominator2";
            this.denominator2.Size = new System.Drawing.Size(299, 21);
            this.denominator2.TabIndex = 11;
            // 
            // labelResult
            // 
            this.labelResult.Location = new System.Drawing.Point(330, 253);
            this.labelResult.Name = "labelResult";
            this.labelResult.ReadOnly = true;
            this.labelResult.Size = new System.Drawing.Size(299, 21);
            this.labelResult.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(641, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "Числитель2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(641, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "Знаменатель2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.denominator2);
            this.Controls.Add(this.labeResult);
            this.Controls.Add(this.numerator2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.denominator1);
            this.Controls.Add(this.numerator1);
            this.Controls.Add(this.Subtract);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.reduce);
            this.Controls.Add(this.add);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button reduce;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Subtract;
        private System.Windows.Forms.TextBox numerator1;
        private System.Windows.Forms.TextBox denominator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numerator2;
        private System.Windows.Forms.Label labeResult;
        private System.Windows.Forms.TextBox denominator2;
        private System.Windows.Forms.TextBox labelResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

