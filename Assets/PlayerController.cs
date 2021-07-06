using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int r = 1;
    SpriteRenderer spriteRenderer;
    PlayerSinifi playerSinifi;
    int rOld;
    int rNew;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        playerSinifi = GetComponent<PlayerSinifi>();
        
    }

    [System.Obsolete]
    void Start()
    {
        StartCoroutine(rastgeleSayi());
    }

    // Update is called once per frame
    
    void Update()
    {
        colorChanged();


    }
    
    
    public void colorChanged()
    {
        if (r == 1)
        {
            spriteRenderer.color = Color.red;
        }
        else if (r == 2)
        {
            spriteRenderer.color = Color.blue;
        }
        else if (r == 3)
        {
            spriteRenderer.color = Color.green;
        }
        else if (r == 4)
        {
            spriteRenderer.color = Color.black;
        }
        else if (r == 5)
        {
            spriteRenderer.color = Color.white;
        }
    }

    [System.Obsolete]
    IEnumerator rastgeleSayi()
    {
        for (int i = 0; i < 10000; i++)
        {
            rOld = r;
            yield return new WaitForSeconds(1f);
            r = (int)Random.RandomRange(1f, 5f);
            Debug.Log(r);
            rNew = r;
            if (rOld == rNew)
            {
                rOld = r;
                r = (int)Random.RandomRange(1f, 6f);
                rNew = r;
                if(rOld==rNew)
                {
                    r = (int)Random.RandomRange(1f, 6f);
                }
            }

        }
    }

}


