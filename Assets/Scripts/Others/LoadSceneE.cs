﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneE : MonoBehaviour
{
    public void OnButtonPressed()
    {
        SceneManager.LoadScene(1);
    }
}
