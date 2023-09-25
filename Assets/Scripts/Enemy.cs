using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    float speed = 5.5f;
    public bool isDead = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        if( gameObject.activeSelf)
            transform.Translate(Vector2.down * speed * Time.deltaTime);

        if( transform.position.y <= -5.0f)
        {
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            isDead = true;
            GetComponent<Animator>().SetBool("isDead", isDead);
        }
    }

    void ResetPos()
    {
        gameObject.SetActive(false);
        gameObject.transform.position = new Vector2(0, 5.0f);
    }
}
