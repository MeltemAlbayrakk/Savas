
namespace Savas.Desktop
{
    partial class AnaForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.bilgiPanel = new System.Windows.Forms.Panel();
            this.tankPanel = new System.Windows.Forms.Panel();
            this.savasAlaniPanel = new System.Windows.Forms.Panel();
            this.bilgiLabel = new System.Windows.Forms.Label();
            this.sureLabel = new System.Windows.Forms.Label();
            this.bilgiPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bilgiPanel
            // 
            this.bilgiPanel.BackColor = System.Drawing.Color.CadetBlue;
            this.bilgiPanel.Controls.Add(this.sureLabel);
            this.bilgiPanel.Controls.Add(this.bilgiLabel);
            this.bilgiPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bilgiPanel.Location = new System.Drawing.Point(0, 0);
            this.bilgiPanel.Name = "bilgiPanel";
            this.bilgiPanel.Size = new System.Drawing.Size(803, 77);
            this.bilgiPanel.TabIndex = 0;
            // 
            // tankPanel
            // 
            this.tankPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.tankPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tankPanel.Location = new System.Drawing.Point(0, 441);
            this.tankPanel.Name = "tankPanel";
            this.tankPanel.Size = new System.Drawing.Size(803, 32);
            this.tankPanel.TabIndex = 1;
            // 
            // savasAlaniPanel
            // 
            this.savasAlaniPanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.savasAlaniPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.savasAlaniPanel.Location = new System.Drawing.Point(0, 77);
            this.savasAlaniPanel.Name = "savasAlaniPanel";
            this.savasAlaniPanel.Size = new System.Drawing.Size(803, 364);
            this.savasAlaniPanel.TabIndex = 2;
            // 
            // bilgiLabel
            // 
            this.bilgiLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bilgiLabel.AutoSize = true;
            this.bilgiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bilgiLabel.ForeColor = System.Drawing.Color.White;
            this.bilgiLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bilgiLabel.Location = new System.Drawing.Point(227, 0);
            this.bilgiLabel.Name = "bilgiLabel";
            this.bilgiLabel.Size = new System.Drawing.Size(373, 80);
            this.bilgiLabel.TabIndex = 0;
            this.bilgiLabel.Text = resources.GetString("bilgiLabel.Text");
            this.bilgiLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sureLabel
            // 
            this.sureLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sureLabel.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sureLabel.ForeColor = System.Drawing.Color.White;
            this.sureLabel.Location = new System.Drawing.Point(643, 9);
            this.sureLabel.Name = "sureLabel";
            this.sureLabel.Size = new System.Drawing.Size(148, 50);
            this.sureLabel.TabIndex = 1;
            this.sureLabel.Text = "0:00";
            this.sureLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 473);
            this.Controls.Add(this.savasAlaniPanel);
            this.Controls.Add(this.tankPanel);
            this.Controls.Add(this.bilgiPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnaForm";
            this.Text = "Savas Oyunu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.bilgiPanel.ResumeLayout(false);
            this.bilgiPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bilgiPanel;
        private System.Windows.Forms.Label sureLabel;
        private System.Windows.Forms.Label bilgiLabel;
        private System.Windows.Forms.Panel tankPanel;
        private System.Windows.Forms.Panel savasAlaniPanel;
    }
}

