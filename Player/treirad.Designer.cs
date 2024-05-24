namespace Player
{
    partial class treirad
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
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            ruta9 = new Button();
            ruta8 = new Button();
            ruta7 = new Button();
            ruta6 = new Button();
            ruta5 = new Button();
            ruta4 = new Button();
            ruta3 = new Button();
            ruta2 = new Button();
            ruta1 = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(408, 70);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Det är X tur";
            label1.Click += label1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(ruta9, 2, 2);
            tableLayoutPanel1.Controls.Add(ruta8, 1, 2);
            tableLayoutPanel1.Controls.Add(ruta7, 0, 2);
            tableLayoutPanel1.Controls.Add(ruta6, 2, 1);
            tableLayoutPanel1.Controls.Add(ruta5, 1, 1);
            tableLayoutPanel1.Controls.Add(ruta4, 0, 1);
            tableLayoutPanel1.Controls.Add(ruta3, 2, 0);
            tableLayoutPanel1.Controls.Add(ruta2, 1, 0);
            tableLayoutPanel1.Controls.Add(ruta1, 0, 0);
            tableLayoutPanel1.Location = new Point(345, 152);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(200, 200);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // ruta9
            // 
            ruta9.Location = new Point(135, 135);
            ruta9.Name = "ruta9";
            ruta9.Size = new Size(60, 60);
            ruta9.TabIndex = 4;
            ruta9.UseVisualStyleBackColor = true;
            ruta9.Click += ruta9_Click;
            // 
            // ruta8
            // 
            ruta8.Location = new Point(69, 135);
            ruta8.Name = "ruta8";
            ruta8.Size = new Size(60, 60);
            ruta8.TabIndex = 3;
            ruta8.UseVisualStyleBackColor = true;
            ruta8.Click += ruta8_Click;
            // 
            // ruta7
            // 
            ruta7.Location = new Point(3, 135);
            ruta7.Name = "ruta7";
            ruta7.Size = new Size(60, 60);
            ruta7.TabIndex = 3;
            ruta7.UseVisualStyleBackColor = true;
            ruta7.Click += ruta7_Click;
            // 
            // ruta6
            // 
            ruta6.Location = new Point(135, 69);
            ruta6.Name = "ruta6";
            ruta6.Size = new Size(60, 60);
            ruta6.TabIndex = 3;
            ruta6.UseVisualStyleBackColor = true;
            ruta6.Click += ruta6_Click;
            // 
            // ruta5
            // 
            ruta5.Location = new Point(69, 69);
            ruta5.Name = "ruta5";
            ruta5.Size = new Size(60, 60);
            ruta5.TabIndex = 3;
            ruta5.UseVisualStyleBackColor = true;
            ruta5.Click += ruta5_Click;
            // 
            // ruta4
            // 
            ruta4.Location = new Point(3, 69);
            ruta4.Name = "ruta4";
            ruta4.Size = new Size(60, 60);
            ruta4.TabIndex = 3;
            ruta4.UseVisualStyleBackColor = true;
            ruta4.Click += ruta4_Click;
            // 
            // ruta3
            // 
            ruta3.Location = new Point(135, 3);
            ruta3.Name = "ruta3";
            ruta3.Size = new Size(60, 60);
            ruta3.TabIndex = 2;
            ruta3.UseVisualStyleBackColor = true;
            ruta3.Click += ruta3_Click;
            // 
            // ruta2
            // 
            ruta2.Location = new Point(69, 3);
            ruta2.Name = "ruta2";
            ruta2.Size = new Size(60, 60);
            ruta2.TabIndex = 1;
            ruta2.UseVisualStyleBackColor = true;
            ruta2.Click += ruta2_Click;
            // 
            // ruta1
            // 
            ruta1.Location = new Point(3, 3);
            ruta1.Name = "ruta1";
            ruta1.Size = new Size(60, 60);
            ruta1.TabIndex = 0;
            ruta1.UseVisualStyleBackColor = true;
            ruta1.Click += ruta1_Click;
            // 
            // treirad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Name = "treirad";
            Text = "treirad";
            Load += treirad_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button ruta7;
        private Button ruta6;
        private Button ruta5;
        private Button ruta4;
        private Button ruta3;
        private Button ruta2;
        private Button ruta1;
        private Button ruta8;
        private Button ruta9;
    }
}