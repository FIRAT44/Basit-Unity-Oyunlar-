using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chracter : MonoBehaviour
{
    [SerializeField] Text text;
    SpriteRenderer _spriteRenderer;
    PlayerController playerController;
    SpriteRenderer spriteRendererPlayer;
    PuamlamaScript puamlamaScript;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        playerController = FindObjectOfType<PlayerController>();
        puamlamaScript = FindObjectOfType<PuamlamaScript>();
        spriteRendererPlayer = playerController.GetComponent<SpriteRenderer>();
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            _spriteRenderer.color = Color.blue;
        }
        if (Input.GetKey("a"))
        {
            _spriteRenderer.color = Color.white;
        }
        if (Input.GetKey("s"))
        {
            _spriteRenderer.color = Color.red;
        }
        if (Input.GetKey("d"))
        {
            _spriteRenderer.color = Color.green;
        }
        if (Input.GetKey("q"))
        {
            _spriteRenderer.color = Color.black;
        }



    }

    [System.Obsolete]
    void OnMouseDown()
    {
        if(spriteRendererPlayer.color == _spriteRenderer.color)
        {

            puamlamaScript.artirici();
        }
    }

    

}
