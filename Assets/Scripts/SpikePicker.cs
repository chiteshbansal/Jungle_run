using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikePicker : MonoBehaviour
{
   private GameManager gameManager;


    void Start()
    {
        gameManager =  FindObjectOfType<GameManager>();
    }

     private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.name == "Player"){
            gameManager.GameOver();
        }
    }
   
}
