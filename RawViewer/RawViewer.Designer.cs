namespace RawViewer
{
    partial class RawViewer
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            depthToolStripMenuItem = new ToolStripMenuItem();
            rGBAToolStripMenuItem = new ToolStripMenuItem();
            rGBToolStripMenuItem = new ToolStripMenuItem();
            monochromeToolStripMenuItem = new ToolStripMenuItem();
            stretchToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            widthField = new NumericUpDown();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)widthField).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, optionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, clearToolStripMenuItem, saveToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(180, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(180, 22);
            clearToolStripMenuItem.Text = "Clear";
            clearToolStripMenuItem.Click += clearToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Enabled = false;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(180, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { depthToolStripMenuItem, stretchToolStripMenuItem });
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(61, 20);
            optionsToolStripMenuItem.Text = "Options";
            // 
            // depthToolStripMenuItem
            // 
            depthToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rGBAToolStripMenuItem, rGBToolStripMenuItem, monochromeToolStripMenuItem });
            depthToolStripMenuItem.Name = "depthToolStripMenuItem";
            depthToolStripMenuItem.Size = new Size(160, 22);
            depthToolStripMenuItem.Text = "Depth";
            // 
            // rGBAToolStripMenuItem
            // 
            rGBAToolStripMenuItem.CheckOnClick = true;
            rGBAToolStripMenuItem.Name = "rGBAToolStripMenuItem";
            rGBAToolStripMenuItem.Size = new Size(190, 22);
            rGBAToolStripMenuItem.Tag = 4;
            rGBAToolStripMenuItem.Text = "RGBA (4 bytes)";
            rGBAToolStripMenuItem.CheckedChanged += ChangeDepth;
            // 
            // rGBToolStripMenuItem
            // 
            rGBToolStripMenuItem.CheckOnClick = true;
            rGBToolStripMenuItem.Name = "rGBToolStripMenuItem";
            rGBToolStripMenuItem.Size = new Size(190, 22);
            rGBToolStripMenuItem.Tag = 3;
            rGBToolStripMenuItem.Text = "RGB (3 bytes)";
            rGBToolStripMenuItem.CheckedChanged += ChangeDepth;
            // 
            // monochromeToolStripMenuItem
            // 
            monochromeToolStripMenuItem.CheckOnClick = true;
            monochromeToolStripMenuItem.Name = "monochromeToolStripMenuItem";
            monochromeToolStripMenuItem.Size = new Size(190, 22);
            monochromeToolStripMenuItem.Tag = 1;
            monochromeToolStripMenuItem.Text = "Monochrome (1 byte)";
            monochromeToolStripMenuItem.CheckedChanged += ChangeDepth;
            // 
            // stretchToolStripMenuItem
            // 
            stretchToolStripMenuItem.CheckOnClick = true;
            stretchToolStripMenuItem.Name = "stretchToolStripMenuItem";
            stretchToolStripMenuItem.Size = new Size(160, 22);
            stretchToolStripMenuItem.Text = "Stretch on resize";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 397);
            panel1.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(widthField);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 24);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 29);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Width:";
            // 
            // widthField
            // 
            widthField.Location = new Point(51, 3);
            widthField.Name = "widthField";
            widthField.Size = new Size(120, 23);
            widthField.TabIndex = 1;
            widthField.ValueChanged += widthField_ValueChanged;
            // 
            // RawViewer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "RawViewer";
            Text = "Raw Viewer";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)widthField).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private PictureBox pictureBox1;
        private ToolStripMenuItem depthToolStripMenuItem;
        private ToolStripMenuItem rGBAToolStripMenuItem;
        private ToolStripMenuItem rGBToolStripMenuItem;
        private ToolStripMenuItem monochromeToolStripMenuItem;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private NumericUpDown widthField;
        private ToolStripMenuItem stretchToolStripMenuItem;
    }
}