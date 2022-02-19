namespace Cuvintel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picJoaca = new System.Windows.Forms.PictureBox();
            this.btnInchide = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picCoroana = new System.Windows.Forms.PictureBox();
            this.lbCMBS = new System.Windows.Forms.Label();
            this.lbTuto1 = new System.Windows.Forms.Label();
            this.picCuvintel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picJoaca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInchide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoroana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCuvintel)).BeginInit();
            this.SuspendLayout();
            // 
            // picJoaca
            // 
            this.picJoaca.BackColor = System.Drawing.Color.Transparent;
            this.picJoaca.BackgroundImage = global::Cuvintel.Properties.Resources.btnJoaca;
            this.picJoaca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picJoaca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picJoaca.InitialImage = null;
            this.picJoaca.Location = new System.Drawing.Point(519, 264);
            this.picJoaca.Name = "picJoaca";
            this.picJoaca.Size = new System.Drawing.Size(332, 142);
            this.picJoaca.TabIndex = 0;
            this.picJoaca.TabStop = false;
            this.picJoaca.Click += new System.EventHandler(this.picJoaca_Click);
            // 
            // btnInchide
            // 
            this.btnInchide.BackColor = System.Drawing.Color.Transparent;
            this.btnInchide.BackgroundImage = global::Cuvintel.Properties.Resources.btnInchide5;
            this.btnInchide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInchide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInchide.Location = new System.Drawing.Point(1076, 175);
            this.btnInchide.Name = "btnInchide";
            this.btnInchide.Size = new System.Drawing.Size(72, 66);
            this.btnInchide.TabIndex = 1;
            this.btnInchide.TabStop = false;
            this.btnInchide.Click += new System.EventHandler(this.btnInchide_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // picCoroana
            // 
            this.picCoroana.BackColor = System.Drawing.Color.Transparent;
            this.picCoroana.BackgroundImage = global::Cuvintel.Properties.Resources.coroana;
            this.picCoroana.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCoroana.Location = new System.Drawing.Point(594, 460);
            this.picCoroana.Name = "picCoroana";
            this.picCoroana.Size = new System.Drawing.Size(50, 45);
            this.picCoroana.TabIndex = 3;
            this.picCoroana.TabStop = false;
            // 
            // lbCMBS
            // 
            this.lbCMBS.AutoSize = true;
            this.lbCMBS.BackColor = System.Drawing.Color.Transparent;
            this.lbCMBS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbCMBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCMBS.ForeColor = System.Drawing.Color.Yellow;
            this.lbCMBS.Location = new System.Drawing.Point(650, 460);
            this.lbCMBS.Name = "lbCMBS";
            this.lbCMBS.Size = new System.Drawing.Size(66, 24);
            this.lbCMBS.TabIndex = 4;
            this.lbCMBS.Text = "label2";
            // 
            // lbTuto1
            // 
            this.lbTuto1.AutoSize = true;
            this.lbTuto1.BackColor = System.Drawing.Color.Transparent;
            this.lbTuto1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTuto1.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbTuto1.Location = new System.Drawing.Point(197, 432);
            this.lbTuto1.Name = "lbTuto1";
            this.lbTuto1.Size = new System.Drawing.Size(276, 126);
            this.lbTuto1.TabIndex = 5;
            this.lbTuto1.Text = "Bun venit!\r\n\r\nMă numesc Cuvințel și astăzi te voi pune\r\nla treaba. Trebuie să ghi" +
    "cești un număr \r\ncât mai mare de cuvinte pentru mine.\r\n\r\nApasa butonul \"Joacă\" p" +
    "entru a începe.\r\n";
            // 
            // picCuvintel
            // 
            this.picCuvintel.BackColor = System.Drawing.Color.Transparent;
            this.picCuvintel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCuvintel.BackgroundImage")));
            this.picCuvintel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCuvintel.Cursor = System.Windows.Forms.Cursors.No;
            this.picCuvintel.Location = new System.Drawing.Point(1076, 543);
            this.picCuvintel.Name = "picCuvintel";
            this.picCuvintel.Size = new System.Drawing.Size(85, 75);
            this.picCuvintel.TabIndex = 6;
            this.picCuvintel.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cuvintel.Properties.Resources.imgFundal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1361, 688);
            this.Controls.Add(this.picCuvintel);
            this.Controls.Add(this.lbTuto1);
            this.Controls.Add(this.lbCMBS);
            this.Controls.Add(this.picCoroana);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInchide);
            this.Controls.Add(this.picJoaca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuvintel";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picJoaca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInchide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoroana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCuvintel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picJoaca;
        private System.Windows.Forms.PictureBox btnInchide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picCoroana;
        private System.Windows.Forms.Label lbCMBS;
        private System.Windows.Forms.Label lbTuto1;
        private System.Windows.Forms.PictureBox picCuvintel;
    }
}

