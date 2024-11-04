using UnityEngine;
using System;

public class ObjectScript : MonoBehaviour, ICollectible 
{
    public BaseObject objectInfo;
    public SpriteRenderer spriteRenderer;

    public static event HandleCollection onObjectCollected;
    public delegate void HandleCollection(BaseObject itemData);

    string name;
    Sprite sprite;
    GameObject cleaningObject;
    bool randomized;
    GameObject notRandomLocation;
    GameObject[] spawnLocations;

    void Start(){
        name = objectInfo.name;
        sprite = objectInfo.sprite;
        gameObject.GetComponent<SpriteRenderer>().sprite = sprite;

        cleaningObject = objectInfo.objectNeededToClean;

        randomized = objectInfo.randomized;
        notRandomLocation = objectInfo.randomSpawnLocations[0];
        spawnLocations = objectInfo.randomSpawnLocations;

        if (!randomized){
            gameObject.transform.position = notRandomLocation.transform.position;
        }else {
            int number = UnityEngine.Random.Range(0, 5);

            print (number);

            gameObject.transform.position = spawnLocations[number].transform.position;
        }
    }

    public void Collect(){
        Destroy(gameObject);
        onObjectCollected?.Invoke(objectInfo);
    }
}
