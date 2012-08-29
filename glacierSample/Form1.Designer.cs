namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.uploadArchive = new System.Windows.Forms.Button();
            this.createVault = new System.Windows.Forms.Button();
            this.deleteVault = new System.Windows.Forms.Button();
            this.vaultName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.archiveId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.download = new System.Windows.Forms.Button();
            this.retrieveMetadata = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uploadArchive
            // 
            this.uploadArchive.Location = new System.Drawing.Point(164, 171);
            this.uploadArchive.Name = "uploadArchive";
            this.uploadArchive.Size = new System.Drawing.Size(156, 38);
            this.uploadArchive.TabIndex = 2;
            this.uploadArchive.Text = "upload";
            this.uploadArchive.UseVisualStyleBackColor = true;
            this.uploadArchive.Click += new System.EventHandler(this.uploadArchive_Click);
            // 
            // createVault
            // 
            this.createVault.Location = new System.Drawing.Point(164, 52);
            this.createVault.Name = "createVault";
            this.createVault.Size = new System.Drawing.Size(156, 38);
            this.createVault.TabIndex = 1;
            this.createVault.Text = "create vault";
            this.createVault.UseVisualStyleBackColor = true;
            this.createVault.Click += new System.EventHandler(this.createVault_Click);
            // 
            // deleteVault
            // 
            this.deleteVault.Location = new System.Drawing.Point(339, 52);
            this.deleteVault.Name = "deleteVault";
            this.deleteVault.Size = new System.Drawing.Size(156, 38);
            this.deleteVault.TabIndex = 3;
            this.deleteVault.Text = "delete vault";
            this.deleteVault.UseVisualStyleBackColor = true;
            this.deleteVault.Click += new System.EventHandler(this.deleteVault_Click);
            // 
            // vaultName
            // 
            this.vaultName.Location = new System.Drawing.Point(84, 12);
            this.vaultName.Name = "vaultName";
            this.vaultName.Size = new System.Drawing.Size(212, 19);
            this.vaultName.TabIndex = 7;
            this.vaultName.Text = "myVault";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "Vault Name";
            // 
            // archiveId
            // 
            this.archiveId.Location = new System.Drawing.Point(164, 219);
            this.archiveId.Name = "archiveId";
            this.archiveId.Size = new System.Drawing.Size(387, 19);
            this.archiveId.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "archiveId";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(339, 171);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(212, 38);
            this.progressBar1.TabIndex = 11;
            // 
            // download
            // 
            this.download.Location = new System.Drawing.Point(164, 271);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(156, 38);
            this.download.TabIndex = 12;
            this.download.Text = "download";
            this.download.UseVisualStyleBackColor = true;
            this.download.Click += new System.EventHandler(this.download_Click);
            // 
            // retrieveMetadata
            // 
            this.retrieveMetadata.Location = new System.Drawing.Point(164, 96);
            this.retrieveMetadata.Name = "retrieveMetadata";
            this.retrieveMetadata.Size = new System.Drawing.Size(156, 38);
            this.retrieveMetadata.TabIndex = 13;
            this.retrieveMetadata.Text = "retrieve metadata";
            this.retrieveMetadata.UseVisualStyleBackColor = true;
            this.retrieveMetadata.Click += new System.EventHandler(this.retrieveMetadata_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 437);
            this.Controls.Add(this.retrieveMetadata);
            this.Controls.Add(this.download);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.archiveId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vaultName);
            this.Controls.Add(this.deleteVault);
            this.Controls.Add(this.createVault);
            this.Controls.Add(this.uploadArchive);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uploadArchive;
        private System.Windows.Forms.Button createVault;
        private System.Windows.Forms.Button deleteVault;
        private System.Windows.Forms.TextBox vaultName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox archiveId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button download;
        private System.Windows.Forms.Button retrieveMetadata;
    }
}

