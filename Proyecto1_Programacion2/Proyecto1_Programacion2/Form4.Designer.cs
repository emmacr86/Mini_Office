namespace Proyecto1_Programacion2
{
    partial class VisorFRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisorFRM));
            this.btnAbrir = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listViewFile = new System.Windows.Forms.ListView();
            this.PanelImagen = new System.Windows.Forms.Panel();
            this.btnFoward = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBoxImagen = new System.Windows.Forms.PictureBox();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.PanelImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).BeginInit();
            this.panelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAbrir
            // 
            this.btnAbrir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbrir.Location = new System.Drawing.Point(319, 308);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(85, 23);
            this.btnAbrir.TabIndex = 0;
            this.btnAbrir.Text = "Abrir Directorio";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Robsonbillponte-Sinem-File-Picture.ico");
            // 
            // listViewFile
            // 
            this.listViewFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewFile.LargeImageList = this.imageList1;
            this.listViewFile.Location = new System.Drawing.Point(319, 12);
            this.listViewFile.Name = "listViewFile";
            this.listViewFile.Size = new System.Drawing.Size(160, 290);
            this.listViewFile.TabIndex = 1;
            this.listViewFile.UseCompatibleStateImageBehavior = false;
            this.listViewFile.ItemActivate += new System.EventHandler(this.listViewFile_ItemActivate);
            // 
            // PanelImagen
            // 
            this.PanelImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelImagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelImagen.Controls.Add(this.btnFoward);
            this.PanelImagen.Controls.Add(this.btnBack);
            this.PanelImagen.Controls.Add(this.pictureBoxImagen);
            this.PanelImagen.Location = new System.Drawing.Point(12, 12);
            this.PanelImagen.Name = "PanelImagen";
            this.PanelImagen.Size = new System.Drawing.Size(292, 290);
            this.PanelImagen.TabIndex = 2;
            // 
            // btnFoward
            // 
            this.btnFoward.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFoward.Image = global::Proyecto1_Programacion2.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_go_next;
            this.btnFoward.Location = new System.Drawing.Point(161, 239);
            this.btnFoward.Name = "btnFoward";
            this.btnFoward.Size = new System.Drawing.Size(47, 34);
            this.btnFoward.TabIndex = 2;
            this.btnFoward.UseVisualStyleBackColor = true;
            this.btnFoward.Click += new System.EventHandler(this.btnFoward_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBack.Image = global::Proyecto1_Programacion2.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_go_previous;
            this.btnBack.Location = new System.Drawing.Point(90, 239);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(47, 34);
            this.btnBack.TabIndex = 1;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBoxImagen
            // 
            this.pictureBoxImagen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxImagen.Location = new System.Drawing.Point(15, 47);
            this.pictureBoxImagen.Name = "pictureBoxImagen";
            this.pictureBoxImagen.Size = new System.Drawing.Size(258, 182);
            this.pictureBoxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImagen.TabIndex = 0;
            this.pictureBoxImagen.TabStop = false;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.btnCerrar);
            this.panelPrincipal.Controls.Add(this.btnAbrir);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(491, 343);
            this.panelPrincipal.TabIndex = 3;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Location = new System.Drawing.Point(410, 309);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(69, 23);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // VisorFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 343);
            this.Controls.Add(this.PanelImagen);
            this.Controls.Add(this.listViewFile);
            this.Controls.Add(this.panelPrincipal);
            this.Name = "VisorFRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Visor";
            this.PanelImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).EndInit();
            this.panelPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listViewFile;
        private System.Windows.Forms.Panel PanelImagen;
        private System.Windows.Forms.PictureBox pictureBoxImagen;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnFoward;
        private System.Windows.Forms.Button btnBack;
    }
}