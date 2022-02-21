using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    /*void Update()
    {
        if( Input.GetKeyDown(KeyCode.Escape) && Time.timeScale == 1 )
        {
            pausePanelUI.SetActive(true); // แสดงหน้าต่าง PausePanel
            Time.timeScale = 0; // หยุดเวลาและทุกอย่างในเกม
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && Time.timeScale == 0)
        {
            pausePanelUI.SetActive(false); // ซ่อนหน้าต่าง PausePanel
            Time.timeScale = 1; // ทำให้เวลาและทุกอย่างในเกมกลับมาปกติ
        }
    }*/
}
