namespace Summitive_greet_card
{
    partial class greetingCardForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.greetTitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(12, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(471, 55);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Hello, It\'s me; Carter!";
            // 
            // greetTitleLabel
            // 
            this.greetTitleLabel.AutoSize = true;
            this.greetTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greetTitleLabel.Location = new System.Drawing.Point(121, 64);
            this.greetTitleLabel.Name = "greetTitleLabel";
            this.greetTitleLabel.Size = new System.Drawing.Size(199, 29);
            this.greetTitleLabel.TabIndex = 1;
            this.greetTitleLabel.Text = "Happy Greetings!";
            // 
            // greetingCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 351);
            this.Controls.Add(this.greetTitleLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "greetingCardForm";
            this.Text = "Hello, I\'m a Greeting Card!";
            this.Click += new System.EventHandler(this.greetingCardForm_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label greetTitleLabel;
    }
}

