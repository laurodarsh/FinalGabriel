namespace FinalGabriel
{
    partial class HomeForm
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
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblProdutc = new System.Windows.Forms.Label();
            this.lblProfile = new System.Windows.Forms.Label();
            this.lblLog = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.pbLog = new System.Windows.Forms.PictureBox();
            this.pbProfile = new System.Windows.Forms.PictureBox();
            this.pbProduct = new System.Windows.Forms.PictureBox();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.pbCategory = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(254, 189);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(97, 25);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Categoria";
            // 
            // lblProdutc
            // 
            this.lblProdutc.AutoSize = true;
            this.lblProdutc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutc.Location = new System.Drawing.Point(555, 189);
            this.lblProdutc.Name = "lblProdutc";
            this.lblProdutc.Size = new System.Drawing.Size(80, 25);
            this.lblProdutc.TabIndex = 1;
            this.lblProdutc.Text = "Produto";
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfile.Location = new System.Drawing.Point(268, 353);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(55, 25);
            this.lblProfile.TabIndex = 2;
            this.lblProfile.Text = "Perfil";
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLog.Location = new System.Drawing.Point(568, 353);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(45, 25);
            this.lblLog.TabIndex = 3;
            this.lblLog.Text = "Log";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(401, 268);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(89, 25);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "Usuários";
            // 
            // pbBack
            // 
            this.pbBack.Image = global::FinalGabriel.Properties.Resources.back_icons;
            this.pbBack.Location = new System.Drawing.Point(12, 499);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(64, 50);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBack.TabIndex = 10;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // pbLog
            // 
            this.pbLog.Image = global::FinalGabriel.Properties.Resources.log_icon;
            this.pbLog.Location = new System.Drawing.Point(530, 262);
            this.pbLog.Name = "pbLog";
            this.pbLog.Size = new System.Drawing.Size(129, 88);
            this.pbLog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLog.TabIndex = 9;
            this.pbLog.TabStop = false;
            // 
            // pbProfile
            // 
            this.pbProfile.Image = global::FinalGabriel.Properties.Resources.user_icon_png;
            this.pbProfile.Location = new System.Drawing.Point(232, 262);
            this.pbProfile.Name = "pbProfile";
            this.pbProfile.Size = new System.Drawing.Size(129, 88);
            this.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProfile.TabIndex = 8;
            this.pbProfile.TabStop = false;
            // 
            // pbProduct
            // 
            this.pbProduct.Image = global::FinalGabriel.Properties.Resources.box_icon_png;
            this.pbProduct.Location = new System.Drawing.Point(530, 98);
            this.pbProduct.Name = "pbProduct";
            this.pbProduct.Size = new System.Drawing.Size(129, 88);
            this.pbProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProduct.TabIndex = 7;
            this.pbProduct.TabStop = false;
            this.pbProduct.Click += new System.EventHandler(this.pbProduct_Click);
            // 
            // pbUser
            // 
            this.pbUser.Image = global::FinalGabriel.Properties.Resources.Users;
            this.pbUser.Location = new System.Drawing.Point(382, 177);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(129, 88);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUser.TabIndex = 6;
            this.pbUser.TabStop = false;
            this.pbUser.Click += new System.EventHandler(this.pbUser_Click);
            this.pbUser.MouseEnter += new System.EventHandler(this.pbUser_MouseEnter);
            this.pbUser.MouseLeave += new System.EventHandler(this.pbUser_MouseLeave);
            // 
            // pbCategory
            // 
            this.pbCategory.Image = global::FinalGabriel.Properties.Resources.category_icon;
            this.pbCategory.Location = new System.Drawing.Point(232, 98);
            this.pbCategory.Name = "pbCategory";
            this.pbCategory.Size = new System.Drawing.Size(129, 88);
            this.pbCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCategory.TabIndex = 5;
            this.pbCategory.TabStop = false;
            this.pbCategory.Click += new System.EventHandler(this.pbCategory_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(907, 561);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.pbLog);
            this.Controls.Add(this.pbProfile);
            this.Controls.Add(this.pbProduct);
            this.Controls.Add(this.pbUser);
            this.Controls.Add(this.pbCategory);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.lblProfile);
            this.Controls.Add(this.lblProdutc);
            this.Controls.Add(this.lblCategory);
            this.Name = "HomeForm";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblProdutc;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.PictureBox pbCategory;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.PictureBox pbProduct;
        private System.Windows.Forms.PictureBox pbProfile;
        private System.Windows.Forms.PictureBox pbLog;
        private System.Windows.Forms.PictureBox pbBack;
    }
}