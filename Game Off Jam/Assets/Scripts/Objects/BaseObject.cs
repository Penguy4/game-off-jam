using UnityEngine;

[CreateAssetMenu(fileName = "ObjectData", menuName = "ScriptableObjects/New Object", order = 1)]
public class BaseObject : ScriptableObject
{
    [Header("Basic Info")]
    public string name = "";
    public Sprite sprite;
    [Header("Interaction Info")]
    public GameObject objectNeededToClean;
    [Header("Spawning Info")]
    public bool randomized;
    public GameObject[] randomSpawnLocations;


}
