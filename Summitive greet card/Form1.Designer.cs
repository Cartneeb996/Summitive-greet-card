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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(greetingCardForm));
            this.nameLabel = new System.Windows.Forms.Label();
            this.greetTitleLabel = new System.Windows.Forms.Label();
            this.skipButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.Green;
            this.nameLabel.Location = new System.Drawing.Point(36, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(471, 55);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Hello, It\'s me; Carter!";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nameLabel.Visible = false;
            // 
            // greetTitleLabel
            // 
            this.greetTitleLabel.AutoSize = true;
            this.greetTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.greetTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greetTitleLabel.ForeColor = System.Drawing.Color.Red;
            this.greetTitleLabel.Location = new System.Drawing.Point(41, 64);
            this.greetTitleLabel.Name = "greetTitleLabel";
            this.greetTitleLabel.Size = new System.Drawing.Size(199, 29);
            this.greetTitleLabel.TabIndex = 1;
            this.greetTitleLabel.Text = "Happy Greetings!";
            this.greetTitleLabel.Visible = false;
            // 
            // skipButton
            // 
            this.skipButton.BackColor = System.Drawing.Color.Black;
            this.skipButton.FlatAppearance.BorderSize = 0;
            this.skipButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.skipButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skipButton.ForeColor = System.Drawing.Color.White;
            this.skipButton.Location = new System.Drawing.Point(46, 273);
            this.skipButton.Name = "skipButton";
            this.skipButton.Size = new System.Drawing.Size(121, 23);
            this.skipButton.TabIndex = 2;
            this.skipButton.Text = "Click to skip animation";
            this.skipButton.UseVisualStyleBackColor = false;
            // 
            // greetingCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Summitive_greet_card.Properties.Resources.gemini;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(563, 350);
            this.Controls.Add(this.skipButton);
            this.Controls.Add(this.greetTitleLabel);
            this.Controls.Add(this.nameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "greetingCardForm";
            this.Text = "Hello, I\'m a Greeting Card!";
            this.Click += new System.EventHandler(this.greetingCardForm_Click);
            this.MouseLeave += new System.EventHandler(this.greetingCardForm_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label greetTitleLabel;
        private System.Windows.Forms.Button skipButton;
    }
}

