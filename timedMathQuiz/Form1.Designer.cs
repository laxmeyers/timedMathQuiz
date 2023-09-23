namespace timedMathQuiz
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timeLabel = new Label();
            label1 = new Label();
            plusLeftLabel = new Label();
            plusRightLabel = new Label();
            label3 = new Label();
            plusLabel = new Label();
            sum = new NumericUpDown();
            difference = new NumericUpDown();
            label2 = new Label();
            label4 = new Label();
            minusRightLabel = new Label();
            minusLeftLabel = new Label();
            product = new NumericUpDown();
            label7 = new Label();
            label8 = new Label();
            timesRightLabel = new Label();
            timesLeftLabel = new Label();
            quotient = new NumericUpDown();
            label11 = new Label();
            label12 = new Label();
            dividedRightLabel = new Label();
            dividedLeftLabel = new Label();
            startButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            currentDate = new Label();
            ((System.ComponentModel.ISupportInitialize)sum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)difference).BeginInit();
            ((System.ComponentModel.ISupportInitialize)product).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quotient).BeginInit();
            SuspendLayout();
            // 
            // timeLabel
            // 
            timeLabel.BorderStyle = BorderStyle.FixedSingle;
            timeLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            timeLabel.Location = new Point(270, 9);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(200, 40);
            timeLabel.TabIndex = 0;
            timeLabel.Click += label1_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(140, -1);
            label1.Name = "label1";
            label1.Size = new Size(130, 50);
            label1.TabIndex = 1;
            label1.Text = "Time Left";
            // 
            // plusLeftLabel
            // 
            plusLeftLabel.Location = new Point(48, 49);
            plusLeftLabel.Name = "plusLeftLabel";
            plusLeftLabel.Size = new Size(60, 50);
            plusLeftLabel.TabIndex = 2;
            plusLeftLabel.Text = "?";
            plusLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // plusRightLabel
            // 
            plusRightLabel.Location = new Point(180, 49);
            plusRightLabel.Name = "plusRightLabel";
            plusRightLabel.Size = new Size(60, 50);
            plusRightLabel.TabIndex = 3;
            plusRightLabel.Text = "?";
            plusRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Location = new Point(246, 49);
            label3.Name = "label3";
            label3.Size = new Size(60, 50);
            label3.TabIndex = 4;
            label3.Text = "=";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // plusLabel
            // 
            plusLabel.Location = new Point(114, 49);
            plusLabel.Name = "plusLabel";
            plusLabel.Size = new Size(60, 50);
            plusLabel.TabIndex = 5;
            plusLabel.Text = "+";
            plusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sum
            // 
            sum.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            sum.Location = new Point(312, 52);
            sum.Name = "sum";
            sum.Size = new Size(100, 47);
            sum.TabIndex = 1;
            // 
            // difference
            // 
            difference.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            difference.Location = new Point(312, 123);
            difference.Name = "difference";
            difference.Size = new Size(100, 47);
            difference.TabIndex = 2;
            // 
            // label2
            // 
            label2.Location = new Point(114, 120);
            label2.Name = "label2";
            label2.Size = new Size(60, 50);
            label2.TabIndex = 10;
            label2.Text = "-";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Location = new Point(246, 120);
            label4.Name = "label4";
            label4.Size = new Size(60, 50);
            label4.TabIndex = 9;
            label4.Text = "=";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minusRightLabel
            // 
            minusRightLabel.Location = new Point(180, 120);
            minusRightLabel.Name = "minusRightLabel";
            minusRightLabel.Size = new Size(60, 50);
            minusRightLabel.TabIndex = 8;
            minusRightLabel.Text = "?";
            minusRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minusLeftLabel
            // 
            minusLeftLabel.Location = new Point(48, 120);
            minusLeftLabel.Name = "minusLeftLabel";
            minusLeftLabel.Size = new Size(60, 50);
            minusLeftLabel.TabIndex = 7;
            minusLeftLabel.Text = "?";
            minusLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // product
            // 
            product.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            product.Location = new Point(312, 187);
            product.Name = "product";
            product.Size = new Size(100, 47);
            product.TabIndex = 3;
            product.ValueChanged += product_ValueChanged;
            // 
            // label7
            // 
            label7.Location = new Point(114, 184);
            label7.Name = "label7";
            label7.Size = new Size(60, 50);
            label7.TabIndex = 15;
            label7.Text = "×";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Location = new Point(246, 184);
            label8.Name = "label8";
            label8.Size = new Size(60, 50);
            label8.TabIndex = 14;
            label8.Text = "=";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timesRightLabel
            // 
            timesRightLabel.Location = new Point(180, 184);
            timesRightLabel.Name = "timesRightLabel";
            timesRightLabel.Size = new Size(60, 50);
            timesRightLabel.TabIndex = 13;
            timesRightLabel.Text = "?";
            timesRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timesLeftLabel
            // 
            timesLeftLabel.Location = new Point(48, 184);
            timesLeftLabel.Name = "timesLeftLabel";
            timesLeftLabel.Size = new Size(60, 50);
            timesLeftLabel.TabIndex = 12;
            timesLeftLabel.Text = "?";
            timesLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // quotient
            // 
            quotient.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            quotient.Location = new Point(312, 250);
            quotient.Name = "quotient";
            quotient.Size = new Size(100, 47);
            quotient.TabIndex = 4;
            // 
            // label11
            // 
            label11.Location = new Point(114, 247);
            label11.Name = "label11";
            label11.Size = new Size(60, 50);
            label11.TabIndex = 20;
            label11.Text = "÷";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.Location = new Point(246, 247);
            label12.Name = "label12";
            label12.Size = new Size(60, 50);
            label12.TabIndex = 19;
            label12.Text = "=";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dividedRightLabel
            // 
            dividedRightLabel.Location = new Point(180, 247);
            dividedRightLabel.Name = "dividedRightLabel";
            dividedRightLabel.Size = new Size(60, 50);
            dividedRightLabel.TabIndex = 18;
            dividedRightLabel.Text = "?";
            dividedRightLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dividedLeftLabel
            // 
            dividedLeftLabel.Location = new Point(48, 247);
            dividedLeftLabel.Name = "dividedLeftLabel";
            dividedLeftLabel.Size = new Size(60, 50);
            dividedLeftLabel.TabIndex = 17;
            dividedLeftLabel.Text = "?";
            dividedLeftLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            startButton.AutoSize = true;
            startButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            startButton.Location = new Point(140, 300);
            startButton.Name = "startButton";
            startButton.Size = new Size(170, 42);
            startButton.TabIndex = 0;
            startButton.Text = "Start the Quiz";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // currentDate
            // 
            currentDate.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            currentDate.Location = new Point(4, -1);
            currentDate.Name = "currentDate";
            currentDate.Size = new Size(130, 50);
            currentDate.TabIndex = 21;
            currentDate.Click += date_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 353);
            Controls.Add(currentDate);
            Controls.Add(startButton);
            Controls.Add(quotient);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(dividedRightLabel);
            Controls.Add(dividedLeftLabel);
            Controls.Add(product);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(timesRightLabel);
            Controls.Add(timesLeftLabel);
            Controls.Add(difference);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(minusRightLabel);
            Controls.Add(minusLeftLabel);
            Controls.Add(sum);
            Controls.Add(plusLabel);
            Controls.Add(label3);
            Controls.Add(plusRightLabel);
            Controls.Add(plusLeftLabel);
            Controls.Add(label1);
            Controls.Add(timeLabel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Andrew Meyers Math Quiz";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)sum).EndInit();
            ((System.ComponentModel.ISupportInitialize)difference).EndInit();
            ((System.ComponentModel.ISupportInitialize)product).EndInit();
            ((System.ComponentModel.ISupportInitialize)quotient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label timeLabel;
        private Label label1;
        private Label plusLeftLabel;
        private Label plusRightLabel;
        private Label label3;
        private Label plusLabel;
        private NumericUpDown sum;
        private NumericUpDown difference;
        private Label label2;
        private Label label4;
        private Label minusRightLabel;
        private Label minusLeftLabel;
        private NumericUpDown product;
        private Label label7;
        private Label label8;
        private Label timesRightLabel;
        private Label timesLeftLabel;
        private NumericUpDown quotient;
        private Label label11;
        private Label label12;
        private Label dividedRightLabel;
        private Label dividedLeftLabel;
        private Button startButton;
        private System.Windows.Forms.Timer timer1;
        private Label currentDate;
    }
}