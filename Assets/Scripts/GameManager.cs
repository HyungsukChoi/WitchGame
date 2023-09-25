using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject bgPrefab;
    List<GameObject> backgrounds;
    static float bg_Interval = 16.0f;

    // Start is called before the first frame update
    void Start()
    {
        GenerateBG();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void GenerateBG()
    {
        backgrounds = new List<GameObject>();

        for( int i = 0; i < 3; i ++)
        {
            GameObject tempBG = Instantiate(bgPrefab);
            tempBG.transform.position = new Vector3(0, -bg_Interval * i + bg_Interval, 0);
            backgrounds.Add(tempBG);
        }
    }
}
