using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner2 : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Random.Range(0, 100) < 50) ProcCube.CloneSphere(this.transform.position);
        
    }
}
