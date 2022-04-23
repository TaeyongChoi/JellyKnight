using JacobHomanics.Core.PoolManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityMovement : MonoBehaviour
{
	public Rigidbody rb;
	private float power = 15f;

    void FixedUpdate()
    {
		rb.velocity = Vector3.forward * power;
    }

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == "Despawn Zone")
		{
			GetComponent<PoolEntity>().Despawn();
		}
	}
}
