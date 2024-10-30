namespace FullyWorkingCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtPrevious = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHistory = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSup = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClearEntry = new System.Windows.Forms.Button();
            this.btnPercent = new System.Windows.Forms.Button();
            this.btnOneDividedBySelf = new System.Windows.Forms.Button();
            this.btnPower = new System.Windows.Forms.Button();
            this.btnSquareRoot = new System.Windows.Forms.Button();
            this.btnDivider = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.SystemColors.Desktop;
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.ForeColor = System.Drawing.SystemColors.Window;
            this.txtInput.Location = new System.Drawing.Point(12, 75);
            this.txtInput.MaxLength = 32;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(280, 56);
            this.txtInput.TabIndex = 0;
            this.txtInput.Text = "0";
            this.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // txtPrevious
            // 
            this.txtPrevious.BackColor = System.Drawing.SystemColors.Desktop;
            this.txtPrevious.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrevious.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrevious.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtPrevious.Location = new System.Drawing.Point(39, 42);
            this.txtPrevious.Name = "txtPrevious";
            this.txtPrevious.ReadOnly = true;
            this.txtPrevious.Size = new System.Drawing.Size(253, 27);
            this.txtPrevious.TabIndex = 1;
            this.txtPrevious.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrevious.TextChanged += new System.EventHandler(this.txtPrevious_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(366, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "History";
            // 
            // txtHistory
            // 
            this.txtHistory.BackColor = System.Drawing.SystemColors.Desktop;
            this.txtHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHistory.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHistory.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtHistory.Location = new System.Drawing.Point(309, 50);
            this.txtHistory.Multiline = true;
            this.txtHistory.Name = "txtHistory";
            this.txtHistory.ReadOnly = true;
            this.txtHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHistory.Size = new System.Drawing.Size(240, 472);
            this.txtHistory.TabIndex = 3;
            this.txtHistory.Text = "There\'s no history yet   ";
            this.txtHistory.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtHistory.TextChanged += new System.EventHandler(this.txtHistory_TextChanged);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(443, 539);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Delete History";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSup
            // 
            this.btnSup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSup.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnSup.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSup.FlatAppearance.BorderSize = 2;
            this.btnSup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSup.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSup.Location = new System.Drawing.Point(227, 137);
            this.btnSup.Name = "btnSup";
            this.btnSup.Size = new System.Drawing.Size(65, 67);
            this.btnSup.TabIndex = 9;
            this.btnSup.Text = "⌫";
            this.btnSup.UseVisualStyleBackColor = false;
            this.btnSup.Click += new System.EventHandler(this.btnSup_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnClear.FlatAppearance.BorderSize = 2;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Window;
            this.btnClear.Location = new System.Drawing.Point(156, 137);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(65, 67);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClearEntry
            // 
            this.btnClearEntry.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClearEntry.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnClearEntry.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnClearEntry.FlatAppearance.BorderSize = 2;
            this.btnClearEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearEntry.ForeColor = System.Drawing.SystemColors.Window;
            this.btnClearEntry.Location = new System.Drawing.Point(85, 137);
            this.btnClearEntry.Name = "btnClearEntry";
            this.btnClearEntry.Size = new System.Drawing.Size(65, 67);
            this.btnClearEntry.TabIndex = 11;
            this.btnClearEntry.Text = "CE";
            this.btnClearEntry.UseVisualStyleBackColor = false;
            this.btnClearEntry.Click += new System.EventHandler(this.btnClearEntry_Click);
            // 
            // btnPercent
            // 
            this.btnPercent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPercent.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnPercent.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPercent.FlatAppearance.BorderSize = 2;
            this.btnPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPercent.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPercent.Location = new System.Drawing.Point(12, 137);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(65, 67);
            this.btnPercent.TabIndex = 12;
            this.btnPercent.Text = "%";
            this.btnPercent.UseVisualStyleBackColor = false;
            this.btnPercent.Click += new System.EventHandler(this.btnPercent_Click);
            // 
            // btnOneDividedBySelf
            // 
            this.btnOneDividedBySelf.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOneDividedBySelf.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnOneDividedBySelf.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnOneDividedBySelf.FlatAppearance.BorderSize = 2;
            this.btnOneDividedBySelf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOneDividedBySelf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOneDividedBySelf.ForeColor = System.Drawing.SystemColors.Window;
            this.btnOneDividedBySelf.Location = new System.Drawing.Point(12, 210);
            this.btnOneDividedBySelf.Name = "btnOneDividedBySelf";
            this.btnOneDividedBySelf.Size = new System.Drawing.Size(65, 67);
            this.btnOneDividedBySelf.TabIndex = 16;
            this.btnOneDividedBySelf.Text = "1/x";
            this.btnOneDividedBySelf.UseVisualStyleBackColor = false;
            this.btnOneDividedBySelf.Click += new System.EventHandler(this.btnOneDividedBySelf_Click);
            // 
            // btnPower
            // 
            this.btnPower.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPower.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnPower.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPower.FlatAppearance.BorderSize = 2;
            this.btnPower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPower.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPower.Location = new System.Drawing.Point(85, 210);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(65, 67);
            this.btnPower.TabIndex = 15;
            this.btnPower.Text = "x²";
            this.btnPower.UseVisualStyleBackColor = false;
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // btnSquareRoot
            // 
            this.btnSquareRoot.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSquareRoot.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnSquareRoot.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSquareRoot.FlatAppearance.BorderSize = 2;
            this.btnSquareRoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSquareRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquareRoot.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSquareRoot.Location = new System.Drawing.Point(156, 210);
            this.btnSquareRoot.Name = "btnSquareRoot";
            this.btnSquareRoot.Size = new System.Drawing.Size(65, 67);
            this.btnSquareRoot.TabIndex = 14;
            this.btnSquareRoot.Text = "√";
            this.btnSquareRoot.UseVisualStyleBackColor = false;
            this.btnSquareRoot.Click += new System.EventHandler(this.btnSquareRoot_Click);
            // 
            // btnDivider
            // 
            this.btnDivider.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDivider.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnDivider.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDivider.FlatAppearance.BorderSize = 2;
            this.btnDivider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivider.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivider.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDivider.Location = new System.Drawing.Point(227, 210);
            this.btnDivider.Name = "btnDivider";
            this.btnDivider.Size = new System.Drawing.Size(65, 67);
            this.btnDivider.TabIndex = 13;
            this.btnDivider.Text = "÷";
            this.btnDivider.UseVisualStyleBackColor = false;
            this.btnDivider.Click += new System.EventHandler(this.btnDivider_Click);
            // 
            // btn7
            // 
            this.btn7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn7.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn7.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn7.FlatAppearance.BorderSize = 2;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.SystemColors.Window;
            this.btn7.Location = new System.Drawing.Point(12, 283);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(65, 67);
            this.btn7.TabIndex = 20;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn8.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn8.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn8.FlatAppearance.BorderSize = 2;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.SystemColors.Window;
            this.btn8.Location = new System.Drawing.Point(85, 283);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(65, 67);
            this.btn8.TabIndex = 19;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn9.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn9.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn9.FlatAppearance.BorderSize = 2;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.SystemColors.Window;
            this.btn9.Location = new System.Drawing.Point(156, 283);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(65, 67);
            this.btn9.TabIndex = 18;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMulti.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnMulti.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMulti.FlatAppearance.BorderSize = 2;
            this.btnMulti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMulti.ForeColor = System.Drawing.SystemColors.Window;
            this.btnMulti.Location = new System.Drawing.Point(227, 283);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(65, 67);
            this.btnMulti.TabIndex = 17;
            this.btnMulti.Text = "×";
            this.btnMulti.UseVisualStyleBackColor = false;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btn4
            // 
            this.btn4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn4.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn4.FlatAppearance.BorderSize = 2;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.SystemColors.Window;
            this.btn4.Location = new System.Drawing.Point(12, 356);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(65, 67);
            this.btn4.TabIndex = 24;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn5.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn5.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn5.FlatAppearance.BorderSize = 2;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.SystemColors.Window;
            this.btn5.Location = new System.Drawing.Point(85, 356);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(65, 67);
            this.btn5.TabIndex = 23;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn6.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn6.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn6.FlatAppearance.BorderSize = 2;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.SystemColors.Window;
            this.btn6.Location = new System.Drawing.Point(156, 356);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(65, 67);
            this.btn6.TabIndex = 22;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMinus.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnMinus.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMinus.FlatAppearance.BorderSize = 2;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.ForeColor = System.Drawing.SystemColors.Window;
            this.btnMinus.Location = new System.Drawing.Point(227, 356);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(65, 67);
            this.btnMinus.TabIndex = 21;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btn1
            // 
            this.btn1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn1.FlatAppearance.BorderSize = 2;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.SystemColors.Window;
            this.btn1.Location = new System.Drawing.Point(12, 429);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(65, 67);
            this.btn1.TabIndex = 28;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn2.FlatAppearance.BorderSize = 2;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.SystemColors.Window;
            this.btn2.Location = new System.Drawing.Point(85, 429);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(65, 67);
            this.btn2.TabIndex = 27;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn3.FlatAppearance.BorderSize = 2;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.SystemColors.Window;
            this.btn3.Location = new System.Drawing.Point(156, 429);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(65, 67);
            this.btn3.TabIndex = 26;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPlus.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnPlus.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPlus.FlatAppearance.BorderSize = 2;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPlus.Location = new System.Drawing.Point(227, 429);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(65, 67);
            this.btnPlus.TabIndex = 25;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // button22
            // 
            this.button22.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button22.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button22.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button22.FlatAppearance.BorderSize = 2;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.ForeColor = System.Drawing.SystemColors.Window;
            this.button22.Location = new System.Drawing.Point(12, 502);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(65, 67);
            this.button22.TabIndex = 32;
            this.button22.Text = "+/-";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // btn0
            // 
            this.btn0.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn0.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn0.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn0.FlatAppearance.BorderSize = 2;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.SystemColors.Window;
            this.btn0.Location = new System.Drawing.Point(85, 502);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(65, 67);
            this.btn0.TabIndex = 31;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnDot
            // 
            this.btnDot.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDot.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnDot.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDot.FlatAppearance.BorderSize = 2;
            this.btnDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDot.Location = new System.Drawing.Point(156, 502);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(65, 67);
            this.btnDot.TabIndex = 30;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = false;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEqual.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnEqual.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEqual.FlatAppearance.BorderSize = 2;
            this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEqual.Location = new System.Drawing.Point(227, 502);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(65, 67);
            this.btnEqual.TabIndex = 29;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(565, 579);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnOneDividedBySelf);
            this.Controls.Add(this.btnPower);
            this.Controls.Add(this.btnSquareRoot);
            this.Controls.Add(this.btnDivider);
            this.Controls.Add(this.btnPercent);
            this.Controls.Add(this.btnClearEntry);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSup);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtHistory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrevious);
            this.Controls.Add(this.txtInput);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPrevious;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHistory;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnSup;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClearEntry;
        private System.Windows.Forms.Button btnPercent;
        private System.Windows.Forms.Button btnOneDividedBySelf;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.Button btnSquareRoot;
        private System.Windows.Forms.Button btnDivider;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnEqual;
    }
}

