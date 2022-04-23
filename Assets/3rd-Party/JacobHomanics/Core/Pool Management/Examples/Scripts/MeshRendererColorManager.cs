using JacobHomanics.Core.PoolManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshRendererColorManager : MonoBehaviour
{
	public MeshRenderer mr;
	
	public void OnSpawn()
	{
		SetColor(mr);
	}

	private void SetColor(MeshRenderer _meshRenderer)
	{

		_meshRenderer.material.color = new Color(
				   Random.Range(0f, 1f),
				   Random.Range(0f, 1f),
				   Random.Range(0f, 1f)
				   );

		var c = Random.ColorHSV(0, 1, 0, 1, .65f, 1);
		_meshRenderer.material.color = c;
	}
}
