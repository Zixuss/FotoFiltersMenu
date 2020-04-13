namespace FotoFiltersMenu
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arkivToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sparaSomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öppnaBildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avslutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ändraFärgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rGGBBRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.effekterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.martinMiniBrusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gabrielMonochromeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emilBrusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emilGrainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gabrielAbsoluteColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emilBrightnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenIMG = new System.Windows.Forms.OpenFileDialog();
            this.PicBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arkivToolStripMenuItem,
            this.ändraFärgToolStripMenuItem,
            this.effekterToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1379, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arkivToolStripMenuItem
            // 
            this.arkivToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sparaSomToolStripMenuItem,
            this.öppnaBildToolStripMenuItem,
            this.avslutaToolStripMenuItem,
            this.undoAllToolStripMenuItem});
            this.arkivToolStripMenuItem.Name = "arkivToolStripMenuItem";
            this.arkivToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.arkivToolStripMenuItem.Text = "Arkiv";
            // 
            // sparaSomToolStripMenuItem
            // 
            this.sparaSomToolStripMenuItem.Name = "sparaSomToolStripMenuItem";
            this.sparaSomToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.sparaSomToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.sparaSomToolStripMenuItem.Text = "Spara Som";
            this.sparaSomToolStripMenuItem.Click += new System.EventHandler(this.sparaSomToolStripMenuItem_Click);
            // 
            // öppnaBildToolStripMenuItem
            // 
            this.öppnaBildToolStripMenuItem.Name = "öppnaBildToolStripMenuItem";
            this.öppnaBildToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.öppnaBildToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.öppnaBildToolStripMenuItem.Text = "Öppna Bild";
            this.öppnaBildToolStripMenuItem.Click += new System.EventHandler(this.öppnaBildToolStripMenuItem_Click);
            // 
            // avslutaToolStripMenuItem
            // 
            this.avslutaToolStripMenuItem.Name = "avslutaToolStripMenuItem";
            this.avslutaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.avslutaToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.avslutaToolStripMenuItem.Text = "Avsluta";
            this.avslutaToolStripMenuItem.Click += new System.EventHandler(this.avslutaToolStripMenuItem_Click);
            // 
            // undoAllToolStripMenuItem
            // 
            this.undoAllToolStripMenuItem.Name = "undoAllToolStripMenuItem";
            this.undoAllToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.undoAllToolStripMenuItem.Text = "UndoAll";
            this.undoAllToolStripMenuItem.Click += new System.EventHandler(this.undoAllToolStripMenuItem_Click);
            // 
            // ändraFärgToolStripMenuItem
            // 
            this.ändraFärgToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rGGBBRToolStripMenuItem,
            this.grayToolStripMenuItem,
            this.redToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.invertToolStripMenuItem});
            this.ändraFärgToolStripMenuItem.Name = "ändraFärgToolStripMenuItem";
            this.ändraFärgToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.ändraFärgToolStripMenuItem.Text = "Ändra Färg";
            // 
            // rGGBBRToolStripMenuItem
            // 
            this.rGGBBRToolStripMenuItem.Name = "rGGBBRToolStripMenuItem";
            this.rGGBBRToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.rGGBBRToolStripMenuItem.Text = "R -> G, G- > B, B -> R";
            this.rGGBBRToolStripMenuItem.Click += new System.EventHandler(this.rGGBBRToolStripMenuItem_Click);
            // 
            // grayToolStripMenuItem
            // 
            this.grayToolStripMenuItem.Name = "grayToolStripMenuItem";
            this.grayToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.grayToolStripMenuItem.Text = "Gray";
            this.grayToolStripMenuItem.Click += new System.EventHandler(this.grayToolStripMenuItem_Click);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // invertToolStripMenuItem
            // 
            this.invertToolStripMenuItem.Name = "invertToolStripMenuItem";
            this.invertToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.invertToolStripMenuItem.Text = "Invert";
            this.invertToolStripMenuItem.Click += new System.EventHandler(this.invertToolStripMenuItem_Click);
            // 
            // effekterToolStripMenuItem
            // 
            this.effekterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.martinMiniBrusToolStripMenuItem,
            this.gabrielMonochromeToolStripMenuItem,
            this.emilBrusToolStripMenuItem,
            this.emilGrainToolStripMenuItem,
            this.gabrielAbsoluteColorToolStripMenuItem,
            this.emilBrightnessToolStripMenuItem});
            this.effekterToolStripMenuItem.Name = "effekterToolStripMenuItem";
            this.effekterToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.effekterToolStripMenuItem.Text = "Effekter";
            // 
            // martinMiniBrusToolStripMenuItem
            // 
            this.martinMiniBrusToolStripMenuItem.Name = "martinMiniBrusToolStripMenuItem";
            this.martinMiniBrusToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.martinMiniBrusToolStripMenuItem.Text = "Martin Mini Brus";
            this.martinMiniBrusToolStripMenuItem.Click += new System.EventHandler(this.martinMiniBrusToolStripMenuItem_Click);
            // 
            // gabrielMonochromeToolStripMenuItem
            // 
            this.gabrielMonochromeToolStripMenuItem.Name = "gabrielMonochromeToolStripMenuItem";
            this.gabrielMonochromeToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.gabrielMonochromeToolStripMenuItem.Text = "Gabriel Monochrome";
            this.gabrielMonochromeToolStripMenuItem.Click += new System.EventHandler(this.gabrielMonochromeToolStripMenuItem_Click);
            // 
            // emilBrusToolStripMenuItem
            // 
            this.emilBrusToolStripMenuItem.Name = "emilBrusToolStripMenuItem";
            this.emilBrusToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.emilBrusToolStripMenuItem.Text = "Emil Brus";
            this.emilBrusToolStripMenuItem.Click += new System.EventHandler(this.emilBrusToolStripMenuItem_Click);
            // 
            // emilGrainToolStripMenuItem
            // 
            this.emilGrainToolStripMenuItem.Name = "emilGrainToolStripMenuItem";
            this.emilGrainToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.emilGrainToolStripMenuItem.Text = "Emil Grain";
            this.emilGrainToolStripMenuItem.Click += new System.EventHandler(this.emilGrainToolStripMenuItem_Click);
            // 
            // gabrielAbsoluteColorToolStripMenuItem
            // 
            this.gabrielAbsoluteColorToolStripMenuItem.Name = "gabrielAbsoluteColorToolStripMenuItem";
            this.gabrielAbsoluteColorToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.gabrielAbsoluteColorToolStripMenuItem.Text = "Gabriel Absolute Color";
            this.gabrielAbsoluteColorToolStripMenuItem.Click += new System.EventHandler(this.gabrielAbsoluteColorToolStripMenuItem_Click);
            // 
            // emilBrightnessToolStripMenuItem
            // 
            this.emilBrightnessToolStripMenuItem.Name = "emilBrightnessToolStripMenuItem";
            this.emilBrightnessToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.emilBrightnessToolStripMenuItem.Text = "Emil Brightness";
            this.emilBrightnessToolStripMenuItem.Click += new System.EventHandler(this.emilBrightnessToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // OpenIMG
            // 
            this.OpenIMG.FileName = "OpenIMG";
            // 
            // PicBox
            // 
            this.PicBox.Location = new System.Drawing.Point(315, 75);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(992, 500);
            this.PicBox.TabIndex = 1;
            this.PicBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 649);
            this.Controls.Add(this.PicBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arkivToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sparaSomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öppnaBildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avslutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ändraFärgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rGGBBRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem effekterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenIMG;
        private System.Windows.Forms.PictureBox PicBox;
        private System.Windows.Forms.ToolStripMenuItem martinMiniBrusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gabrielMonochromeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emilBrusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emilGrainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gabrielAbsoluteColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emilBrightnessToolStripMenuItem;
    }
}

