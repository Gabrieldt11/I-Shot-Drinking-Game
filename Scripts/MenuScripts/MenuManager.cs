using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Toggle lightToggle;
    public Toggle heavyToggle;

    public GameManager gm;
    public List<GameObject> cartasLeves;
    public List<GameObject> cartasPesadas;

    void Update()
    {
        
    }
    public void StartGame()
    {
        if (lightToggle.isOn && heavyToggle.isOn)
        {
            foreach (var item in cartasLeves)
            {
                gm.allCards.Add(item);
            }
            foreach (var item in cartasPesadas)
            {
                gm.allCards.Add(item);
            }
            SceneManager.LoadScene("GameScene");
        }
        else if (lightToggle.isOn)
        {
            foreach (var item in cartasLeves)
            {
                gm.allCards.Add(item);
            }
            SceneManager.LoadScene("GameScene");
        }
        else if (heavyToggle.isOn)
        {
            foreach (var item in cartasPesadas)
            {
                gm.allCards.Add(item);
            }
            SceneManager.LoadScene("GameScene");
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
