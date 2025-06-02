using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardDetailPanel : MonoBehaviour
{
    public static CardDetailPanel Instance;

    [Header("UI Elements Basic")]
    public TextMeshProUGUI CardName;
    public TextMeshProUGUI CardHealth;
    public TextMeshProUGUI CardDamage;
    public TextMeshProUGUI CardAbility;

    public Image CardImage;
    
    [Header("UI Elements Details")]
    public TextMeshProUGUI NameText;
    public TextMeshProUGUI DescriptionText;
    public TextMeshProUGUI HealthText;
    public TextMeshProUGUI DamageText;
    public TextMeshProUGUI AbilityText;

    public Button OpenButton;
    public Button CloseButton;
    
    [Header("Panels")]
    public GameObject CardDetailPanelContainer;
    
    private void Awake()
    {
        Instance = this;
        
        if(OpenButton != null)
            OpenButton.onClick.AddListener(View);
        
        if(CloseButton != null)
            CloseButton.onClick.AddListener(Hide);
    }
    
    public void ShowDetails(CardSO card)
    {
        CardName.text = card.CardName;
        CardHealth.SetText("{0}", card.Health);
        CardDamage.SetText("{0}", card.Damage);
        CardAbility.text = card.CardAbility != null ? card.CardAbility.GetDescription() : "No Ability";
        
        NameText.text = card.CardName;
        DescriptionText.text = card.CardDescription;
        HealthText.SetText("{0}", card.Health);
        DamageText.SetText("{0}", card.Damage);
        AbilityText.text = card.CardAbility != null ? card.CardAbility.GetDescription() : "No Ability";
    }

    public void View() => CardDetailPanelContainer.SetActive(true);
    public void Hide() => CardDetailPanelContainer.SetActive(false);
}
