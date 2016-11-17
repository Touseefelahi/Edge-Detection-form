namespace WindowsFormsApplication1
{
    partial class Edge_detection
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
            this.components = new System.ComponentModel.Container();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.bt_start = new System.Windows.Forms.Button();
            this.bt_edges = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.borderPanel1 = new Microsoft.TeamFoundation.Client.BorderPanel();
            this.trackBar_th1 = new System.Windows.Forms.TrackBar();
            this.trackBar_th2 = new System.Windows.Forms.TrackBar();
            this.trackBar_blur = new System.Windows.Forms.TrackBar();
            this.trackBar_blurx = new System.Windows.Forms.TrackBar();
            this.trackBar_can_apsize = new System.Windows.Forms.TrackBar();
            this.trackBar_blury = new System.Windows.Forms.TrackBar();
            this.label_th0 = new System.Windows.Forms.Label();
            this.label_th1 = new System.Windows.Forms.Label();
            this.label_can_apsize = new System.Windows.Forms.Label();
            this.label_blur = new System.Windows.Forms.Label();
            this.label_blurx = new System.Windows.Forms.Label();
            this.label_blury = new System.Windows.Forms.Label();
            this.textBox_thlower = new System.Windows.Forms.TextBox();
            this.textBox_thhigher = new System.Windows.Forms.TextBox();
            this.textBox_canny_app = new System.Windows.Forms.TextBox();
            this.textBox_blursize = new System.Windows.Forms.TextBox();
            this.textBox_blurx = new System.Windows.Forms.TextBox();
            this.textBox_blury = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.borderPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_th1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_th2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_blur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_blurx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_can_apsize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_blury)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox1
            // 
            this.imageBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.imageBox1.Location = new System.Drawing.Point(2, 2);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(640, 480);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // bt_start
            // 
            this.bt_start.Location = new System.Drawing.Point(5, 496);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(75, 70);
            this.bt_start.TabIndex = 3;
            this.bt_start.Text = "Start";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // bt_edges
            // 
            this.bt_edges.Location = new System.Drawing.Point(5, 572);
            this.bt_edges.Name = "bt_edges";
            this.bt_edges.Size = new System.Drawing.Size(75, 70);
            this.bt_edges.TabIndex = 4;
            this.bt_edges.Text = "Edges on";
            this.bt_edges.UseVisualStyleBackColor = true;
            this.bt_edges.Click += new System.EventHandler(this.bt_edges_Click);
            // 
            // borderPanel1
            // 
            this.borderPanel1.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.borderPanel1.BorderPadding = new System.Windows.Forms.Padding(0);
            this.borderPanel1.BorderSides = ((Microsoft.TeamFoundation.Client.BorderPanel.Sides)((((Microsoft.TeamFoundation.Client.BorderPanel.Sides.Top | Microsoft.TeamFoundation.Client.BorderPanel.Sides.Bottom) 
            | Microsoft.TeamFoundation.Client.BorderPanel.Sides.Left) 
            | Microsoft.TeamFoundation.Client.BorderPanel.Sides.Right)));
            this.borderPanel1.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.borderPanel1.Controls.Add(this.imageBox1);
            this.borderPanel1.InnerColor = System.Drawing.SystemColors.Control;
            this.borderPanel1.Location = new System.Drawing.Point(3, 3);
            this.borderPanel1.Name = "borderPanel1";
            this.borderPanel1.Size = new System.Drawing.Size(644, 484);
            this.borderPanel1.TabIndex = 5;
            this.borderPanel1.UseInnerColor = false;
            // 
            // trackBar_th1
            // 
            this.trackBar_th1.Location = new System.Drawing.Point(175, 491);
            this.trackBar_th1.Name = "trackBar_th1";
            this.trackBar_th1.Size = new System.Drawing.Size(423, 45);
            this.trackBar_th1.TabIndex = 6;
            this.trackBar_th1.Scroll += new System.EventHandler(this.trackBar_th1_Scroll);
            // 
            // trackBar_th2
            // 
            this.trackBar_th2.Location = new System.Drawing.Point(175, 518);
            this.trackBar_th2.Name = "trackBar_th2";
            this.trackBar_th2.Size = new System.Drawing.Size(423, 45);
            this.trackBar_th2.TabIndex = 7;
            this.trackBar_th2.Scroll += new System.EventHandler(this.trackBar_th2_Scroll);
            // 
            // trackBar_blur
            // 
            this.trackBar_blur.Location = new System.Drawing.Point(175, 574);
            this.trackBar_blur.Name = "trackBar_blur";
            this.trackBar_blur.Size = new System.Drawing.Size(423, 45);
            this.trackBar_blur.TabIndex = 8;
            this.trackBar_blur.Scroll += new System.EventHandler(this.trackBar_blur_Scroll);
            // 
            // trackBar_blurx
            // 
            this.trackBar_blurx.Location = new System.Drawing.Point(175, 602);
            this.trackBar_blurx.Maximum = 20;
            this.trackBar_blurx.Name = "trackBar_blurx";
            this.trackBar_blurx.Size = new System.Drawing.Size(423, 45);
            this.trackBar_blurx.TabIndex = 9;
            this.trackBar_blurx.Scroll += new System.EventHandler(this.trackBar_blurx_Scroll);
            // 
            // trackBar_can_apsize
            // 
            this.trackBar_can_apsize.Location = new System.Drawing.Point(175, 546);
            this.trackBar_can_apsize.Maximum = 4;
            this.trackBar_can_apsize.Minimum = 3;
            this.trackBar_can_apsize.Name = "trackBar_can_apsize";
            this.trackBar_can_apsize.Size = new System.Drawing.Size(423, 45);
            this.trackBar_can_apsize.SmallChange = 2;
            this.trackBar_can_apsize.TabIndex = 15;
            this.trackBar_can_apsize.Value = 3;
            this.trackBar_can_apsize.Scroll += new System.EventHandler(this.trackBar_can_apsize_Scroll);
            // 
            // trackBar_blury
            // 
            this.trackBar_blury.Location = new System.Drawing.Point(175, 629);
            this.trackBar_blury.Maximum = 20;
            this.trackBar_blury.Name = "trackBar_blury";
            this.trackBar_blury.Size = new System.Drawing.Size(423, 45);
            this.trackBar_blury.TabIndex = 11;
            this.trackBar_blury.Scroll += new System.EventHandler(this.trackBar_blury_Scroll);
            // 
            // label_th0
            // 
            this.label_th0.AutoSize = true;
            this.label_th0.Location = new System.Drawing.Point(89, 495);
            this.label_th0.Name = "label_th0";
            this.label_th0.Size = new System.Drawing.Size(91, 13);
            this.label_th0.TabIndex = 12;
            this.label_th0.Text = "Threshhold_lower";
            // 
            // label_th1
            // 
            this.label_th1.AutoSize = true;
            this.label_th1.Location = new System.Drawing.Point(89, 522);
            this.label_th1.Name = "label_th1";
            this.label_th1.Size = new System.Drawing.Size(89, 13);
            this.label_th1.TabIndex = 13;
            this.label_th1.Text = "Threshold_higher";
            // 
            // label_can_apsize
            // 
            this.label_can_apsize.AutoSize = true;
            this.label_can_apsize.Location = new System.Drawing.Point(89, 550);
            this.label_can_apsize.Name = "label_can_apsize";
            this.label_can_apsize.Size = new System.Drawing.Size(88, 13);
            this.label_can_apsize.TabIndex = 14;
            this.label_can_apsize.Text = "Canny Appr. Size";
            // 
            // label_blur
            // 
            this.label_blur.AutoSize = true;
            this.label_blur.Location = new System.Drawing.Point(129, 578);
            this.label_blur.Name = "label_blur";
            this.label_blur.Size = new System.Drawing.Size(48, 13);
            this.label_blur.TabIndex = 15;
            this.label_blur.Text = "Blur Size";
            // 
            // label_blurx
            // 
            this.label_blurx.AutoSize = true;
            this.label_blurx.Location = new System.Drawing.Point(139, 606);
            this.label_blurx.Name = "label_blurx";
            this.label_blurx.Size = new System.Drawing.Size(35, 13);
            this.label_blurx.TabIndex = 16;
            this.label_blurx.Text = "Blur X";
            // 
            // label_blury
            // 
            this.label_blury.AutoSize = true;
            this.label_blury.Location = new System.Drawing.Point(139, 632);
            this.label_blury.Name = "label_blury";
            this.label_blury.Size = new System.Drawing.Size(35, 13);
            this.label_blury.TabIndex = 17;
            this.label_blury.Text = "Blur Y";
            // 
            // textBox_thlower
            // 
            this.textBox_thlower.Location = new System.Drawing.Point(604, 491);
            this.textBox_thlower.Name = "textBox_thlower";
            this.textBox_thlower.Size = new System.Drawing.Size(36, 20);
            this.textBox_thlower.TabIndex = 18;
            // 
            // textBox_thhigher
            // 
            this.textBox_thhigher.Location = new System.Drawing.Point(604, 522);
            this.textBox_thhigher.Name = "textBox_thhigher";
            this.textBox_thhigher.Size = new System.Drawing.Size(36, 20);
            this.textBox_thhigher.TabIndex = 19;
            // 
            // textBox_canny_app
            // 
            this.textBox_canny_app.Location = new System.Drawing.Point(604, 550);
            this.textBox_canny_app.Name = "textBox_canny_app";
            this.textBox_canny_app.Size = new System.Drawing.Size(36, 20);
            this.textBox_canny_app.TabIndex = 20;
            // 
            // textBox_blursize
            // 
            this.textBox_blursize.Location = new System.Drawing.Point(604, 578);
            this.textBox_blursize.Name = "textBox_blursize";
            this.textBox_blursize.Size = new System.Drawing.Size(36, 20);
            this.textBox_blursize.TabIndex = 21;
            // 
            // textBox_blurx
            // 
            this.textBox_blurx.Location = new System.Drawing.Point(604, 604);
            this.textBox_blurx.Name = "textBox_blurx";
            this.textBox_blurx.Size = new System.Drawing.Size(36, 20);
            this.textBox_blurx.TabIndex = 22;
            // 
            // textBox_blury
            // 
            this.textBox_blury.Location = new System.Drawing.Point(604, 630);
            this.textBox_blury.Name = "textBox_blury";
            this.textBox_blury.Size = new System.Drawing.Size(36, 20);
            this.textBox_blury.TabIndex = 23;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(8, 645);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 25;
            this.checkBox1.Text = "Gray Image";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Edge_detection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 663);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox_blury);
            this.Controls.Add(this.textBox_blurx);
            this.Controls.Add(this.textBox_blursize);
            this.Controls.Add(this.textBox_canny_app);
            this.Controls.Add(this.textBox_thhigher);
            this.Controls.Add(this.textBox_thlower);
            this.Controls.Add(this.label_blury);
            this.Controls.Add(this.label_blurx);
            this.Controls.Add(this.label_blur);
            this.Controls.Add(this.label_can_apsize);
            this.Controls.Add(this.label_th1);
            this.Controls.Add(this.label_th0);
            this.Controls.Add(this.trackBar_blury);
            this.Controls.Add(this.trackBar_blurx);
            this.Controls.Add(this.trackBar_blur);
            this.Controls.Add(this.trackBar_can_apsize);
            this.Controls.Add(this.trackBar_th2);
            this.Controls.Add(this.trackBar_th1);
            this.Controls.Add(this.borderPanel1);
            this.Controls.Add(this.bt_edges);
            this.Controls.Add(this.bt_start);
            this.Name = "Edge_detection";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.borderPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_th1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_th2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_blur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_blurx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_can_apsize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_blury)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.Button bt_edges;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Microsoft.TeamFoundation.Client.BorderPanel borderPanel1;
        private System.Windows.Forms.TrackBar trackBar_th1;
        private System.Windows.Forms.TrackBar trackBar_th2;
        private System.Windows.Forms.TrackBar trackBar_blur;
        private System.Windows.Forms.TrackBar trackBar_blurx;
        private System.Windows.Forms.TrackBar trackBar_can_apsize;
        private System.Windows.Forms.TrackBar trackBar_blury;
        private System.Windows.Forms.Label label_th0;
        private System.Windows.Forms.Label label_th1;
        private System.Windows.Forms.Label label_can_apsize;
        private System.Windows.Forms.Label label_blur;
        private System.Windows.Forms.Label label_blurx;
        private System.Windows.Forms.Label label_blury;
        private System.Windows.Forms.TextBox textBox_thlower;
        private System.Windows.Forms.TextBox textBox_thhigher;
        private System.Windows.Forms.TextBox textBox_canny_app;
        private System.Windows.Forms.TextBox textBox_blursize;
        private System.Windows.Forms.TextBox textBox_blurx;
        private System.Windows.Forms.TextBox textBox_blury;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

