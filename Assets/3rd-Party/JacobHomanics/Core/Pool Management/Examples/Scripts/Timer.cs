using JacobHomanics.Core.PoolManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
	public PoolEntityManager manager;

	private float timeLeft;
	public float timerDur = 3f;

	private void OnEnable()
	{
		timeLeft = 0f;
	}

	public void SetTimer(float val)
	{
		timerDur = val;
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
