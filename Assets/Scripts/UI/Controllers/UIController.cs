using UI.Base;
using UI.Screens;
using UnityEngine;

namespace UI.Controllers
{
    public class UIController : BaseUIController
    {
        [SerializeField] private ChannelsScreen channelsScreen;
        [SerializeField] private LoginScreen loginScreen;
        [SerializeField] private PlayerScreen playerScreen;

        public override void Init()
        {
            base.Init();
            channelsScreen.Init(this);
            loginScreen.Init(this);
            playerScreen.Init(this);
        }

        public void OpenChannelScreen()
        {
            OpenScreenWithCloseAll(channelsScreen);
        }
        
        public void OpenLoginScreen()
        {
            OpenScreenWithCloseAll(loginScreen);
        }
        
        public void OpenPlayerScreen()
        {
            OpenScreenWithCloseAll(playerScreen);
        }
    }
}