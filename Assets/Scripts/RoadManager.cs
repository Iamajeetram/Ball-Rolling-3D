using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class RoadManager : MonoBehaviour
{
    public GameObject roadPrefab;
    public float roadLength;
    public float roadCount;

    private void Start()
    {
        for(int i = 0; i < 2; i++)
        {
            SpawnARoad();    
        }
        
    }
    public void SpawnARoad()
    {
        GameObject road = Instantiate(roadPrefab);
        road.transform.position = new Vector3(0, 0, roadLength * roadCount);
        roadCount++;
    }

}
