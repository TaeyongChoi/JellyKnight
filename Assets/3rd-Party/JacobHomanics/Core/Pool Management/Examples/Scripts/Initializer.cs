using JacobHomanics.Core.PoolManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initializer : MonoBehaviour
{
	public PoolEntityManager manager;

    void Start()
    {
		manager.Initialize();
    }

}
