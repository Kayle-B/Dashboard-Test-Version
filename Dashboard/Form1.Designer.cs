namespace Dashboard
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
            this.Calculator_Widget = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.devideButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.caluclatedTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.value2TextBox = new System.Windows.Forms.TextBox();
            this.value1TextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Calculator_Widget.SuspendLayout();
            this.SuspendLayout();
            // 
            // Calculator_Widget
            // 
            this.Calculator_Widget.Controls.Add(this.label3);
            this.Calculator_Widget.Controls.Add(this.multiplyButton);
            this.Calculator_Widget.Controls.Add(this.devideButton);
            this.Calculator_Widget.Controls.Add(this.minusButton);
            this.Calculator_Widget.Controls.Add(this.plusButton);
            this.Calculator_Widget.Controls.Add(this.caluclatedTextBox);
            this.Calculator_Widget.Controls.Add(this.label2);
            this.Calculator_Widget.Controls.Add(this.label1);
            this.Calculator_Widget.Controls.Add(this.value2TextBox);
            this.Calculator_Widget.Controls.Add(this.value1TextBox);
            this.Calculator_Widget.Location = new System.Drawing.Point(12, 12);
            this.Calculator_Widget.Name = "Calculator_Widget";
            this.Calculator_Widget.Size = new System.Drawing.Size(237, 426);
            this.Calculator_Widget.TabIndex = 0;
            this.Calculator_Widget.TabStop = false;
            this.Calculator_Widget.Text = "Calculator Widget";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Calculator";
            // 
            // multiplyButton
            // 
            this.multiplyButton.Location = new System.Drawing.Point(206, 157);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(25, 23);
            this.multiplyButton.TabIndex = 8;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // devideButton
            // 
            this.devideButton.Location = new System.Drawing.Point(134, 157);
            this.devideButton.Name = "devideButton";
            this.devideButton.Size = new System.Drawing.Size(25, 23);
            this.devideButton.TabIndex = 7;
            this.devideButton.Text = "/";
            this.devideButton.UseVisualStyleBackColor = true;
            this.devideButton.Click += new System.EventHandler(this.devideButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.Location = new System.Drawing.Point(69, 157);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(25, 23);
            this.minusButton.TabIndex = 6;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.Location = new System.Drawing.Point(6, 157);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(25, 23);
            this.plusButton.TabIndex = 5;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // caluclatedTextBox
            // 
            this.caluclatedTextBox.Enabled = false;
            this.caluclatedTextBox.Location = new System.Drawing.Point(6, 223);
            this.caluclatedTextBox.Name = "caluclatedTextBox";
            this.caluclatedTextBox.Size = new System.Drawing.Size(225, 23);
            this.caluclatedTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Value 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Value 1";
            // 
            // value2TextBox
            // 
            this.value2TextBox.Location = new System.Drawing.Point(6, 128);
            this.value2TextBox.Name = "value2TextBox";
            this.value2TextBox.Size = new System.Drawing.Size(225, 23);
            this.value2TextBox.TabIndex = 1;
            // 
            // value1TextBox
            // 
            this.value1TextBox.Location = new System.Drawing.Point(6, 77);
            this.value1TextBox.Name = "value1TextBox";
            this.value1TextBox.Size = new System.Drawing.Size(225, 23);
            this.value1TextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(255, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 426);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(498, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(237, 426);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(741, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(237, 426);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Calculator_Widget);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Calculator_Widget.ResumeLayout(false);
            this.Calculator_Widget.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox Calculator_Widget;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private TextBox caluclatedTextBox;
        private Label label2;
        private Label label1;
        private TextBox value2TextBox;
        private TextBox value1TextBox;
        private Label label3;
        private Button multiplyButton;
        private Button devideButton;
        private Button minusButton;
        private Button plusButton;
    }
}