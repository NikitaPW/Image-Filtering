namespace WindowsFormsApp6
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.uploadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadImageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoAllChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoAllChangesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightnessCorrectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contrastEnhancementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gammaCorrectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convolutionFiltersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gausssianBlurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sharpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeDetectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.embossToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polylineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Image2 = new System.Windows.Forms.PictureBox();
            this.Image1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uploadImageToolStripMenuItem,
            this.filtersToolStripMenuItem,
            this.convolutionFiltersToolStripMenuItem,
            this.polylineToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1282, 32);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // uploadImageToolStripMenuItem
            // 
            this.uploadImageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uploadImageToolStripMenuItem1,
            this.saveImageToolStripMenuItem,
            this.undoAllChangesToolStripMenuItem,
            this.undoAllChangesToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.uploadImageToolStripMenuItem.Name = "uploadImageToolStripMenuItem";
            this.uploadImageToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.uploadImageToolStripMenuItem.Size = new System.Drawing.Size(63, 28);
            this.uploadImageToolStripMenuItem.Text = "Image";
            // 
            // uploadImageToolStripMenuItem1
            // 
            this.uploadImageToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("uploadImageToolStripMenuItem1.Image")));
            this.uploadImageToolStripMenuItem1.Name = "uploadImageToolStripMenuItem1";
            this.uploadImageToolStripMenuItem1.Size = new System.Drawing.Size(198, 26);
            this.uploadImageToolStripMenuItem1.Text = "Upload Image";
            this.uploadImageToolStripMenuItem1.Click += new System.EventHandler(this.uploadImageToolStripMenuItem1_Click);
            // 
            // saveImageToolStripMenuItem
            // 
            this.saveImageToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveImageToolStripMenuItem.Image")));
            this.saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            this.saveImageToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.saveImageToolStripMenuItem.Text = "Save Image";
            this.saveImageToolStripMenuItem.Click += new System.EventHandler(this.saveImageToolStripMenuItem_Click);
            // 
            // undoAllChangesToolStripMenuItem
            // 
            this.undoAllChangesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("undoAllChangesToolStripMenuItem.Image")));
            this.undoAllChangesToolStripMenuItem.Name = "undoAllChangesToolStripMenuItem";
            this.undoAllChangesToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.undoAllChangesToolStripMenuItem.Text = "Undo all changes";
            this.undoAllChangesToolStripMenuItem.Click += new System.EventHandler(this.undoAllChangesToolStripMenuItem_Click);
            // 
            // undoAllChangesToolStripMenuItem1
            // 
            this.undoAllChangesToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("undoAllChangesToolStripMenuItem1.Image")));
            this.undoAllChangesToolStripMenuItem1.Name = "undoAllChangesToolStripMenuItem1";
            this.undoAllChangesToolStripMenuItem1.Size = new System.Drawing.Size(198, 26);
            this.undoAllChangesToolStripMenuItem1.Text = "Delete image";
            this.undoAllChangesToolStripMenuItem1.Click += new System.EventHandler(this.undoAllChangesToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.CheckOnClick = true;
            this.filtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inversionToolStripMenuItem,
            this.brightnessCorrectionToolStripMenuItem,
            this.contrastEnhancementToolStripMenuItem,
            this.gammaCorrectionToolStripMenuItem});
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(120, 28);
            this.filtersToolStripMenuItem.Text = "Function Filters";
            // 
            // inversionToolStripMenuItem
            // 
            this.inversionToolStripMenuItem.Name = "inversionToolStripMenuItem";
            this.inversionToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.inversionToolStripMenuItem.Text = "Inversion";
            this.inversionToolStripMenuItem.Click += new System.EventHandler(this.inversionToolStripMenuItem_Click);
            // 
            // brightnessCorrectionToolStripMenuItem
            // 
            this.brightnessCorrectionToolStripMenuItem.Name = "brightnessCorrectionToolStripMenuItem";
            this.brightnessCorrectionToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.brightnessCorrectionToolStripMenuItem.Text = "Brightness correction";
            this.brightnessCorrectionToolStripMenuItem.Click += new System.EventHandler(this.brightnessCorrectionToolStripMenuItem_Click);
            // 
            // contrastEnhancementToolStripMenuItem
            // 
            this.contrastEnhancementToolStripMenuItem.Name = "contrastEnhancementToolStripMenuItem";
            this.contrastEnhancementToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.contrastEnhancementToolStripMenuItem.Text = "Contrast enhancement";
            this.contrastEnhancementToolStripMenuItem.Click += new System.EventHandler(this.contrastEnhancementToolStripMenuItem_Click);
            // 
            // gammaCorrectionToolStripMenuItem
            // 
            this.gammaCorrectionToolStripMenuItem.Name = "gammaCorrectionToolStripMenuItem";
            this.gammaCorrectionToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.gammaCorrectionToolStripMenuItem.Text = "Gamma correction";
            this.gammaCorrectionToolStripMenuItem.Click += new System.EventHandler(this.gammaCorrectionToolStripMenuItem_Click);
            // 
            // convolutionFiltersToolStripMenuItem
            // 
            this.convolutionFiltersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blurToolStripMenuItem,
            this.gausssianBlurToolStripMenuItem,
            this.sharpenToolStripMenuItem,
            this.edgeDetectionToolStripMenuItem,
            this.embossToolStripMenuItem});
            this.convolutionFiltersToolStripMenuItem.Name = "convolutionFiltersToolStripMenuItem";
            this.convolutionFiltersToolStripMenuItem.Size = new System.Drawing.Size(144, 28);
            this.convolutionFiltersToolStripMenuItem.Text = "Convolution Filters";
            // 
            // blurToolStripMenuItem
            // 
            this.blurToolStripMenuItem.Name = "blurToolStripMenuItem";
            this.blurToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.blurToolStripMenuItem.Text = "Blur";
            this.blurToolStripMenuItem.Click += new System.EventHandler(this.blurToolStripMenuItem_Click);
            // 
            // gausssianBlurToolStripMenuItem
            // 
            this.gausssianBlurToolStripMenuItem.Name = "gausssianBlurToolStripMenuItem";
            this.gausssianBlurToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.gausssianBlurToolStripMenuItem.Text = "Gausssian Blur";
            this.gausssianBlurToolStripMenuItem.Click += new System.EventHandler(this.gausssianBlurToolStripMenuItem_Click);
            // 
            // sharpenToolStripMenuItem
            // 
            this.sharpenToolStripMenuItem.Name = "sharpenToolStripMenuItem";
            this.sharpenToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.sharpenToolStripMenuItem.Text = "Sharpen";
            this.sharpenToolStripMenuItem.Click += new System.EventHandler(this.sharpenToolStripMenuItem_Click);
            // 
            // edgeDetectionToolStripMenuItem
            // 
            this.edgeDetectionToolStripMenuItem.Name = "edgeDetectionToolStripMenuItem";
            this.edgeDetectionToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.edgeDetectionToolStripMenuItem.Text = "Edge Detection";
            this.edgeDetectionToolStripMenuItem.Click += new System.EventHandler(this.edgeDetectionToolStripMenuItem_Click);
            // 
            // embossToolStripMenuItem
            // 
            this.embossToolStripMenuItem.Name = "embossToolStripMenuItem";
            this.embossToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.embossToolStripMenuItem.Text = "Emboss";
            this.embossToolStripMenuItem.Click += new System.EventHandler(this.embossToolStripMenuItem_Click);
            // 
            // polylineToolStripMenuItem
            // 
            this.polylineToolStripMenuItem.Name = "polylineToolStripMenuItem";
            this.polylineToolStripMenuItem.Size = new System.Drawing.Size(72, 28);
            this.polylineToolStripMenuItem.Text = "Polyline";
            this.polylineToolStripMenuItem.Click += new System.EventHandler(this.polylineToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "Raw image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(852, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "Filtered image";
            // 
            // Image2
            // 
            this.Image2.Image = global::WindowsFormsApp6.Properties.Resources.image_placeholder;
            this.Image2.Location = new System.Drawing.Point(657, 174);
            this.Image2.Name = "Image2";
            this.Image2.Size = new System.Drawing.Size(600, 400);
            this.Image2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Image2.TabIndex = 2;
            this.Image2.TabStop = false;
            this.Image2.Paint += new System.Windows.Forms.PaintEventHandler(this.Image2_Paint);
            // 
            // Image1
            // 
            this.Image1.Image = global::WindowsFormsApp6.Properties.Resources.image_placeholder;
            this.Image1.Location = new System.Drawing.Point(25, 174);
            this.Image1.Name = "Image1";
            this.Image1.Size = new System.Drawing.Size(600, 400);
            this.Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Image1.TabIndex = 1;
            this.Image1.TabStop = false;
            this.Image1.Paint += new System.Windows.Forms.PaintEventHandler(this.Image1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(574, 287);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(8, 8);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(25, 594);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(298, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Gamma correction number";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 632);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 660);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Image2);
            this.Controls.Add(this.Image1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Form1";
            this.Text = "Computer Graphics Task 1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Image1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem uploadImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inversionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brightnessCorrectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contrastEnhancementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gammaCorrectionToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem convolutionFiltersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gausssianBlurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sharpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edgeDetectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem embossToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadImageToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoAllChangesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoAllChangesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polylineToolStripMenuItem;
        public System.Windows.Forms.PictureBox Image2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

