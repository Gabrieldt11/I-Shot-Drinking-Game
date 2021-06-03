using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class UnityMonetization : MonoBehaviour
{
    string gameId = "3986795";
    bool testMode = true;
    public MenuManager menu;

    void Start()
    {
        Advertisement.Initialize(gameId, testMode);
    }

    public void StartAd()
    {
        Advertisement.Show();
        if (!Advertisement.isShowing)
        {
            menu.StartGame();
        }
    }
}
