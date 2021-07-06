using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PuamlamaScript : MonoBehaviour
{
    [SerializeField] Text text;
    PlayerController playerController;

    public int count = 0;
    bool devam =true ;
    void Awake()
    {
        playerController = FindObjectOfType<PlayerController>();  
    }
    // Start is called before the first frame update
    void Start()
    {
        text.text = "Puan: " + count;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [System.Obsolete]
    public void yazici()
    {
        
        text.text ="Puan: "+count;
    }

    [System.Obsolete]
    public void artirici()
    {
        if(devam)
        {
            count++;
            yazici();
            devam = false;
            StartCoroutine(devamCevirici());

        }
        
    }

    IEnumerator devamCevirici()
    {
        yield return new WaitForSeconds(0.8f);
        devam = true;
    }
}
