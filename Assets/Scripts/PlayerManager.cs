using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public const string PlayerGameObjectName = "Player";

    [SerializeField]
    private Vector3 startPostion = Vector3.zero;

    private GameObject player = null;

    public int playerSpeed = 5;

    private PlayerManager() { }

    public void CreatePlayer()
    {
        if (player != null) return;

        player = ResourceUtils.MakePrefabInstance(PlayerGameObjectName);
        player.transform.position = startPostion;
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
