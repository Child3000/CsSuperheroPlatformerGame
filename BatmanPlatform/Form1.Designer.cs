namespace BatmanPlatform
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
            this.components = new System.ComponentModel.Container();
            this.lblScore = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.PictureBox();
            this.p1 = new System.Windows.Forms.PictureBox();
            this.p2 = new System.Windows.Forms.PictureBox();
            this.p3 = new System.Windows.Forms.PictureBox();
            this.p4 = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.displayBatman = new System.Windows.Forms.PictureBox();
            this.displaySuperman = new System.Windows.Forms.PictureBox();
            this.selectBatman = new System.Windows.Forms.Button();
            this.selectSuperman = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayBatman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displaySuperman)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Luckiest Guy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(16, 11);
            this.lblScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(75, 25);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score:";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Location = new System.Drawing.Point(159, 142);
            this.player.Margin = new System.Windows.Forms.Padding(4);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(80, 75);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.Transparent;
            this.p1.Image = global::BatmanPlatform.Properties.Resources.platform;
            this.p1.Location = new System.Drawing.Point(139, 289);
            this.p1.Margin = new System.Windows.Forms.Padding(4);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(364, 34);
            this.p1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p1.TabIndex = 2;
            this.p1.TabStop = false;
            this.p1.Tag = "Platform";
            // 
            // p2
            // 
            this.p2.BackColor = System.Drawing.Color.Transparent;
            this.p2.Image = global::BatmanPlatform.Properties.Resources.platform;
            this.p2.Location = new System.Drawing.Point(655, 289);
            this.p2.Margin = new System.Windows.Forms.Padding(4);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(364, 34);
            this.p2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p2.TabIndex = 3;
            this.p2.TabStop = false;
            this.p2.Tag = "Platform";
            // 
            // p3
            // 
            this.p3.BackColor = System.Drawing.Color.Transparent;
            this.p3.Image = global::BatmanPlatform.Properties.Resources.platform;
            this.p3.Location = new System.Drawing.Point(405, 32);
            this.p3.Margin = new System.Windows.Forms.Padding(4);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(364, 34);
            this.p3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p3.TabIndex = 4;
            this.p3.TabStop = false;
            this.p3.Tag = "Platform";
            // 
            // p4
            // 
            this.p4.BackColor = System.Drawing.Color.Transparent;
            this.p4.Image = global::BatmanPlatform.Properties.Resources.platform;
            this.p4.Location = new System.Drawing.Point(940, 32);
            this.p4.Margin = new System.Windows.Forms.Padding(4);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(364, 34);
            this.p4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p4.TabIndex = 5;
            this.p4.TabStop = false;
            this.p4.Tag = "Platform";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.Game_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(283, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(486, 297);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "HeroSelection";
            // 
            // displayBatman
            // 
            this.displayBatman.BackColor = System.Drawing.SystemColors.Control;
            this.displayBatman.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayBatman.Image = global::BatmanPlatform.Properties.Resources.selectBatman;
            this.displayBatman.Location = new System.Drawing.Point(354, 44);
            this.displayBatman.Name = "displayBatman";
            this.displayBatman.Size = new System.Drawing.Size(140, 132);
            this.displayBatman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.displayBatman.TabIndex = 7;
            this.displayBatman.TabStop = false;
            this.displayBatman.Tag = "HeroSelection";
            // 
            // displaySuperman
            // 
            this.displaySuperman.BackColor = System.Drawing.SystemColors.Control;
            this.displaySuperman.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displaySuperman.Image = global::BatmanPlatform.Properties.Resources.selectSuperman;
            this.displaySuperman.Location = new System.Drawing.Point(548, 44);
            this.displaySuperman.Name = "displaySuperman";
            this.displaySuperman.Size = new System.Drawing.Size(140, 132);
            this.displaySuperman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.displaySuperman.TabIndex = 8;
            this.displaySuperman.TabStop = false;
            this.displaySuperman.Tag = "HeroSelection";
            // 
            // selectBatman
            // 
            this.selectBatman.Font = new System.Drawing.Font("Hobo Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectBatman.Location = new System.Drawing.Point(354, 205);
            this.selectBatman.Name = "selectBatman";
            this.selectBatman.Size = new System.Drawing.Size(125, 41);
            this.selectBatman.TabIndex = 9;
            this.selectBatman.Tag = "HeroSelection";
            this.selectBatman.Text = "Select !";
            this.selectBatman.UseVisualStyleBackColor = true;
            this.selectBatman.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown_Batman);
            this.selectBatman.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp_Batman);
            // 
            // selectSuperman
            // 
            this.selectSuperman.Font = new System.Drawing.Font("Hobo Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectSuperman.Location = new System.Drawing.Point(548, 205);
            this.selectSuperman.Name = "selectSuperman";
            this.selectSuperman.Size = new System.Drawing.Size(125, 41);
            this.selectSuperman.TabIndex = 10;
            this.selectSuperman.Tag = "HeroSelection";
            this.selectSuperman.Text = "Select !";
            this.selectSuperman.UseVisualStyleBackColor = true;
            this.selectSuperman.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown_Superman);
            this.selectSuperman.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp_Superman);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BatmanPlatform.Properties.Resources.city;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1045, 321);
            this.Controls.Add(this.selectSuperman);
            this.Controls.Add(this.selectBatman);
            this.Controls.Add(this.displaySuperman);
            this.Controls.Add(this.displayBatman);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.p4);
            this.Controls.Add(this.p3);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.lblScore);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "GravityRun";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IsKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayBatman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displaySuperman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox p1;
        private System.Windows.Forms.PictureBox p2;
        private System.Windows.Forms.PictureBox p3;
        private System.Windows.Forms.PictureBox p4;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox displayBatman;
        private System.Windows.Forms.PictureBox displaySuperman;
        private System.Windows.Forms.Button selectBatman;
        private System.Windows.Forms.Button selectSuperman;
    }
}

