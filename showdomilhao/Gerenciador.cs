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
        Q1.ConfigurarDesenho(LabelPerg, btnResposta01, btnResposta02, btnResposta03, btnResposta04, btnResposta05);
        Q1.pergunta = "Quanto é 2+2";
        Q1.resposta01 = "2";
        Q1.resposta02 = "22";
        Q1.resposta03 = "4";
        Q1.resposta04 = "sim";
        Q1.resposta05 = "1";
        Q1.respostacorreta= 3;
        ListaQuestoes.Add(Q1);

    }

    public async void VerificaResposta(int RR)
    {
        if (QuestaoCorrente.VerificaResposta(RR))
        {
            await TaskDelay(1000);
            ProximaQuestao();
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
}