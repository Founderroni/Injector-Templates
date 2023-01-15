using DiscordRPC;

namespace KekKinjector.Handlers
{
    public class RPC
    {
        public static bool IsRPCRunning { get; private set; }
        public static DiscordRpcClient client;


        public static void StartRpc(string detail, string state)
        {
            if (string.IsNullOrEmpty(detail)) detail = "Whoa";
            if (string.IsNullOrEmpty(state)) state = "The RPC";

            if (!IsRPCRunning)
            {
                client = new DiscordRpcClient("1021597841791139950");
                client.SetPresence(new RichPresence()
                {
                    Details = detail,
                    State = state,
                    Assets = new Assets()
                    {
                        LargeImageKey = "https://i.ibb.co/qjTt7Bv/kek.png", //Don't go above 32 characters
                        LargeImageText = "Kek Injector By Founder",
                    }
                });
                client.Initialize();
                IsRPCRunning = true;
            }
            else
            {
                UpdateRpc(detail, state);
            }
        }

        public static void UpdateRpc(string detail, string state)
        {
            if (string.IsNullOrEmpty(detail)) detail = "Funky RPC";
            if (string.IsNullOrEmpty(state)) state = "very";

            if (IsRPCRunning)
            {
                client.UpdateDetails(detail);
                client.UpdateState(state);
            }
            else
            {
                StartRpc(detail, state);
            }
        }

        public static void ClearRpc()
        {
            if (IsRPCRunning)
                client.ClearPresence();
            IsRPCRunning = false;
        }
    }
}
