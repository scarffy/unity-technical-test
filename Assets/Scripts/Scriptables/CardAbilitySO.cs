using UnityEngine;

public abstract class CardAbilitySO : ScriptableObject, ICardAbility
{
    public abstract void Execute(Card target);
    public abstract string GetDescription();
}