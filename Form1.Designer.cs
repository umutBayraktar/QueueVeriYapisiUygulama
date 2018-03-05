namespace _152802029_2
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
            this.grpBoxNormal = new System.Windows.Forms.GroupBox();
            this.btnNormal = new System.Windows.Forms.Button();
            this.grpBAzOncelikli = new System.Windows.Forms.GroupBox();
            this.btnAz = new System.Windows.Forms.Button();
            this.grpBCokOncelikli = new System.Windows.Forms.GroupBox();
            this.btnCok = new System.Windows.Forms.Button();
            this.lblOrtalamaNOrmal = new System.Windows.Forms.Label();
            this.lblOrtalamaAz = new System.Windows.Forms.Label();
            this.lblOrtalamaCok = new System.Windows.Forms.Label();
            this.grpBoxNormal.SuspendLayout();
            this.grpBAzOncelikli.SuspendLayout();
            this.grpBCokOncelikli.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxNormal
            // 
            this.grpBoxNormal.Controls.Add(this.lblOrtalamaNOrmal);
            this.grpBoxNormal.Controls.Add(this.btnNormal);
            this.grpBoxNormal.Location = new System.Drawing.Point(12, 12);
            this.grpBoxNormal.Name = "grpBoxNormal";
            this.grpBoxNormal.Size = new System.Drawing.Size(286, 237);
            this.grpBoxNormal.TabIndex = 0;
            this.grpBoxNormal.TabStop = false;
            this.grpBoxNormal.Text = "Normal Sıra";
            // 
            // btnNormal
            // 
            this.btnNormal.Location = new System.Drawing.Point(89, 64);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(75, 23);
            this.btnNormal.TabIndex = 0;
            this.btnNormal.Text = "Görüntüle";
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // grpBAzOncelikli
            // 
            this.grpBAzOncelikli.Controls.Add(this.lblOrtalamaAz);
            this.grpBAzOncelikli.Controls.Add(this.btnAz);
            this.grpBAzOncelikli.Location = new System.Drawing.Point(304, 12);
            this.grpBAzOncelikli.Name = "grpBAzOncelikli";
            this.grpBAzOncelikli.Size = new System.Drawing.Size(286, 237);
            this.grpBAzOncelikli.TabIndex = 1;
            this.grpBAzOncelikli.TabStop = false;
            this.grpBAzOncelikli.Text = "Az İşlem SüresiÖncelikli";
            // 
            // btnAz
            // 
            this.btnAz.Location = new System.Drawing.Point(105, 64);
            this.btnAz.Name = "btnAz";
            this.btnAz.Size = new System.Drawing.Size(75, 23);
            this.btnAz.TabIndex = 1;
            this.btnAz.Text = "Görüntüle";
            this.btnAz.UseVisualStyleBackColor = true;
            this.btnAz.Click += new System.EventHandler(this.btnAz_Click);
            // 
            // grpBCokOncelikli
            // 
            this.grpBCokOncelikli.Controls.Add(this.lblOrtalamaCok);
            this.grpBCokOncelikli.Controls.Add(this.btnCok);
            this.grpBCokOncelikli.Location = new System.Drawing.Point(596, 12);
            this.grpBCokOncelikli.Name = "grpBCokOncelikli";
            this.grpBCokOncelikli.Size = new System.Drawing.Size(286, 237);
            this.grpBCokOncelikli.TabIndex = 1;
            this.grpBCokOncelikli.TabStop = false;
            this.grpBCokOncelikli.Text = "Çok İşlem Süresi Öncelikli";
            // 
            // btnCok
            // 
            this.btnCok.Location = new System.Drawing.Point(89, 64);
            this.btnCok.Name = "btnCok";
            this.btnCok.Size = new System.Drawing.Size(75, 23);
            this.btnCok.TabIndex = 2;
            this.btnCok.Text = "Görüntüle";
            this.btnCok.UseVisualStyleBackColor = true;
            this.btnCok.Click += new System.EventHandler(this.btnCok_Click);
            // 
            // lblOrtalamaNOrmal
            // 
            this.lblOrtalamaNOrmal.AutoSize = true;
            this.lblOrtalamaNOrmal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrtalamaNOrmal.Location = new System.Drawing.Point(21, 108);
            this.lblOrtalamaNOrmal.Name = "lblOrtalamaNOrmal";
            this.lblOrtalamaNOrmal.Size = new System.Drawing.Size(93, 24);
            this.lblOrtalamaNOrmal.TabIndex = 1;
            this.lblOrtalamaNOrmal.Text = "Ortalama";
            // 
            // lblOrtalamaAz
            // 
            this.lblOrtalamaAz.AutoSize = true;
            this.lblOrtalamaAz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrtalamaAz.Location = new System.Drawing.Point(19, 108);
            this.lblOrtalamaAz.Name = "lblOrtalamaAz";
            this.lblOrtalamaAz.Size = new System.Drawing.Size(93, 24);
            this.lblOrtalamaAz.TabIndex = 2;
            this.lblOrtalamaAz.Text = "Ortalama";
            // 
            // lblOrtalamaCok
            // 
            this.lblOrtalamaCok.AutoSize = true;
            this.lblOrtalamaCok.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrtalamaCok.Location = new System.Drawing.Point(20, 108);
            this.lblOrtalamaCok.Name = "lblOrtalamaCok";
            this.lblOrtalamaCok.Size = new System.Drawing.Size(93, 24);
            this.lblOrtalamaCok.TabIndex = 3;
            this.lblOrtalamaCok.Text = "Ortalama";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 261);
            this.Controls.Add(this.grpBCokOncelikli);
            this.Controls.Add(this.grpBAzOncelikli);
            this.Controls.Add(this.grpBoxNormal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpBoxNormal.ResumeLayout(false);
            this.grpBoxNormal.PerformLayout();
            this.grpBAzOncelikli.ResumeLayout(false);
            this.grpBAzOncelikli.PerformLayout();
            this.grpBCokOncelikli.ResumeLayout(false);
            this.grpBCokOncelikli.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxNormal;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.GroupBox grpBAzOncelikli;
        private System.Windows.Forms.Button btnAz;
        private System.Windows.Forms.GroupBox grpBCokOncelikli;
        private System.Windows.Forms.Button btnCok;
        private System.Windows.Forms.Label lblOrtalamaNOrmal;
        private System.Windows.Forms.Label lblOrtalamaAz;
        private System.Windows.Forms.Label lblOrtalamaCok;
    }
}

