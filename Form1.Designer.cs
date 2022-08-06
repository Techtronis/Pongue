namespace Pongue
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.paddleL = new System.Windows.Forms.PictureBox();
            this.paddleR = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ball = new System.Windows.Forms.PictureBox();
            this.scoreL = new System.Windows.Forms.Label();
            this.scoreR = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.paddleL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddleR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // paddleL
            // 
            this.paddleL.BackColor = System.Drawing.Color.White;
            this.paddleL.Location = new System.Drawing.Point(12, 404);
            this.paddleL.Name = "paddleL";
            this.paddleL.Size = new System.Drawing.Size(25, 150);
            this.paddleL.TabIndex = 0;
            this.paddleL.TabStop = false;
            // 
            // paddleR
            // 
            this.paddleR.BackColor = System.Drawing.Color.White;
            this.paddleR.Location = new System.Drawing.Point(1792, 404);
            this.paddleR.Name = "paddleR";
            this.paddleR.Size = new System.Drawing.Size(25, 150);
            this.paddleR.TabIndex = 1;
            this.paddleR.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.White;
            this.ball.Location = new System.Drawing.Point(881, 486);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(20, 20);
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            // 
            // scoreL
            // 
            this.scoreL.AutoSize = true;
            this.scoreL.BackColor = System.Drawing.Color.Transparent;
            this.scoreL.Font = new System.Drawing.Font("Segoe UI", 20.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreL.ForeColor = System.Drawing.Color.White;
            this.scoreL.Location = new System.Drawing.Point(724, 24);
            this.scoreL.Name = "scoreL";
            this.scoreL.Size = new System.Drawing.Size(54, 65);
            this.scoreL.TabIndex = 3;
            this.scoreL.Text = "0";
            // 
            // scoreR
            // 
            this.scoreR.AutoSize = true;
            this.scoreR.BackColor = System.Drawing.Color.Transparent;
            this.scoreR.Font = new System.Drawing.Font("Segoe UI", 20.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreR.ForeColor = System.Drawing.Color.White;
            this.scoreR.Location = new System.Drawing.Point(1004, 24);
            this.scoreR.Name = "scoreR";
            this.scoreR.Size = new System.Drawing.Size(54, 65);
            this.scoreR.TabIndex = 4;
            this.scoreR.Text = "0";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1829, 976);
            this.Controls.Add(this.scoreR);
            this.Controls.Add(this.scoreL);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.paddleR);
            this.Controls.Add(this.paddleL);
            this.Name = "Form1";
            this.Text = "Pongue";
            ((System.ComponentModel.ISupportInitialize)(this.paddleL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddleR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private PictureBox paddleL;
        private PictureBox paddleR;
        private System.Windows.Forms.Timer timer1;
        private PictureBox ball;
        private Label scoreL;
        private Label scoreR;
    }
}