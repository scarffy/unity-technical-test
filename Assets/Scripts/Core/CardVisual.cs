using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardVisual : MonoBehaviour
{
    [Header("Card Properties")]
    public TextMeshProUGUI NameText;
    public TextMeshProUGUI HealthText;
    public TextMeshProUGUI DamageText;
    public TextMeshProUGUI AbilityText;
    
    public Image CardImage;
    
    public void UpdateView(CardSO cardSo)
    {
        NameText.text = cardSo.CardName;
        HealthText.SetText("{0}", cardSo.Health);
        DamageText.SetText("{0}", cardSo.Damage);
        
        CardImage.sprite = cardSo.CardSprite;
        
        AbilityText.text = cardSo.CardAbility?.GetDescription() ?? "No Ability";
    }
}
