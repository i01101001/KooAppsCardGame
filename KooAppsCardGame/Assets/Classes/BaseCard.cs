using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCard : Card
{
    protected CardType cardType = CardType.None;
    public override CardType getCardType()
    {
        return cardType;
    }

    public override KooappsType getKooappsType()
    {
        return KooappsType.None;
    }
}
