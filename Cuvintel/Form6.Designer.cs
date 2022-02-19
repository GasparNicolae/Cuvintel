namespace Cuvintel
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.lbText = new System.Windows.Forms.Label();
            this.picAcasa = new System.Windows.Forms.PictureBox();
            this.picMaiDeparte = new System.Windows.Forms.PictureBox();
            this.lbRunda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picAcasa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaiDeparte)).BeginInit();
            this.SuspendLayout();
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.BackColor = System.Drawing.Color.Transparent;
            this.lbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbText.Location = new System.Drawing.Point(82, 19);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(80, 25);
            this.lbText.TabIndex = 0;
            this.lbText.Text = "Bravo!";
            this.lbText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picAcasa
            // 
            this.picAcasa.BackColor = System.Drawing.Color.Transparent;
            this.picAcasa.BackgroundImage = global::Cuvintel.Properties.Resources.btnAcasa2;
            this.picAcasa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAcasa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAcasa.Location = new System.Drawing.Point(17, 124);
            this.picAcasa.Name = "picAcasa";
            this.picAcasa.Size = new System.Drawing.Size(79, 69);
            this.picAcasa.TabIndex = 1;
            this.picAcasa.TabStop = false;
            this.picAcasa.Click += new System.EventHandler(this.picAcasa_Click);
            // 
            // picMaiDeparte
            // 
            this.picMaiDeparte.BackColor = System.Drawing.Color.Transparent;
            this.picMaiDeparte.BackgroundImage = global::Cuvintel.Properties.Resources.picMaiDeparte;
            this.picMaiDeparte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMaiDeparte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMaiDeparte.Location = new System.Drawing.Point(158, 124);
            this.picMaiDeparte.Name = "picMaiDeparte";
            this.picMaiDeparte.Size = new System.Drawing.Size(79, 69);
            this.picMaiDeparte.TabIndex = 2;
            this.picMaiDeparte.TabStop = false;
            this.picMaiDeparte.Click += new System.EventHandler(this.picMaiDeparte_Click);
            // 
            // lbRunda
            // 
            this.lbRunda.AutoSize = true;
            this.lbRunda.BackColor = System.Drawing.Color.Transparent;
            this.lbRunda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRunda.ForeColor = System.Drawing.Color.Yellow;
            this.lbRunda.Location = new System.Drawing.Point(30, 70);
            this.lbRunda.Name = "lbRunda";
            this.lbRunda.Size = new System.Drawing.Size(57, 20);
            this.lbRunda.TabIndex = 3;
            this.lbRunda.Text = "label1";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cuvintel.Properties.Resources.BK3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(249, 222);
            this.Controls.Add(this.lbRunda);
            this.Controls.Add(this.picMaiDeparte);
            this.Controls.Add(this.picAcasa);
            this.Controls.Add(this.lbText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Felicitări!";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAcasa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaiDeparte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.PictureBox picAcasa;
        private System.Windows.Forms.PictureBox picMaiDeparte;
        private System.Windows.Forms.Label lbRunda;
    }
}