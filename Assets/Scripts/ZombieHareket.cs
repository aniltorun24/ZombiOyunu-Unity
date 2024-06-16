using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieHareket : MonoBehaviour
{
    private GameObject oyuncu;
    private int zombieCan=3;
    private float mesafe ;
    public GameObject kalp;
    private OyunKontrol oKontrol;
    private int zombidenGelenPuan =10;
    private AudioSource aSource;
    private bool zombiOluyor = false;
    // Start is called before the first frame update
    void Start()
    {
        aSource = GetComponent<AudioSource>();
        oyuncu = GameObject.Find("Oyuncu");
        oKontrol =GameObject.Find("_Scripts").GetComponent<OyunKontrol>();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<NavMeshAgent>().destination = oyuncu.transform.position;
        mesafe = Vector3.Distance(this.transform.position,oyuncu.transform.position);
        if(mesafe < 3f){
            if(!aSource.isPlaying)
            aSource.Play();
            if(!zombiOluyor)
            GetComponentInChildren<Animation>().Play("Zombie_Attack_01");
        }
        else{
            if(aSource.isPlaying)
            aSource.Stop();
        }
    }
    private void OnCollisionEnter(Collision c){
        if(c.collider.gameObject.tag.Equals("mermi")){
            Debug.Log("çarpışma gerçekleşti");
            zombieCan--;
            if(zombieCan == 0){
                zombiOluyor=true;
                oKontrol.PuanArtir(zombidenGelenPuan);
                Instantiate(kalp,transform.position,Quaternion.identity);
                GetComponentInChildren<Animation>().Play("Zombie_Death_01");
                Destroy(this.gameObject,1.667f);
            }
        }
    }
}
