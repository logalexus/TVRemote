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
            base.Init(baseUIController);
            
            _uiController = baseUIController as UIController;
            
            ok.onClick.AddListener(_uiController.OpenChannelScreen);
            back.onClick.AddListener(_uiController.OpenChannelScreen);
        }
    }
}