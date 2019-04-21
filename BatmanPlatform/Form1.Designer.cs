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
            this.Heart_0 = new System.Windows.Forms.PictureBox();
            this.Heart_1 = new System.Windows.Forms.PictureBox();
            this.Heart_2 = new System.Windows.Forms.PictureBox();
            this.Heart_3 = new System.Windows.Forms.PictureBox();
            this.Heart_4 = new System.Windows.Forms.PictureBox();
            this.displaySpeedy = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.selectWonderWoman = new System.Windows.Forms.Button();
            this.selectCatwoman = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dash = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayBatman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displaySuperman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heart_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heart_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heart_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heart_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heart_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displaySpeedy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
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
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.Transparent;
            this.p1.Image = global::BatmanPlatform.Properties.Resources.platform;
            this.p1.Location = new System.Drawing.Point(102, 268);
            this.p1.Margin = new System.Windows.Forms.Padding(4);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(300, 40);
            this.p1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p1.TabIndex = 2;
            this.p1.TabStop = false;
            this.p1.Tag = "Platform";
            // 
            // p2
            // 
            this.p2.BackColor = System.Drawing.Color.Transparent;
            this.p2.Image = global::BatmanPlatform.Properties.Resources.platform;
            this.p2.Location = new System.Drawing.Point(605, 268);
            this.p2.Margin = new System.Windows.Forms.Padding(4);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(300, 40);
            this.p2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p2.TabIndex = 3;
            this.p2.TabStop = false;
            this.p2.Tag = "Platform";
            // 
            // p3
            // 
            this.p3.BackColor = System.Drawing.Color.Transparent;
            this.p3.Image = global::BatmanPlatform.Properties.Resources.platform;
            this.p3.Location = new System.Drawing.Point(304, 13);
            this.p3.Margin = new System.Windows.Forms.Padding(4);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(300, 40);
            this.p3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p3.TabIndex = 4;
            this.p3.TabStop = false;
            this.p3.Tag = "Platform";
            // 
            // p4
            // 
            this.p4.BackColor = System.Drawing.Color.Transparent;
            this.p4.Image = global::BatmanPlatform.Properties.Resources.platform;
            this.p4.Location = new System.Drawing.Point(789, 11);
            this.p4.Margin = new System.Windows.Forms.Padding(4);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(300, 40);
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
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(21, 293);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(985, 297);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "HeroSelection";
            // 
            // displayBatman
            // 
            this.displayBatman.BackColor = System.Drawing.SystemColors.Control;
            this.displayBatman.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayBatman.Image = global::BatmanPlatform.Properties.Resources.selectBatman;
            this.displayBatman.Location = new System.Drawing.Point(448, 48);
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
            this.displaySuperman.Location = new System.Drawing.Point(642, 48);
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
            this.selectBatman.Location = new System.Drawing.Point(448, 209);
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
            this.selectSuperman.Location = new System.Drawing.Point(642, 209);
            this.selectSuperman.Name = "selectSuperman";
            this.selectSuperman.Size = new System.Drawing.Size(125, 41);
            this.selectSuperman.TabIndex = 10;
            this.selectSuperman.Tag = "HeroSelection";
            this.selectSuperman.Text = "Select !";
            this.selectSuperman.UseVisualStyleBackColor = true;
            this.selectSuperman.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown_Superman);
            this.selectSuperman.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp_Superman);
            // 
            // Heart_0
            // 
            this.Heart_0.BackColor = System.Drawing.Color.Transparent;
            this.Heart_0.Location = new System.Drawing.Point(980, 273);
            this.Heart_0.Name = "Heart_0";
            this.Heart_0.Size = new System.Drawing.Size(46, 36);
            this.Heart_0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Heart_0.TabIndex = 11;
            this.Heart_0.TabStop = false;
            this.Heart_0.Tag = "Heart";
            // 
            // Heart_1
            // 
            this.Heart_1.BackColor = System.Drawing.Color.Transparent;
            this.Heart_1.Location = new System.Drawing.Point(934, 273);
            this.Heart_1.Name = "Heart_1";
            this.Heart_1.Size = new System.Drawing.Size(46, 36);
            this.Heart_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Heart_1.TabIndex = 12;
            this.Heart_1.TabStop = false;
            this.Heart_1.Tag = "Heart";
            // 
            // Heart_2
            // 
            this.Heart_2.BackColor = System.Drawing.Color.Transparent;
            this.Heart_2.Location = new System.Drawing.Point(888, 273);
            this.Heart_2.Name = "Heart_2";
            this.Heart_2.Size = new System.Drawing.Size(46, 36);
            this.Heart_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Heart_2.TabIndex = 13;
            this.Heart_2.TabStop = false;
            this.Heart_2.Tag = "Heart";
            // 
            // Heart_3
            // 
            this.Heart_3.BackColor = System.Drawing.Color.Transparent;
            this.Heart_3.Location = new System.Drawing.Point(842, 272);
            this.Heart_3.Name = "Heart_3";
            this.Heart_3.Size = new System.Drawing.Size(46, 36);
            this.Heart_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Heart_3.TabIndex = 14;
            this.Heart_3.TabStop = false;
            this.Heart_3.Tag = "Heart";
            // 
            // Heart_4
            // 
            this.Heart_4.BackColor = System.Drawing.Color.Transparent;
            this.Heart_4.Location = new System.Drawing.Point(796, 273);
            this.Heart_4.Name = "Heart_4";
            this.Heart_4.Size = new System.Drawing.Size(46, 36);
            this.Heart_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Heart_4.TabIndex = 15;
            this.Heart_4.TabStop = false;
            this.Heart_4.Tag = "Heart";
            // 
            // displaySpeedy
            // 
            this.displaySpeedy.BackColor = System.Drawing.SystemColors.Control;
            this.displaySpeedy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displaySpeedy.Image = global::BatmanPlatform.Properties.Resources.selectSpeedy;
            this.displaySpeedy.Location = new System.Drawing.Point(818, 48);
            this.displaySpeedy.Name = "displaySpeedy";
            this.displaySpeedy.Size = new System.Drawing.Size(140, 132);
            this.displaySpeedy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.displaySpeedy.TabIndex = 16;
            this.displaySpeedy.TabStop = false;
            this.displaySpeedy.Tag = "HeroSelection";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Hobo Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(818, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 41);
            this.button1.TabIndex = 17;
            this.button1.Tag = "HeroSelection";
            this.button1.Text = "Select !";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown_Speedy);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp_Speedy);
            // 
            // selectWonderWoman
            // 
            this.selectWonderWoman.Font = new System.Drawing.Font("Hobo Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectWonderWoman.Location = new System.Drawing.Point(251, 208);
            this.selectWonderWoman.Name = "selectWonderWoman";
            this.selectWonderWoman.Size = new System.Drawing.Size(125, 41);
            this.selectWonderWoman.TabIndex = 18;
            this.selectWonderWoman.Tag = "HeroSelection";
            this.selectWonderWoman.Text = "Select !";
            this.selectWonderWoman.UseVisualStyleBackColor = true;
            this.selectWonderWoman.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown_WonderWoman);
            this.selectWonderWoman.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp_WonderWoman);
            // 
            // selectCatwoman
            // 
            this.selectCatwoman.Font = new System.Drawing.Font("Hobo Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectCatwoman.Location = new System.Drawing.Point(66, 208);
            this.selectCatwoman.Name = "selectCatwoman";
            this.selectCatwoman.Size = new System.Drawing.Size(125, 41);
            this.selectCatwoman.TabIndex = 19;
            this.selectCatwoman.Tag = "HeroSelection";
            this.selectCatwoman.Text = "Select !";
            this.selectCatwoman.UseVisualStyleBackColor = true;
            this.selectCatwoman.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown_Catwoman);
            this.selectCatwoman.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp_Catwoman);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = global::BatmanPlatform.Properties.Resources.selectWonderWoman;
            this.pictureBox2.Location = new System.Drawing.Point(251, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(140, 132);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "HeroSelection";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Image = global::BatmanPlatform.Properties.Resources.selectCatwoman;
            this.pictureBox3.Location = new System.Drawing.Point(66, 48);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(140, 132);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "HeroSelection";
            // 
            // dash
            // 
            this.dash.BackColor = System.Drawing.Color.Transparent;
            this.dash.Location = new System.Drawing.Point(41, 145);
            this.dash.Name = "dash";
            this.dash.Size = new System.Drawing.Size(105, 71);
            this.dash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dash.TabIndex = 23;
            this.dash.TabStop = false;
            this.dash.Visible = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Location = new System.Drawing.Point(119, 128);
            this.player.Margin = new System.Windows.Forms.Padding(4);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(80, 75);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 24;
            this.player.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::BatmanPlatform.Properties.Resources.SkeletonSwordAttack;
            this.pictureBox4.Location = new System.Drawing.Point(930, 128);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 60);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "Enemy";
            this.pictureBox4.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BatmanPlatform.Properties.Resources.city;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1045, 321);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.selectCatwoman);
            this.Controls.Add(this.selectWonderWoman);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.displaySpeedy);
            this.Controls.Add(this.Heart_4);
            this.Controls.Add(this.Heart_3);
            this.Controls.Add(this.Heart_2);
            this.Controls.Add(this.Heart_1);
            this.Controls.Add(this.Heart_0);
            this.Controls.Add(this.selectSuperman);
            this.Controls.Add(this.selectBatman);
            this.Controls.Add(this.displaySuperman);
            this.Controls.Add(this.displayBatman);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.p4);
            this.Controls.Add(this.p3);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.player);
            this.Controls.Add(this.dash);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "GravityRun";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IsKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.p1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayBatman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displaySuperman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heart_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heart_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heart_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heart_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heart_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displaySpeedy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
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
        private System.Windows.Forms.PictureBox Heart_0;
        private System.Windows.Forms.PictureBox Heart_1;
        private System.Windows.Forms.PictureBox Heart_2;
        private System.Windows.Forms.PictureBox Heart_3;
        private System.Windows.Forms.PictureBox Heart_4;
        private System.Windows.Forms.PictureBox displaySpeedy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button selectWonderWoman;
        private System.Windows.Forms.Button selectCatwoman;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox dash;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

