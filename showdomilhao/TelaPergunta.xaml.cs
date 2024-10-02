namespace showdomilhao
{
    public partial class TelaPergunta : ContentPage
    {
        Gerenciador gerenciador;
        public TelaPergunta()
        {
            InitializeComponent();
            gerenciador = new Gerenciador (labelPergunta, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05, labelPontuacao, labelNivel);
        }

        private void Resposta01Clicado (object sender, EventArgs e)
        {
            gerenciador!.VerificaResposta(1);
        }
        private void Resposta02Clicado (object sender, EventArgs e)
        {
            gerenciador!.VerificaResposta(2);
        }
        private void Resposta03Clicado (object sender, EventArgs e)
        {
            gerenciador!.VerificaResposta(3);
        }
        private void Resposta04Clicado (object sender, EventArgs e)
        {
            gerenciador!.VerificaResposta(4);
        }
        private void Resposta05Clicado (object sender, EventArgs e)
        {
            gerenciador!.VerificaResposta(5);
 
        }
    }
}