using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject firemoth;
    public GameObject ladybug;
    List<GameObject> firemoths;
    List<GameObject> ladybugs;
    static int enemy_Num = 20;
    static float spawn_Time = 1.0f;
    float time = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        GenerateEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        SpawnEnemy();
    }

    void GenerateEnemy()
    {
        firemoths = new List<GameObject>();
        ladybugs = new List<GameObject>();

        for( int i = 0; i < enemy_Num; i++)
        {
            GameObject tempEnemy = Instantiate(firemoth);
            tempEnemy.SetActive(false);
            firemoths.Add(tempEnemy);
        }

        for (int i = 0; i < enemy_Num; i++)
        {
            GameObject tempEnemy = Instantiate(ladybug);
            tempEnemy.SetActive(false);
            ladybugs.Add(tempEnemy);
        }
    }

    void SpawnEnemy()
    {
        time += Time.deltaTime;

        if( time >= spawn_Time)
        {
            int random = Random.Range(0, 2);

            if( random == 0)
            {
                foreach (GameObject enemy in firemoths)
                {
                    if (!enemy.activeSelf)
                    {
                        enemy.transform.position = new Vector2(Random.Range(-2.1f, 2.1f), 5.0f);
                        enemy.SetActive(true);
                        time = 0.0f;
                        break;
                    }
                }
            }
            else if( random == 1)
            {
                foreach (GameObject enemy in ladybugs)
                {
                    if (!enemy.activeSelf)
                    {
                        enemy.transform.position = new Vector2(Random.Range(-2.1f, 2.1f), 5.0f);
                        enemy.SetActive(true);
                        time = 0.0f;
                        break;
                    }
                }
            }
        }
    }
}
