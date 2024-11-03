using UnityEngine;
using System;

public class ObjectScript : MonoBehaviour
{
    public BaseObject objectInfo;
    public SpriteRenderer spriteRenderer;

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
            int number = Convert.ToInt32(spawnLocations[UnityEngine.Random.Range(0, spawnLocations.Length + 1)]);

            gameObject.transform.position = spawnLocations[number].transform.position;
        }
    }

}
