namespace WindowsFormsThreading
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
            this.button1Loop = new System.Windows.Forms.Button();
            this.button2Loop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1Loop
            // 
            this.button1Loop.Location = new System.Drawing.Point(49, 47);
            this.button1Loop.Name = "button1Loop";
            this.button1Loop.Size = new System.Drawing.Size(75, 23);
            this.button1Loop.TabIndex = 0;
            this.button1Loop.Text = "Loop1";
            this.button1Loop.UseVisualStyleBackColor = true;
            this.button1Loop.Click += new System.EventHandler(this.button1Loop_Click);
            // 
            // button2Loop
            // 
            this.button2Loop.Location = new System.Drawing.Point(203, 47);
            this.button2Loop.Name = "button2Loop";
            this.button2Loop.Size = new System.Drawing.Size(75, 23);
            this.button2Loop.TabIndex = 1;
            this.button2Loop.Text = "Loop2";
            this.button2Loop.UseVisualStyleBackColor = true;
            this.button2Loop.Click += new System.EventHandler(this.button2Loop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 398);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2Loop);
            this.Controls.Add(this.button1Loop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1Loop;
        private System.Windows.Forms.Button button2Loop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

