public class Questao
{
    public Questao()
    {

    }
    public string pergunta { get; set; }
    public string resposta1 { get; set; }
    public string resposta2 { get; set; }
    public string resposta3 { get; set; }
    public string resposta4 { get; set; }
    public string resposta5 { get; set; }
    public int respostacorreta { get; set; }
    public int nivelpergunta { get; set; }

    public void desenhar()
    {
      labelPergunta.Text = pergunta;
      btnResposta01.Text = resposta1;
      btnResposta02.Text = resposta2;
      btnResposta03.Text = resposta3;
      btnResposta04.Text = resposta4;
      btnResposta05.Text = resposta5;
    }

    private Label labelPergunta; 
    private Button btnResposta01;
    private Button btnResposta02;
    private Button btnResposta03;
    private Button btnResposta04;   
    private Button btnResposta05;   

    public Questao(Label lp, Button bt01, Button bt02, Button bt03, Button bt04, Button bt05)
    {
        labelPergunta = lp;
        btnResposta01 = bt01;
        btnResposta02 = bt02;
        btnResposta03 = bt03;
        btnResposta04 = bt04;
        btnResposta05 = bt05;

    }

     public void ConfigurarEstruturaDesenho(Label lp, Button bt01, Button bt02, Button bt03, Button bt04, Button bt05)
    {
        labelPergunta = lp;
        btnResposta01 = bt01;
        btnResposta02 = bt02;
        btnResposta03 = bt03;
        btnResposta04 = bt04;
        btnResposta05 = bt05;

    }

    public bool VerificaResposta(int RR)
    {
        if (RespostaRespondida == RR)
        {
            var btn = Qualbnt (RR);
                btn.BackgroundColor = Colors.Green;
            return true; 
        }
        else
        {
            return false;
        }
    }


}