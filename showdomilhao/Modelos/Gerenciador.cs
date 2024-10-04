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
        Q1.nivelpergunta = 1;
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
        Q2.nivelpergunta = 1;
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
        Q3.nivelpergunta = 1;
        Q3.ConfigurarEstruturaDesenho(LabelPerg, btnResposta01, btnResposta02, btnResposta03, btnResposta04, btnResposta05);
        Q3.pergunta = "Qual é o oceano mais profundo do mundo?";
        Q3.resposta01 = "Atlântico";
        Q3.resposta02 = "Índico";
        Q3.resposta03 = "Pacífico";
        Q3.resposta04 = "Ártico";
        Q3.resposta05 = "Antaértico";
        Q3.respostacorreta= 3;
        ListaTodaQuestoes.Add(Q3);

        
        var Q4 = new Questao();
        Q4.nivelpergunta = 1;
        Q4.ConfigurarEstruturaDesenho(LabelPerg, btnResposta01, btnResposta02, btnResposta03, btnResposta04, btnResposta05);
        Q4.pergunta = "Quem pintou a Mona Lisa?";
        Q4.resposta01 = "Vincent van Gogh";
        Q4.resposta02 = "Pablo Picasso";
        Q4.resposta03 = "Leonardo da Vinci";
        Q4.resposta04 = "Claude Monet";
        Q4.resposta05 = "Salvador Dalí";
        Q4.respostacorreta = 3;
        ListaTodaQuestoes.Add(Q4);

        var Q5 = new Questao();
        Q5.nivelpergunta = 1;
        Q5.ConfigurarEstruturaDesenho(LabelPerg, btnResposta01, btnResposta02, btnResposta03, btnResposta04, btnResposta05);
        Q5.pergunta = "Qual é a fórmula química da água?";
        Q5.resposta01 = "H2O";
        Q5.resposta02 = "CO2";
        Q5.resposta03 = "O2";
        Q5.resposta04 = "H2O2";
        Q5.resposta05 = "CH4";
        Q5.respostacorreta = 1;
        ListaTodaQuestoes.Add(Q5);

        var Q6 = new Questao();
        Q6.nivelpergunta = 1;
        Q6.ConfigurarEstruturaDesenho(LabelPerg, btnResposta01, btnResposta02, btnResposta03, btnResposta04, btnResposta05);
        Q6.pergunta = "Qual é o continente onde está localizado o Egito?";
        Q6.resposta01 = "Ásia";
        Q6.resposta02 = "América";
        Q6.resposta03 = "África";
        Q6.resposta04 = "Europa";
        Q6.resposta05 = "Oceania";
        Q6.respostacorreta = 3;
        ListaTodaQuestoes.Add(Q6);

        var Q7 = new Questao();
        Q7.nivelpergunta= 1;
        Q7.ConfigurarEstruturaDesenho(LabelPerg, btnResposta01, btnResposta02, btnResposta03, btnResposta04, btnResposta05);
        Q7.pergunta = "Qual é a moeda do Japão?";
        Q7.resposta01 = "Yuan";
        Q7.resposta02 = "Won";
        Q7.resposta03 = "Dólar";
        Q7.resposta04 = "Iene";
        Q7.resposta05 = "Rupia";
        Q7.respostacorreta = 4;
        ListaTodaQuestoes.Add(Q7);

        var Q8 = new Questao();
        Q8.nivelpergunta = 1;
        Q8.ConfigurarEstruturaDesenho(LabelPerg, btnResposta01, btnResposta02, btnResposta03, btnResposta04, btnResposta05);
        Q8.pergunta = "Quem é conhecido como o 'Rei do Pop'?";
        Q8.resposta01 = "Elvis Presley";
        Q8.resposta02 = "Michael Jackson";
        Q8.resposta03 = "Prince";
        Q8.resposta04 = "David Bowie";
        Q8.resposta05 = "Freddie Mercury";
        Q8.respostacorreta = 2;
        ListaTodaQuestoes.Add(Q8);

        var Q9 = new Questao();
        Q9.nivelpergunta = 1;
        Q9.ConfigurarEstruturaDesenho(LabelPerg, btnResposta01, btnResposta02, btnResposta03, btnResposta04, btnResposta05);
        Q9.pergunta = "Qual é o órgão responsável por bombear o sangue no corpo humano?";
        Q9.resposta01 = "Fígado";
        Q9.resposta02 = "Coração";
        Q9.resposta03 = "Pulmão";
        Q9.resposta04 = "Rim";
        Q9.resposta05 = "Estômago";
        Q9.respostacorreta = 2;
        ListaTodaQuestoes.Add(Q9);

        var Q10 = new Questao();
        Q10.nivelpergunta = 1;
        Q10.ConfigurarEstruturaDesenho(LabelPerg, btnResposta01, btnResposta02, btnResposta03, btnResposta04, btnResposta05);
        Q10.pergunta = "Qual é a língua oficial do Brasil?";
        Q10.resposta01 = "Espanhol";
        Q10.resposta02 = "Inglês";
        Q10.resposta03 = "Francês";
        Q10.resposta04 = "Português";
        Q10.resposta05 = "Italiano";
        Q10.respostacorreta = 4;
        ListaTodaQuestoes.Add(Q10);

        var Q11 = new Questao();
        Q11.nivelpergunta = 2;
        Q11.ConfigurarEstruturaDesenho(LabelPerg, btnResposta01, btnResposta02, btnResposta03, btnResposta04, btnResposta05);
        Q11.pergunta = "Qual é o nome do famoso cientista que formulou a teoria da relatividade?";
        Q11.resposta01 = "Isaac Newton";
        Q11.resposta02 = "Albert Einstein";
        Q11.resposta03 = "Galileu Galilei";
        Q11.resposta04 = "Nikola Tesla";
        Q11.resposta05 = "Stephen Hawking";
        Q11.respostacorreta = 2;
        ListaTodaQuestoes.Add(Q11);

        var Q12 = new Questao();
        Q12.nivelpergunta = 2;
        Q12.ConfigurarEstruturaDesenho(LabelPerg, btnResposta01, btnResposta02, btnResposta03, btnResposta04, btnResposta05);
        Q12.pergunta = "Qual é o maior oceano do mundo?";
        Q12.resposta01 = "Oceano Atlântico";
        Q12.resposta02 = "Oceano Índico";
        Q12.resposta03 = "Oceano Pacífico";
        Q12.resposta04 = "Oceano Ártico";
        Q12.resposta05 = "Oceano Antártico";
        Q12.respostacorreta = 3;
        ListaTodaQuestoes.Add(Q12);

        var Q13 = new Questao();
        Q13.nivelpergunta = 2;
        Q13.ConfigurarEstruturaDesenho(LabelPerg, btnResposta01, btnResposta02, btnResposta03, btnResposta04, btnResposta05);
        Q13.pergunta = "Qual é a capital da Itália?";
        Q13.resposta01 = "Roma";
        Q13.resposta02 = "Milão";
        Q13.resposta03 = "Nápoles";
        Q13.resposta04 = "Florença";
        Q13.resposta05 = "Veneza";
        Q13.respostacorreta = 1;
        ListaTodaQuestoes.Add(Q13);

        var Q14 = new Questao();
        Q14.nivelpergunta = 2;
        Q14.ConfigurarEstruturaDesenho(LabelPerg, btnResposta01, btnResposta02, btnResposta03, btnResposta04, btnResposta05);
        Q14.pergunta = "Qual é o planeta mais próximo do sol?";
        Q14.resposta01 = "Terra";
        Q14.resposta02 = "Marte";
        Q14.resposta03 = "Mercúrio";
        Q14.resposta04 = "Vênus";
        Q14.resposta05 = "Júpiter";
        Q14.respostacorreta = 3;
        ListaTodaQuestoes.Add(Q14);

        var Q15 = new Questao();
        Q15.nivelpergunta = 2;
        Q15.ConfigurarEstruturaDesenho(LabelPerg, btnResposta01, btnResposta02, btnResposta03, btnResposta04, btnResposta05);
        Q15.pergunta = "Qual é o maior planeta do sistema solar?";
        Q15.resposta01 = "Terra";
        Q15.resposta02 = "Marte";
        Q15.resposta03 = "Júpiter";
        Q15.resposta04 = "Saturno";
        Q15.resposta05 = "Vênus";
        Q15.respostacorreta = 3;
        ListaTodaQuestoes.Add(Q15);

        var Q16 = new Questao();
        Q16.nivelpergunta = 2;
        Q16.ConfigurarEstruturaDesenho(LabelPerg, btnResposta01, btnResposta02, btnResposta03, btnResposta04, btnResposta05);
        Q16.pergunta = "Qual é a capital da França?";
        Q16.resposta01 = "Berlim";
        Q16.resposta02 = "Madrid";
        Q16.resposta03 = "Paris";
        Q16.resposta04 = "Roma";
        Q16.resposta05 = "Lisboa";
        Q16.respostacorreta = 3;
        ListaTodaQuestoes.Add(Q16);

        var Q17 = new Questao();
        Q17.nivelpergunta = 2;
        Q17.ConfigurarEstruturaDesenho(LabelPerg, btnResposta01, btnResposta02, btnResposta03, btnResposta04, btnResposta05);
        Q17.pergunta = "Quem escreveu 'Dom Casmurro'?";
        Q17.resposta01 = "Machado de Assis";
        Q17.resposta02 = "José de Alencar";
        Q17.resposta03 = "Joaquim Manuel de Macedo";
        Q17.resposta04 = "Clarice Lispector";
        Q17.resposta05 = "Carlos Drummond de Andrade";
        Q17.respostacorreta = 1;
        ListaTodaQuestoes.Add(Q17);

        var Q18 = new Questao();
        Q18.nivelpergunta = 2;
        Q8.ConfigurarEstruturaDesenho(LabelPerg, btnResposta01, btnResposta02, btnResposta03, btnResposta04, btnResposta05);
        Q18.pergunta = "Qual é o elemento químico representado pela letra 'O'?";
        Q18.resposta01 = "Ouro";
        Q18.resposta02 = "Oxigênio";
        Q18.resposta03 = "Ósmio";
        Q18.resposta04 = "Oganessônio";
        Q18.resposta05 = "Prata";
        Q18.respostacorreta = 2;
        ListaTodaQuestoes.Add(Q18);

        var Q19 = new Questao();
        Q19.nivelpergunta = 2;
        Q19.ConfigurarEstruturaDesenho(LabelPerg, btnResposta01, btnResposta02, btnResposta03, btnResposta04, btnResposta05);
        Q19.pergunta = "Qual é o maior deserto do mundo?";
        Q19.resposta01 = "Deserto do Saara";
        Q19.resposta02 = "Deserto da Antártida";
        Q19.resposta03 = "Deserto de Gobi";
        Q19.resposta04 = "Deserto da Arábia";
        Q19.resposta05 = "Deserto de Kalahari";
        Q19.respostacorreta = 2;
        ListaTodaQuestoes.Add(Q19);

        var Q20 = new Questao();
        Q20.nivelpergunta = 2;
        Q20.ConfigurarEstruturaDesenho(LabelPerg, btnResposta01, btnResposta02, btnResposta03, btnResposta04, btnResposta05);
        Q20.pergunta = "Quem pintou 'A Última Ceia'?";
        Q20.resposta01 = "Michelangelo";
        Q20.resposta02 = "Leonardo da Vinci";
        Q20.resposta03 = "Raphael";
        Q20.resposta04 = "Van Gogh";
        Q20.resposta05 = "Monet";
        Q20.respostacorreta = 2;
        ListaTodaQuestoes.Add(Q20);



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