namespace WindowsFormsApp4
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
            this.btnEndTask = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnRunNew = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnEndTask
            // 
            this.btnEndTask.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEndTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndTask.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEndTask.Location = new System.Drawing.Point(507, 456);
            this.btnEndTask.Name = "btnEndTask";
            this.btnEndTask.Size = new System.Drawing.Size(140, 41);
            this.btnEndTask.TabIndex = 2;
            this.btnEndTask.Text = "END TASK";
            this.btnEndTask.UseVisualStyleBackColor = false;
            this.btnEndTask.Click += new System.EventHandler(this.btnEndTask_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(297, 461);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 41);
            this.button2.TabIndex = 4;
            this.button2.Text = "proprietati";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRunNew
            // 
            this.btnRunNew.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnRunNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRunNew.Location = new System.Drawing.Point(71, 465);
            this.btnRunNew.Name = "btnRunNew";
            this.btnRunNew.Size = new System.Drawing.Size(140, 32);
            this.btnRunNew.TabIndex = 5;
            this.btnRunNew.Text = "RUN TASK";
            this.btnRunNew.UseVisualStyleBackColor = false;
            this.btnRunNew.Click += new System.EventHandler(this.btnRunNew_Click);
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 31;
            this.listBox.Location = new System.Drawing.Point(120, 291);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(502, 159);
            this.listBox.TabIndex = 1;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(120, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(502, 179);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(771, 529);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnRunNew);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnEndTask);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "gestiunare memorii";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEndTask;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnRunNew;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.ListBox listBox1;
    }
}

