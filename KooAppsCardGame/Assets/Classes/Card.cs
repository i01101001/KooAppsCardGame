using System.Collections;
using System.Collections.Generic;
using System.Runtime;
using UnityEngine;
using System;

[Serializable]
public abstract class Card : ScriptableObject
{
    public const string cardFileName = "card";
    public string cardName;
    public Sprite cardImage;
    protected bool isCardConsumable;

    //public List<CardAbility> cardAbilities;
    //public List<CardModifier> cardModifiers;
    public abstract CardType getCardType();
    public abstract KooappsType getKooappsType();
}

