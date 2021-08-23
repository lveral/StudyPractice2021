
namespace Restaurant
{
    partial class AdminForm
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
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.panelHello = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonVisitors = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonTable = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonRes = new System.Windows.Forms.Button();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.panelBack = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(180, 65);
            this.panelDesktopPane.Margin = new System.Windows.Forms.Padding(2);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(812, 458);
            this.panelDesktopPane.TabIndex = 5;
            // 
            // panelHello
            // 
            this.panelHello.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(137)))), ((int)(((byte)(136)))));
            this.panelHello.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHello.Location = new System.Drawing.Point(180, 0);
            this.panelHello.Margin = new System.Windows.Forms.Padding(2);
            this.panelHello.Name = "panelHello";
            this.panelHello.Size = new System.Drawing.Size(812, 65);
            this.panelHello.TabIndex = 4;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(53)))), ((int)(((byte)(44)))));
            this.panelMenu.Controls.Add(this.buttonVisitors);
            this.panelMenu.Controls.Add(this.buttonInfo);
            this.panelMenu.Controls.Add(this.buttonTable);
            this.panelMenu.Controls.Add(this.buttonExit);
            this.panelMenu.Controls.Add(this.buttonRes);
            this.panelMenu.Controls.Add(this.buttonOrder);
            this.panelMenu.Controls.Add(this.panelBack);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.MinimumSize = new System.Drawing.Size(180, 523);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(180, 523);
            this.panelMenu.TabIndex = 3;
            // 
            // buttonVisitors
            // 
            this.buttonVisitors.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonVisitors.FlatAppearance.BorderSize = 0;
            this.buttonVisitors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVisitors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonVisitors.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonVisitors.Location = new System.Drawing.Point(0, 212);
            this.buttonVisitors.Margin = new System.Windows.Forms.Padding(2);
            this.buttonVisitors.Name = "buttonVisitors";
            this.buttonVisitors.Size = new System.Drawing.Size(180, 49);
            this.buttonVisitors.TabIndex = 7;
            this.buttonVisitors.Text = "Информация об администраторах";
            this.buttonVisitors.UseVisualStyleBackColor = true;
            this.buttonVisitors.Click += new System.EventHandler(this.buttonVisitors_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonInfo.FlatAppearance.BorderSize = 0;
            this.buttonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonInfo.Location = new System.Drawing.Point(0, 425);
            this.buttonInfo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(180, 49);
            this.buttonInfo.TabIndex = 6;
            this.buttonInfo.Text = "Аккаунт";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // buttonTable
            // 
            this.buttonTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTable.FlatAppearance.BorderSize = 0;
            this.buttonTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTable.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonTable.Location = new System.Drawing.Point(0, 163);
            this.buttonTable.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTable.Name = "buttonTable";
            this.buttonTable.Size = new System.Drawing.Size(180, 49);
            this.buttonTable.TabIndex = 5;
            this.buttonTable.Text = "Информация о столах";
            this.buttonTable.UseVisualStyleBackColor = true;
            this.buttonTable.Click += new System.EventHandler(this.buttonTable_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonExit.Location = new System.Drawing.Point(0, 474);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(180, 49);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonRes
            // 
            this.buttonRes.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRes.FlatAppearance.BorderSize = 0;
            this.buttonRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRes.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonRes.Location = new System.Drawing.Point(0, 114);
            this.buttonRes.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRes.Name = "buttonRes";
            this.buttonRes.Size = new System.Drawing.Size(180, 49);
            this.buttonRes.TabIndex = 3;
            this.buttonRes.Text = "Информация о брони";
            this.buttonRes.UseVisualStyleBackColor = true;
            this.buttonRes.Click += new System.EventHandler(this.buttonRes_Click);
            // 
            // buttonOrder
            // 
            this.buttonOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonOrder.FlatAppearance.BorderSize = 0;
            this.buttonOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOrder.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonOrder.Location = new System.Drawing.Point(0, 65);
            this.buttonOrder.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(180, 49);
            this.buttonOrder.TabIndex = 1;
            this.buttonOrder.Text = "Заказать стол";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // panelBack
            // 
            this.panelBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(104)))), ((int)(((byte)(103)))));
            this.panelBack.Controls.Add(this.button1);
            this.panelBack.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBack.Location = new System.Drawing.Point(0, 0);
            this.panelBack.Margin = new System.Windows.Forms.Padding(2);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(180, 65);
            this.panelBack.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 65);
            this.button1.TabIndex = 8;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 523);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelHello);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(1010, 570);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelBack.ResumeLayout(false);
            this.panelBack.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Panel panelHello;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonRes;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonTable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonVisitors;
    }
}