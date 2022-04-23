using JacobHomanics.Core.PoolManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolEntitiesManagerTimer : MonoBehaviour
{
	public PoolEntitiesManager manager;

	private float timeLeft;
	public float timerDur = 3f;

	void Start()
	{
		manager.Initialize();
	}

	private void OnEnable()
	{
		timeLeft = 0f;
	}

	void Update()
	{
		timeLeft -= Time.deltaTime;
		if (timeLeft <= 0)
		{
			timeLeft = timerDur;
			manager.Spawn();
		}
	}
}
