using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
[CreateAssetMenu(fileName = "CardDeck", menuName = "ScriptableObjects/CardDeck")]
public class CardDeck : ScriptableObject
{
    public List<Card> deckCardList;
}
