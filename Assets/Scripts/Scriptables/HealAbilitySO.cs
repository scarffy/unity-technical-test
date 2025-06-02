using UnityEngine;

[CreateAssetMenu(menuName = "CardAbilities/Heal")]
public class HealAbilitySO : CardAbilitySO
{
    public int healAmount = 10;

    public override void Execute(Card target)
    {
        target.Heal(healAmount);
    }

    public override string GetDescription()
    {
        return $"Heal {healAmount} HP";
    }
}