using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public InputManager inputManager;
    public PlayerManager playerManager;

    private GameManager() { }

    private void Awake()
    {
        DontDestroyOnLoad(this);

        MakeManagerGameObject<InputManager>();
        MakeManagerGameObject<PlayerManager>();
    }

    private void MakeManagerGameObject<T>() where T : MonoBehaviour
    {
        GameObject manager = new GameObject();
        manager.AddComponent<T>();
        manager.name = typeof(T).ToString();

        DontDestroyOnLoad(manager);
    }

    // Start is called before the first frame update
    void Start()
    {
        playerManager.CreatePlayer();

        inputManager.AddHorizontalInputDelegate(playerManager.MoveHorizontal);
        inputManager.AddVerticalInputDelegate(playerManager.MoveVertical);
    }

    // Update is called once per frame
    void Update()
    {
        inputManager.GetInput();
    }
}
