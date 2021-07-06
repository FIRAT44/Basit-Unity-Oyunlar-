using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSinifi : MonoBehaviour
{
    public int a = 45;
    void Start()
    {
        
    }


    void Update()
    {
        
    }


    public IEnumerator denemeSayac()
    {
        yield return new WaitForSeconds(2);
     
        Debug.Log("hello");
    }

    public void calistirici()
    {
        StartCoroutine(denemeSayac());
    }

    
}
