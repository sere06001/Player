namespace Player
{
    partial class Snake
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            printDialog1 = new PrintDialog();
            lblScore = new Label();
            medbtn = new Button();
            smallbtn = new Button();
            hardbtn = new Button();
            tillbakabtn = new Button();
            SuspendLayout();
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(368, 53);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(63, 15);
            lblScore.TabIndex = 0;
            lblScore.Text = "Välj storlek";
            // 
            // medbtn
            // 
            medbtn.AutoSize = true;
            medbtn.Location = new Point(348, 118);
            medbtn.Name = "medbtn";
            medbtn.Size = new Size(103, 25);
            medbtn.TabIndex = 1;
            medbtn.Text = "Medium (15x15)";
            medbtn.UseVisualStyleBackColor = true;
            medbtn.Click += medbtn_Click_1;
            // 
            // smallbtn
            // 
            smallbtn.AutoSize = true;
            smallbtn.Location = new Point(348, 87);
            smallbtn.Name = "smallbtn";
            smallbtn.Size = new Size(103, 25);
            smallbtn.TabIndex = 2;
            smallbtn.Text = "Liten (10x10)";
            smallbtn.UseVisualStyleBackColor = true;
            smallbtn.Click += smallbtn_Click_1;
            // 
            // hardbtn
            // 
            hardbtn.AutoSize = true;
            hardbtn.Location = new Point(348, 149);
            hardbtn.Name = "hardbtn";
            hardbtn.Size = new Size(103, 25);
            hardbtn.TabIndex = 3;
            hardbtn.Text = "Svår (20x20)";
            hardbtn.UseVisualStyleBackColor = true;
            hardbtn.Click += hardbtn_Click;
            // 
            // tillbakabtn
            // 
            tillbakabtn.Location = new Point(189, 53);
            tillbakabtn.Name = "tillbakabtn";
            tillbakabtn.Size = new Size(75, 23);
            tillbakabtn.TabIndex = 4;
            tillbakabtn.Text = "Tillbaka";
            tillbakabtn.UseVisualStyleBackColor = true;
            tillbakabtn.Click += tillbakabtn_Click_1;
            // 
            // Snake
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tillbakabtn);
            Controls.Add(hardbtn);
            Controls.Add(smallbtn);
            Controls.Add(medbtn);
            Controls.Add(lblScore);
            Name = "Snake";
            Text = "Snake";
            Load += Snake_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private PrintDialog printDialog1;
        private Label lblScore;
        private Button medbtn;
        private Button smallbtn;
        private Button hardbtn;
        private Button tillbakabtn;
    }
}