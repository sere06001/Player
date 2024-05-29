namespace Player
{
    partial class Välj_spel
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
            väljspellabel = new Label();
            treiradbtn = new Button();
            snakebtn = new Button();
            SuspendLayout();
            // 
            // väljspellabel
            // 
            väljspellabel.AutoSize = true;
            väljspellabel.Location = new Point(398, 94);
            väljspellabel.Name = "väljspellabel";
            väljspellabel.Size = new Size(49, 15);
            väljspellabel.TabIndex = 0;
            väljspellabel.Text = "Välj spel";
            // 
            // treiradbtn
            // 
            treiradbtn.Location = new Point(379, 137);
            treiradbtn.Name = "treiradbtn";
            treiradbtn.Size = new Size(87, 23);
            treiradbtn.TabIndex = 1;
            treiradbtn.Text = "Tre i rad";
            treiradbtn.UseVisualStyleBackColor = true;
            treiradbtn.Click += treiradbtn_Click;
            // 
            // snakebtn
            // 
            snakebtn.AutoSize = true;
            snakebtn.Location = new Point(379, 180);
            snakebtn.Name = "snakebtn";
            snakebtn.Size = new Size(87, 25);
            snakebtn.TabIndex = 2;
            snakebtn.Text = "Snake";
            snakebtn.UseVisualStyleBackColor = true;
            snakebtn.Click += minesweeperbtn_Click;
            // 
            // Välj_spel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(snakebtn);
            Controls.Add(treiradbtn);
            Controls.Add(väljspellabel);
            Name = "Välj_spel";
            Text = "Välj Spel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label väljspellabel;
        private Button treiradbtn;
        private Button snakebtn;
    }
}