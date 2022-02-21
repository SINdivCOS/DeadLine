using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject bulletPrefabs;//ประกาศกระสุน Prefab
    public Transform bulletOut;//ประกาศใน scene
    private GameObject cloneBullet;
    private Animator anim;

    private bool isGround;//เช็คพื้นตรวจสอบ jump
    // Use this for initialization
    
    public void GenerateBullet()
    {
        cloneBullet = Instantiate(bulletPrefabs);
        cloneBullet.transform.position = bulletOut.position;//จุดออกกระสุน
        cloneBullet.GetComponent<Rigidbody2D>().AddForce(Vector2.right*500);//ใส่แรง
        Destroy(cloneBullet, 1);
    }

    private void OnCollisionEnter2D(Collision2D hitObjects)
    {
        if (hitObjects.gameObject.tag == "Monster")
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.left * 200);
            LifeManager.lifeValue = LifeManager.lifeValue - 100;
        }

        if (hitObjects.gameObject.tag == "Ground")
        {
            isGround = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D hitObjects)
    {
        if (hitObjects.gameObject.name == "SoulPoint")
        {
            Destroy(hitObjects.gameObject);
        }
        if (hitObjects.gameObject.tag == "Soul")
        {
            Destroy(hitObjects.gameObject);
        }
        if (hitObjects.gameObject.tag == "Blade10")
        {
            Destroy(hitObjects.gameObject);
            BulletManager.bulletValue = BulletManager.bulletValue + 10;
        }
    }
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (BulletManager.bulletValue > 0)
            {
                GenerateBullet();
                BulletManager.bulletValue--;
                //print(BulletController.lifeMonster);
            }
        }
        /*if (Input.GetButtonDown(KeyCode.Z)==true)
        {
            if (BulletManager.bulletValue > 0)
            {
                GenerateBullet();
                BulletManager.bulletValue--;
                //print(BulletController.lifeMonster);
            }
        }*/

        if (Input.GetButtonDown("Jump") && isGround)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * 350);
            isGround = false;
        }
        
        float LR, SpeedX = 5.0f, UD, SpeedY = 9.0f;
        LR = Input.GetAxis("Horizontal");
        transform.Translate(LR * Time.deltaTime * SpeedX, 0, 0);//x,y,z
        /*UD = Input.GetAxis("Vertical");
        transform.Translate(0, UD * Time.deltaTime * SpeedY, 0);*/
        if (LR==0)
        {
            anim.SetBool("isWalking", false);
        }
        else
        {
            anim.SetBool("isWalking", true);
        }
        /*if (LR < 0)
        {
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }
        else if (LR > 0)
        {
            transform.localScale = new Vector2(transform.localScale.x, transform.localScale.y);
        }*/
    }
}
