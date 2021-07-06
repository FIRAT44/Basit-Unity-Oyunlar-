using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DenemeScript : MonoBehaviour
{
    PlayerSinifi _playerSinifi;
    // Start is called before the first frame update

    void Awake()
    {
        _playerSinifi = FindObjectOfType<PlayerSinifi>();
        
    }


    void Start()
    {
        Debug.Log(_playerSinifi.a);
        _playerSinifi.calistirici();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
