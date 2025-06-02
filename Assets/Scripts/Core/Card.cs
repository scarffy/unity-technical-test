using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class Card : MonoBehaviour, IPointerClickHandler
{
    private CardSO _cardSo;
    [SerializeField] private CardVisual _cardVisual;

    public void Init(CardSO cardso)
    {
        _cardSo = cardso;
        _cardVisual.UpdateView(cardso);
    }
    
    public void ExecuteAbility()
    {
        _cardSo.CardAbility?.Execute(this);
    }

    public void Heal(int amount)
    {
        Debug.Log("Healing " + amount + " to " + _cardSo.CardName);
    }

    public void IncreaseDamage(int amount)
    {
        Debug.Log("Increased damage " + amount + " to " + _cardSo.CardName);
    }

    public void ReduceDamage(int amount)
    {
        Debug.Log("Reducing damage " + amount + " to " + _cardSo.CardName);
    }
    
    public CardSO GetCardSO() => _cardSo;
    public void OnPointerClick(PointerEventData eventData)
    {
        CardSelectionManager.Instance.SelectCard(this);
    }
}
