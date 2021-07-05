using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class PlayerSetupMenuContext : MonoBehaviour
{
    private int PlayerIndex;

    [SerializeField] 
    private TextMeshProUGUI titletext;
    [SerializeField]
    private GameObject readyPanel;
    [SerializeField]
    private GameObject menuPanel;
    [SerializeField]
    private Button readyButton;

    public AnimatedBackAndDisplay scriptWithIndexForTrail;

    private float ignoreInputTime = 1.5f;
    private bool inputEnabled;

    public void SetPlayerIndex(int pi)
    {
        PlayerIndex = pi;
        titletext.SetText("Player " + (pi + 1).ToString());
        ignoreInputTime = Time.time + ignoreInputTime;
    }

    void Update()
    {
        if(Time.time > ignoreInputTime)
        {
            inputEnabled = true;
        }
    }

    public void SetSptrite(Image spritePlayer)
    {
        if(!inputEnabled) { return; }

        Sprite sprite = spritePlayer.sprite;

        PlayerConfigurationManager.Instance.SetPlayerSprite(PlayerIndex, sprite, scriptWithIndexForTrail.index);
        readyPanel.SetActive(true);
        readyButton.Select();
        menuPanel.SetActive(false);
    }

    public void ReadyPlayer()
    {
        if (!inputEnabled) { return; }
        PlayerConfigurationManager.Instance.ReadyPlayer(PlayerIndex);
        readyButton.gameObject.SetActive(false);
    }



}
