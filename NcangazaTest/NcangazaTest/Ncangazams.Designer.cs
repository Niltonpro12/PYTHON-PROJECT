namespace NcangazaTest
{
    partial class Ncangazams
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ncangazams));
            pictureBox1 = new PictureBox();
            bem_vindo = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            labelLogin = new Label();
            comboBox1 = new ComboBox();
            buttonEntrar = new Button();
            buttonSair = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(111, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(380, 222);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // bem_vindo
            // 
            bem_vindo.AutoSize = true;
            bem_vindo.Font = new Font("Segoe UI Emoji", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bem_vindo.Location = new Point(178, 237);
            bem_vindo.Name = "bem_vindo";
            bem_vindo.Size = new Size(248, 37);
            bem_vindo.TabIndex = 1;
            bem_vindo.Text = "SEJA BEM-VINDO";
            bem_vindo.Click += bem_vindo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(92, 382);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 3;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(92, 429);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 4;
            label2.Text = "Função";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(93, 481);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 5;
            label3.Text = "Senha";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.MenuText;
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(160, 379);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(317, 31);
            textBox1.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.MenuText;
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(159, 475);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(317, 31);
            textBox3.TabIndex = 8;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.ForeColor = Color.Red;
            labelLogin.Location = new Point(257, 320);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(95, 25);
            labelLogin.TabIndex = 9;
            labelLogin.Text = "Faça Login";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.MenuText;
            comboBox1.ForeColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(160, 426);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(316, 33);
            comboBox1.TabIndex = 10;
            // 
            // buttonEntrar
            // 
            buttonEntrar.BackColor = Color.Red;
            buttonEntrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEntrar.Location = new Point(108, 545);
            buttonEntrar.Name = "buttonEntrar";
            buttonEntrar.Size = new Size(141, 55);
            buttonEntrar.TabIndex = 11;
            buttonEntrar.Text = "Entrar";
            buttonEntrar.UseVisualStyleBackColor = false;
    
            // 
            // buttonSair
            // 
            buttonSair.BackColor = Color.Red;
            buttonSair.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSair.Location = new Point(336, 545);
            buttonSair.Name = "buttonSair";
            buttonSair.Size = new Size(141, 55);
            buttonSair.TabIndex = 12;
            buttonSair.Text = "Sair";
            buttonSair.UseVisualStyleBackColor = false;
            // 
            // Ncangazams
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(662, 641);
            Controls.Add(buttonSair);
            Controls.Add(buttonEntrar);
            Controls.Add(comboBox1);
            Controls.Add(labelLogin);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bem_vindo);
            Controls.Add(pictureBox1);
            Name = "Ncangazams";
            Text = "Form1";
            Load += Ncangazams_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label bem_vindo;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox3;
        private Label labelLogin;
        private ComboBox comboBox1;
        private Button buttonEntrar;
        private Button buttonSair;
    }
}
