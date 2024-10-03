public class Questao : IEquatable<Questao>
{
    public Questao()
    {

    }
    public string pergunta { get; set; }
    public string resposta01 { get; set; }
    public string resposta02 { get; set; }
    public string resposta03 { get; set; }
    public string resposta04 { get; set; }
    public string resposta05 { get; set; }
    public int respostacorreta { get; set; }
    public int nivelpergunta { get; set; }

    public void Desenhar()
    {
      labelPergunta.Text = pergunta;
      btnResposta01.Text = resposta01;
      btnResposta02.Text = resposta02;
      btnResposta03.Text = resposta03;
      btnResposta04.Text = resposta04;
      btnResposta05.Text = resposta05;

      btnResposta01!.BackgroundColor = Colors.Beige;
      btnResposta01!.TextColor       = Colors.Black;
      btnResposta02!.BackgroundColor = Colors.Beige;
      btnResposta02!.TextColor       = Colors.Black;
      btnResposta03!.BackgroundColor = Colors.Beige;
      btnResposta03!.TextColor       = Colors.Black;
      btnResposta04!.BackgroundColor = Colors.Beige;
      btnResposta04!.TextColor       = Colors.Black;
      btnResposta05!.BackgroundColor = Colors.Beige;
      btnResposta05!.TextColor       = Colors.Black;
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
        if (respostacorreta == RR)
        {
            var btn = Qualbtn (RR);
                btn.BackgroundColor = Colors.GreenYellow;
            return true; 
        }
        else
        {
            var btnCorreto = Qualbtn (respostacorreta);
            var btnIncorreto = Qualbtn (RR);
            btnCorreto.BackgroundColor = Colors.GreenYellow;
            btnIncorreto.BackgroundColor = Colors.Red;

            return false;
        }
    }

    private Button Qualbtn(int RR)
    {
        if (RR == 1)
          return btnResposta01;

        else if (RR == 2)
          return btnResposta02;
        
        else if (RR == 3)
           return btnResposta03;
        
        else if (RR == 4)
           return btnResposta04;

        else if (RR == 5)
           return btnResposta05;

        else 
        return null;
    }

    public bool Equals (Questao q )
    { 
        return this.nivelpergunta == q.nivelpergunta && this.pergunta == q.pergunta;
    }

    
}