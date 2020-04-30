using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] prefabs;

    public void Spawn()
    {
        var prefab = prefabs[Random.Range(0, prefabs.Length)];
        Instantiate(prefab, transform.position, transform.rotation);
    }
}
