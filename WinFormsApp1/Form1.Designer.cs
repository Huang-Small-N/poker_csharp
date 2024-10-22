namespace WinFormsApp1
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            start = new Button();
            stop = new Button();
            imageList1 = new ImageList(components);
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(61, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 96);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(206, 81);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(71, 96);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 81);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 2;
            label1.Text = "電腦:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(158, 81);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 3;
            label2.Text = "玩家:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 180);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 4;
            label3.Text = "label3";
            // 
            // start
            // 
            start.Location = new Point(61, 232);
            start.Name = "start";
            start.Size = new Size(71, 32);
            start.TabIndex = 5;
            start.Text = "start";
            start.UseVisualStyleBackColor = true;
            start.Click += start_Click;
            // 
            // stop
            // 
            stop.Location = new Point(206, 232);
            stop.Name = "stop";
            stop.Size = new Size(71, 32);
            stop.TabIndex = 6;
            stop.Text = "stop";
            stop.UseVisualStyleBackColor = true;
            stop.Click += stop_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "poker1.jpg");
            imageList1.Images.SetKeyName(1, "poker2.jpg");
            imageList1.Images.SetKeyName(2, "poker3.jpg");
            imageList1.Images.SetKeyName(3, "poker4.jpg");
            imageList1.Images.SetKeyName(4, "poker5.jpg");
            imageList1.Images.SetKeyName(5, "poker6.jpg");
            imageList1.Images.SetKeyName(6, "poker7.jpg");
            imageList1.Images.SetKeyName(7, "poker8.jpg");
            imageList1.Images.SetKeyName(8, "poker9.jpg");
            imageList1.Images.SetKeyName(9, "poker10.jpg");
            imageList1.Images.SetKeyName(10, "poker11.jpg");
            imageList1.Images.SetKeyName(11, "poker12.jpg");
            imageList1.Images.SetKeyName(12, "poker13.jpg");
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 326);
            Controls.Add(stop);
            Controls.Add(start);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button start;
        private Button stop;
        private ImageList imageList1;
        private System.Windows.Forms.Timer timer1;
    }
}