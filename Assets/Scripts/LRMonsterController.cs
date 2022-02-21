using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LRMonsterController : MonoBehaviour
{
    Vector2 StartPointMonster;
    float LR = 1;
    // Start is called before the first frame update
    void Start()
    {
        StartPointMonster = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > StartPointMonster.x + 1)
        {
            LR = -1;
        }
        if(transform.position.x < StartPointMonster.x - 1)
        {
            LR = 1;
        }
        transform.Translate(LR * Time.deltaTime * 4.0f, 0, 0);
    }
}
