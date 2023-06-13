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
            tx_1 = new TextBox();
            tx_2 = new TextBox();
            tx_3 = new TextBox();
            tx_4 = new TextBox();
            tx_5 = new TextBox();
            tx_6 = new TextBox();
            tx_7 = new TextBox();
            tx_8 = new TextBox();
            tx_9 = new TextBox();
            tx_10 = new TextBox();
            button1 = new Button();
            lb_resultado = new Label();
            SuspendLayout();
            // 
            // tx_1
            // 
            tx_1.Location = new Point(81, 55);
            tx_1.Name = "tx_1";
            tx_1.Size = new Size(100, 23);
            tx_1.TabIndex = 0;
            // 
            // tx_2
            // 
            tx_2.Location = new Point(81, 108);
            tx_2.Name = "tx_2";
            tx_2.Size = new Size(100, 23);
            tx_2.TabIndex = 1;
            // 
            // tx_3
            // 
            tx_3.Location = new Point(81, 164);
            tx_3.Name = "tx_3";
            tx_3.Size = new Size(100, 23);
            tx_3.TabIndex = 2;
            // 
            // tx_4
            // 
            tx_4.Location = new Point(81, 214);
            tx_4.Name = "tx_4";
            tx_4.Size = new Size(100, 23);
            tx_4.TabIndex = 3;
            // 
            // tx_5
            // 
            tx_5.Location = new Point(81, 264);
            tx_5.Name = "tx_5";
            tx_5.Size = new Size(100, 23);
            tx_5.TabIndex = 4;
            // 
            // tx_6
            // 
            tx_6.Location = new Point(221, 55);
            tx_6.Name = "tx_6";
            tx_6.Size = new Size(100, 23);
            tx_6.TabIndex = 5;
            // 
            // tx_7
            // 
            tx_7.Location = new Point(221, 108);
            tx_7.Name = "tx_7";
            tx_7.Size = new Size(100, 23);
            tx_7.TabIndex = 6;
            // 
            // tx_8
            // 
            tx_8.Location = new Point(221, 164);
            tx_8.Name = "tx_8";
            tx_8.Size = new Size(100, 23);
            tx_8.TabIndex = 7;
            // 
            // tx_9
            // 
            tx_9.Location = new Point(221, 214);
            tx_9.Name = "tx_9";
            tx_9.Size = new Size(100, 23);
            tx_9.TabIndex = 8;
            // 
            // tx_10
            // 
            tx_10.Location = new Point(221, 264);
            tx_10.Name = "tx_10";
            tx_10.Size = new Size(100, 23);
            tx_10.TabIndex = 9;
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
            Controls.Add(tx_10);
            Controls.Add(tx_9);
            Controls.Add(tx_8);
            Controls.Add(tx_7);
            Controls.Add(tx_6);
            Controls.Add(tx_5);
            Controls.Add(tx_4);
            Controls.Add(tx_3);
            Controls.Add(tx_2);
            Controls.Add(tx_1);
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
    }
}