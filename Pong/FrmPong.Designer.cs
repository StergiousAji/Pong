namespace Pong
{
    partial class FrmPong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPong));
            this.pbPaddleL = new System.Windows.Forms.PictureBox();
            this.pbPaddleR = new System.Windows.Forms.PictureBox();
            this.pbBall = new System.Windows.Forms.PictureBox();
            this.lblScoreL = new System.Windows.Forms.Label();
            this.lblScoreR = new System.Windows.Forms.Label();
            this.tmrGameEngine = new System.Windows.Forms.Timer(this.components);
            this.lblPlay = new System.Windows.Forms.Label();
            this.btnSinglePlayer = new System.Windows.Forms.Button();
            this.btnTwoPlayer = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblRally = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.lblWinner = new System.Windows.Forms.Label();
            this.btnRematch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPaddleL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPaddleR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBall)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPaddleL
            // 
            this.pbPaddleL.BackColor = System.Drawing.Color.White;
            this.pbPaddleL.Location = new System.Drawing.Point(30, 276);
            this.pbPaddleL.Name = "pbPaddleL";
            this.pbPaddleL.Size = new System.Drawing.Size(20, 99);
            this.pbPaddleL.TabIndex = 0;
            this.pbPaddleL.TabStop = false;
            // 
            // pbPaddleR
            // 
            this.pbPaddleR.BackColor = System.Drawing.Color.White;
            this.pbPaddleR.Location = new System.Drawing.Point(955, 276);
            this.pbPaddleR.Name = "pbPaddleR";
            this.pbPaddleR.Size = new System.Drawing.Size(20, 99);
            this.pbPaddleR.TabIndex = 1;
            this.pbPaddleR.TabStop = false;
            // 
            // pbBall
            // 
            this.pbBall.BackColor = System.Drawing.Color.White;
            this.pbBall.Location = new System.Drawing.Point(490, 315);
            this.pbBall.Name = "pbBall";
            this.pbBall.Size = new System.Drawing.Size(20, 20);
            this.pbBall.TabIndex = 2;
            this.pbBall.TabStop = false;
            // 
            // lblScoreL
            // 
            this.lblScoreL.AutoSize = true;
            this.lblScoreL.Font = new System.Drawing.Font("OCR A Extended", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreL.Location = new System.Drawing.Point(330, 5);
            this.lblScoreL.Name = "lblScoreL";
            this.lblScoreL.Size = new System.Drawing.Size(125, 123);
            this.lblScoreL.TabIndex = 3;
            this.lblScoreL.Text = "0";
            // 
            // lblScoreR
            // 
            this.lblScoreR.AutoSize = true;
            this.lblScoreR.Font = new System.Drawing.Font("OCR A Extended", 90F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreR.Location = new System.Drawing.Point(545, 5);
            this.lblScoreR.Name = "lblScoreR";
            this.lblScoreR.Size = new System.Drawing.Size(125, 123);
            this.lblScoreR.TabIndex = 4;
            this.lblScoreR.Text = "0";
            // 
            // tmrGameEngine
            // 
            this.tmrGameEngine.Interval = 1;
            this.tmrGameEngine.Tick += new System.EventHandler(this.TmrGameEngine_Tick);
            // 
            // lblPlay
            // 
            this.lblPlay.AutoSize = true;
            this.lblPlay.Font = new System.Drawing.Font("OCR A Extended", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlay.Location = new System.Drawing.Point(245, 193);
            this.lblPlay.Name = "lblPlay";
            this.lblPlay.Size = new System.Drawing.Size(548, 66);
            this.lblPlay.TabIndex = 5;
            this.lblPlay.Text = "CLICK TO PLAY";
            // 
            // btnSinglePlayer
            // 
            this.btnSinglePlayer.BackColor = System.Drawing.Color.White;
            this.btnSinglePlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSinglePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSinglePlayer.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinglePlayer.ForeColor = System.Drawing.Color.Black;
            this.btnSinglePlayer.Location = new System.Drawing.Point(375, 285);
            this.btnSinglePlayer.Name = "btnSinglePlayer";
            this.btnSinglePlayer.Size = new System.Drawing.Size(250, 50);
            this.btnSinglePlayer.TabIndex = 1;
            this.btnSinglePlayer.Text = "Single Player";
            this.btnSinglePlayer.UseVisualStyleBackColor = false;
            this.btnSinglePlayer.Click += new System.EventHandler(this.BtnSinglePlayer_Click);
            // 
            // btnTwoPlayer
            // 
            this.btnTwoPlayer.BackColor = System.Drawing.Color.White;
            this.btnTwoPlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTwoPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwoPlayer.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwoPlayer.ForeColor = System.Drawing.Color.Black;
            this.btnTwoPlayer.Location = new System.Drawing.Point(375, 367);
            this.btnTwoPlayer.Name = "btnTwoPlayer";
            this.btnTwoPlayer.Size = new System.Drawing.Size(250, 50);
            this.btnTwoPlayer.TabIndex = 2;
            this.btnTwoPlayer.Text = "Two Player";
            this.btnTwoPlayer.UseVisualStyleBackColor = false;
            this.btnTwoPlayer.Click += new System.EventHandler(this.BtnTwoPlayer_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("OCR A Extended", 99.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(311, 54);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(383, 139);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "PONG";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkRed;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(920, 600);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(65, 35);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(920, 600);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(65, 35);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // lblRally
            // 
            this.lblRally.AutoSize = true;
            this.lblRally.Font = new System.Drawing.Font("OCR A Extended", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRally.Location = new System.Drawing.Point(418, 610);
            this.lblRally.Name = "lblRally";
            this.lblRally.Size = new System.Drawing.Size(165, 30);
            this.lblRally.TabIndex = 11;
            this.lblRally.Text = "RALLY: 0";
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.BackgroundImage = global::Pong.Properties.Resources.AdminSettings_Symbol;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.Black;
            this.btnSettings.Location = new System.Drawing.Point(942, 12);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(43, 42);
            this.btnSettings.TabIndex = 12;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("OCR A Extended", 101.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.Location = new System.Drawing.Point(100, 224);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(807, 140);
            this.lblWinner.TabIndex = 13;
            this.lblWinner.Text = "LEFT WINS";
            // 
            // btnRematch
            // 
            this.btnRematch.BackColor = System.Drawing.Color.IndianRed;
            this.btnRematch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRematch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRematch.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRematch.ForeColor = System.Drawing.Color.Black;
            this.btnRematch.Location = new System.Drawing.Point(422, 424);
            this.btnRematch.Name = "btnRematch";
            this.btnRematch.Size = new System.Drawing.Size(161, 50);
            this.btnRematch.TabIndex = 14;
            this.btnRematch.Text = "Rematch";
            this.btnRematch.UseVisualStyleBackColor = false;
            this.btnRematch.Click += new System.EventHandler(this.BtnRematch_Click);
            // 
            // FrmPong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.pbBall);
            this.Controls.Add(this.lblRally);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnTwoPlayer);
            this.Controls.Add(this.btnSinglePlayer);
            this.Controls.Add(this.lblPlay);
            this.Controls.Add(this.lblScoreR);
            this.Controls.Add(this.lblScoreL);
            this.Controls.Add(this.pbPaddleR);
            this.Controls.Add(this.pbPaddleL);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.btnRematch);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong";
            this.Click += new System.EventHandler(this.FrmPong_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPong_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmPong_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbPaddleL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPaddleR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPaddleL;
        private System.Windows.Forms.PictureBox pbPaddleR;
        private System.Windows.Forms.PictureBox pbBall;
        private System.Windows.Forms.Label lblScoreL;
        private System.Windows.Forms.Label lblScoreR;
        private System.Windows.Forms.Timer tmrGameEngine;
        private System.Windows.Forms.Label lblPlay;
        private System.Windows.Forms.Button btnSinglePlayer;
        private System.Windows.Forms.Button btnTwoPlayer;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblRally;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Button btnRematch;
    }
}

