using RageCoop.Server.Scripting;

namespace RageCoop.Resources.LightRace
{
    public class Main : ServerScript
    {
        public override void OnStart()
        {
            API.RegisterCommand("race", StartRace);
            API.RegisterCommand("join", JoinRace);
            API.RegisterCommand("leave", LeaveRace);
            API.RegisterCommand("finish", FinishRace);

            API.SendChatMessage("LightRace loaded! Use /race to start.");
        }

        public override void OnStop()
        {
        }

        private void StartRace(CommandContext context)
        {
            API.SendChatMessage("🏁 Race started! 3... 2... 1... GO!");
        }

        private void JoinRace(CommandContext context)
        {
            API.SendChatMessage(context.Client.Username + " joined the race!");
        }

        private void LeaveRace(CommandContext context)
        {
            API.SendChatMessage(context.Client.Username + " left the race!");
        }

        private void FinishRace(CommandContext context)
        {
            API.SendChatMessage(context.Client.Username + " finished the race!");
        }
    }
}
