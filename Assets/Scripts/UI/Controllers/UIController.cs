using System;
using DefaultNamespace.UI.Remotes;
using UI.Base;
using UI.Screens;
using UnityEngine;

namespace UI.Controllers
{
    public class UIController : BaseUIController
    {
        [Header("Screens")]
        [SerializeField] private ChannelsScreen channelsScreen;
        [SerializeField] private LoginScreen loginScreen;
        [SerializeField] private PlayerScreen playerScreen;

        public ChannelsScreen ChannelsScreen => channelsScreen;
        public LoginScreen LoginScreen => loginScreen;
        
        public event Action OnOk; 
        public event Action OnBack; 

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
        
        public void InvokeOk()
        {
            OnOk?.Invoke();
        }
        
        public void InvokeBack()
        {
            OnBack?.Invoke();
        }
    }
}