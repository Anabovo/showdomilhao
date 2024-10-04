public class Universitarios : IAjuda
{
    public override void RealizaAjuda(Questao questao)
    {
        var porcentagem = 100;
        for (int i = 0; i < 5; i++)
        {
            int NumRand = 0;
            if (porcentagem > 0)
            {
                NumRand = Random.Shared.Next(0, porcentagem);
                porcentagem -= NumRand;
            }

            switch (i)
            {
                case 0:
                    btnResp01.Text += "=" + NumRand.ToString() + "%";
                    break;
                case 1:
                    btnResp02.Text += "=" + NumRand.ToString() + "%";
                    break;
                case 2:
                    btnResp03.Text += "=" + NumRand.ToString() + "%";
                    break;
                case 3:
                    btnResp04.Text += "=" + NumRand.ToString() + "%";
                    break;
                case 4:
                    btnResp05.Text += "=" + NumRand.ToString() + "%";
                    break;
            }
        }
    }
}