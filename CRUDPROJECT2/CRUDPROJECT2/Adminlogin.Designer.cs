namespace CRUDPROJECT2
{
    partial class Adminlogin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adminlogin));
            label2 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Lucida Calligraphy", 35F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(259, 508);
            label2.Name = "label2";
            label2.Size = new Size(421, 91);
            label2.TabIndex = 60;
            label2.Text = "Dynamics";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(1715, 645);
            button1.Name = "button1";
            button1.Size = new Size(99, 32);
            button1.TabIndex = 59;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 11F);
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(1370, 566);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(416, 30);
            textBox2.TabIndex = 58;
            textBox2.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 11F);
            textBox1.Location = new Point(1370, 441);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(416, 30);
            textBox1.TabIndex = 57;
            textBox1.Tag = "Employee ID";
            textBox1.Text = "Admin ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lucida Calligraphy", 35F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(213, 437);
            label1.Name = "label1";
            label1.Size = new Size(420, 91);
            label1.TabIndex = 56;
            label1.Text = "AeroTech ";
            // 
            // Adminlogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Adminlogin";
            Size = new Size(1920, 1080);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
    }
}
