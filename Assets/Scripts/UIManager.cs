using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject playerStatusUI;
    private GameObject hpBar;
    private GameObject shieldBar;
    private GameObject mpBar;

    public GameObject goldUI;
    private GameObject gold;

    private void Awake()
    { 
        initPlayerStatusUI();
        initGoldUI();
    }

    private void initPlayerStatusUI()
    {
        hpBar = playerStatusUI.transform.GetChild(0).gameObject;
        shieldBar = playerStatusUI.transform.GetChild(1).gameObject;
        mpBar = playerStatusUI.transform.GetChild(2).gameObject;
    }

    private void initGoldUI()
    {
        gold = goldUI.transform.GetChild(0).gameObject;
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

    public void ToggleGoldUI()
    {
        if (goldUI.activeSelf)
        {
            goldUI.SetActive(false);
        }
        else
        {
            goldUI.SetActive(true);
        }
    }

    public void updateHpBarText(int currentHP, int maxHP)
    {
        hpBar.GetComponentInChildren<TMPro.TMP_Text>().text = currentHP + "/" + maxHP;
    }

    public void updateShieldBarText(int currentShield, int maxShield)
    {
        shieldBar.GetComponentInChildren<TMPro.TMP_Text>().text = currentShield + "/" + maxShield;
    }

    public void updateMpBarText(int currentMP, int maxMP)
    {
        mpBar.GetComponentInChildren<TMPro.TMP_Text>().text = currentMP + "/" + maxMP;
    }

    public void updateGoldText(int value)
    {
        gold.GetComponentInChildren<TMPro.TMP_Text>().text = value.ToString();
    }

}
