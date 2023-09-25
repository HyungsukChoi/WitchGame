using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float speed = 4.0f;
    public bool isFiring = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Fire();
    }

    void Move()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(Vector2.right * speed * Time.deltaTime);

        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -2.1f, 2.1f), Mathf.Clamp(transform.position.y, -3.8f, 3.7f));
    }

    void Fire()
    {
        if( Input.GetKey(KeyCode.Space))
        {
            isFiring = true;
        }
        else
        {
            isFiring = false;
        }
    }
}
