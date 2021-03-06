﻿using Ship;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tokens
{

    public class CalculateToken : GenericToken
    {
        public CalculateToken(GenericShip host) : base(host)
        {
            Name = ImageName = "Calculate Token";
            TokenColor = TokenColors.Green;
            TokenShape = TokenShapes.Cirular;
            PriorityUI = 65;
            Action = new ActionsList.CalculateAction() { HostShip = host};
        }
    }

}
