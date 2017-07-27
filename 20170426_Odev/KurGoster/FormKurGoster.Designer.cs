namespace KurGoster
{
    partial class FormKurGoster
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
            this.btnKurYukle = new System.Windows.Forms.Button();
            this.lsvParaBirimi = new System.Windows.Forms.ListView();
            this.clhParaBirimi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblAlis = new System.Windows.Forms.Label();
            this.lblAlisFiyat = new System.Windows.Forms.Label();
            this.lblSatis = new System.Windows.Forms.Label();
            this.lblSatisFiyat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKurYukle
            // 
            this.btnKurYukle.Location = new System.Drawing.Point(12, 11);
            this.btnKurYukle.Name = "btnKurYukle";
            this.btnKurYukle.Size = new System.Drawing.Size(172, 34);
            this.btnKurYukle.TabIndex = 0;
            this.btnKurYukle.Text = "Kur Bilgilerini Yükle";
            this.btnKurYukle.UseVisualStyleBackColor = true;
            this.btnKurYukle.Click += new System.EventHandler(this.btnKurYukle_Click);
            // 
            // lsvParaBirimi
            // 
            this.lsvParaBirimi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhParaBirimi});
            this.lsvParaBirimi.GridLines = true;
            this.lsvParaBirimi.Location = new System.Drawing.Point(12, 51);
            this.lsvParaBirimi.Name = "lsvParaBirimi";
            this.lsvParaBirimi.Size = new System.Drawing.Size(173, 348);
            this.lsvParaBirimi.TabIndex = 1;
            this.lsvParaBirimi.UseCompatibleStateImageBehavior = false;
            this.lsvParaBirimi.View = System.Windows.Forms.View.Details;
            this.lsvParaBirimi.SelectedIndexChanged += new System.EventHandler(this.lsvParaBirimi_SelectedIndexChanged);
            // 
            // clhParaBirimi
            // 
            this.clhParaBirimi.Text = "Para Birimi";
            this.clhParaBirimi.Width = 167;
            // 
            // lblAlis
            // 
            this.lblAlis.AutoSize = true;
            this.lblAlis.Location = new System.Drawing.Point(240, 121);
            this.lblAlis.Name = "lblAlis";
            this.lblAlis.Size = new System.Drawing.Size(26, 13);
            this.lblAlis.TabIndex = 2;
            this.lblAlis.Text = "Alış:";
            // 
            // lblAlisFiyat
            // 
            this.lblAlisFiyat.AutoSize = true;
            this.lblAlisFiyat.Location = new System.Drawing.Point(330, 121);
            this.lblAlisFiyat.Name = "lblAlisFiyat";
            this.lblAlisFiyat.Size = new System.Drawing.Size(0, 13);
            this.lblAlisFiyat.TabIndex = 2;
            // 
            // lblSatis
            // 
            this.lblSatis.AutoSize = true;
            this.lblSatis.Location = new System.Drawing.Point(240, 169);
            this.lblSatis.Name = "lblSatis";
            this.lblSatis.Size = new System.Drawing.Size(33, 13);
            this.lblSatis.TabIndex = 2;
            this.lblSatis.Text = "Satış:";
            // 
            // lblSatisFiyat
            // 
            this.lblSatisFiyat.AutoSize = true;
            this.lblSatisFiyat.Location = new System.Drawing.Point(330, 169);
            this.lblSatisFiyat.Name = "lblSatisFiyat";
            this.lblSatisFiyat.Size = new System.Drawing.Size(0, 13);
            this.lblSatisFiyat.TabIndex = 2;
            // 
            // FormKurGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 472);
            this.Controls.Add(this.lblAlisFiyat);
            this.Controls.Add(this.lblSatisFiyat);
            this.Controls.Add(this.lblSatis);
            this.Controls.Add(this.lblAlis);
            this.Controls.Add(this.lsvParaBirimi);
            this.Controls.Add(this.btnKurYukle);
            this.Name = "FormKurGoster";
            this.Text = "Kur Bilgileri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKurYukle;
        private System.Windows.Forms.ListView lsvParaBirimi;
        private System.Windows.Forms.ColumnHeader clhParaBirimi;
        private System.Windows.Forms.Label lblAlis;
        private System.Windows.Forms.Label lblAlisFiyat;
        private System.Windows.Forms.Label lblSatis;
        private System.Windows.Forms.Label lblSatisFiyat;
    }
}

