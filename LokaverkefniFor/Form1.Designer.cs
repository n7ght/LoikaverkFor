namespace LokaverkefniFor
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
            this.Bakgrunnur = new System.Windows.Forms.Panel();
            this.spaðinn = new System.Windows.Forms.PictureBox();
            this.boltinn = new System.Windows.Forms.PictureBox();
            this.Bakgrunnur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spaðinn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltinn)).BeginInit();
            this.SuspendLayout();
            // 
            // Bakgrunnur
            // 
            this.Bakgrunnur.Controls.Add(this.boltinn);
            this.Bakgrunnur.Controls.Add(this.spaðinn);
            this.Bakgrunnur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bakgrunnur.Location = new System.Drawing.Point(0, 0);
            this.Bakgrunnur.Name = "Bakgrunnur";
            this.Bakgrunnur.Size = new System.Drawing.Size(1080, 601);
            this.Bakgrunnur.TabIndex = 0;
            // 
            // spaðinn
            // 
            this.spaðinn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.spaðinn.BackColor = System.Drawing.Color.Black;
            this.spaðinn.Location = new System.Drawing.Point(533, 541);
            this.spaðinn.Name = "spaðinn";
            this.spaðinn.Size = new System.Drawing.Size(185, 15);
            this.spaðinn.TabIndex = 0;
            this.spaðinn.TabStop = false;
            // 
            // boltinn
            // 
            this.boltinn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boltinn.BackColor = System.Drawing.Color.Maroon;
            this.boltinn.Location = new System.Drawing.Point(606, 378);
            this.boltinn.Name = "boltinn";
            this.boltinn.Size = new System.Drawing.Size(50, 50);
            this.boltinn.TabIndex = 1;
            this.boltinn.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 601);
            this.Controls.Add(this.Bakgrunnur);
            this.Name = "Form1";
            this.Text = "PingPong";
            this.Bakgrunnur.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spaðinn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltinn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Bakgrunnur;
        private System.Windows.Forms.PictureBox boltinn;
        private System.Windows.Forms.PictureBox spaðinn;
    }
}

