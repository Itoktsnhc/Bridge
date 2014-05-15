﻿namespace Bridge.CLR.Html
{
    /// <summary>
    /// The FocusEvent interface represents focus-related events like focus, blur, focusin, or focusout.
    /// </summary>
    [Bridge.CLR.Ignore]
    [Bridge.CLR.Name("FocusEvent")]
    public class FocusEvent : UIEvent
    {
        private FocusEvent()
        {
        }

        /// <summary>
        /// The FocusEvent.relatedTarget read-only property represents a secondary target for this event, which will depend of the event itself. As in some cases (like when tabbing in or out a page), this property may be set to null for security reasons.
        /// </summary>
        public readonly Element RelatedTarget;
    }
}