using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public static int lifeMonster = 10;
    private void OnCollisionEnter2D(Collision2D hitObjects)
    {
        if (hitObjects.gameObject.tag == "Monster")
        {
            lifeMonster -= 2;
            Destroy(gameObject);
            if (lifeMonster < 1)
            {
                Destroy(hitObjects.gameObject);
                lifeMonster = 10;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
