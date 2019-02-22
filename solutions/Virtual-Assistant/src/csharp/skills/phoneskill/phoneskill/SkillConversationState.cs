using Luis;
using Microsoft.Bot.Builder.Dialogs;

namespace PhoneSkill
{
    public class SkillConversationState : DialogState
    {
        public SkillConversationState()
        {
        }

        public string Token { get; internal set; }

        public PhoneSkillLU LuisResult { get; set; }

        public void Clear()
        {
        }
    }
}