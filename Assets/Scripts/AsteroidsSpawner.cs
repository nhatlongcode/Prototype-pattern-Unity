using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidsSpawner : MonoBehaviour
{
    public GameObject asteroid;
    public Material material;

    private void Start()
    {
        CreateAsteroid();
    }

    public void CreateAsteroid()
    {
        asteroid = ProcAsteroid.Clone(this.transform.position);
        asteroid.GetComponent<MeshRenderer>().sharedMaterial = material;
    }
}
