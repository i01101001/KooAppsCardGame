using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EmployeeCard : BaseCard
{
    public int employeeVelocity;
    public KooappsType employeeType;
    public List<EmployeeAffinity> employeeAffinityList;

    EmployeeCard()
    {
        this.cardType = CardType.EmployeeCard;
    }

    public override KooappsType getKooappsType()
    {
        return employeeType;
    }
}
