namespace tictactoe
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
            A00 = new Button();
            A01 = new Button();
            A02 = new Button();
            A11 = new Button();
            A10 = new Button();
            A12 = new Button();
            A20 = new Button();
            A21 = new Button();
            A22 = new Button();
            newgame = new Button();
            reset = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // A00
            // 
            A00.Location = new Point(31, 36);
            A00.Name = "A00";
            A00.Size = new Size(109, 65);
            A00.TabIndex = 0;
            A00.UseVisualStyleBackColor = true;
            A00.Click += buttonClick;
            // 
            // A01
            // 
            A01.Location = new Point(146, 36);
            A01.Name = "A01";
            A01.Size = new Size(111, 65);
            A01.TabIndex = 1;
            A01.UseVisualStyleBackColor = true;
            A01.Click += buttonClick;
            // 
            // A02
            // 
            A02.Location = new Point(263, 36);
            A02.Name = "A02";
            A02.Size = new Size(111, 65);
            A02.TabIndex = 2;
            A02.UseVisualStyleBackColor = true;
            A02.Click += buttonClick;
            // 
            // A11
            // 
            A11.Location = new Point(146, 107);
            A11.Name = "A11";
            A11.Size = new Size(111, 65);
            A11.TabIndex = 3;
            A11.UseVisualStyleBackColor = true;
            A11.Click += buttonClick;
            // 
            // A10
            // 
            A10.Location = new Point(29, 107);
            A10.Name = "A10";
            A10.Size = new Size(111, 65);
            A10.TabIndex = 4;
            A10.UseVisualStyleBackColor = true;
            A10.Click += buttonClick;
            // 
            // A12
            // 
            A12.Location = new Point(263, 107);
            A12.Name = "A12";
            A12.Size = new Size(111, 65);
            A12.TabIndex = 5;
            A12.UseVisualStyleBackColor = true;
            A12.Click += buttonClick;
            // 
            // A20
            // 
            A20.Location = new Point(29, 178);
            A20.Name = "A20";
            A20.Size = new Size(111, 65);
            A20.TabIndex = 6;
            A20.UseVisualStyleBackColor = true;
            A20.MouseCaptureChanged += A20_MouseCaptureChanged;
            // 
            // A21
            // 
            A21.Location = new Point(146, 178);
            A21.Name = "A21";
            A21.Size = new Size(111, 65);
            A21.TabIndex = 7;
            A21.UseVisualStyleBackColor = true;
            // 
            // A22
            // 
            A22.Location = new Point(263, 178);
            A22.Name = "A22";
            A22.Size = new Size(111, 65);
            A22.TabIndex = 8;
            A22.UseVisualStyleBackColor = true;
            // 
            // newgame
            // 
            newgame.Location = new Point(31, 249);
            newgame.Name = "newgame";
            newgame.Size = new Size(109, 23);
            newgame.TabIndex = 9;
            newgame.Text = "NewGame";
            newgame.UseVisualStyleBackColor = true;
            // 
            // reset
            // 
            reset.Location = new Point(148, 249);
            reset.Name = "reset";
            reset.Size = new Size(109, 23);
            reset.TabIndex = 10;
            reset.Text = "Reset";
            reset.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(519, 132);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 11;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(519, 107);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 12;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(519, 157);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 13;
            label3.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 611);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(reset);
            Controls.Add(newgame);
            Controls.Add(A22);
            Controls.Add(A21);
            Controls.Add(A20);
            Controls.Add(A12);
            Controls.Add(A10);
            Controls.Add(A11);
            Controls.Add(A02);
            Controls.Add(A01);
            Controls.Add(A00);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button A00;
        private Button A01;
        private Button A02;
        private Button A11;
        private Button A10;
        private Button A12;
        private Button A20;
        private Button A21;
        private Button A22;
        private Button newgame;
        private Button reset;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
