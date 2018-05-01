namespace doan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabctrl = new System.Windows.Forms.TabControl();
            this.tbpageBios = new System.Windows.Forms.TabPage();
            this.tbpageBonho = new System.Windows.Forms.TabPage();
            this.tbpageProcessor = new System.Windows.Forms.TabPage();
            this.tbpageMainBoard = new System.Windows.Forms.TabPage();
            this.tabPageBattery = new System.Windows.Forms.TabPage();
            this.tabPageGraphic = new System.Windows.Forms.TabPage();
            this.tabPageRegistry = new System.Windows.Forms.TabPage();
            this.tabPageMemory = new System.Windows.Forms.TabPage();
            this.richtxtShow = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.tabctrl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabctrl
            // 
            this.tabctrl.AccessibleName = "";
            this.tabctrl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabctrl.Controls.Add(this.tbpageBios);
            this.tabctrl.Controls.Add(this.tbpageBonho);
            this.tabctrl.Controls.Add(this.tbpageProcessor);
            this.tabctrl.Controls.Add(this.tbpageMainBoard);
            this.tabctrl.Controls.Add(this.tabPageBattery);
            this.tabctrl.Controls.Add(this.tabPageGraphic);
            this.tabctrl.Controls.Add(this.tabPageRegistry);
            this.tabctrl.Controls.Add(this.tabPageMemory);
            this.tabctrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabctrl.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.tabctrl.Location = new System.Drawing.Point(11, 3);
            this.tabctrl.Name = "tabctrl";
            this.tabctrl.SelectedIndex = 0;
            this.tabctrl.Size = new System.Drawing.Size(442, 30);
            this.tabctrl.TabIndex = 1;
            this.tabctrl.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tbpageBios
            // 
            this.tbpageBios.AllowDrop = true;
            this.tbpageBios.BackColor = System.Drawing.Color.Blue;
            this.tbpageBios.CausesValidation = false;
            this.tbpageBios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tbpageBios.Location = new System.Drawing.Point(4, 25);
            this.tbpageBios.Name = "tbpageBios";
            this.tbpageBios.Padding = new System.Windows.Forms.Padding(3);
            this.tbpageBios.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbpageBios.Size = new System.Drawing.Size(434, 1);
            this.tbpageBios.TabIndex = 0;
            this.tbpageBios.Text = "BIOS";
            this.tbpageBios.UseVisualStyleBackColor = true;
            this.tbpageBios.UseWaitCursor = true;
            // 
            // tbpageBonho
            // 
            this.tbpageBonho.AllowDrop = true;
            this.tbpageBonho.BackColor = System.Drawing.Color.Blue;
            this.tbpageBonho.CausesValidation = false;
            this.tbpageBonho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tbpageBonho.Location = new System.Drawing.Point(4, 25);
            this.tbpageBonho.Name = "tbpageBonho";
            this.tbpageBonho.Padding = new System.Windows.Forms.Padding(3);
            this.tbpageBonho.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbpageBonho.Size = new System.Drawing.Size(434, 1);
            this.tbpageBonho.TabIndex = 2;
            this.tbpageBonho.Text = "Network";
            this.tbpageBonho.UseVisualStyleBackColor = true;
            this.tbpageBonho.UseWaitCursor = true;
            // 
            // tbpageProcessor
            // 
            this.tbpageProcessor.AllowDrop = true;
            this.tbpageProcessor.BackColor = System.Drawing.Color.Blue;
            this.tbpageProcessor.CausesValidation = false;
            this.tbpageProcessor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tbpageProcessor.Location = new System.Drawing.Point(4, 25);
            this.tbpageProcessor.Name = "tbpageProcessor";
            this.tbpageProcessor.Padding = new System.Windows.Forms.Padding(3);
            this.tbpageProcessor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbpageProcessor.Size = new System.Drawing.Size(434, 1);
            this.tbpageProcessor.TabIndex = 3;
            this.tbpageProcessor.Text = "Processor";
            this.tbpageProcessor.UseVisualStyleBackColor = true;
            this.tbpageProcessor.UseWaitCursor = true;
            // 
            // tbpageMainBoard
            // 
            this.tbpageMainBoard.AllowDrop = true;
            this.tbpageMainBoard.BackColor = System.Drawing.Color.Blue;
            this.tbpageMainBoard.CausesValidation = false;
            this.tbpageMainBoard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tbpageMainBoard.Location = new System.Drawing.Point(4, 25);
            this.tbpageMainBoard.Name = "tbpageMainBoard";
            this.tbpageMainBoard.Padding = new System.Windows.Forms.Padding(3);
            this.tbpageMainBoard.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbpageMainBoard.Size = new System.Drawing.Size(434, 1);
            this.tbpageMainBoard.TabIndex = 4;
            this.tbpageMainBoard.Text = "MainBoard";
            this.tbpageMainBoard.UseVisualStyleBackColor = true;
            this.tbpageMainBoard.UseWaitCursor = true;
            // 
            // tabPageBattery
            // 
            this.tabPageBattery.AllowDrop = true;
            this.tabPageBattery.BackColor = System.Drawing.Color.Blue;
            this.tabPageBattery.CausesValidation = false;
            this.tabPageBattery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tabPageBattery.Location = new System.Drawing.Point(4, 25);
            this.tabPageBattery.Name = "tabPageBattery";
            this.tabPageBattery.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBattery.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabPageBattery.Size = new System.Drawing.Size(434, 1);
            this.tabPageBattery.TabIndex = 5;
            this.tabPageBattery.Text = "Battery";
            this.tabPageBattery.UseVisualStyleBackColor = true;
            this.tabPageBattery.UseWaitCursor = true;
            // 
            // tabPageGraphic
            // 
            this.tabPageGraphic.AllowDrop = true;
            this.tabPageGraphic.BackColor = System.Drawing.Color.Blue;
            this.tabPageGraphic.CausesValidation = false;
            this.tabPageGraphic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tabPageGraphic.Location = new System.Drawing.Point(4, 25);
            this.tabPageGraphic.Name = "tabPageGraphic";
            this.tabPageGraphic.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGraphic.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabPageGraphic.Size = new System.Drawing.Size(434, 1);
            this.tabPageGraphic.TabIndex = 6;
            this.tabPageGraphic.Text = "Graphic";
            this.tabPageGraphic.UseVisualStyleBackColor = true;
            this.tabPageGraphic.UseWaitCursor = true;
            // 
            // tabPageRegistry
            // 
            this.tabPageRegistry.AllowDrop = true;
            this.tabPageRegistry.BackColor = System.Drawing.Color.Blue;
            this.tabPageRegistry.CausesValidation = false;
            this.tabPageRegistry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageRegistry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tabPageRegistry.Location = new System.Drawing.Point(4, 25);
            this.tabPageRegistry.Name = "tabPageRegistry";
            this.tabPageRegistry.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRegistry.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabPageRegistry.Size = new System.Drawing.Size(434, 1);
            this.tabPageRegistry.TabIndex = 7;
            this.tabPageRegistry.Text = "Registry";
            this.tabPageRegistry.UseVisualStyleBackColor = true;
            this.tabPageRegistry.UseWaitCursor = true;
            // 
            // tabPageMemory
            // 
            this.tabPageMemory.Location = new System.Drawing.Point(4, 25);
            this.tabPageMemory.Name = "tabPageMemory";
            this.tabPageMemory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMemory.Size = new System.Drawing.Size(434, 1);
            this.tabPageMemory.TabIndex = 8;
            this.tabPageMemory.Text = "Memory";
            this.tabPageMemory.UseVisualStyleBackColor = true;
            // 
            // richtxtShow
            // 
            this.richtxtShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richtxtShow.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.richtxtShow.Location = new System.Drawing.Point(11, 31);
            this.richtxtShow.Name = "richtxtShow";
            this.richtxtShow.Size = new System.Drawing.Size(444, 277);
            this.richtxtShow.TabIndex = 2;
            this.richtxtShow.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTest);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnShow);
            this.panel1.Controls.Add(this.tabctrl);
            this.panel1.Controls.Add(this.richtxtShow);
            this.panel1.Location = new System.Drawing.Point(-8, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 360);
            this.panel1.TabIndex = 0;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(547, 196);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(84, 36);
            this.btnTest.TabIndex = 5;
            this.btnTest.Text = "Test RegEx";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(547, 129);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 39);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(547, 66);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(84, 39);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(673, 361);
            this.Controls.Add(this.panel1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "READ Information of Hardware";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabctrl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabctrl;
        private System.Windows.Forms.TabPage tbpageBios;
        private System.Windows.Forms.TabPage tbpageBonho;
        private System.Windows.Forms.TabPage tbpageProcessor;
        private System.Windows.Forms.TabPage tbpageMainBoard;
        private System.Windows.Forms.RichTextBox richtxtShow;
        private System.Windows.Forms.TabPage tabPageBattery;
        private System.Windows.Forms.TabPage tabPageGraphic;
        private System.Windows.Forms.TabPage tabPageRegistry;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPageMemory;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnTest;
    }
}

