namespace fastFood
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
            panel1 = new Panel();
            dateLB = new Label();
            label1 = new Label();
            panel2 = new Panel();
            wrapTB = new TextBox();
            wrapCB = new CheckBox();
            chickenTB = new TextBox();
            chickenCB = new CheckBox();
            sandwichTB = new TextBox();
            sandwichCB = new CheckBox();
            saladTB = new TextBox();
            saladCB = new CheckBox();
            burgerTB = new TextBox();
            burgerCB = new CheckBox();
            friesTB = new TextBox();
            friesCB = new CheckBox();
            label2 = new Label();
            panel3 = new Panel();
            milkTB = new TextBox();
            milkCB = new CheckBox();
            juiceTB = new TextBox();
            juiceCB = new CheckBox();
            cocoaTB = new TextBox();
            cocoaCB = new CheckBox();
            waterTB = new TextBox();
            waterCB = new CheckBox();
            coffeeTB = new TextBox();
            coffeeCB = new CheckBox();
            teaTB = new TextBox();
            teaCB = new CheckBox();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(dateLB);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1143, 103);
            panel1.TabIndex = 0;
            // 
            // dateLB
            // 
            dateLB.AutoSize = true;
            dateLB.BackColor = Color.Red;
            dateLB.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dateLB.ForeColor = Color.Gold;
            dateLB.Location = new Point(931, 46);
            dateLB.Margin = new Padding(4, 0, 4, 0);
            dateLB.Name = "dateLB";
            dateLB.Size = new Size(85, 40);
            dateLB.TabIndex = 3;
            dateLB.Text = "Time";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(504, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(147, 40);
            label1.TabIndex = 0;
            label1.Text = "SWIFTY'S";
            // 
            // panel2
            // 
            panel2.Controls.Add(wrapTB);
            panel2.Controls.Add(wrapCB);
            panel2.Controls.Add(chickenTB);
            panel2.Controls.Add(chickenCB);
            panel2.Controls.Add(sandwichTB);
            panel2.Controls.Add(sandwichCB);
            panel2.Controls.Add(saladTB);
            panel2.Controls.Add(saladCB);
            panel2.Controls.Add(burgerTB);
            panel2.Controls.Add(burgerCB);
            panel2.Controls.Add(friesTB);
            panel2.Controls.Add(friesCB);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 103);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(261, 647);
            panel2.TabIndex = 1;
            // 
            // wrapTB
            // 
            wrapTB.Enabled = false;
            wrapTB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            wrapTB.Location = new Point(150, 468);
            wrapTB.Multiline = true;
            wrapTB.Name = "wrapTB";
            wrapTB.Size = new Size(51, 46);
            wrapTB.TabIndex = 14;
            wrapTB.Text = "0";
            wrapTB.TextAlign = HorizontalAlignment.Center;
            // 
            // wrapCB
            // 
            wrapCB.AutoSize = true;
            wrapCB.Location = new Point(12, 470);
            wrapCB.Name = "wrapCB";
            wrapCB.Size = new Size(81, 29);
            wrapCB.TabIndex = 13;
            wrapCB.Text = "Wrap";
            wrapCB.UseVisualStyleBackColor = true;
            wrapCB.CheckedChanged += wrapCB_CheckedChanged;
            // 
            // chickenTB
            // 
            chickenTB.Enabled = false;
            chickenTB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            chickenTB.Location = new Point(150, 391);
            chickenTB.Multiline = true;
            chickenTB.Name = "chickenTB";
            chickenTB.Size = new Size(51, 46);
            chickenTB.TabIndex = 12;
            chickenTB.Text = "0";
            chickenTB.TextAlign = HorizontalAlignment.Center;
            // 
            // chickenCB
            // 
            chickenCB.AutoSize = true;
            chickenCB.Location = new Point(12, 393);
            chickenCB.Name = "chickenCB";
            chickenCB.Size = new Size(99, 29);
            chickenCB.TabIndex = 11;
            chickenCB.Text = "Chicken";
            chickenCB.UseVisualStyleBackColor = true;
            chickenCB.CheckedChanged += chickenCB_CheckedChanged;
            // 
            // sandwichTB
            // 
            sandwichTB.Enabled = false;
            sandwichTB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            sandwichTB.Location = new Point(150, 309);
            sandwichTB.Multiline = true;
            sandwichTB.Name = "sandwichTB";
            sandwichTB.Size = new Size(51, 46);
            sandwichTB.TabIndex = 10;
            sandwichTB.Text = "0";
            sandwichTB.TextAlign = HorizontalAlignment.Center;
            // 
            // sandwichCB
            // 
            sandwichCB.AutoSize = true;
            sandwichCB.Location = new Point(12, 311);
            sandwichCB.Name = "sandwichCB";
            sandwichCB.Size = new Size(113, 29);
            sandwichCB.TabIndex = 9;
            sandwichCB.Text = "Sandwich";
            sandwichCB.UseVisualStyleBackColor = true;
            sandwichCB.CheckedChanged += sandwichCB_CheckedChanged;
            // 
            // saladTB
            // 
            saladTB.Enabled = false;
            saladTB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            saladTB.Location = new Point(150, 225);
            saladTB.Multiline = true;
            saladTB.Name = "saladTB";
            saladTB.Size = new Size(51, 46);
            saladTB.TabIndex = 8;
            saladTB.Text = "0";
            saladTB.TextAlign = HorizontalAlignment.Center;
            // 
            // saladCB
            // 
            saladCB.AutoSize = true;
            saladCB.Location = new Point(12, 227);
            saladCB.Name = "saladCB";
            saladCB.Size = new Size(81, 29);
            saladCB.TabIndex = 7;
            saladCB.Text = "Salad";
            saladCB.UseVisualStyleBackColor = true;
            saladCB.CheckedChanged += saladCB_CheckedChanged;
            // 
            // burgerTB
            // 
            burgerTB.Enabled = false;
            burgerTB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            burgerTB.Location = new Point(150, 141);
            burgerTB.Multiline = true;
            burgerTB.Name = "burgerTB";
            burgerTB.Size = new Size(51, 46);
            burgerTB.TabIndex = 6;
            burgerTB.Text = "0";
            burgerTB.TextAlign = HorizontalAlignment.Center;
            // 
            // burgerCB
            // 
            burgerCB.AutoSize = true;
            burgerCB.Location = new Point(12, 143);
            burgerCB.Name = "burgerCB";
            burgerCB.Size = new Size(90, 29);
            burgerCB.TabIndex = 5;
            burgerCB.Text = "Burger";
            burgerCB.UseVisualStyleBackColor = true;
            burgerCB.CheckedChanged += burgerCB_CheckedChanged;
            // 
            // friesTB
            // 
            friesTB.Enabled = false;
            friesTB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            friesTB.Location = new Point(150, 62);
            friesTB.Multiline = true;
            friesTB.Name = "friesTB";
            friesTB.Size = new Size(51, 46);
            friesTB.TabIndex = 4;
            friesTB.Text = "0";
            friesTB.TextAlign = HorizontalAlignment.Center;
            // 
            // friesCB
            // 
            friesCB.AutoSize = true;
            friesCB.Location = new Point(12, 64);
            friesCB.Name = "friesCB";
            friesCB.Size = new Size(74, 29);
            friesCB.TabIndex = 3;
            friesCB.Text = "Fries";
            friesCB.UseVisualStyleBackColor = true;
            friesCB.CheckedChanged += friesCB_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(79, 5);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(98, 40);
            label2.TabIndex = 3;
            label2.Text = "Meals";
            // 
            // panel3
            // 
            panel3.Controls.Add(milkTB);
            panel3.Controls.Add(milkCB);
            panel3.Controls.Add(juiceTB);
            panel3.Controls.Add(juiceCB);
            panel3.Controls.Add(cocoaTB);
            panel3.Controls.Add(cocoaCB);
            panel3.Controls.Add(waterTB);
            panel3.Controls.Add(waterCB);
            panel3.Controls.Add(coffeeTB);
            panel3.Controls.Add(coffeeCB);
            panel3.Controls.Add(teaTB);
            panel3.Controls.Add(teaCB);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(857, 103);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(286, 647);
            panel3.TabIndex = 2;
            // 
            // milkTB
            // 
            milkTB.Enabled = false;
            milkTB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            milkTB.Location = new Point(170, 468);
            milkTB.Multiline = true;
            milkTB.Name = "milkTB";
            milkTB.Size = new Size(51, 42);
            milkTB.TabIndex = 26;
            milkTB.Text = "0";
            milkTB.TextAlign = HorizontalAlignment.Center;
            // 
            // milkCB
            // 
            milkCB.AutoSize = true;
            milkCB.Location = new Point(32, 470);
            milkCB.Name = "milkCB";
            milkCB.Size = new Size(71, 29);
            milkCB.TabIndex = 25;
            milkCB.Text = "Milk";
            milkCB.UseVisualStyleBackColor = true;
            // 
            // juiceTB
            // 
            juiceTB.Enabled = false;
            juiceTB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            juiceTB.Location = new Point(170, 391);
            juiceTB.Multiline = true;
            juiceTB.Name = "juiceTB";
            juiceTB.Size = new Size(51, 42);
            juiceTB.TabIndex = 24;
            juiceTB.Text = "0";
            juiceTB.TextAlign = HorizontalAlignment.Center;
            // 
            // juiceCB
            // 
            juiceCB.AutoSize = true;
            juiceCB.Location = new Point(32, 393);
            juiceCB.Name = "juiceCB";
            juiceCB.Size = new Size(75, 29);
            juiceCB.TabIndex = 23;
            juiceCB.Text = "Juice";
            juiceCB.UseVisualStyleBackColor = true;
            // 
            // cocoaTB
            // 
            cocoaTB.Enabled = false;
            cocoaTB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cocoaTB.Location = new Point(170, 309);
            cocoaTB.Multiline = true;
            cocoaTB.Name = "cocoaTB";
            cocoaTB.Size = new Size(51, 42);
            cocoaTB.TabIndex = 22;
            cocoaTB.Text = "0";
            cocoaTB.TextAlign = HorizontalAlignment.Center;
            // 
            // cocoaCB
            // 
            cocoaCB.AutoSize = true;
            cocoaCB.Location = new Point(32, 311);
            cocoaCB.Name = "cocoaCB";
            cocoaCB.Size = new Size(88, 29);
            cocoaCB.TabIndex = 21;
            cocoaCB.Text = "Cocoa";
            cocoaCB.UseVisualStyleBackColor = true;
            cocoaCB.CheckedChanged += cocoaCB_CheckedChanged;
            // 
            // waterTB
            // 
            waterTB.Enabled = false;
            waterTB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            waterTB.Location = new Point(170, 225);
            waterTB.Multiline = true;
            waterTB.Name = "waterTB";
            waterTB.Size = new Size(51, 42);
            waterTB.TabIndex = 20;
            waterTB.Text = "0";
            waterTB.TextAlign = HorizontalAlignment.Center;
            // 
            // waterCB
            // 
            waterCB.AutoSize = true;
            waterCB.Location = new Point(32, 227);
            waterCB.Name = "waterCB";
            waterCB.Size = new Size(84, 29);
            waterCB.TabIndex = 19;
            waterCB.Text = "Water";
            waterCB.UseVisualStyleBackColor = true;
            waterCB.CheckedChanged += waterCB_CheckedChanged;
            // 
            // coffeeTB
            // 
            coffeeTB.Enabled = false;
            coffeeTB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            coffeeTB.Location = new Point(170, 141);
            coffeeTB.Multiline = true;
            coffeeTB.Name = "coffeeTB";
            coffeeTB.Size = new Size(51, 42);
            coffeeTB.TabIndex = 18;
            coffeeTB.Text = "0";
            coffeeTB.TextAlign = HorizontalAlignment.Center;
            // 
            // coffeeCB
            // 
            coffeeCB.AutoSize = true;
            coffeeCB.Location = new Point(32, 143);
            coffeeCB.Name = "coffeeCB";
            coffeeCB.Size = new Size(90, 29);
            coffeeCB.TabIndex = 17;
            coffeeCB.Text = "Coffee";
            coffeeCB.UseVisualStyleBackColor = true;
            coffeeCB.CheckedChanged += coffeeCB_CheckedChanged;
            // 
            // teaTB
            // 
            teaTB.Enabled = false;
            teaTB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            teaTB.Location = new Point(170, 62);
            teaTB.Multiline = true;
            teaTB.Name = "teaTB";
            teaTB.Size = new Size(51, 42);
            teaTB.TabIndex = 16;
            teaTB.Text = "0";
            teaTB.TextAlign = HorizontalAlignment.Center;
            // 
            // teaCB
            // 
            teaCB.AutoSize = true;
            teaCB.Location = new Point(32, 64);
            teaCB.Name = "teaCB";
            teaCB.Size = new Size(63, 29);
            teaCB.TabIndex = 15;
            teaCB.Text = "Tea";
            teaCB.UseVisualStyleBackColor = true;
            teaCB.CheckedChanged += teaCB_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(89, 5);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(105, 40);
            label3.TabIndex = 4;
            label3.Text = "Drinks";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private CheckBox friesCB;
        private Label label3;
        private TextBox friesTB;
        private TextBox wrapTB;
        private CheckBox wrapCB;
        private TextBox chickenTB;
        private CheckBox chickenCB;
        private TextBox sandwichTB;
        private CheckBox sandwichCB;
        private TextBox saladTB;
        private CheckBox saladCB;
        private TextBox burgerTB;
        private CheckBox burgerCB;
        private TextBox milkTB;
        private CheckBox milkCB;
        private TextBox juiceTB;
        private CheckBox juiceCB;
        private TextBox cocoaTB;
        private CheckBox cocoaCB;
        private TextBox waterTB;
        private CheckBox waterCB;
        private TextBox coffeeTB;
        private CheckBox coffeeCB;
        private TextBox teaTB;
        private CheckBox teaCB;
        private System.Windows.Forms.Timer timer1;
        private Label dateLB;
    }
}