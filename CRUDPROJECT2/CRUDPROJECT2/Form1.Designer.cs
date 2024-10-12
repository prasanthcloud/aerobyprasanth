namespace CRUDPROJECT2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button2 = new Button();
            button1 = new Button();
            button5 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 20;
            button2.Font = new Font("Tahoma", 11F);
            button2.Location = new Point(1471, 665);
            button2.Name = "button2";
            button2.Size = new Size(159, 54);
            button2.TabIndex = 155;
            button2.Text = "EMPLOYEE";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 20;
            button1.Font = new Font("Tahoma", 11F);
            button1.Location = new Point(1471, 545);
            button1.Name = "button1";
            button1.Size = new Size(159, 54);
            button1.TabIndex = 154;
            button1.Text = "MANAGER";
            button1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 20;
            button5.Font = new Font("Tahoma", 11F);
            button5.Location = new Point(1471, 419);
            button5.Name = "button5";
            button5.Size = new Size(159, 54);
            button5.TabIndex = 153;
            button5.Text = "ADMIN";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Tahoma", 15F);
            label3.Location = new Point(1195, 306);
            label3.Name = "label3";
            label3.Size = new Size(467, 36);
            label3.TabIndex = 152;
            label3.Text = "Choose the below role to continue";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Lucida Calligraphy", 35F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(282, 508);
            label2.Name = "label2";
            label2.Size = new Size(421, 91);
            label2.TabIndex = 151;
            label2.Text = "Dynamics";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lucida Calligraphy", 35F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(236, 437);
            label1.Name = "label1";
            label1.Size = new Size(420, 91);
            label1.TabIndex = 150;
            label1.Text = "AeroTech ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1898, 1024);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Admin portal";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Button button5;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
