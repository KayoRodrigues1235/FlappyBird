using UnityEditor.SceneManagement;
using UnityEngine;

public class Pontuar : MonoBehaviour
{
    public GerenciadorPontuacao gerenciadorPontuacao;

   private void OnTriggerEnter2D(Collider2D other) {
    if(other.CompareTag("Cano")){
       Debug.Log("Jogador marcou 1 ponto");
       gerenciadorPontuacao.AumentarPontuacao(); 
    }
   }
}
