using UnityEngine;


public class Canos : MonoBehaviour
{
     public GameObject canoPrefabSuperior; // O prefab do cano superior
    public GameObject canoPrefabInferior; // O prefab do cano inferior
    public float tempoEntrePlataformas = 2f; // Intervalo entre a criação dos canos
    public float alturaMinima = -2f; // Posição mínima no eixo Y para o cano inferior
    public float alturaMaxima = 2f; // Posição máxima no eixo Y para o cano superior
    public float distanciaEntrePlataformas = 5f; // Distância entre os canos no eixo X
    public float espacoEntrePlataformas = 3f; // Espaço entre o cano superior e inferior
    private float timer;

       void Update()
    {
       
        timer += Time.deltaTime;

        // Verifica se o tempo entre os canos passou
        if (timer >= tempoEntrePlataformas)
        {
            GerarCanos();
            timer = 0f; // Reseta o timer
        }
    }

    void GerarCanos()
    {
        
        float alturaAleatoria = Random.Range(alturaMinima, alturaMaxima);

        
        GameObject canoPair = new GameObject("CanoPair");

       
        GameObject canoSuperior = Instantiate(canoPrefabSuperior, new Vector3(transform.position.x + distanciaEntrePlataformas, alturaAleatoria, 0f), Quaternion.identity);
        GameObject canoInferior = Instantiate(canoPrefabInferior, new Vector3(transform.position.x + distanciaEntrePlataformas, alturaAleatoria - espacoEntrePlataformas, 0f), Quaternion.identity);

        
        canoSuperior.transform.parent = canoPair.transform;
        canoInferior.transform.parent = canoPair.transform;

        MovimentoCano movimentoCano = canoPair.AddComponent<MovimentoCano>();

        movimentoCano.velocidade = 2f; 

        
    }
}

