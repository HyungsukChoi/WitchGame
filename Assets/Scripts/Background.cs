using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    static float BG_MIN_HEIGHT = -16.0f;
    float bgSpeed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BGMove();
    }

    void BGMove()
    {
        transform.Translate(0, -bgSpeed * Time.deltaTime, 0);

        if (transform.position.y <= BG_MIN_HEIGHT)
        {
            transform.Translate(0, -3.0f * BG_MIN_HEIGHT, 0);
        }
    }
}
