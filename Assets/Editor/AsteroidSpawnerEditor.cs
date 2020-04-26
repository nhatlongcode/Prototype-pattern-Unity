using UnityEngine;
using UnityEditor;
using System.IO;

[CustomEditor (typeof(AsteroidsSpawner))]
public class AsteroidSpawnerEditor : Editor
{
    private string path;
    private string assetPath;
    private string fileName;

    private void OnEnable()
    {
        path = Application.dataPath + "/Asteroid";
        assetPath = "Assets/Asteroid/";
        fileName = "Asteroid_" + System.DateTime.Now.Ticks.ToString();

    }

    public override void OnInspectorGUI()
    {
        AsteroidsSpawner asteroidsSpawner = (AsteroidsSpawner)target;
        DrawDefaultInspector();

        if (GUILayout.Button("Create Asteroid"))
        {
            asteroidsSpawner.CreateAsteroid();
        }

        if (GUILayout.Button("Save Asteroid"))
        {
            System.IO.Directory.CreateDirectory(path);
            Mesh mesh = asteroidsSpawner.asteroid.GetComponent<MeshFilter>().sharedMesh;
            AssetDatabase.CreateAsset(mesh, assetPath + mesh.name + ".asset");
            AssetDatabase.SaveAssets();
            PrefabUtility.SaveAsPrefabAsset(asteroidsSpawner.asteroid,assetPath + fileName + ".prefab");
        }
    }
}
