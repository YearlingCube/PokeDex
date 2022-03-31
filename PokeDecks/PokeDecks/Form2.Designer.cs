namespace PokeDecks
{
    partial class Form2
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
            System.Windows.Forms.Button BackButton;
            this.label5 = new System.Windows.Forms.Label();
            this.PokeHPTextbox = new System.Windows.Forms.TextBox();
            this.PokeAbilityTextbox = new System.Windows.Forms.TextBox();
            this.PokeTypeTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PokeDescriptionTextbox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PokePicture = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.PokeNameTextbox = new System.Windows.Forms.TextBox();
            this.PokeNumber = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            BackButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PokePicture)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BackButton.Location = new System.Drawing.Point(219, 359);
            BackButton.Name = "BackButton";
            BackButton.Size = new System.Drawing.Size(75, 23);
            BackButton.TabIndex = 30;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(542, 173);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Description:";
            // 
            // PokeHPTextbox
            // 
            this.PokeHPTextbox.Location = new System.Drawing.Point(878, 125);
            this.PokeHPTextbox.Name = "PokeHPTextbox";
            this.PokeHPTextbox.ReadOnly = true;
            this.PokeHPTextbox.Size = new System.Drawing.Size(100, 20);
            this.PokeHPTextbox.TabIndex = 25;
            // 
            // PokeAbilityTextbox
            // 
            this.PokeAbilityTextbox.Location = new System.Drawing.Point(772, 125);
            this.PokeAbilityTextbox.Name = "PokeAbilityTextbox";
            this.PokeAbilityTextbox.ReadOnly = true;
            this.PokeAbilityTextbox.Size = new System.Drawing.Size(100, 20);
            this.PokeAbilityTextbox.TabIndex = 24;
            // 
            // PokeTypeTextbox
            // 
            this.PokeTypeTextbox.Location = new System.Drawing.Point(654, 125);
            this.PokeTypeTextbox.Name = "PokeTypeTextbox";
            this.PokeTypeTextbox.ReadOnly = true;
            this.PokeTypeTextbox.Size = new System.Drawing.Size(100, 20);
            this.PokeTypeTextbox.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(912, 93);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "HP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(787, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ability:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(672, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(555, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Name:";
            // 
            // PokeDescriptionTextbox
            // 
            this.PokeDescriptionTextbox.Location = new System.Drawing.Point(546, 196);
            this.PokeDescriptionTextbox.Multiline = true;
            this.PokeDescriptionTextbox.Name = "PokeDescriptionTextbox";
            this.PokeDescriptionTextbox.ReadOnly = true;
            this.PokeDescriptionTextbox.Size = new System.Drawing.Size(337, 128);
            this.PokeDescriptionTextbox.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::PokeDecks.Properties.Resources.PokeDexImage;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 693);
            this.panel2.TabIndex = 28;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(199, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(802, 630);
            this.panel4.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::PokeDecks.Properties.Resources.PokeDexTitleImage;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(199, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 64);
            this.panel1.TabIndex = 27;
            // 
            // PokePicture
            // 
            this.PokePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PokePicture.Location = new System.Drawing.Point(219, 93);
            this.PokePicture.Name = "PokePicture";
            this.PokePicture.Size = new System.Drawing.Size(310, 260);
            this.PokePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PokePicture.TabIndex = 21;
            this.PokePicture.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::PokeDecks.Properties.Resources.PokeDexImage;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(998, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(190, 693);
            this.panel3.TabIndex = 29;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(199, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(802, 630);
            this.panel5.TabIndex = 14;
            // 
            // PokeNameTextbox
            // 
            this.PokeNameTextbox.Location = new System.Drawing.Point(535, 125);
            this.PokeNameTextbox.Name = "PokeNameTextbox";
            this.PokeNameTextbox.ReadOnly = true;
            this.PokeNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.PokeNameTextbox.TabIndex = 31;
            // 
            // PokeNumber
            // 
            this.PokeNumber.AutoSize = true;
            this.PokeNumber.Location = new System.Drawing.Point(219, 71);
            this.PokeNumber.Name = "PokeNumber";
            this.PokeNumber.Size = new System.Drawing.Size(35, 13);
            this.PokeNumber.TabIndex = 32;
            this.PokeNumber.Text = "label6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "#";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 689);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PokeNumber);
            this.Controls.Add(BackButton);
            this.Controls.Add(this.PokeNameTextbox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PokeHPTextbox);
            this.Controls.Add(this.PokeAbilityTextbox);
            this.Controls.Add(this.PokeTypeTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PokeDescriptionTextbox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PokePicture);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PokePicture)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PokeHPTextbox;
        private System.Windows.Forms.TextBox PokeAbilityTextbox;
        private System.Windows.Forms.TextBox PokeTypeTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PokeDescriptionTextbox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PokePicture;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox PokeNameTextbox;
        private System.Windows.Forms.Label PokeNumber;
        private System.Windows.Forms.Label label6;
    }
}