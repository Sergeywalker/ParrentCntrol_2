namespace WindowsFormsApp4
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
            this.buttonStopBlack = new System.Windows.Forms.Button();
            this.buttonDellBlack = new System.Windows.Forms.Button();
            this.buttonStartBlack = new System.Windows.Forms.Button();
            this.textBoxWhite = new System.Windows.Forms.TextBox();
            this.buttonWhite = new System.Windows.Forms.Button();
            this.Whitelist = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonStopBlack
            // 
            this.buttonStopBlack.Location = new System.Drawing.Point(71, 314);
            this.buttonStopBlack.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStopBlack.Name = "buttonStopBlack";
            this.buttonStopBlack.Size = new System.Drawing.Size(56, 28);
            this.buttonStopBlack.TabIndex = 6;
            this.buttonStopBlack.Text = "Stop";
            this.buttonStopBlack.UseVisualStyleBackColor = true;
            this.buttonStopBlack.Click += new System.EventHandler(this.buttonStopBlack_Click);
            // 
            // buttonDellBlack
            // 
            this.buttonDellBlack.Location = new System.Drawing.Point(159, 314);
            this.buttonDellBlack.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDellBlack.Name = "buttonDellBlack";
            this.buttonDellBlack.Size = new System.Drawing.Size(51, 28);
            this.buttonDellBlack.TabIndex = 5;
            this.buttonDellBlack.Text = "Dell";
            this.buttonDellBlack.UseVisualStyleBackColor = true;
            // 
            // buttonStartBlack
            // 
            this.buttonStartBlack.Location = new System.Drawing.Point(11, 314);
            this.buttonStartBlack.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStartBlack.Name = "buttonStartBlack";
            this.buttonStartBlack.Size = new System.Drawing.Size(56, 28);
            this.buttonStartBlack.TabIndex = 4;
            this.buttonStartBlack.Text = "Start";
            this.buttonStartBlack.UseVisualStyleBackColor = true;
            // 
            // textBoxWhite
            // 
            this.textBoxWhite.Location = new System.Drawing.Point(13, 50);
            this.textBoxWhite.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxWhite.Name = "textBoxWhite";
            this.textBoxWhite.Size = new System.Drawing.Size(95, 20);
            this.textBoxWhite.TabIndex = 1;
            // 
            // buttonWhite
            // 
            this.buttonWhite.Location = new System.Drawing.Point(154, 50);
            this.buttonWhite.Margin = new System.Windows.Forms.Padding(2);
            this.buttonWhite.Name = "buttonWhite";
            this.buttonWhite.Size = new System.Drawing.Size(56, 20);
            this.buttonWhite.TabIndex = 3;
            this.buttonWhite.Text = "Add";
            this.buttonWhite.UseVisualStyleBackColor = true;
            this.buttonWhite.Click += new System.EventHandler(this.buttonWhite_Click);
            // 
            // Whitelist
            // 
            this.Whitelist.FormattingEnabled = true;
            this.Whitelist.Location = new System.Drawing.Point(11, 85);
            this.Whitelist.Margin = new System.Windows.Forms.Padding(2);
            this.Whitelist.Name = "Whitelist";
            this.Whitelist.Size = new System.Drawing.Size(199, 225);
            this.Whitelist.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 477);
            this.Controls.Add(this.buttonStartBlack);
            this.Controls.Add(this.buttonStopBlack);
            this.Controls.Add(this.buttonDellBlack);
            this.Controls.Add(this.Whitelist);
            this.Controls.Add(this.textBoxWhite);
            this.Controls.Add(this.buttonWhite);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "ParrentControl";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonStartBlack;
        private System.Windows.Forms.Button buttonDellBlack;
        private System.Windows.Forms.Button buttonStopBlack;
        private System.Windows.Forms.TextBox textBoxWhite;
        private System.Windows.Forms.Button buttonWhite;
        private System.Windows.Forms.ListBox Whitelist;
    }
}

