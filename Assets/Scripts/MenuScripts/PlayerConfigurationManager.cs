using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Linq;
using UnityEngine.SceneManagement;

public class PlayerConfigurationManager : MonoBehaviour
{
    private List<PlayerConfiguration> playerConfigs;

    public static PlayerConfigurationManager Instance { get; private set; }

    public int scenToLaod;

    public List<PlayerConfiguration> GetPlayerConfigs()
    {
        return playerConfigs;
    }

    private void Awake()
    {
        if(Instance != null)
        {
            Debug.Log("TRYING TO CREATE ANOTHER INSTANCE!");
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(Instance);
            playerConfigs = new List<PlayerConfiguration>();
        }
    }

    public void SetPlayerSprite(int index, Sprite sprite, int animtionState)
    {
        playerConfigs[index].PlayerSprite = sprite;
        playerConfigs[index].animationState = animtionState;
        playerConfigs[index].itemHeld = false;
    }

    public void ReadyPlayer(int index)
    {
        playerConfigs[index].IsReady = true;
        if (playerConfigs.All(p => p.IsReady == true))
        {
            SceneManager.LoadScene(scenToLaod);
        }
    }

    public void HandlePlayerJoin(PlayerInput pi)
    {
        Debug.Log("PlayerJoined");
        if(!playerConfigs.Any(p => p.PlayerIndex == pi.playerIndex))
        {
            pi.transform.SetParent(transform);
            playerConfigs.Add(new PlayerConfiguration(pi));
        }
    }
}

