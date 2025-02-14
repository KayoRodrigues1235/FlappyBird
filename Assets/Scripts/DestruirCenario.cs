using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirCenario : MonoBehaviour
{
    Vector3 startPos;
    public float repeatWidth;

    private void Start() {
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider2D>().size.x;
    }
    void Update()
    {
        if(transform.position.x < startPos.x - repeatWidth )
        {
            transform.position = startPos;
        }
        
    }
}
