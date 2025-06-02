using UnityEngine;

[CreateAssetMenu(menuName = "CardAbilities/Debuff")]
public class DebuffAbilitySO : CardAbilitySO
{
    public int damageReduction = 3;

    public override void Execute(Card target)
    {
        target.ReduceDamage(damageReduction);
    }

    public override string GetDescription()
    {
        return $"Reduce Damage by {damageReduction}";
    }
}