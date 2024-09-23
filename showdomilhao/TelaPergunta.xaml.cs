namespace showdomilhao;

public partial class TelaPergunta : ContentPage
{
	Gerenciador gerenciador;
	public TelaPergunta()
	{
		InitializeComponent();

		gerenciador = new Gerenciador(Perguntas, Resposta01, Resposta02, Resposta03, Resposta04, Resposta05);
	}
	
	void Resposta01Clicado(object sender, EventArgs e)	
	{
		gerenciador.VerificaResposta(1);
	}

	void Resposta02Clicado(object sender, EventArgs e)	
	{
		gerenciador.VerificaResposta(1);
	}

	void Resposta03Clicado(object sender, EventArgs e)	
	{
		gerenciador.VerificaResposta(1);
	}

	void Resposta04Clicado(object sender, EventArgs e)	
	{
		gerenciador.VerificaResposta(1);
	}

	void Resposta05Clicado(object sender, EventArgs e)	
	{
		gerenciador.VerificaResposta(1);
	}


}