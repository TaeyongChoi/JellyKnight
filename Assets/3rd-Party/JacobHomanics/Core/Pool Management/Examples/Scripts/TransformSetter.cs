using JacobHomanics.Core.PoolManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformSetter : MonoBehaviour
{
	public void OnSpawn(PoolEntityManager manager, PoolEntity entity)
	{
		entity.transform.position = transform.position;
	}
}
