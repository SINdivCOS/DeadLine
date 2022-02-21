using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public static float timeValue = 30.0f;
    private Text timeText;
    // Start is called before the first frame update
    void Start()
    {
        timeText = GetComponent<Text>(); //ย่อ
        timeText.text = "TIME : " + timeValue.ToString("f2");//แสดงทศนิยมf2ตำแหน่ง
    }

    // Update is called once per frame
    void Update()
    {
        if (timeValue>0.0f)
        {
            timeValue = timeValue - Time.deltaTime; //+เพิ่ม -ลดเวลา
            timeText.text = "TIME : " + timeValue.ToString("f2");
        }
        else
        {
            Time.timeScale = 0;//0หยุดเวลา 0.5 slow
        }
    }
}
