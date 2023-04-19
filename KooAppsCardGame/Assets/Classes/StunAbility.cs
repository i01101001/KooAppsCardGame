using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "StunAbility", menuName = "ScriptableObjects/StunAbility")]
public class StunAbility : Ability
{
    private List<Card> abilityTargets;

    StunAbility()
    {
        this.abilityType = AbilityType.StunAbility;
    }

    public List<Card> findTargets()
    {
        return new List<Card>();
    }

    public string getFormattedAbilityDescription()
    {
        return string.Format(abilityDescription, abilityValue);
    }

    public override bool activateEffect()
    {
        return false;
    }

    public override AbilityType getAbilityType()
    {
        return abilityType;
    }
}
