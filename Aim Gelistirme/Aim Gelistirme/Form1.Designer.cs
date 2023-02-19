namespace Aim_Gelistirme
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.skor = new System.Windows.Forms.Label();
            this.skorLbl = new System.Windows.Forms.Label();
            this.sure = new System.Windows.Forms.Label();
            this.sureLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.canLbl = new System.Windows.Forms.Label();
            this.can = new System.Windows.Forms.Label();
            this.oyunSonuLbl = new System.Windows.Forms.Label();
            this.yenidenOynaBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.pictureBox1.Location = new System.Drawing.Point(375, 225);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // skor
            // 
            this.skor.AutoSize = true;
            this.skor.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.skor.Location = new System.Drawing.Point(604, 22);
            this.skor.Name = "skor";
            this.skor.Size = new System.Drawing.Size(91, 33);
            this.skor.TabIndex = 1;
            this.skor.Text = "Skor :";
            // 
            // skorLbl
            // 
            this.skorLbl.AutoSize = true;
            this.skorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.skorLbl.Location = new System.Drawing.Point(701, 22);
            this.skorLbl.Name = "skorLbl";
            this.skorLbl.Size = new System.Drawing.Size(31, 33);
            this.skorLbl.TabIndex = 1;
            this.skorLbl.Text = "0";
            // 
            // sure
            // 
            this.sure.AutoSize = true;
            this.sure.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.sure.Location = new System.Drawing.Point(22, 22);
            this.sure.Name = "sure";
            this.sure.Size = new System.Drawing.Size(92, 33);
            this.sure.TabIndex = 2;
            this.sure.Text = "Süre :";
            // 
            // sureLbl
            // 
            this.sureLbl.AutoSize = true;
            this.sureLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sureLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.sureLbl.Location = new System.Drawing.Point(110, 22);
            this.sureLbl.Name = "sureLbl";
            this.sureLbl.Size = new System.Drawing.Size(47, 33);
            this.sureLbl.TabIndex = 2;
            this.sureLbl.Text = "60";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Enabled = false;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 500);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // canLbl
            // 
            this.canLbl.AutoSize = true;
            this.canLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.canLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.canLbl.Location = new System.Drawing.Point(438, 22);
            this.canLbl.Name = "canLbl";
            this.canLbl.Size = new System.Drawing.Size(31, 33);
            this.canLbl.TabIndex = 2;
            this.canLbl.Text = "3";
            // 
            // can
            // 
            this.can.AutoSize = true;
            this.can.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.can.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.can.Location = new System.Drawing.Point(341, 22);
            this.can.Name = "can";
            this.can.Size = new System.Drawing.Size(84, 33);
            this.can.TabIndex = 3;
            this.can.Text = "Can :";
            // 
            // oyunSonuLbl
            // 
            this.oyunSonuLbl.AutoSize = true;
            this.oyunSonuLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oyunSonuLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.oyunSonuLbl.Location = new System.Drawing.Point(207, 299);
            this.oyunSonuLbl.Name = "oyunSonuLbl";
            this.oyunSonuLbl.Size = new System.Drawing.Size(385, 39);
            this.oyunSonuLbl.TabIndex = 4;
            this.oyunSonuLbl.Text = "Oyun Bitti, Skorunuz : X";
            this.oyunSonuLbl.Visible = false;
            // 
            // yenidenOynaBtn
            // 
            this.yenidenOynaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.yenidenOynaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yenidenOynaBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.yenidenOynaBtn.Location = new System.Drawing.Point(280, 388);
            this.yenidenOynaBtn.Name = "yenidenOynaBtn";
            this.yenidenOynaBtn.Size = new System.Drawing.Size(240, 40);
            this.yenidenOynaBtn.TabIndex = 5;
            this.yenidenOynaBtn.Text = "Yeniden Oyna";
            this.yenidenOynaBtn.UseVisualStyleBackColor = false;
            this.yenidenOynaBtn.Visible = false;
            this.yenidenOynaBtn.Click += new System.EventHandler(this.yenidenOynaBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.yenidenOynaBtn);
            this.Controls.Add(this.can);
            this.Controls.Add(this.oyunSonuLbl);
            this.Controls.Add(this.sureLbl);
            this.Controls.Add(this.canLbl);
            this.Controls.Add(this.sure);
            this.Controls.Add(this.skorLbl);
            this.Controls.Add(this.skor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label skor;
        private System.Windows.Forms.Label skorLbl;
        private System.Windows.Forms.Label sure;
        private System.Windows.Forms.Label sureLbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label canLbl;
        private System.Windows.Forms.Label can;
        private System.Windows.Forms.Label oyunSonuLbl;
        private System.Windows.Forms.Button yenidenOynaBtn;
    }
}

