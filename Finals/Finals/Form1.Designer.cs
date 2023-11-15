namespace Finals
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
            menuButtom = new PictureBox();
            sidebar = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel2 = new Panel();
            button1 = new Button();
            panel3 = new Panel();
            button2 = new Button();
            panel4 = new Panel();
            button3 = new Button();
            panel5 = new Panel();
            button4 = new Button();
            panel6 = new Panel();
            button5 = new Button();
            sidebarTransition = new System.Windows.Forms.Timer(components);
            menuTransition = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuButtom).BeginInit();
            sidebar.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(menuButtom);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1324, 51);
            panel1.TabIndex = 0;
            // 
            // menuButtom
            // 
            menuButtom.BackColor = Color.WhiteSmoke;
            menuButtom.Image = Properties.Resources.menu_button1;
            menuButtom.Location = new Point(39, 12);
            menuButtom.Name = "menuButtom";
            menuButtom.Size = new Size(65, 32);
            menuButtom.SizeMode = PictureBoxSizeMode.StretchImage;
            menuButtom.TabIndex = 0;
            menuButtom.TabStop = false;
            menuButtom.Click += pictureBox1_Click_1;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.Black;
            sidebar.Controls.Add(flowLayoutPanel2);
            sidebar.Controls.Add(panel5);
            sidebar.Controls.Add(panel6);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 51);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(270, 661);
            sidebar.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.Black;
            flowLayoutPanel2.Controls.Add(panel2);
            flowLayoutPanel2.Controls.Add(panel3);
            flowLayoutPanel2.Controls.Add(panel4);
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(223, 241);
            flowLayoutPanel2.TabIndex = 3;
            flowLayoutPanel2.Paint += flowLayoutPanel2_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(button1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(180, 62);
            panel2.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(16, 13);
            button1.Name = "button1";
            button1.Size = new Size(125, 36);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Controls.Add(button2);
            panel3.Location = new Point(3, 71);
            panel3.Name = "panel3";
            panel3.Size = new Size(160, 71);
            panel3.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(18, 16);
            button2.Name = "button2";
            button2.Size = new Size(106, 33);
            button2.TabIndex = 0;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Controls.Add(button3);
            panel4.Location = new Point(3, 148);
            panel4.Name = "panel4";
            panel4.Size = new Size(183, 74);
            panel4.TabIndex = 4;
            // 
            // button3
            // 
            button3.Location = new Point(18, 20);
            button3.Name = "button3";
            button3.Size = new Size(123, 34);
            button3.TabIndex = 0;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Controls.Add(button4);
            panel5.Location = new Point(3, 250);
            panel5.Name = "panel5";
            panel5.Size = new Size(234, 74);
            panel5.TabIndex = 5;
            // 
            // button4
            // 
            button4.Location = new Point(75, 19);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 0;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Controls.Add(button5);
            panel6.Location = new Point(3, 330);
            panel6.Name = "panel6";
            panel6.Size = new Size(234, 75);
            panel6.TabIndex = 5;
            // 
            // button5
            // 
            button5.Location = new Point(75, 19);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 0;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // menuTransition
            // 
            menuTransition.Interval = 10;
            menuTransition.Tick += menuTransition_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1324, 712);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)menuButtom).EndInit();
            sidebar.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox menuButtom;
        private FlowLayoutPanel sidebar;
        private Panel panel3;
        private Button button2;
        private Panel panel4;
        private Button button3;
        private Panel panel5;
        private Button button4;
        private Panel panel6;
        private Button button5;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Timer menuTransition;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button button1;
        private Panel panel2;
    }
}