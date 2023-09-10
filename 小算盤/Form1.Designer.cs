namespace 小算盤
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.multi = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.value = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button15 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.number_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(224, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 54);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.number_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(412, 183);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 54);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.number_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(36, 243);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(182, 54);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.number_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(224, 243);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(182, 54);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.number_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(412, 243);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(182, 54);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.number_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(36, 303);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(182, 54);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.number_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(224, 303);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(182, 54);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.number_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(412, 303);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(182, 54);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.number_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(56, -71);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(182, 54);
            this.button10.TabIndex = 10;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.number_Click);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(633, 183);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(86, 54);
            this.division.TabIndex = 11;
            this.division.Text = "%";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.operation_Click);
            // 
            // multi
            // 
            this.multi.Location = new System.Drawing.Point(633, 243);
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(86, 54);
            this.multi.TabIndex = 12;
            this.multi.Text = "X";
            this.multi.UseVisualStyleBackColor = true;
            this.multi.Click += new System.EventHandler(this.operation_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(633, 303);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(86, 54);
            this.minus.TabIndex = 13;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.operation_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(633, 363);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(86, 54);
            this.add.TabIndex = 14;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.operation_Click);
            // 
            // value
            // 
            this.value.Location = new System.Drawing.Point(412, 363);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(182, 54);
            this.value.TabIndex = 15;
            this.value.Text = "=";
            this.value.UseVisualStyleBackColor = true;
            this.value.Click += new System.EventHandler(this.value_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(675, 25);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(36, 363);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(182, 54);
            this.button15.TabIndex = 17;
            this.button15.Text = "C";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(225, 363);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(180, 53);
            this.button0.TabIndex = 18;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.number_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.value);
            this.Controls.Add(this.add);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.multi);
            this.Controls.Add(this.division);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button multi;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button value;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button0;
    }
}

