namespace SmartBrowser
{
    partial class Form1
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
            AnimatorNS.Animation animation1 = new AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            AnimatorNS.Animation animation2 = new AnimatorNS.Animation();
            this.btnKeyboard = new System.Windows.Forms.Button();
            this.animator1 = new AnimatorNS.Animator(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.animator2 = new AnimatorNS.Animator(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKeyboard
            // 
            this.animator1.SetDecoration(this.btnKeyboard, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this.btnKeyboard, AnimatorNS.DecorationType.None);
            this.btnKeyboard.Location = new System.Drawing.Point(619, 22);
            this.btnKeyboard.Name = "btnKeyboard";
            this.btnKeyboard.Size = new System.Drawing.Size(75, 23);
            this.btnKeyboard.TabIndex = 0;
            this.btnKeyboard.Text = "Keyboard";
            this.btnKeyboard.UseVisualStyleBackColor = true;
            this.btnKeyboard.Click += new System.EventHandler(this.button1_Click);
            // 
            // animator1
            // 
            this.animator1.AnimationType = AnimatorNS.AnimationType.Rotate;
            this.animator1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(50);
            animation1.RotateCoeff = 1F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.animator1.DefaultAnimation = animation1;
            this.animator1.Interval = 30;
            this.animator1.MaxAnimationTime = 3000;
            this.animator1.TimeStep = 0.003F;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackgroundImage = global::SmartBrowser.Properties.Resources.g1;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.animator2.SetDecoration(this.panel3, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.panel3, AnimatorNS.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(18, 135);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(127, 103);
            this.panel3.TabIndex = 1;
            this.panel3.Click += new System.EventHandler(this.panel3_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackgroundImage = global::SmartBrowser.Properties.Resources.uol;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.animator2.SetDecoration(this.panel2, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.panel2, AnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(18, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(127, 103);
            this.panel2.TabIndex = 0;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // splitContainer1
            // 
            this.animator2.SetDecoration(this.splitContainer1, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.splitContainer1, AnimatorNS.DecorationType.None);
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(20, 60);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.animator2.SetDecoration(this.splitContainer1.Panel1, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.splitContainer1.Panel1, AnimatorNS.DecorationType.None);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.animator2.SetDecoration(this.splitContainer1.Panel2, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.splitContainer1.Panel2, AnimatorNS.DecorationType.None);
            this.splitContainer1.Size = new System.Drawing.Size(677, 410);
            this.splitContainer1.SplitterDistance = 160;
            this.splitContainer1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.webBrowser1);
            this.animator2.SetDecoration(this.panel1, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.panel1, AnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 410);
            this.panel1.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.animator2.SetDecoration(this.webBrowser1, AnimatorNS.DecorationType.None);
            this.animator1.SetDecoration(this.webBrowser1, AnimatorNS.DecorationType.None);
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(513, 410);
            this.webBrowser1.TabIndex = 1;
            // 
            // animator2
            // 
            this.animator2.AnimationType = AnimatorNS.AnimationType.Mosaic;
            this.animator2.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 20;
            animation2.Padding = new System.Windows.Forms.Padding(30);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.animator2.DefaultAnimation = animation2;
            this.animator2.TimeStep = 0.03F;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 490);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnKeyboard);
            this.animator1.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.animator2.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKeyboard;
        private AnimatorNS.Animator animator1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private AnimatorNS.Animator animator2;
    }
}

