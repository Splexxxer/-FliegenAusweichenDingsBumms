using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneE : MonoBehaviour
{
    public int index;
    public void OnButtonPressed()
    {
        SceneManager.LoadScene(index);
    }
}
