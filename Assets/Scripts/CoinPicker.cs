using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPicker : MonoBehaviour
{
    // Start is called before the first frame update
    private AudioSource coinPickSound;
    private float coinPoints = 15f;
    private ScoreManager scoreManager;


    void Start()
    {
           coinPickSound = GameObject.Find("CoinPickSound").GetComponent<AudioSource>(); 
           scoreManager = FindObjectOfType<ScoreManager>();
    }

     private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.name == "Player"){
            gameObject.SetActive(false);
            if(coinPickSound.isPlaying){
                coinPickSound.Stop();
            }
            coinPickSound.Play();
            // Increase the score
            scoreManager.score += coinPoints;
        }
    }
   
}
