using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject playerStatusUI;
    private GameObject hpBar;
    private GameObject shieldBar;
    private GameObject mpBar;

    private void Awake()
    { 
        initPlayerStatusUI();
    }

    private void initPlayerStatusUI()
    {
        hpBar = playerStatusUI.transform.GetChild(0).gameObject;
        shieldBar = playerStatusUI.transform.GetChild(1).gameObject;
        mpBar = playerStatusUI.transform.GetChild(2).gameObject;
    }

    public void TogglePlayerStatusUI()
    {
        if(playerStatusUI.activeSelf)
        {
            playerStatusUI.SetActive(false);
        }
        else
        {
            playerStatusUI.SetActive(true);
        }
    }

    public void updateHpBarText(string value)
    {
        hpBar.GetComponentInChildren<TMPro.TMP_Text>().text = value;
    }

    public void updateShieldBarText(string value)
    {
        shieldBar.GetComponentInChildren<TMPro.TMP_Text>().text = value;
    }

    public void updateMpBarText(string value)
    {
        mpBar.GetComponentInChildren<TMPro.TMP_Text>().text = value;
    }

}
