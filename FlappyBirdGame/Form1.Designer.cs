namespace FlappyBirdGame
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.floor = new System.Windows.Forms.PictureBox();
            this.block1 = new System.Windows.Forms.PictureBox();
            this.block2 = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.floor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            this.SuspendLayout();
            // 
            // floor
            // 
            this.floor.Image = ((System.Drawing.Image)(resources.GetObject("floor.Image")));
            this.floor.Location = new System.Drawing.Point(-2, 394);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(613, 73);
            this.floor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.floor.TabIndex = 1;
            this.floor.TabStop = false;
            // 
            // block1
            // 
            this.block1.Image = ((System.Drawing.Image)(resources.GetObject("block1.Image")));
            this.block1.Location = new System.Drawing.Point(311, -1);
            this.block1.Name = "block1";
            this.block1.Size = new System.Drawing.Size(67, 70);
            this.block1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.block1.TabIndex = 2;
            this.block1.TabStop = false;
            // 
            // block2
            // 
            this.block2.Image = ((System.Drawing.Image)(resources.GetObject("block2.Image")));
            this.block2.Location = new System.Drawing.Point(347, 307);
            this.block2.Name = "block2";
            this.block2.Size = new System.Drawing.Size(67, 89);
            this.block2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.block2.TabIndex = 3;
            this.block2.TabStop = false;
            // 
            // bird
            // 
            this.bird.Image = ((System.Drawing.Image)(resources.GetObject("bird.Image")));
            this.bird.Location = new System.Drawing.Point(32, 163);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(61, 56);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 4;
            this.bird.TabStop = false;
            this.bird.Click += new System.EventHandler(this.bird_Click);
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.Transparent;
            this.scoreText.Font = new System.Drawing.Font("Unispace", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scoreText.ForeColor = System.Drawing.Color.White;
            this.scoreText.Location = new System.Drawing.Point(169, 93);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(39, 42);
            this.scoreText.TabIndex = 5;
            this.scoreText.Text = "0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(457, 465);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.block2);
            this.Controls.Add(this.block1);
            this.Controls.Add(this.floor);
            this.Name = "Form1";
            this.Text = "FlappyBirdGame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.floor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox floor;
        private System.Windows.Forms.PictureBox block1;
        private System.Windows.Forms.PictureBox block2;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
    }
}

