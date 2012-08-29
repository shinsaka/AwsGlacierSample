using System;
using System.Windows.Forms;
using Amazon;
using Amazon.Glacier;
using Amazon.Glacier.Transfer;
using Amazon.Glacier.Model;
using Amazon.Runtime;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private RegionEndpoint getRegionEndpoint()
        {
            return RegionEndpoint.USEast1;
        }

        private ArchiveTransferManager getManager()
        {
            return new ArchiveTransferManager(this.getRegionEndpoint());
        }

        void progress(object sender, StreamTransferProgressArgs args)
        {
            progressBar1.Value = args.PercentDone;
        }

        private void createVault_Click(object sender, EventArgs e)
        {
            try
            {
                ArchiveTransferManager manager = this.getManager();
                manager.CreateVault(vaultName.Text);
                MessageBox.Show(String.Format("create vault:{0}", vaultName.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteVault_Click(object sender, EventArgs e)
        {
            try
            {
                ArchiveTransferManager manager = this.getManager();
                manager.DeleteVault(vaultName.Text);
                MessageBox.Show(String.Format("delete vault:{0}", vaultName.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void uploadArchive_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            if (openfile.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            try
            {
                ArchiveTransferManager manager = this.getManager();

                UploadOptions options = new UploadOptions();
                options.StreamTransferProgress += this.progress;
                progressBar1.Value = 0;

                UploadResult upload = manager.Upload(vaultName.Text, "description", openfile.FileName, options);

                archiveId.Text = upload.ArchiveId;
                MessageBox.Show("upload complete" + openfile.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void download_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            if (savefile.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            try
            {
                ArchiveTransferManager manager = this.getManager();

                DownloadOptions options = new DownloadOptions();
                options.StreamTransferProgress += this.progress;
                progressBar1.Value = 0;

                manager.Download(vaultName.Text, archiveId.Text, savefile.FileName, options);
                MessageBox.Show("download complete" + savefile.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void retrieveMetadata_Click(object sender, EventArgs e)
        {
            try
            {
                AmazonGlacierClient client = new AmazonGlacierClient(this.getRegionEndpoint());
                DescribeVaultRequest describeVaultRequest = new DescribeVaultRequest()
                {
                    VaultName = vaultName.Text
                };
                DescribeVaultResponse describeVaultResponse = client.DescribeVault(describeVaultRequest);
                DescribeVaultResult describeVaultResult = describeVaultResponse.DescribeVaultResult;

                String result =
                    "VaultName: " + describeVaultResult.VaultName +
                    "\nVaultARN: " + describeVaultResult.VaultARN +
                    "\nVaultCreationDate: " + describeVaultResult.CreationDate +
                    "\nNumberOfArchives: " + describeVaultResult.NumberOfArchives +
                    "\nSizeInBytes: " + describeVaultResult.SizeInBytes +
                    "\nLastInventoryDate:" + describeVaultResult.LastInventoryDate
                ;
                MessageBox.Show(result, "Vault description");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    }
