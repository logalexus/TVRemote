using TMPro;
using UI.Base;
using UI.Controllers;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Screens
{
    public class PlayerScreen : BaseScreen
    {
        [SerializeField] private Button ok;
        [SerializeField] private Button back;
        [SerializeField] private TMP_Text channelName;
        
        private UIController _uiController;

        public override void Init(BaseUIController baseUIController)
        {
            _uiController = baseUIController as UIController;

            ok.onClick.AddListener(_uiController.OpenChannelScreen);
            back.onClick.AddListener(_uiController.OpenChannelScreen);
            
            base.Init(baseUIController);
        }
        
        public override void Open()
        {
            base.Open();
            _uiController.OnOk += _uiController.OpenChannelScreen;
            _uiController.OnBack += _uiController.OpenChannelScreen;
        }

        public override void Close()
        {
            base.Close();
            _uiController.OnOk -= _uiController.OpenChannelScreen;
            _uiController.OnBack -= _uiController.OpenChannelScreen;
        }
    }
}