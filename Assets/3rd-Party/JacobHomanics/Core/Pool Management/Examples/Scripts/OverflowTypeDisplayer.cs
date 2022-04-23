using JacobHomanics.Core.PoolManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OverflowTypeDisplayer : MonoBehaviour
{
	public Text text;
	public PoolEntityManager poolEntityManager;

	void Update()
	{
		text.text = "OverflowType: " + poolEntityManager.overflowType.ToString();
	}
}
