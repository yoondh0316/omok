
namespace GomokGameProject
{
    partial class SinglePlayForm
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
            this.boardPicture = new System.Windows.Forms.PictureBox();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.playButton = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.boardPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // boardPicture
            // 
            this.boardPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(216)))));
            this.boardPicture.Location = new System.Drawing.Point(20, 20);
            this.boardPicture.Name = "boardPicture";
            this.boardPicture.Size = new System.Drawing.Size(500, 500);
            this.boardPicture.TabIndex = 0;
            this.boardPicture.TabStop = false;
            this.boardPicture.Paint += new System.Windows.Forms.PaintEventHandler(this.boardPicture_Paint);
            this.boardPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.boardPicture_MouseDown);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(571, 344);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(8, 8);
            this.propertyGrid1.TabIndex = 1;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(641, 46);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(100, 40);
            this.playButton.TabIndex = 2;
            this.playButton.Text = "게임 시작";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(557, 107);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(272, 28);
            this.status.TabIndex = 3;
            this.status.Text = "게임을 시작해주세요";
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SinglePlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 678);
            this.Controls.Add(this.status);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.boardPicture);
            this.Name = "SinglePlayForm";
            this.Text = "SinglePlayForm";
            ((System.ComponentModel.ISupportInitialize)(this.boardPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox boardPicture;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label status;
    }
}
