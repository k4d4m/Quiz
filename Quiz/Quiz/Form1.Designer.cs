namespace Quiz
{
    partial class FormQuiz
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
            this.pnMenu = new System.Windows.Forms.Panel();
            this.lbTopicCount = new System.Windows.Forms.Label();
            this.numTopic = new System.Windows.Forms.NumericUpDown();
            this.btnPlay = new System.Windows.Forms.Button();
            this.pnGame = new System.Windows.Forms.Panel();
            this.lbQuestion = new System.Windows.Forms.Label();
            this.lbTopic = new System.Windows.Forms.Label();
            this.btnD = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTopic)).BeginInit();
            this.pnGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnMenu.Controls.Add(this.lbTopicCount);
            this.pnMenu.Controls.Add(this.numTopic);
            this.pnMenu.Controls.Add(this.btnPlay);
            this.pnMenu.Location = new System.Drawing.Point(12, 12);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(262, 100);
            this.pnMenu.TabIndex = 0;
            // 
            // lbTopicCount
            // 
            this.lbTopicCount.AutoSize = true;
            this.lbTopicCount.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTopicCount.Location = new System.Drawing.Point(42, 76);
            this.lbTopicCount.Name = "lbTopicCount";
            this.lbTopicCount.Size = new System.Drawing.Size(34, 13);
            this.lbTopicCount.TabIndex = 7;
            this.lbTopicCount.Text = "Topic";
            // 
            // numTopic
            // 
            this.numTopic.Location = new System.Drawing.Point(3, 73);
            this.numTopic.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numTopic.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTopic.Name = "numTopic";
            this.numTopic.Size = new System.Drawing.Size(37, 20);
            this.numTopic.TabIndex = 1;
            this.numTopic.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTopic.ValueChanged += new System.EventHandler(this.numTopic_ValueChanged);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.White;
            this.btnPlay.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(3, 3);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(256, 64);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // pnGame
            // 
            this.pnGame.BackColor = System.Drawing.Color.Transparent;
            this.pnGame.Controls.Add(this.lbQuestion);
            this.pnGame.Controls.Add(this.lbTopic);
            this.pnGame.Controls.Add(this.btnD);
            this.pnGame.Controls.Add(this.btnC);
            this.pnGame.Controls.Add(this.btnB);
            this.pnGame.Controls.Add(this.btnA);
            this.pnGame.Location = new System.Drawing.Point(367, 271);
            this.pnGame.Name = "pnGame";
            this.pnGame.Size = new System.Drawing.Size(524, 200);
            this.pnGame.TabIndex = 2;
            this.pnGame.Visible = false;
            // 
            // lbQuestion
            // 
            this.lbQuestion.AutoSize = true;
            this.lbQuestion.BackColor = System.Drawing.Color.White;
            this.lbQuestion.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuestion.Location = new System.Drawing.Point(3, 30);
            this.lbQuestion.Name = "lbQuestion";
            this.lbQuestion.Size = new System.Drawing.Size(97, 30);
            this.lbQuestion.TabIndex = 6;
            this.lbQuestion.Text = "Question";
            // 
            // lbTopic
            // 
            this.lbTopic.AutoSize = true;
            this.lbTopic.BackColor = System.Drawing.Color.White;
            this.lbTopic.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTopic.Location = new System.Drawing.Point(3, 0);
            this.lbTopic.Name = "lbTopic";
            this.lbTopic.Size = new System.Drawing.Size(61, 30);
            this.lbTopic.TabIndex = 5;
            this.lbTopic.Text = "Topic";
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.Color.White;
            this.btnD.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD.Location = new System.Drawing.Point(265, 133);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(256, 64);
            this.btnD.TabIndex = 4;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = false;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.White;
            this.btnC.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(3, 133);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(256, 64);
            this.btnC.TabIndex = 3;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.Color.White;
            this.btnB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB.Location = new System.Drawing.Point(265, 63);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(256, 64);
            this.btnB.TabIndex = 2;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.White;
            this.btnA.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.Location = new System.Drawing.Point(3, 63);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(256, 64);
            this.btnA.TabIndex = 0;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 632);
            this.Controls.Add(this.pnGame);
            this.Controls.Add(this.pnMenu);
            this.Name = "FormQuiz";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnMenu.ResumeLayout(false);
            this.pnMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTopic)).EndInit();
            this.pnGame.ResumeLayout(false);
            this.pnGame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.NumericUpDown numTopic;
        private System.Windows.Forms.Panel pnGame;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Label lbQuestion;
        private System.Windows.Forms.Label lbTopic;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Label lbTopicCount;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

