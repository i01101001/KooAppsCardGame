using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;

[Serializable]
public abstract class Ability : ScriptableObject
{
    public string abilityName;
    public string abilityDescription;
    public int abilityValue;
    protected AbilityType abilityType = AbilityType.None;

    public abstract bool activateEffect();
    public abstract AbilityType getAbilityType();
}
