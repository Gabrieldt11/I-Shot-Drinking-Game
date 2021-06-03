using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public GameManager gm;
    public List<GameObject> oldCards;
    public List<int> oldNumbers = new List<int>();
    int number;

    GameObject card;
    void Start()
    {
        GameObject gameManager = GameObject.Find("GameManager");
        gm = gameManager.GetComponent<GameManager>();
        ButtonClicked();
    }

    public void ButtonClicked()
    {
        RandomNumber();
        Destroy(card, 0.5f);
        card = Instantiate(gm.allCards[number]);
        card.transform.SetParent(GameObject.Find("Canvas").transform, false);
        oldCards.Add(gm.allCards[number]);
    }
    
    public void CardAnimation()
    {
        card.GetComponent<Animator>().SetBool("isDiscarted", true);
    }

    private int RandomNumber()
    {
        if (14 > oldNumbers.Count)
        {
            while (true)
            {
                number = Random.Range(0, gm.allCards.Count);
                if (!oldNumbers.Contains(number))
                {
                    oldNumbers.Add(number);
                    return number;
                }
            }
        }
        else
        {
            oldNumbers.Remove(oldNumbers[0]);
            while (true)
            {
                number = Random.Range(0, gm.allCards.Count);
                if (!oldNumbers.Contains(number))
                {
                    oldNumbers.Add(number);
                    return number;
                }
            }
        }
    }

    public void ReturnScene()
    {
        SceneManager.LoadScene("MenuScene");
        Destroy(gm.gameObject);
    }
}
