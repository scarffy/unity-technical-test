using UnityEngine;

[CreateAssetMenu(menuName ="ScriptableObjects/Card")]
public class CardSO : ScriptableObject
{
    public string CardName;
    public int Health;
    public int Damage;

    public string CardDescription;
    
    public Sprite CardSprite;
    
    [Tooltip("If card doesn't have an ability, it is ok to be empty")]
    public CardAbilitySO CardAbility;
}
