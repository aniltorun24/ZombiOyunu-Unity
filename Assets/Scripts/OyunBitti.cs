using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OyunBitti : MonoBehaviour
{
    public Text puan;
    // Start is called before the first frame update
    void start()
    {
        Cursor.visible = true;
        puan.text ="Puanınız:" + PlayerPrefs.GetInt("puan");
    }

    public void YenidenOyna(){
        SceneManager.LoadScene("oyun");
    }
}
