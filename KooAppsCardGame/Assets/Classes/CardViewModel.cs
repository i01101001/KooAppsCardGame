using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

[ExecuteInEditMode]
public class CardViewModel : MonoBehaviour
{
    public SpriteRenderer cardImage;
    public TextMeshPro cardNameText;
    public TextMeshPro cardDescriptionText;
    public TextMeshPro cardValueText;
    public Card refCard;
    // Start is called before the first frame update
    private void OnValidate()
    {

        cardImage.sprite = refCard.cardImage;
        CardType refCardType = refCard.getCardType();
        cardNameText.SetText(getCardNameText(refCardType));
        cardDescriptionText.SetText(getCardDescriptionText(refCardType));
        setCardValueText(refCardType);
    }

    public void updateViews()
    {
        OnValidate();
    }

    private string getCardNameText(CardType cardType)
    {
        switch (cardType)
        {
            case CardType.TicketCard:
            case CardType.EmployeeCard:
                return string.Format("{0} - {1}", refCard.cardName, getKooappsTypeText(refCard.getKooappsType()));
            default:
                return refCard.cardName;
        }
    }
    
    private string getKooappsTypeText(KooappsType kooappsType)
    {
        switch (kooappsType)
        {
            case KooappsType.Dev:
                return "Dev";
            case KooappsType.Ops:
                return "Ops";
            case KooappsType.Arts:
                return "Arts";
            case KooappsType.HR:
                return "HR";
            case KooappsType.Marketing:
                return "Marketing";
            default:
                return "";
        }
    }

    private string getCardDescriptionText(CardType cardType)
    {
        string cardDescriptionText = "";
        switch (cardType)
        {
            case CardType.TicketCard:
                cardDescriptionText = getTicketCardDescription();
                break;
            case CardType.EmployeeCard:
                cardDescriptionText = getEmployeeCardDescription() ;
                break;
        }
        return cardDescriptionText;
    }

    private string getTicketCardDescription()
    {
        cardDescriptionText.enableWordWrapping = true;
        TicketCard refTicket = (TicketCard)refCard;
        return refTicket.ticketDescription;
    }


    private string getEmployeeCardDescription()
    {
        cardDescriptionText.enableWordWrapping = false;
        string employeeCardDescription = "";
        EmployeeCard refEmployee = (EmployeeCard)refCard;
        IEnumerator<EmployeeAffinity> affinityEnumerator = refEmployee.employeeAffinityList.GetEnumerator();

        foreach(EmployeeAffinity affinity in refEmployee.employeeAffinityList)
        {
            if (affinity.affinityValue <= 0)
            {
                continue;
            }

            employeeCardDescription += string.Format("+{0} attack to {1}\n", affinity.affinityValue, affinity.affinityName);
        }
        return employeeCardDescription;
    }

    private void setCardValueText(CardType cardType)
    {
        if (cardType == CardType.TicketCard || cardType == CardType.EmployeeCard)
        {
            switch (cardType)
            {
                case CardType.TicketCard:
                    TicketCard refTicket = (TicketCard)refCard;
                    cardValueText.SetText(refTicket.ticketHours.ToString());
                    break;

                case CardType.EmployeeCard:
                    EmployeeCard refEmployee = (EmployeeCard)refCard;
                    cardValueText.SetText(refEmployee.employeeVelocity.ToString());
                    break;
            }
        }
    }
}
