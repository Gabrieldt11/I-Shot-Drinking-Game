using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GameManager : MonoBehaviour
{
    public List<GameObject> allCards;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
    void Update()
    {

    }
}
