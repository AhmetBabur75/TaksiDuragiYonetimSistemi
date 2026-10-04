namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPlaka = new System.Windows.Forms.TextBox();
            this.textBoxMesafe = new System.Windows.Forms.TextBox();
            this.buttonTaksiEkle = new System.Windows.Forms.Button();
            this.buttonSeferEkle = new System.Windows.Forms.Button();
            this.listBoxSira = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plaka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mesafe (km)";
            // 
            // textBoxPlaka
            // 
            this.textBoxPlaka.Location = new System.Drawing.Point(270, 83);
            this.textBoxPlaka.Name = "textBoxPlaka";
            this.textBoxPlaka.Size = new System.Drawing.Size(100, 20);
            this.textBoxPlaka.TabIndex = 2;
            // 
            // textBoxMesafe
            // 
            this.textBoxMesafe.Location = new System.Drawing.Point(270, 118);
            this.textBoxMesafe.Name = "textBoxMesafe";
            this.textBoxMesafe.Size = new System.Drawing.Size(100, 20);
            this.textBoxMesafe.TabIndex = 3;
            // 
            // buttonTaksiEkle
            // 
            this.buttonTaksiEkle.Location = new System.Drawing.Point(179, 186);
            this.buttonTaksiEkle.Name = "buttonTaksiEkle";
            this.buttonTaksiEkle.Size = new System.Drawing.Size(75, 23);
            this.buttonTaksiEkle.TabIndex = 4;
            this.buttonTaksiEkle.Text = "Taksi Ekle";
            this.buttonTaksiEkle.UseVisualStyleBackColor = true;
            // 
            // buttonSeferEkle
            // 
            this.buttonSeferEkle.Location = new System.Drawing.Point(306, 186);
            this.buttonSeferEkle.Name = "buttonSeferEkle";
            this.buttonSeferEkle.Size = new System.Drawing.Size(75, 23);
            this.buttonSeferEkle.TabIndex = 5;
            this.buttonSeferEkle.Text = "Sefer Ekle";
            this.buttonSeferEkle.UseVisualStyleBackColor = true;
            // 
            // listBoxSira
            // 
            this.listBoxSira.FormattingEnabled = true;
            this.listBoxSira.Location = new System.Drawing.Point(437, 83);
            this.listBoxSira.Name = "listBoxSira";
            this.listBoxSira.Size = new System.Drawing.Size(223, 225);
            this.listBoxSira.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxSira);
            this.Controls.Add(this.buttonSeferEkle);
            this.Controls.Add(this.buttonTaksiEkle);
            this.Controls.Add(this.textBoxMesafe);
            this.Controls.Add(this.textBoxPlaka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPlaka;
        private System.Windows.Forms.TextBox textBoxMesafe;
        private System.Windows.Forms.Button buttonTaksiEkle;
        private System.Windows.Forms.Button buttonSeferEkle;
        private System.Windows.Forms.ListBox listBoxSira;
    }
}

