using UnityEngine;

[CreateAssetMenu(menuName = "CardAbilities/Buff")]
public class BuffAbilitySO : CardAbilitySO
{
    public int bonusDamage = 5;

    public override void Execute(Card target)
    {
        target.IncreaseDamage(bonusDamage);
    }

    public override string GetDescription()
    {
        return $"Increase Damage by {bonusDamage}";
    }
}