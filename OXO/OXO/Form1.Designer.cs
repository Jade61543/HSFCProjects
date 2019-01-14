namespace OXO
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
            this.player1 = new System.Windows.Forms.TextBox();
            this.p1Name = new System.Windows.Forms.Label();
            this.p2Name = new System.Windows.Forms.Label();
            this.player2 = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // player1
            // 
            this.player1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1.Location = new System.Drawing.Point(249, 88);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(100, 22);
            this.player1.TabIndex = 0;
            // 
            // p1Name
            // 
            this.p1Name.AutoSize = true;
            this.p1Name.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1Name.Location = new System.Drawing.Point(90, 89);
            this.p1Name.Name = "p1Name";
            this.p1Name.Size = new System.Drawing.Size(67, 16);
            this.p1Name.TabIndex = 1;
            this.p1Name.Text = "Player 1";
            // 
            // p2Name
            // 
            this.p2Name.AutoSize = true;
            this.p2Name.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2Name.Location = new System.Drawing.Point(89, 195);
            this.p2Name.Name = "p2Name";
            this.p2Name.Size = new System.Drawing.Size(67, 16);
            this.p2Name.TabIndex = 2;
            this.p2Name.Text = "Player 2";
            // 
            // player2
            // 
            this.player2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2.Location = new System.Drawing.Point(249, 194);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(100, 22);
            this.player2.TabIndex = 3;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(188, 289);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(96, 34);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 434);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.p2Name);
            this.Controls.Add(this.p1Name);
            this.Controls.Add(this.player1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox player1;
        private System.Windows.Forms.Label p1Name;
        private System.Windows.Forms.Label p2Name;
        private System.Windows.Forms.TextBox player2;
        private System.Windows.Forms.Button startButton;
    }
}

