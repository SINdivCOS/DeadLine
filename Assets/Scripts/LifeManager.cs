using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//Class UI


public class LifeManager : MonoBehaviour
{
    public static int lifeValue = 1000;//set Health
    private Text lifeText;
    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<text>().text = ""+lifeValue;
        lifeText = GetComponent<Text>();
        lifeText.text = ""+lifeValue;
    }

    // Update is called once per frame
    void Update()
    {
        lifeText.text = "" + lifeValue;
    }
}
