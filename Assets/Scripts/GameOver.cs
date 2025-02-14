
using UnityEditor.SceneManagement;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public BirdMovement birdMovement;
    public CircleCollider2D circleCollider;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("GameOver")){
            birdMovement.GetComponent<BirdMovement>().enabled = false;
            circleCollider.isTrigger = false;
        }
    }
}
