namespace NotePadMoon
{
    partial class NotePad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotePad));
            this.NoteMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Control_panel = new System.Windows.Forms.Panel();
            this.Panel_control = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.CloseButt = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.TxtTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.Menu = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DGview = new System.Windows.Forms.DataGridView();
            this.NoteBody = new System.Windows.Forms.RichTextBox();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NoteMenu.SuspendLayout();
            this.Control_panel.SuspendLayout();
            this.Panel_control.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGview)).BeginInit();
            this.SuspendLayout();
            // 
            // NoteMenu
            // 
            this.NoteMenu.AccessibleDescription = " ";
            this.NoteMenu.BackColor = System.Drawing.Color.Transparent;
            this.NoteMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.NoteMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.NoteMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.NoteMenu.Location = new System.Drawing.Point(0, 0);
            this.NoteMenu.Name = "NoteMenu";
            this.NoteMenu.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.NoteMenu.Size = new System.Drawing.Size(123, 34);
            this.NoteMenu.TabIndex = 6;
            this.NoteMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.AccessibleDescription = " ";
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newNoteToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.exalToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(116, 19);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // newNoteToolStripMenuItem
            // 
            this.newNoteToolStripMenuItem.Name = "newNoteToolStripMenuItem";
            this.newNoteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newNoteToolStripMenuItem.Text = "New Note";
            this.newNoteToolStripMenuItem.Click += new System.EventHandler(this.newNoteToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.AccessibleDescription = " ";
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.AccessibleDescription = " ";
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // exalToolStripMenuItem
            // 
            this.exalToolStripMenuItem.AccessibleDescription = " ";
            this.exalToolStripMenuItem.Name = "exalToolStripMenuItem";
            this.exalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exalToolStripMenuItem.Text = "Exit";
            this.exalToolStripMenuItem.Click += new System.EventHandler(this.exalToolStripMenuItem_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // Control_panel
            // 
            this.Control_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Control_panel.Controls.Add(this.Panel_control);
            this.Control_panel.Controls.Add(this.panel1);
            this.Control_panel.Controls.Add(this.guna2PictureBox1);
            this.Control_panel.Controls.Add(this.guna2ControlBox1);
            this.Control_panel.Controls.Add(this.guna2ControlBox2);
            this.Control_panel.Controls.Add(this.CloseButt);
            this.Control_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Control_panel.Location = new System.Drawing.Point(0, 0);
            this.Control_panel.Name = "Control_panel";
            this.Control_panel.Size = new System.Drawing.Size(800, 34);
            this.Control_panel.TabIndex = 7;
            // 
            // Panel_control
            // 
            this.Panel_control.Controls.Add(this.label2);
            this.Panel_control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_control.Location = new System.Drawing.Point(76, 0);
            this.Panel_control.Name = "Panel_control";
            this.Panel_control.Size = new System.Drawing.Size(589, 34);
            this.Panel_control.TabIndex = 8;
            this.Panel_control.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_control_Paint);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(589, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "NotePad";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NoteMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(37, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(39, 34);
            this.panel1.TabIndex = 8;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackgroundImage = global::NotePadMoon.Properties.Resources.note;
            this.guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(37, 34);
            this.guna2PictureBox1.TabIndex = 8;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(665, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 34);
            this.guna2ControlBox1.TabIndex = 2;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(710, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 34);
            this.guna2ControlBox2.TabIndex = 1;
            // 
            // CloseButt
            // 
            this.CloseButt.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.CloseButt.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.CloseButt.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.CloseButt.HoverState.IconColor = System.Drawing.Color.WhiteSmoke;
            this.CloseButt.IconColor = System.Drawing.Color.White;
            this.CloseButt.Location = new System.Drawing.Point(755, 0);
            this.CloseButt.Name = "CloseButt";
            this.CloseButt.Size = new System.Drawing.Size(45, 34);
            this.CloseButt.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.guna2Panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 416);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.NoteBody);
            this.panel3.Controls.Add(this.DGview);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 378);
            this.panel3.TabIndex = 5;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Controls.Add(this.Menu);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(800, 38);
            this.guna2Panel1.TabIndex = 4;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.TxtTitle);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(42, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(713, 38);
            this.guna2Panel2.TabIndex = 7;
            // 
            // TxtTitle
            // 
            this.TxtTitle.BorderColor = System.Drawing.Color.Transparent;
            this.TxtTitle.BorderRadius = 10;
            this.TxtTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtTitle.DefaultText = "";
            this.TxtTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtTitle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(34)))));
            this.TxtTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TxtTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtTitle.Location = new System.Drawing.Point(0, 0);
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.PasswordChar = '\0';
            this.TxtTitle.PlaceholderText = "";
            this.TxtTitle.SelectedText = "";
            this.TxtTitle.Size = new System.Drawing.Size(713, 38);
            this.TxtTitle.TabIndex = 5;
            // 
            // Menu
            // 
            this.Menu.BackgroundImage = global::NotePadMoon.Properties.Resources.burger_bar;
            this.Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Menu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Menu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Menu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Menu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Menu.Dock = System.Windows.Forms.DockStyle.Right;
            this.Menu.FillColor = System.Drawing.Color.Transparent;
            this.Menu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Menu.ForeColor = System.Drawing.Color.White;
            this.Menu.Location = new System.Drawing.Point(755, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(45, 38);
            this.Menu.TabIndex = 6;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Title:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DGview
            // 
            this.DGview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(34)))));
            this.DGview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGview.Dock = System.Windows.Forms.DockStyle.Right;
            this.DGview.Location = new System.Drawing.Point(665, 0);
            this.DGview.Name = "DGview";
            this.DGview.Size = new System.Drawing.Size(135, 378);
            this.DGview.TabIndex = 5;
            this.DGview.Visible = false;
            this.DGview.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGview_CellContentDoubleClick);
            // 
            // NoteBody
            // 
            this.NoteBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(34)))));
            this.NoteBody.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NoteBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NoteBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteBody.ForeColor = System.Drawing.SystemColors.Info;
            this.NoteBody.Location = new System.Drawing.Point(0, 0);
            this.NoteBody.Name = "NoteBody";
            this.NoteBody.Size = new System.Drawing.Size(665, 378);
            this.NoteBody.TabIndex = 6;
            this.NoteBody.Text = "";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // NotePad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Control_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NotePad";
            this.Text = "NotePad";
            this.Load += new System.EventHandler(this.NotePad_Load);
            this.NoteMenu.ResumeLayout(false);
            this.NoteMenu.PerformLayout();
            this.Control_panel.ResumeLayout(false);
            this.Panel_control.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip NoteMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exalToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel Control_panel;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox CloseButt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Panel_control;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button Menu;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2TextBox TxtTitle;
        private System.Windows.Forms.RichTextBox NoteBody;
        private System.Windows.Forms.DataGridView DGview;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
    }
}

