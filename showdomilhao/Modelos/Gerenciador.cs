using showdomilhao;

public class Gerenciador
{
    List<Questao> ListaQuestoes = new List<Questao>();
    List<int> ListaQuestoesRespondidas = new List<int>();
    Questao QuestaoCorrente;

    public Gerenciador(Label LabelPerg, Button btnResposta01, Button btnResposta02, Button btnResposta03, Button btnResposta04, Button btnResposta05)
    {
        CriaPerguntas(LabelPerg, btnResposta01, btnResposta02, btnResposta03, btnResposta04, btnResposta05);
    }

    void CriaPerguntas(Label LabelPerg, Button btnResposta01, Button btnResposta02, Button btnResposta03, Button btnResposta04, Button btnResposta05) 
    {
        var Q1 = new Questao();
        Q1.ConfigurarEstruturaDesenho(LabelPerg, btnResposta01, btnResposta02, btnResposta03, btnResposta04, btnResposta05);
        Q1.pergunta = "Quanto é 2+2";
        Q1.resposta01 = "2";
        Q1.resposta02 = "22";
        Q1.resposta03 = "4";
        Q1.resposta04 = "SIM";
        Q1.resposta05 = "1";
        Q1.respostacorreta= 3;
        ListaQuestoes.Add(Q1);

        ProximaQuestao();

    }

    public async void VerificaResposta(int RR)
    {
        if (QuestaoCorrente.VerificaResposta(RR))
        {
            await Task.Delay(1000);
            AdicionaPontuacao(NivelAtual);
            NivelAtual ++;
            ProximaQuestao();
        }
        else
        {
            await App.Current.MainPage.DisplayAlert ("Game Over", "Que pena... Você errou!", "OK");
            Inicializar();
        }
    }

    void ProximaQuestao()
    {
        var numAleat = Random.Shared.Next(0, ListaQuestoes.Count);
        while (ListaQuestoesRespondidas.Contains(numAleat))
              numAleat = Random.Shared.Next(0, ListaQuestoes.Count);
        ListaQuestoesRespondidas.Add(numAleat);
        QuestaoCorrente = ListaQuestoes[numAleat];
        QuestaoCorrente.Desenhar();
    }

    public int Pontuacao{get; private set;}
    int NivelAtual=0;

    void  Inicializar()
    {
        Pontuacao = 0;
        NivelAtual = 1;
        ProximaQuestao();
    }

    void AdicionaPontuacao(int n)
    {
        if (n==1)
          Pontuacao = 1000;
        else if (n==2)  
          Pontuacao = 2000;
        else if (n==3)  
          Pontuacao = 5000;
        else if (n==2)  
          Pontuacao = 10000;
        else if (n==3)  
          Pontuacao = 20000;
        else if (n==2)  
          Pontuacao = 50000;
        else if (n==3)  
          Pontuacao = 100000;
        else if (n==2)  
          Pontuacao = 200000;
        else if (n==3)  
          Pontuacao = 500000;
         else if (n==3)  
          Pontuacao = 1000000;
    }


}