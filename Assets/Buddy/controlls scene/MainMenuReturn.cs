﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuReturn : MonoBehaviour
{

    public string MainMenu;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void Menu()
    {
        SceneManager.LoadScene(MainMenu);
    }


    // Update is called once per frame
    void Update()
    {

    }
}
