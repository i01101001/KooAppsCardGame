using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
