using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletManager : MonoBehaviour
{
    public static int bulletValue = 10;
    private Text bulletText;
    // Start is called before the first frame update
    void Start()
    {
        bulletText = GetComponent<Text>();//ย่อ
        bulletText.text = "" + bulletValue;//แสดงข้อความ
    }

    // Update is called once per frame
    void Update()
    {
        bulletText.text = "" + bulletValue; 
    }
}
