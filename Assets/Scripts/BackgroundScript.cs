using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundScript : MonoBehaviour
{
   public float speed = 1f;
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * speed);
    }
}
