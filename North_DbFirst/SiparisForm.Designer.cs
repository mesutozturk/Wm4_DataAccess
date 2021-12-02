namespace North_DbFirst
{
    partial class SiparisForm
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
            this.txtAra = new System.Windows.Forms.TextBox();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.lstCart = new System.Windows.Forms.ListView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnArttır = new System.Windows.Forms.Button();
            this.btnAzalt = new System.Windows.Forms.Button();
            this.lblToplam = new System.Windows.Forms.Label();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.cmbShippers = new System.Windows.Forms.ComboBox();
            this.dtpRequiredDate = new System.Windows.Forms.DateTimePicker();
            this.txtShipName = new System.Windows.Forms.TextBox();
            this.txtShipCity = new System.Windows.Forms.TextBox();
            this.txtShipPostalCode = new System.Windows.Forms.TextBox();
            this.txtShipAdress = new System.Windows.Forms.TextBox();
            this.txtShipRagion = new System.Windows.Forms.TextBox();
            this.txtShipCountry = new System.Windows.Forms.TextBox();
            this.nFreight = new System.Windows.Forms.NumericUpDown();
            this.btnOnay = new System.Windows.Forms.Button();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nFreight)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(12, 12);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(270, 27);
            this.txtAra.TabIndex = 8;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // lstProducts
            // 
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.ItemHeight = 20;
            this.lstProducts.Location = new System.Drawing.Point(12, 52);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(296, 284);
            this.lstProducts.TabIndex = 7;
            // 
            // lstCart
            // 
            this.lstCart.HideSelection = false;
            this.lstCart.Location = new System.Drawing.Point(314, 52);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(304, 284);
            this.lstCart.TabIndex = 9;
            this.lstCart.UseCompatibleStateImageBehavior = false;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(53, 356);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(199, 56);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnArttır
            // 
            this.btnArttır.Location = new System.Drawing.Point(448, 356);
            this.btnArttır.Name = "btnArttır";
            this.btnArttır.Size = new System.Drawing.Size(109, 56);
            this.btnArttır.TabIndex = 11;
            this.btnArttır.Text = "Arttır";
            this.btnArttır.UseVisualStyleBackColor = true;
            this.btnArttır.Click += new System.EventHandler(this.btnArttır_Click);
            // 
            // btnAzalt
            // 
            this.btnAzalt.Location = new System.Drawing.Point(336, 356);
            this.btnAzalt.Name = "btnAzalt";
            this.btnAzalt.Size = new System.Drawing.Size(103, 56);
            this.btnAzalt.TabIndex = 11;
            this.btnAzalt.Text = "Azalt";
            this.btnAzalt.UseVisualStyleBackColor = true;
            this.btnAzalt.Click += new System.EventHandler(this.btnAzalt_Click);
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToplam.Location = new System.Drawing.Point(314, 12);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(269, 31);
            this.lblToplam.TabIndex = 12;
            this.lblToplam.Text = "Toplam : 0.00 ₺";
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(639, 52);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(298, 28);
            this.cmbEmployee.TabIndex = 13;
            // 
            // cmbShippers
            // 
            this.cmbShippers.FormattingEnabled = true;
            this.cmbShippers.Location = new System.Drawing.Point(639, 86);
            this.cmbShippers.Name = "cmbShippers";
            this.cmbShippers.Size = new System.Drawing.Size(298, 28);
            this.cmbShippers.TabIndex = 14;
            // 
            // dtpRequiredDate
            // 
            this.dtpRequiredDate.Location = new System.Drawing.Point(639, 154);
            this.dtpRequiredDate.Name = "dtpRequiredDate";
            this.dtpRequiredDate.Size = new System.Drawing.Size(298, 27);
            this.dtpRequiredDate.TabIndex = 15;
            // 
            // txtShipName
            // 
            this.txtShipName.Location = new System.Drawing.Point(639, 187);
            this.txtShipName.Name = "txtShipName";
            this.txtShipName.Size = new System.Drawing.Size(146, 27);
            this.txtShipName.TabIndex = 16;
            // 
            // txtShipCity
            // 
            this.txtShipCity.Location = new System.Drawing.Point(639, 220);
            this.txtShipCity.Name = "txtShipCity";
            this.txtShipCity.Size = new System.Drawing.Size(146, 27);
            this.txtShipCity.TabIndex = 16;
            // 
            // txtShipPostalCode
            // 
            this.txtShipPostalCode.Location = new System.Drawing.Point(639, 253);
            this.txtShipPostalCode.Name = "txtShipPostalCode";
            this.txtShipPostalCode.Size = new System.Drawing.Size(146, 27);
            this.txtShipPostalCode.TabIndex = 16;
            // 
            // txtShipAdress
            // 
            this.txtShipAdress.Location = new System.Drawing.Point(791, 187);
            this.txtShipAdress.Name = "txtShipAdress";
            this.txtShipAdress.Size = new System.Drawing.Size(146, 27);
            this.txtShipAdress.TabIndex = 16;
            // 
            // txtShipRagion
            // 
            this.txtShipRagion.Location = new System.Drawing.Point(791, 220);
            this.txtShipRagion.Name = "txtShipRagion";
            this.txtShipRagion.Size = new System.Drawing.Size(146, 27);
            this.txtShipRagion.TabIndex = 16;
            // 
            // txtShipCountry
            // 
            this.txtShipCountry.Location = new System.Drawing.Point(791, 253);
            this.txtShipCountry.Name = "txtShipCountry";
            this.txtShipCountry.Size = new System.Drawing.Size(146, 27);
            this.txtShipCountry.TabIndex = 16;
            // 
            // nFreight
            // 
            this.nFreight.DecimalPlaces = 2;
            this.nFreight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nFreight.Location = new System.Drawing.Point(791, 286);
            this.nFreight.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nFreight.Name = "nFreight";
            this.nFreight.Size = new System.Drawing.Size(146, 34);
            this.nFreight.TabIndex = 17;
            this.nFreight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnOnay
            // 
            this.btnOnay.Location = new System.Drawing.Point(639, 356);
            this.btnOnay.Name = "btnOnay";
            this.btnOnay.Size = new System.Drawing.Size(298, 56);
            this.btnOnay.TabIndex = 18;
            this.btnOnay.Text = "Onayla";
            this.btnOnay.UseVisualStyleBackColor = true;
            this.btnOnay.Click += new System.EventHandler(this.btnOnay_Click);
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(639, 120);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(298, 28);
            this.cmbCustomer.TabIndex = 19;
            // 
            // SiparisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 495);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.btnOnay);
            this.Controls.Add(this.nFreight);
            this.Controls.Add(this.txtShipCountry);
            this.Controls.Add(this.txtShipRagion);
            this.Controls.Add(this.txtShipAdress);
            this.Controls.Add(this.txtShipPostalCode);
            this.Controls.Add(this.txtShipCity);
            this.Controls.Add(this.txtShipName);
            this.Controls.Add(this.dtpRequiredDate);
            this.Controls.Add(this.cmbShippers);
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.btnAzalt);
            this.Controls.Add(this.btnArttır);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstCart);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.lstProducts);
            this.Name = "SiparisForm";
            this.Text = "SiparisForm";
            this.Load += new System.EventHandler(this.SiparisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nFreight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.ListView lstCart;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnArttır;
        private System.Windows.Forms.Button btnAzalt;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.ComboBox cmbShippers;
        private System.Windows.Forms.DateTimePicker dtpRequiredDate;
        private System.Windows.Forms.TextBox txtShipName;
        private System.Windows.Forms.TextBox txtShipCity;
        private System.Windows.Forms.TextBox txtShipPostalCode;
        private System.Windows.Forms.TextBox txtShipAdress;
        private System.Windows.Forms.TextBox txtShipRagion;
        private System.Windows.Forms.TextBox txtShipCountry;
        private System.Windows.Forms.NumericUpDown nFreight;
        private System.Windows.Forms.Button btnOnay;
        private System.Windows.Forms.ComboBox cmbCustomer;
    }
}