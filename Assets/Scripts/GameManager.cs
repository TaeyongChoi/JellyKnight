using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public InputManager inputManager;
    public PlayerManager playerManager;
    public UIManager uiManager;

    private GameManager() { }

    private void Awake()
    {
        DontDestroyOnLoad(this);

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
        initPlayerManager();
        initInputManager();
        initUIManager();
    }

    private void initPlayerManager()
    {
        playerManager.CreatePlayer();
    }

    private void initInputManager()
    {
        inputManager.AddHorizontalInputDelegate(playerManager.MoveHorizontal);
        inputManager.AddVerticalInputDelegate(playerManager.MoveVertical);
    }

    private void initUIManager()
    {
        uiManager.TogglePlayerStatusUI();
        uiManager.updateHpBarText(playerManager.playerCurrentHP, PlayerManager.playerMaxHP);
        uiManager.updateShieldBarText(playerManager.playerCurrentShield, PlayerManager.playerMaxShield);
        uiManager.updateMpBarText(playerManager.playerCurrentMP, PlayerManager.playerMaxMP);

        uiManager.ToggleGoldUI();
        uiManager.updateGoldText(playerManager.goldCount);

        uiManager.ToggleJoystickUI();
    }

    // Update is called once per frame
    void Update()
    {
        inputManager.GetInput();
    }
}
