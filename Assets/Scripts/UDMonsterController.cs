using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UDMonsterController : MonoBehaviour
{
    Vector2 StartPointMonster;
    float UD = 1;
    // Start is called before the first frame update
    void Start()
    {
        StartPointMonster = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > StartPointMonster.y + 2)
        {
            UD = -1;
        }
        if(transform.position.y<StartPointMonster.y - 0.5)
        {
            UD = 1;
        }
        transform.Translate(0, UD * Time.deltaTime * 4.0f, 0);
    }
}
