﻿using Ship;

namespace Tokens
{

    public class GenericToken
    {
        public string Name;
        public GenericShip Host;
        public bool Temporary = true;
        public ActionsList.GenericAction Action = null;
        public bool CanBeUsed = true;
        public int Count = 1;
        public string Tooltip;

        public GenericToken(GenericShip host = null)
        {
            Host = host;
        }

        public virtual ActionsList.GenericAction GetAvailableEffects()
        {
            ActionsList.GenericAction result = null;
            if ((Action != null) && (CanBeUsed))
            {
                result = Action;
            }
            return result;
        }

    }

}
