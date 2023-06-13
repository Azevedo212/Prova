namespace prova
{
    partial class Gabarito
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
            tx1 = new TextBox();
            tx2 = new TextBox();
            tx3 = new TextBox();
            tx4 = new TextBox();
            tx5 = new TextBox();
            tx6 = new TextBox();
            tx7 = new TextBox();
            tx8 = new TextBox();
            tx9 = new TextBox();
            tx10 = new TextBox();
            button1 = new Button();
            lb_resultado = new Label();
            SuspendLayout();
            // 
            // tx1
            // 
            tx1.Location = new Point(81, 55);
            tx1.Name = "tx1";
            tx1.Size = new Size(100, 23);
            tx1.TabIndex = 0;
            tx1.TextChanged += tx1_TextChanged;
            // 
            // tx2
            // 
            tx2.Location = new Point(81, 108);
            tx2.Name = "tx2";
            tx2.Size = new Size(100, 23);
            tx2.TabIndex = 1;
            // 
            // tx3
            // 
            tx3.Location = new Point(81, 164);
            tx3.Name = "tx3";
            tx3.Size = new Size(100, 23);
            tx3.TabIndex = 2;
            // 
            // tx4
            // 
            tx4.Location = new Point(81, 214);
            tx4.Name = "tx4";
            tx4.Size = new Size(100, 23);
            tx4.TabIndex = 3;
            // 
            // tx5
            // 
            tx5.Location = new Point(81, 264);
            tx5.Name = "tx5";
            tx5.Size = new Size(100, 23);
            tx5.TabIndex = 4;
            // 
            // tx6
            // 
            tx6.Location = new Point(221, 55);
            tx6.Name = "tx6";
            tx6.Size = new Size(100, 23);
            tx6.TabIndex = 5;
            // 
            // tx7
            // 
            tx7.Location = new Point(221, 108);
            tx7.Name = "tx7";
            tx7.Size = new Size(100, 23);
            tx7.TabIndex = 6;
            // 
            // tx8
            // 
            tx8.Location = new Point(221, 164);
            tx8.Name = "tx8";
            tx8.Size = new Size(100, 23);
            tx8.TabIndex = 7;
            // 
            // tx9
            // 
            tx9.Location = new Point(221, 214);
            tx9.Name = "tx9";
            tx9.Size = new Size(100, 23);
            tx9.TabIndex = 8;
            // 
            // tx10
            // 
            tx10.Location = new Point(221, 264);
            tx10.Name = "tx10";
            tx10.Size = new Size(100, 23);
            tx10.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(156, 322);
            button1.Name = "button1";
            button1.Size = new Size(86, 39);
            button1.TabIndex = 10;
            button1.Text = "Avaliar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lb_resultado
            // 
            lb_resultado.AutoSize = true;
            lb_resultado.Location = new Point(283, 322);
            lb_resultado.Name = "lb_resultado";
            lb_resultado.Size = new Size(38, 15);
            lb_resultado.TabIndex = 11;
            lb_resultado.Text = "label1";
            // 
            // Gabarito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 390);
            Controls.Add(lb_resultado);
            Controls.Add(button1);
            Controls.Add(tx10);
            Controls.Add(tx9);
            Controls.Add(tx8);
            Controls.Add(tx7);
            Controls.Add(tx6);
            Controls.Add(tx5);
            Controls.Add(tx4);
            Controls.Add(tx3);
            Controls.Add(tx2);
            Controls.Add(tx1);
            Name = "Gabarito";
            Text = "Gabarito";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tx_1;
        private TextBox tx_2;
        private TextBox tx_3;
        private TextBox tx_4;
        private TextBox tx_5;
        private TextBox tx_6;
        private TextBox tx_7;
        private TextBox tx_8;
        private TextBox tx_9;
        private TextBox tx_10;
        private Button button1;
        private Label lb_resultado;
        private TextBox tx1;
        private TextBox tx2;
        private TextBox tx3;
        private TextBox tx4;
        private TextBox tx5;
        private TextBox tx6;
        private TextBox tx7;
        private TextBox tx8;
        private TextBox tx9;
        private TextBox tx10;
    }
}