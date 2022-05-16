using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public const string PlayerGameObjectName = "Player";

    [SerializeField]
    private Vector3 startPostion = new Vector3(0, 0, 100f);

    private GameObject player = null;

    public const int playerMaxHP = 100;
    public const int playerMaxShield = 100;
    public const int playerMaxMP = 100;

    public int playerCurrentHP = 100;
    public int playerCurrentShield = 100;
    public int playerCurrentMP = 100;

    public int playerSpeed = 5;

    public int goldCount = 0;

    private PlayerManager() { }

    public void CreatePlayer()
    {
        if (player != null) return;

        player = ResourceUtils.MakePrefabInstance(PlayerGameObjectName);
        player.transform.SetPositionAndRotation(startPostion, Quaternion.identity);
        player.name = PlayerGameObjectName;
    }

    public void MoveHorizontal(float value)
    {
        player.transform.Translate(new Vector3(value * playerSpeed * Time.deltaTime, 0, 0));
    }

    public void MoveVertical(float value)
    {
        player.transform.Translate(new Vector3(0, value * playerSpeed * Time.deltaTime, 0));
    }
}
