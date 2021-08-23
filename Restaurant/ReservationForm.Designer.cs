
namespace Restaurant
{
    partial class ReservationForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timeBox = new System.Windows.Forms.ComboBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.chButton = new System.Windows.Forms.Button();
            this.TablesPanel = new System.Windows.Forms.Panel();
            this.panelOrder = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.timeBox);
            this.panel1.Controls.Add(this.datePicker);
            this.panel1.Controls.Add(this.chButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(300, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Время";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(70, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Дата";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timeBox
            // 
            this.timeBox.FormattingEnabled = true;
            this.timeBox.Location = new System.Drawing.Point(370, 35);
            this.timeBox.Margin = new System.Windows.Forms.Padding(2);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(78, 21);
            this.timeBox.TabIndex = 10;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(130, 35);
            this.datePicker.Margin = new System.Windows.Forms.Padding(2);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(151, 20);
            this.datePicker.TabIndex = 9;
            // 
            // chButton
            // 
            this.chButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(53)))), ((int)(((byte)(44)))));
            this.chButton.FlatAppearance.BorderSize = 0;
            this.chButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chButton.ForeColor = System.Drawing.SystemColors.Control;
            this.chButton.Location = new System.Drawing.Point(525, 30);
            this.chButton.Name = "chButton";
            this.chButton.Size = new System.Drawing.Size(230, 31);
            this.chButton.TabIndex = 8;
            this.chButton.Text = "Показать свободные столы";
            this.chButton.UseVisualStyleBackColor = false;
            this.chButton.Click += new System.EventHandler(this.chButton_Click);
            // 
            // TablesPanel
            // 
            this.TablesPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TablesPanel.Location = new System.Drawing.Point(0, 100);
            this.TablesPanel.Name = "TablesPanel";
            this.TablesPanel.Size = new System.Drawing.Size(800, 202);
            this.TablesPanel.TabIndex = 1;
            // 
            // panelOrder
            // 
            this.panelOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrder.Location = new System.Drawing.Point(0, 302);
            this.panelOrder.Name = "panelOrder";
            this.panelOrder.Size = new System.Drawing.Size(800, 148);
            this.panelOrder.TabIndex = 2;
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelOrder);
            this.Controls.Add(this.TablesPanel);
            this.Controls.Add(this.panel1);
            this.Name = "ReservationForm";
            this.Text = "ReservationForm";
            this.Load += new System.EventHandler(this.ReservationForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox timeBox;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button chButton;
        private System.Windows.Forms.Panel TablesPanel;
        private System.Windows.Forms.Panel panelOrder;
    }
}