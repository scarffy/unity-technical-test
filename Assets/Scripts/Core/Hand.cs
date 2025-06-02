using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    public List<CardSO> CardList; 
    public GameObject CardPrefab; 
    public Transform HandContent;  

    void Start()
    {
        SpawnCards();
    }

    void SpawnCards()
    {
        foreach (CardSO cardData in CardList)
        {
            GameObject cardGO = Instantiate(CardPrefab, HandContent);
            Card card = cardGO.GetComponent<Card>();
            card.Init(cardData);
        }
    }
}
