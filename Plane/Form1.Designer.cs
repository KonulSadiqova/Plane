namespace Plane
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBoxLight = new PictureBox();
            pictureBoxPlane = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            btnKemarlar = new Button();
            btnTesekkurler = new Button();
            btnBeep = new Button();
            btnGas = new Button();
            btnBreak = new Button();
            onOffButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlane).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(pictureBoxLight);
            panel1.Controls.Add(pictureBoxPlane);
            panel1.Location = new Point(2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(321, 435);
            panel1.TabIndex = 0;
            // 
            // pictureBoxLight
            // 
            pictureBoxLight.Image = (Image)resources.GetObject("pictureBoxLight.Image");
            pictureBoxLight.Location = new Point(129, 278);
            pictureBoxLight.Name = "pictureBoxLight";
            pictureBoxLight.Size = new Size(32, 19);
            pictureBoxLight.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLight.TabIndex = 1;
            pictureBoxLight.TabStop = false;
            // 
            // pictureBoxPlane
            // 
            pictureBoxPlane.Image = (Image)resources.GetObject("pictureBoxPlane.Image");
            pictureBoxPlane.Location = new Point(98, 278);
            pictureBoxPlane.Name = "pictureBoxPlane";
            pictureBoxPlane.Size = new Size(94, 154);
            pictureBoxPlane.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPlane.TabIndex = 0;
            pictureBoxPlane.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.PaleTurquoise;
            button1.Location = new Point(355, 12);
            button1.Name = "button1";
            button1.Size = new Size(433, 43);
            button1.TabIndex = 1;
            button1.Text = "btnEnisHazirligi";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleTurquoise;
            button2.Location = new Point(355, 74);
            button2.Name = "button2";
            button2.Size = new Size(433, 43);
            button2.TabIndex = 2;
            button2.Text = "btnTurbulans";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnKemarlar
            // 
            btnKemarlar.BackColor = Color.PaleTurquoise;
            btnKemarlar.Location = new Point(355, 142);
            btnKemarlar.Name = "btnKemarlar";
            btnKemarlar.Size = new Size(433, 43);
            btnKemarlar.TabIndex = 3;
            btnKemarlar.Text = "Kəmərlər";
            btnKemarlar.UseVisualStyleBackColor = false;
            // 
            // btnTesekkurler
            // 
            btnTesekkurler.BackColor = Color.PaleTurquoise;
            btnTesekkurler.Location = new Point(355, 212);
            btnTesekkurler.Name = "btnTesekkurler";
            btnTesekkurler.Size = new Size(433, 43);
            btnTesekkurler.TabIndex = 4;
            btnTesekkurler.Text = "Təşəkkürlər";
            btnTesekkurler.UseVisualStyleBackColor = false;
            // 
            // btnBeep
            // 
            btnBeep.BackColor = Color.PaleTurquoise;
            btnBeep.Location = new Point(355, 281);
            btnBeep.Name = "btnBeep";
            btnBeep.Size = new Size(433, 43);
            btnBeep.TabIndex = 5;
            btnBeep.Text = "Beep";
            btnBeep.UseVisualStyleBackColor = false;
            // 
            // btnGas
            // 
            btnGas.BackColor = Color.MediumSeaGreen;
            btnGas.Location = new Point(407, 330);
            btnGas.Name = "btnGas";
            btnGas.Size = new Size(124, 60);
            btnGas.TabIndex = 6;
            btnGas.Text = "Gas";
            btnGas.UseVisualStyleBackColor = false;
            // 
            // btnBreak
            // 
            btnBreak.BackColor = Color.Crimson;
            btnBreak.Location = new Point(617, 330);
            btnBreak.Name = "btnBreak";
            btnBreak.Size = new Size(124, 60);
            btnBreak.TabIndex = 7;
            btnBreak.Text = "Break";
            btnBreak.UseVisualStyleBackColor = false;
            // 
            // onOffButton
            // 
            onOffButton.BackColor = SystemColors.Highlight;
            onOffButton.Location = new Point(355, 396);
            onOffButton.Name = "onOffButton";
            onOffButton.Size = new Size(433, 43);
            onOffButton.TabIndex = 8;
            onOffButton.Text = "On/Off";
            onOffButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(onOffButton);
            Controls.Add(btnBreak);
            Controls.Add(btnGas);
            Controls.Add(btnBeep);
            Controls.Add(btnTesekkurler);
            Controls.Add(btnKemarlar);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Plane";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLight).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlane).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBoxPlane;
        private Button button1;
        private Button button2;
        private Button btnKemarlar;
        private Button btnTesekkurler;
        private Button btnBeep;
        private Button btnGas;
        private Button btnBreak;
        private Button onOffButton;
        private PictureBox pictureBoxLight;
        private System.Windows.Forms.Timer timer1;
    }
}
