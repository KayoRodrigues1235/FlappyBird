
using UnityEngine;

public class MovimentoCano : MonoBehaviour
{   
    public float velocidade = 6f; // Velocidade de movimentação

    void Update()
    {
        transform.Translate(Vector3.left * velocidade * Time.deltaTime);
        
        if (transform.position.x < -20f)
        {
            Destroy(gameObject);
        }
    }
}
