using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    // Start is called before the first frame update
    private Player player;
    private Vector3 lastPosition;
    private float distance;
    void Start()
    {
        player = FindObjectOfType<Player>();
        lastPosition = player.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        distance = player.transform.position.x - lastPosition.x;
        transform.position =new  Vector3(transform.position.x + distance,transform.position.y,transform.position.z);
        lastPosition = player.transform.position;
    }
}
