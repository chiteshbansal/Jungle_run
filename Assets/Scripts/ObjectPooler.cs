using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{

    public GameObject pooledObject ; 
    public int numOfObject;
    private List<GameObject> gameObjects;

    // Start is called before the first frame update
    void Start()
    {
        gameObjects = new List<GameObject>();

        for(int i=0;i<numOfObject;i++){
            GameObject gameObject = Instantiate(pooledObject);
            gameObject.SetActive(false);
            gameObjects.Add(gameObject);
        }
    }

    public GameObject GetPooledObject(){
        foreach(GameObject gameObject in gameObjects){
            if(!gameObject.activeInHierarchy){
                return gameObject;
            }
        }

        GameObject gameObj = Instantiate(pooledObject);
        gameObj.SetActive(false);
        gameObjects.Add(gameObj);
        return gameObj;
    }

}
