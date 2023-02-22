namespace downloadPDF
{
    using System.Net;

    public partial class formDownloadPDF : Form
    {
        public formDownloadPDF()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            var download = new WebClient();

            download.DownloadFile("https://arquivos.unifafibe.com.br/PAGINACURSO/SISTEMAS_INFORMACAO/62a3d2bb1da421654903483.pdf", "C:\\Users\\administrator\\Desktop\\UNIFAFIBE\\Visual Studio\\downloadPDF\\arquivos\\" + "sistemasInformacao.pdf");

            MessageBox.Show("Arquivo baixado com sucesso! :)");
        }
    }
}