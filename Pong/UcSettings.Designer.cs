namespace Pong
{
    partial class UcSettings
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
            lblPaddleSpeed = new System.Windows.Forms.Label();
            nupPaddleSpeed = new System.Windows.Forms.NumericUpDown();
            nupBallSpeed = new System.Windows.Forms.NumericUpDown();
            lblBallSpeed = new System.Windows.Forms.Label();
            lblMaxScore = new System.Windows.Forms.Label();
            nupMaxScore = new System.Windows.Forms.NumericUpDown();
            chbRallyCounter = new System.Windows.Forms.CheckBox();
            chbMaxScore = new System.Windows.Forms.CheckBox();
            lblSinglePlayerRNG = new System.Windows.Forms.Label();
            nupSinglePlayerRNG = new System.Windows.Forms.NumericUpDown();
            lblSPRNGInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(nupPaddleSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(nupBallSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(nupMaxScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(nupSinglePlayerRNG)).BeginInit();
            SuspendLayout();
            // 
            // lblPaddleSpeed
            // 
            lblPaddleSpeed.AutoSize = true;
            lblPaddleSpeed.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPaddleSpeed.ForeColor = System.Drawing.Color.White;
            lblPaddleSpeed.Location = new System.Drawing.Point(56, 40);
            lblPaddleSpeed.Name = "lblPaddleSpeed";
            lblPaddleSpeed.Size = new System.Drawing.Size(221, 29);
            lblPaddleSpeed.TabIndex = 6;
            lblPaddleSpeed.Text = "Paddle Speed:";
            // 
            // nupPaddleSpeed
            // 
            nupPaddleSpeed.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nupPaddleSpeed.Location = new System.Drawing.Point(381, 36);
            nupPaddleSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            nupPaddleSpeed.Name = "nupPaddleSpeed";
            nupPaddleSpeed.Size = new System.Drawing.Size(65, 35);
            nupPaddleSpeed.TabIndex = 1;
            nupPaddleSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            nupPaddleSpeed.ValueChanged += new System.EventHandler(NupPaddleSpeed_ValueChanged);
            // 
            // nupBallSpeed
            // 
            nupBallSpeed.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nupBallSpeed.Location = new System.Drawing.Point(381, 115);
            nupBallSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            nupBallSpeed.Name = "nupBallSpeed";
            nupBallSpeed.Size = new System.Drawing.Size(65, 35);
            nupBallSpeed.TabIndex = 2;
            nupBallSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            nupBallSpeed.ValueChanged += new System.EventHandler(NupBallSpeed_ValueChanged);
            // 
            // lblBallSpeed
            // 
            lblBallSpeed.AutoSize = true;
            lblBallSpeed.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblBallSpeed.ForeColor = System.Drawing.Color.White;
            lblBallSpeed.Location = new System.Drawing.Point(56, 119);
            lblBallSpeed.Name = "lblBallSpeed";
            lblBallSpeed.Size = new System.Drawing.Size(189, 29);
            lblBallSpeed.TabIndex = 8;
            lblBallSpeed.Text = "Ball Speed:";
            // 
            // lblMaxScore
            // 
            lblMaxScore.AutoSize = true;
            lblMaxScore.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblMaxScore.ForeColor = System.Drawing.Color.White;
            lblMaxScore.Location = new System.Drawing.Point(56, 316);
            lblMaxScore.Name = "lblMaxScore";
            lblMaxScore.Size = new System.Drawing.Size(173, 29);
            lblMaxScore.TabIndex = 9;
            lblMaxScore.Text = "Max Score:";
            lblMaxScore.Visible = false;
            // 
            // nupMaxScore
            // 
            nupMaxScore.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nupMaxScore.Location = new System.Drawing.Point(381, 310);
            nupMaxScore.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            nupMaxScore.Name = "nupMaxScore";
            nupMaxScore.Size = new System.Drawing.Size(65, 35);
            nupMaxScore.TabIndex = 4;
            nupMaxScore.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            nupMaxScore.Visible = false;
            nupMaxScore.ValueChanged += new System.EventHandler(NupMaxScore_ValueChanged);
            // 
            // chbRallyCounter
            // 
            chbRallyCounter.AutoSize = true;
            chbRallyCounter.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            chbRallyCounter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chbRallyCounter.Font = new System.Drawing.Font("OCR A Extended", 19F);
            chbRallyCounter.ForeColor = System.Drawing.Color.White;
            chbRallyCounter.Location = new System.Drawing.Point(53, 395);
            chbRallyCounter.Name = "chbRallyCounter";
            chbRallyCounter.Size = new System.Drawing.Size(349, 33);
            chbRallyCounter.TabIndex = 5;
            chbRallyCounter.Text = "Enable Rally Counter";
            chbRallyCounter.UseVisualStyleBackColor = true;
            chbRallyCounter.CheckStateChanged += new System.EventHandler(ChbRallyCounter_CheckStateChanged);
            // 
            // chbMaxScore
            // 
            chbMaxScore.AutoSize = true;
            chbMaxScore.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            chbMaxScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chbMaxScore.Font = new System.Drawing.Font("OCR A Extended", 19F);
            chbMaxScore.ForeColor = System.Drawing.Color.White;
            chbMaxScore.Location = new System.Drawing.Point(53, 266);
            chbMaxScore.Name = "chbMaxScore";
            chbMaxScore.Size = new System.Drawing.Size(285, 33);
            chbMaxScore.TabIndex = 3;
            chbMaxScore.Text = "Enable Max Score";
            chbMaxScore.UseVisualStyleBackColor = true;
            chbMaxScore.CheckStateChanged += new System.EventHandler(ChbMaxScore_CheckStateChanged);
            // 
            // lblSinglePlayerRNG
            // 
            lblSinglePlayerRNG.AutoSize = true;
            lblSinglePlayerRNG.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblSinglePlayerRNG.ForeColor = System.Drawing.Color.White;
            lblSinglePlayerRNG.Location = new System.Drawing.Point(56, 191);
            lblSinglePlayerRNG.Name = "lblSinglePlayerRNG";
            lblSinglePlayerRNG.Size = new System.Drawing.Size(317, 29);
            lblSinglePlayerRNG.TabIndex = 10;
            lblSinglePlayerRNG.Text = "Single-Player RNG: ";
            // 
            // nupSinglePlayerRNG
            // 
            nupSinglePlayerRNG.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nupSinglePlayerRNG.Location = new System.Drawing.Point(381, 188);
            nupSinglePlayerRNG.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            nupSinglePlayerRNG.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            nupSinglePlayerRNG.Name = "nupSinglePlayerRNG";
            nupSinglePlayerRNG.Size = new System.Drawing.Size(65, 35);
            nupSinglePlayerRNG.TabIndex = 11;
            nupSinglePlayerRNG.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            nupSinglePlayerRNG.ValueChanged += new System.EventHandler(NUPSinglePlayerRNG_ValueChanged);
            // 
            // lblSPRNGInfo
            // 
            lblSPRNGInfo.AutoSize = true;
            lblSPRNGInfo.BackColor = System.Drawing.Color.Black;
            lblSPRNGInfo.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblSPRNGInfo.ForeColor = System.Drawing.Color.White;
            lblSPRNGInfo.Location = new System.Drawing.Point(103, 223);
            lblSPRNGInfo.Name = "lblSPRNGInfo";
            lblSPRNGInfo.Size = new System.Drawing.Size(189, 13);
            lblSPRNGInfo.TabIndex = 13;
            lblSPRNGInfo.Text = "(Low RNG = Low Difficulty)";
            // 
            // UcSettings
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            Controls.Add(lblSPRNGInfo);
            Controls.Add(nupSinglePlayerRNG);
            Controls.Add(lblSinglePlayerRNG);
            Controls.Add(chbMaxScore);
            Controls.Add(chbRallyCounter);
            Controls.Add(nupMaxScore);
            Controls.Add(lblMaxScore);
            Controls.Add(nupBallSpeed);
            Controls.Add(lblBallSpeed);
            Controls.Add(nupPaddleSpeed);
            Controls.Add(lblPaddleSpeed);
            Name = "UcSettings";
            Size = new System.Drawing.Size(510, 510);
            ((System.ComponentModel.ISupportInitialize)(nupPaddleSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(nupBallSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(nupMaxScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(nupSinglePlayerRNG)).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSPRNGInfo;
        public static System.Windows.Forms.Label lblSinglePlayerRNG;
        public static System.Windows.Forms.NumericUpDown nupSinglePlayerRNG;
        public static System.Windows.Forms.CheckBox chbMaxScore;
        public static System.Windows.Forms.Label lblPaddleSpeed;
        public static System.Windows.Forms.NumericUpDown nupPaddleSpeed;
        public static System.Windows.Forms.NumericUpDown nupBallSpeed;
        public static System.Windows.Forms.Label lblBallSpeed;
        public static System.Windows.Forms.Label lblMaxScore;
        public static System.Windows.Forms.NumericUpDown nupMaxScore;
        public static System.Windows.Forms.CheckBox chbRallyCounter;
    }
}
