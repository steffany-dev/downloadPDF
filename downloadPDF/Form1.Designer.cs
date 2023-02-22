namespace downloadPDF
{
    partial class formDownloadPDF
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDownload = new Button();
            SuspendLayout();
            // 
            // btnDownload
            // 
            btnDownload.Location = new Point(115, 89);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(180, 64);
            btnDownload.TabIndex = 0;
            btnDownload.Text = "Download de Arquivo";
            btnDownload.Click += btnDownload_Click;
            // 
            // formDownloadPDF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 241);
            Controls.Add(btnDownload);
            Name = "formDownloadPDF";
            Text = "Download de PDF";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDownload;
    }
}