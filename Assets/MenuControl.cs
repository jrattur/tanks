﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{

    public void StartGame(int scene) {
        SceneManager.LoadScene(scene);
    }

    public void Quit() {
        Application.Quit();
    }


}
