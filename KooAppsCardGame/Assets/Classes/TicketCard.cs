using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TicketCard", menuName = "ScriptableObjects/TicketCard")]
public class TicketCard : BaseCard
{
    public int ticketHours;
    public string ticketDescription;
    public KooappsType ticketType;

    TicketCard()
    {
        this.cardType = CardType.TicketCard;
    }

    public override KooappsType getKooappsType()
    {
        return ticketType;
    }
}
