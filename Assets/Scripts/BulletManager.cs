using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    public Player player;
    public GameObject bulletPrefab;
    List<GameObject> bullets;
    static int bullet_Num = 30;
    static float fire_Interval = 0.2f;
    static float time = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        CreateBullet();
    }

    // Update is called once per frame
    void Update()
    {
        SpawnBullet();
    }

    void CreateBullet()
    {
        bullets = new List<GameObject>();

        for(int i = 0; i < bullet_Num; i++)
        {
            GameObject tempBullet = Instantiate(bulletPrefab);
            tempBullet.SetActive(false);
            bullets.Add(tempBullet);
        }
    }

    public void SpawnBullet()
    {
        if (!player.isFiring) return;

        time += Time.deltaTime;

        if( time >= fire_Interval)
        {
            foreach (GameObject bullet in bullets)
            {
                if (!bullet.activeSelf)
                {
                    bullet.transform.position = player.transform.position + new Vector3(0, 0.8f, 0);
                    bullet.SetActive(true);
                    time = 0.0f;
                    break;
                }
            }
        }
    }
}
