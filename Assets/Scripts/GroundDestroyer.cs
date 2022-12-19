using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDestroyer : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject point;
    void Start()
    {
        point = GameObject.Find("GroundEndPoint");
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < point.transform.position.x){
            gameObject.SetActive(false);

        }
    }
}
