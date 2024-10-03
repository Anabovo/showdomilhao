using showdomilhao;

public class Gerenciador
{
    Label labelPontuacao;
    Label labelNivel;
    List<Questao> ListaTodaQuestoes = new List<Questao>();
    List<Questao> ListaTodaQuestoesRespondidas = new List<Questao>();
    Questao QuestaoCorrente;

    

    public Gerenciador(Label LabelPerg, Button btnResposta01, Button btnResposta02, Button btnResposta03, Button btnResposta04, Button btnResposta05, Label labelPontuacao, Label labelNivel)
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
        ListaTodaQuestoes.Add(Q1);

        var Q2 = new Questao();
        Q2.ConfigurarEstruturaDesenho(LabelPerg, btnResposta01, btnResposta02, btnResposta03, btnResposta04, btnResposta05);
        Q2.pergunta = "Em qual continente se localiza o Egito?";
        Q2.resposta01 = "América";
        Q2.resposta02 = "Ásia";
        Q2.resposta03 = "Europa";
        Q2.resposta04 = "África";
        Q2.resposta05 = "Oceania";
        Q2.respostacorreta= 4;
        ListaTodaQuestoes.Add(Q2);

        var Q3 = new Questao();
        Q3.ConfigurarEstruturaDesenho(LabelPerg, btnResposta01, btnResposta02, btnResposta03, btnResposta04, btnResposta05);
        Q3.pergunta = "Qual é o oceano mais profundo do mundo?";
        Q3.resposta01 = "Atlântico";
        Q3.resposta02 = "Índico";
        Q3.resposta03 = "Pacífico";
        Q3.resposta04 = "Ártico";
        Q3.resposta05 = "Antaértico";
        Q3.respostacorreta= 3;
        ListaTodaQuestoes.Add(Q3);



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

    public void ProximaQuestao()
    {
      var ListaTodasQuestoes = ListaTodaQuestoes.Where(d=>d.nivelpergunta==NivelAtual).ToList();
      var NumRand = Random.Shared.Next(0, ListaTodaQuestoes.Count);
      var NovaQuestao = ListaTodaQuestoes[NumRand];
      while (ListaTodaQuestoesRespondidas.Contains(NovaQuestao))
      {
        NumRand = Random.Shared.Next(0, ListaTodaQuestoes.Count);
        NovaQuestao = ListaTodasQuestoes[NumRand];
      }
        ListaTodaQuestoes.Add(NovaQuestao);
        QuestaoCorrente = NovaQuestao;
        QuestaoCorrente.Desenhar();
    }
   

    public int Pontuacao{get; private set;}
    int NivelAtual=0;

    void  Inicializar()
    {
        Pontuacao = 0;
        NivelAtual = 1;
        ProximaQuestao();
        ListaTodaQuestoesRespondidas.Clear();
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

    public Questao GetQuestaoCorrente()
    {
      return QuestaoCorrente;
    }
    
   



}