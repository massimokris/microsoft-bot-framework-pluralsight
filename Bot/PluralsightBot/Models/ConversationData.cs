using System;
using System.Collections.Generic;
using System.Text;

namespace PluralsightBot.Models
{
    class ConversationData
    {
        // Track whether we have already asked the user's name
        public bool PromptedUserForName { get; set; } = false;
    }
}
