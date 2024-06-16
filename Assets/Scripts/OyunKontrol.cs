using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OyunKontrol : MonoBehaviour
{
    public GameObject zombi;
    private float zamansayaci;
    private float olusumSureci = 10f;
    public Text puanText;
    private int puan;
    // Start is called before the first frame update
    void Start()
    {
        zamansayaci = olusumSureci;
    }

    // Update is called once per frame
    void Update()
    {
        zamansayaci -= Time.deltaTime;
        if(zamansayaci < 0){
            Vector3 pos = new Vector3(Random.Range(174f,318f),25f,Random.Range(124f,217f));
            Instantiate(zombi,pos,Quaternion.identity);
            zamansayaci = olusumSureci;
        }
    }
    public void PuanArtir(int p){
        puan += p;
        puanText.text = ""+ puan;
    }
    public void oyunBitti(){
        PlayerPrefs.SetInt("puan",puan);
        SceneManager.LoadScene("oyunbitti");
    }
}
