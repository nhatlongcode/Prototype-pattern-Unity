using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject cubePrefab;
    public GameObject spherePrefabs;
    private void Update()
    {
        if (Random.Range(0,100) < 50)
        Instantiate(cubePrefab, this.transform.position, Quaternion.identity);
        //else 
        //Instantiate(spherePrefabs, this.transform.position, Quaternion.identity);
    }
}
