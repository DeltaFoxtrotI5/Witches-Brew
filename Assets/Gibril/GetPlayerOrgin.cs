using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPlayerOrgin : MonoBehaviour
{

    private Vector3 playerOrgin;
    public GameObject mainPlayer;

    // Start is called before the first frame update
    void Start()
    {
        playerOrgin = mainPlayer.transform.position;
        transform.localPosition = playerOrgin;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
