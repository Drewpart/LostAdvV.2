namespace LostAdvV._2
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
            this.outputLabel = new System.Windows.Forms.Label();
            this.opt1Button = new System.Windows.Forms.Button();
            this.opt2Button = new System.Windows.Forms.Button();
            this.option1Label = new System.Windows.Forms.Label();
            this.option2Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(-1, 9);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(489, 186);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Text = "You\'re at a abandoned house";
            // 
            // opt1Button
            // 
            this.opt1Button.Location = new System.Drawing.Point(69, 267);
            this.opt1Button.Name = "opt1Button";
            this.opt1Button.Size = new System.Drawing.Size(75, 22);
            this.opt1Button.TabIndex = 2;
            this.opt1Button.Text = "-->";
            this.opt1Button.UseVisualStyleBackColor = true;
            this.opt1Button.Click += new System.EventHandler(this.opt1Button_Click);
            // 
            // opt2Button
            // 
            this.opt2Button.Location = new System.Drawing.Point(69, 377);
            this.opt2Button.Name = "opt2Button";
            this.opt2Button.Size = new System.Drawing.Size(75, 23);
            this.opt2Button.TabIndex = 3;
            this.opt2Button.Text = "-->";
            this.opt2Button.UseVisualStyleBackColor = true;
            this.opt2Button.Click += new System.EventHandler(this.opt2Button_Click);
            // 
            // option1Label
            // 
            this.option1Label.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1Label.Location = new System.Drawing.Point(150, 267);
            this.option1Label.Name = "option1Label";
            this.option1Label.Size = new System.Drawing.Size(133, 23);
            this.option1Label.TabIndex = 4;
            this.option1Label.Text = "Leave";
            // 
            // option2Label
            // 
            this.option2Label.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2Label.Location = new System.Drawing.Point(150, 377);
            this.option2Label.Name = "option2Label";
            this.option2Label.Size = new System.Drawing.Size(133, 23);
            this.option2Label.TabIndex = 5;
            this.option2Label.Text = "Go in";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.BackgroundImage = global::LostAdvV._2.Properties.Resources.abandoned_house;
            this.ClientSize = new System.Drawing.Size(1049, 664);
            this.Controls.Add(this.option2Label);
            this.Controls.Add(this.option1Label);
            this.Controls.Add(this.opt2Button);
            this.Controls.Add(this.opt1Button);
            this.Controls.Add(this.outputLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Abandoned House";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button opt1Button;
        private System.Windows.Forms.Button opt2Button;
        private System.Windows.Forms.Label option1Label;
        private System.Windows.Forms.Label option2Label;
    }
}

