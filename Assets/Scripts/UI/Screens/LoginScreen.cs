using TMPro;
using UI.Base;
using UI.Controllers;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Screens
{
    public class LoginScreen : BaseScreen
    {
        [SerializeField] private Button login;

        private UIController _uiController;
        
        public override void Init(BaseUIController baseUIController)
        {
            base.Init(baseUIController);
            
            _uiController = baseUIController as UIController;
            
            login.onClick.AddListener(_uiController.OpenChannelScreen);
        }
    }
}