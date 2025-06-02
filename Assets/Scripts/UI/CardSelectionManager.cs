using UnityEngine;
using UnityEngine.UI;

public class CardSelectionManager : MonoBehaviour
{
    public static CardSelectionManager Instance;
    
    private Card _selectedCard;

    public Button ExecuteButton;

    private void Awake()
    {
        Instance = this;
        ExecuteButton.onClick.AddListener(ExecuteSelectedCardAbility);
    }

    public void SelectCard(Card card)
    {
        _selectedCard = card;
        CardDetailPanel.Instance.ShowDetails(card.GetCardSO());
    }

    public void ExecuteSelectedCardAbility()
    {
        if (_selectedCard != null)
        {
            _selectedCard.ExecuteAbility();
        }
    }
    
    public Card GetSelectedCard() => _selectedCard;
}
