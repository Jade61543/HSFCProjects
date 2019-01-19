namespace OneArmedBandit
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
            this.spinButton = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nudgeB1 = new System.Windows.Forms.Button();
            this.nudgeB2 = new System.Windows.Forms.Button();
            this.nudgeB3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // spinButton
            // 
            this.spinButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.spinButton.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.spinButton.Location = new System.Drawing.Point(880, 504);
            this.spinButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.spinButton.Name = "spinButton";
            this.spinButton.Size = new System.Drawing.Size(140, 52);
            this.spinButton.TabIndex = 3;
            this.spinButton.Text = "SPIN";
            this.spinButton.UseVisualStyleBackColor = false;
            this.spinButton.Click += new System.EventHandler(this.spinButton_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(780, 106);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(240, 223);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(446, 106);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(240, 223);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(94, 106);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 223);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // nudgeB1
            // 
            this.nudgeB1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudgeB1.Location = new System.Drawing.Point(94, 377);
            this.nudgeB1.Name = "nudgeB1";
            this.nudgeB1.Size = new System.Drawing.Size(240, 44);
            this.nudgeB1.TabIndex = 4;
            this.nudgeB1.Text = "Nudge";
            this.nudgeB1.UseVisualStyleBackColor = true;
            this.nudgeB1.Click += new System.EventHandler(this.nudgeB1_Click);
            // 
            // nudgeB2
            // 
            this.nudgeB2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudgeB2.Location = new System.Drawing.Point(446, 377);
            this.nudgeB2.Name = "nudgeB2";
            this.nudgeB2.Size = new System.Drawing.Size(240, 44);
            this.nudgeB2.TabIndex = 5;
            this.nudgeB2.Text = "Nudge";
            this.nudgeB2.UseVisualStyleBackColor = true;
            this.nudgeB2.Click += new System.EventHandler(this.nudgeB2_Click);
            // 
            // nudgeB3
            // 
            this.nudgeB3.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudgeB3.Location = new System.Drawing.Point(780, 377);
            this.nudgeB3.Name = "nudgeB3";
            this.nudgeB3.Size = new System.Drawing.Size(240, 44);
            this.nudgeB3.TabIndex = 6;
            this.nudgeB3.Text = "Nudge";
            this.nudgeB3.UseVisualStyleBackColor = true;
            this.nudgeB3.Click += new System.EventHandler(this.nudgeB3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.nudgeB3);
            this.Controls.Add(this.nudgeB2);
            this.Controls.Add(this.nudgeB1);
            this.Controls.Add(this.spinButton);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button spinButton;
        private System.Windows.Forms.Button nudgeB1;
        private System.Windows.Forms.Button nudgeB2;
        private System.Windows.Forms.Button nudgeB3;
    }
}

