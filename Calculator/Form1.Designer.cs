namespace Calculator
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
            groupBox1 = new GroupBox();
            TextOutput = new TextBox();
            TxtNum2 = new TextBox();
            TxtNum1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            btnSub = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TextOutput);
            groupBox1.Controls.Add(TxtNum2);
            groupBox1.Controls.Add(TxtNum1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(297, 156);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // TextOutput
            // 
            TextOutput.Location = new Point(109, 82);
            TextOutput.Name = "TextOutput";
            TextOutput.Size = new Size(100, 23);
            TextOutput.TabIndex = 5;
            // 
            // TxtNum2
            // 
            TxtNum2.Location = new Point(109, 53);
            TxtNum2.Name = "TxtNum2";
            TxtNum2.Size = new Size(100, 23);
            TxtNum2.TabIndex = 4;
            // 
            // TxtNum1
            // 
            TxtNum1.Location = new Point(109, 24);
            TxtNum1.Name = "TxtNum1";
            TxtNum1.Size = new Size(100, 23);
            TxtNum1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 90);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "OUTPUT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 61);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "NUMBER 2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 32);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "NUMBER 1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(btnSub);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(12, 204);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(297, 70);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // button4
            // 
            button4.Location = new Point(221, 24);
            button4.Name = "button4";
            button4.Size = new Size(38, 23);
            button4.TabIndex = 3;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(159, 24);
            button3.Name = "button3";
            button3.Size = new Size(38, 23);
            button3.TabIndex = 2;
            button3.Text = "*";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnSub
            // 
            btnSub.Location = new Point(99, 24);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(38, 23);
            btnSub.TabIndex = 1;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(36, 24);
            button1.Name = "button1";
            button1.Size = new Size(38, 23);
            button1.TabIndex = 0;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 285);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "calculator";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox TextOutput;
        private TextBox TxtNum2;
        private TextBox TxtNum1;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button button4;
        private Button button3;
        private Button btnSub;
        private Button button1;
    }
}