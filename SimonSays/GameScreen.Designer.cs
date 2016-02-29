namespace SimonSays
{
    partial class GameScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.Gainsboro;
            this.Button1.Location = new System.Drawing.Point(3, 3);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(340, 340);
            this.Button1.TabIndex = 1;
            this.Button1.Tag = "1";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.Gainsboro;
            this.Button2.Location = new System.Drawing.Point(357, 3);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(340, 340);
            this.Button2.TabIndex = 2;
            this.Button2.Tag = "2";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.Color.Gainsboro;
            this.Button3.Location = new System.Drawing.Point(3, 357);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(340, 340);
            this.Button3.TabIndex = 3;
            this.Button3.Tag = "3";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button4
            // 
            this.Button4.BackColor = System.Drawing.Color.Gainsboro;
            this.Button4.Location = new System.Drawing.Point(357, 357);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(340, 340);
            this.Button4.TabIndex = 4;
            this.Button4.Tag = "4";
            this.Button4.UseVisualStyleBackColor = false;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(700, 700);
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button Button4;
    }
}
