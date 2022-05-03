using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceUtils : MonoBehaviour
{
    static public GameObject MakePrefabInstance(string prefabName)
    {
        return Instantiate(Resources.Load("Prefabs/" + prefabName, typeof(GameObject))) as GameObject;
    }
}
