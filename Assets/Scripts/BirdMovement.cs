using Unity.Mathematics;
using UnityEngine;
public class BirdMovement : MonoBehaviour
{
    [SerializeField] private float JumpForce = 5f;
    [SerializeField] private float velocidadeRotacao = 0f;

    private Rigidbody2D rb;
    private float rotacaoMax = 30f;
    private float rotacaoMin = -45f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }
    void Update()
    {
        Movement();
        RotacaoPassaro();
        
    }
    private void Jump()
    {
        rb.velocity = Vector3.up * JumpForce;
    }
    private void RotacaoPassaro()
    {
        float rotacaoAlvo = rb.velocity.y > 0 ? rotacaoMax : rotacaoMin; 
        float novaRotacao = Mathf.MoveTowardsAngle(transform.eulerAngles.z, rotacaoAlvo, velocidadeRotacao * Time.deltaTime);
        transform.rotation = Quaternion.Euler(0, 0, novaRotacao);
    }

    public void Movement()
    {
        if(Input.GetKey(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            Jump();
            transform.rotation = Quaternion.Euler(0, 0, 30f);
        }
        
    }
}
