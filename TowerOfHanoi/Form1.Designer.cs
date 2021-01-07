namespace TowerOfHanoi
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
            this.Stack1 = new System.Windows.Forms.ListBox();
            this.Stack2 = new System.Windows.Forms.ListBox();
            this.Stack3 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.NewGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Stack1
            // 
            this.Stack1.FormattingEnabled = true;
            this.Stack1.Location = new System.Drawing.Point(13, 13);
            this.Stack1.Name = "Stack1";
            this.Stack1.Size = new System.Drawing.Size(120, 95);
            this.Stack1.TabIndex = 0;
            // 
            // Stack2
            // 
            this.Stack2.FormattingEnabled = true;
            this.Stack2.Location = new System.Drawing.Point(139, 12);
            this.Stack2.Name = "Stack2";
            this.Stack2.Size = new System.Drawing.Size(120, 95);
            this.Stack2.TabIndex = 1;
            // 
            // Stack3
            // 
            this.Stack3.FormattingEnabled = true;
            this.Stack3.Location = new System.Drawing.Point(265, 12);
            this.Stack3.Name = "Stack3";
            this.Stack3.Size = new System.Drawing.Size(120, 95);
            this.Stack3.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 114);
            this.button1.Name = "1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Pick up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ClickAction);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(139, 114);
            this.button2.Name = "2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Pick up";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ClickAction);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(265, 114);
            this.button3.Name = "3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Pick up";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ClickAction);
            // 
            // NewGameButton
            // 
            this.NewGameButton.Location = new System.Drawing.Point(13, 207);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(75, 23);
            this.NewGameButton.TabIndex = 6;
            this.NewGameButton.Text = "New Game";
            this.NewGameButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 240);
            this.Controls.Add(this.NewGameButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Stack3);
            this.Controls.Add(this.Stack2);
            this.Controls.Add(this.Stack1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Stack1;
        private System.Windows.Forms.ListBox Stack2;
        private System.Windows.Forms.ListBox Stack3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button NewGameButton;
    }
}

