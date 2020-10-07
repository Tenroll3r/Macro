namespace MacroLol
{
    partial class Base
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Base));
            this.Panel_Lateral = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.Btn_Principal = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.painel_Principal = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Panel_Lateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.painel_Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Lateral
            // 
            this.Panel_Lateral.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Panel_Lateral.Controls.Add(this.iconButton1);
            this.Panel_Lateral.Controls.Add(this.Btn_Principal);
            this.Panel_Lateral.Controls.Add(this.panel1);
            this.Panel_Lateral.Controls.Add(this.pictureBox1);
            this.Panel_Lateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Lateral.Location = new System.Drawing.Point(0, 0);
            this.Panel_Lateral.Name = "Panel_Lateral";
            this.Panel_Lateral.Size = new System.Drawing.Size(231, 681);
            this.Panel_Lateral.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.Font = new System.Drawing.Font("Minecrafter", 20F);
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserSecret;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(0, 619);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(231, 62);
            this.iconButton1.TabIndex = 3;
            this.iconButton1.Text = "Sobre";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // Btn_Principal
            // 
            this.Btn_Principal.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Principal.FlatAppearance.BorderSize = 0;
            this.Btn_Principal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Principal.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.Btn_Principal.Font = new System.Drawing.Font("Minecrafter", 19F);
            this.Btn_Principal.IconChar = FontAwesome.Sharp.IconChar.CookieBite;
            this.Btn_Principal.IconColor = System.Drawing.Color.Black;
            this.Btn_Principal.IconSize = 30;
            this.Btn_Principal.Location = new System.Drawing.Point(0, 175);
            this.Btn_Principal.Name = "Btn_Principal";
            this.Btn_Principal.Rotation = 0D;
            this.Btn_Principal.Size = new System.Drawing.Size(231, 62);
            this.Btn_Principal.TabIndex = 2;
            this.Btn_Principal.Text = "Macro";
            this.Btn_Principal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Principal.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 51);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // painel_Principal
            // 
            this.painel_Principal.Controls.Add(this.textBox1);
            this.painel_Principal.Controls.Add(this.label1);
            this.painel_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painel_Principal.Location = new System.Drawing.Point(231, 0);
            this.painel_Principal.Name = "painel_Principal";
            this.painel_Principal.Size = new System.Drawing.Size(1033, 681);
            this.painel_Principal.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(84, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mansagem:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textBox1.Location = new System.Drawing.Point(182, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(488, 35);
            this.textBox1.TabIndex = 1;
            // 
            // Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.painel_Principal);
            this.Controls.Add(this.Panel_Lateral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Base";
            this.Text = "Painel_Principal";
            this.Panel_Lateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.painel_Principal.ResumeLayout(false);
            this.painel_Principal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Lateral;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton Btn_Principal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel painel_Principal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

