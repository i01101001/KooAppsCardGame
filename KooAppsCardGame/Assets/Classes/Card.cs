using System.Collections;
using System.Collections.Generic;
using System.Runtime;
using UnityEngine;
using System;

[Serializable]
[CreateAssetMenu(fileName = "Card", menuName = "ScriptableObjects/Card")]
public abstract class Card : ScriptableObject
{
    public const string cardFileName = "card";
    public string cardName;
    public Sprite cardImage;
    protected bool isCardConsumable;

    public List<Ability> cardAbilities;
    //public List<CardModifier> cardModifiers;
    public abstract CardType getCardType();
    public abstract KooappsType getKooappsType();
}

