namespace DbClients
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
            this.LayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.GroupBoxed = new System.Windows.Forms.GroupBox();
            this.Description = new System.Windows.Forms.Label();
            this.Mail = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.NamePanel = new System.Windows.Forms.Label();
            this.PhotoImage = new System.Windows.Forms.PictureBox();
            this.Edit = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.Delete = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.Button1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.Button2 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.ScrollBar = new Siticone.Desktop.UI.WinForms.SiticoneVScrollBar();
            this.LayoutPanel.SuspendLayout();
            this.GroupBoxed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // LayoutPanel
            // 
            this.LayoutPanel.AutoScroll = true;
            this.LayoutPanel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.LayoutPanel.Controls.Add(this.GroupBoxed);
            this.LayoutPanel.Location = new System.Drawing.Point(12, 7);
            this.LayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.LayoutPanel.Name = "LayoutPanel";
            this.LayoutPanel.Padding = new System.Windows.Forms.Padding(10);
            this.LayoutPanel.Size = new System.Drawing.Size(1140, 549);
            this.LayoutPanel.TabIndex = 0;
            this.LayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // GroupBoxed
            // 
            this.GroupBoxed.AutoSize = true;
            this.GroupBoxed.BackColor = System.Drawing.Color.Linen;
            this.GroupBoxed.Controls.Add(this.Description);
            this.GroupBoxed.Controls.Add(this.Mail);
            this.GroupBoxed.Controls.Add(this.Phone);
            this.GroupBoxed.Controls.Add(this.NamePanel);
            this.GroupBoxed.Controls.Add(this.PhotoImage);
            this.GroupBoxed.Controls.Add(this.Edit);
            this.GroupBoxed.Controls.Add(this.Delete);
            this.GroupBoxed.Location = new System.Drawing.Point(13, 13);
            this.GroupBoxed.Name = "GroupBoxed";
            this.GroupBoxed.Size = new System.Drawing.Size(1094, 296);
            this.GroupBoxed.TabIndex = 0;
            this.GroupBoxed.TabStop = false;
            this.GroupBoxed.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Description
            // 
            this.Description.Cursor = System.Windows.Forms.Cursors.No;
            this.Description.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Description.Location = new System.Drawing.Point(189, 117);
            this.Description.MaximumSize = new System.Drawing.Size(1000, 400);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(899, 160);
            this.Description.TabIndex = 7;
            this.Description.Text = resources.GetString("Description.Text");
            this.Description.Click += new System.EventHandler(this.label5_Click);
            // 
            // Mail
            // 
            this.Mail.AutoSize = true;
            this.Mail.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mail.Location = new System.Drawing.Point(189, 41);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(78, 25);
            this.Mail.TabIndex = 5;
            this.Mail.Text = "Почта";
            this.Mail.Click += new System.EventHandler(this.label3_Click);
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Phone.Location = new System.Drawing.Point(189, 66);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(109, 25);
            this.Phone.TabIndex = 4;
            this.Phone.Text = "Телефон";
            // 
            // NamePanel
            // 
            this.NamePanel.AutoSize = true;
            this.NamePanel.BackColor = System.Drawing.Color.Linen;
            this.NamePanel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NamePanel.Location = new System.Drawing.Point(189, 16);
            this.NamePanel.Name = "NamePanel";
            this.NamePanel.Size = new System.Drawing.Size(172, 25);
            this.NamePanel.TabIndex = 3;
            this.NamePanel.Text = "Name Surname";
            // 
            // PhotoImage
            // 
            this.PhotoImage.BackColor = System.Drawing.Color.Cyan;
            this.PhotoImage.Location = new System.Drawing.Point(6, 15);
            this.PhotoImage.Name = "PhotoImage";
            this.PhotoImage.Size = new System.Drawing.Size(160, 160);
            this.PhotoImage.TabIndex = 2;
            this.PhotoImage.TabStop = false;
            this.PhotoImage.Click += new System.EventHandler(this.PhotoImage_Click);
            // 
            // Edit
            // 
            this.Edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Edit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Edit.ForeColor = System.Drawing.Color.White;
            this.Edit.Location = new System.Drawing.Point(6, 181);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(160, 45);
            this.Edit.TabIndex = 1;
            this.Edit.Text = "Редактировать профиль";
            // 
            // Delete
            // 
            this.Delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Delete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.Location = new System.Drawing.Point(6, 232);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(161, 45);
            this.Delete.TabIndex = 0;
            this.Delete.Text = "Удалить ";
            this.Delete.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // Button1
            // 
            this.Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Button1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button1.ForeColor = System.Drawing.Color.Black;
            this.Button1.Location = new System.Drawing.Point(13, 585);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(180, 45);
            this.Button1.TabIndex = 1;
            this.Button1.Text = "Добавить элемент";
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.BorderColor = System.Drawing.Color.Transparent;
            this.Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button2.FillColor = System.Drawing.Color.IndianRed;
            this.Button2.Font = new System.Drawing.Font("Impact", 12F);
            this.Button2.ForeColor = System.Drawing.Color.Black;
            this.Button2.Location = new System.Drawing.Point(219, 585);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(180, 45);
            this.Button2.TabIndex = 2;
            this.Button2.Text = "Удалить элемент";
            this.Button2.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // ScrollBar
            // 
            this.ScrollBar.InUpdate = false;
            this.ScrollBar.LargeChange = 10;
            this.ScrollBar.Location = new System.Drawing.Point(1156, 7);
            this.ScrollBar.Name = "ScrollBar";
            this.ScrollBar.ScrollbarSize = 10;
            this.ScrollBar.Size = new System.Drawing.Size(10, 549);
            this.ScrollBar.TabIndex = 3;
            this.ScrollBar.ThumbColor = System.Drawing.Color.Gray;
            this.ScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollBar_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1167, 662);
            this.Controls.Add(this.ScrollBar);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.LayoutPanel);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "База клиентов";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LayoutPanel.ResumeLayout(false);
            this.LayoutPanel.PerformLayout();
            this.GroupBoxed.ResumeLayout(false);
            this.GroupBoxed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel LayoutPanel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton Button1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton Button2;
        private System.Windows.Forms.GroupBox GroupBoxed;
        private Siticone.Desktop.UI.WinForms.SiticoneButton Edit;
        private Siticone.Desktop.UI.WinForms.SiticoneButton Delete;
        private System.Windows.Forms.PictureBox PhotoImage;
        private System.Windows.Forms.Label Mail;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label NamePanel;
        private System.Windows.Forms.Label Description;
        private Siticone.Desktop.UI.WinForms.SiticoneVScrollBar ScrollBar;
    }
}

