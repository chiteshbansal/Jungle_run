using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeGenerator : MonoBehaviour
{
    public ObjectPooler spikePooler;
     
    public void SpawnSpikes(Vector3 position,float groundWidth){

        int random = Random.Range(1,100);
        float posx = Random.Range(position.x-groundWidth/3,position.x + groundWidth/10);
        
        if(random< 50 || groundWidth < 10)return ;

        int numberOfCoins = 1;

        for(int i=0;i<numberOfCoins;i++){
            GameObject coin = spikePooler.GetPooledObject();

            coin.transform.position = new Vector3( posx ,position.y+0.5f,0);
            coin.SetActive(true);
        }


    }
}
