using TMPro;
using UnityEngine;


public class GerenciadorPontuacao : MonoBehaviour
{
    private int pontuacaoAtual;
    public TextMeshProUGUI msgPontuacao;

    void Start()
    {
        AtualizarPontuacao();
    }
    public void AumentarPontuacao()
    {
        pontuacaoAtual++;
        AtualizarPontuacao();
    }
    public void AtualizarPontuacao()
    {
        msgPontuacao.text = "Score: " + pontuacaoAtual.ToString();
    }
}
