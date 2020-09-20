using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BridgeReBuildNavMash : MonoBehaviour
{
    public NavMeshSurface navMeshSurface;

    // Start is called before the first frame update
    void Start()
    {
        navMeshSurface.BuildNavMesh();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
