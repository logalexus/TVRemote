using System.Collections.Generic;
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
        [SerializeField] private List<TMP_InputField> _inputFields;

        private UIController _uiController;
        private int _currentFieldIndex = 0;
        
        public override void Init(BaseUIController baseUIController)
        {
            _uiController = baseUIController as UIController;

            login.onClick.AddListener(_uiController.OpenChannelScreen);
            
            base.Init(baseUIController);
        }
        
        private void Start()
        {
            SelectField(_currentFieldIndex);
        }
        
        public override void Open()
        {
            base.Open();
            _uiController.OnOk += _uiController.OpenChannelScreen;
        }

        public override void Close()
        {
            base.Close();
            _uiController.OnOk -= _uiController.OpenChannelScreen;
        }
        
        public void SelectField(int index)
        {
            _currentFieldIndex = Mathf.Min(index, _inputFields.Count - 1);
            TMP_InputField channel = _inputFields[_currentFieldIndex];
            channel.Select();
        }
        
        public void SelectNextField(int offset = 1)
        {
            _currentFieldIndex += offset;
            _currentFieldIndex = _currentFieldIndex < 0 ? _inputFields.Count + _currentFieldIndex : _currentFieldIndex;
            _currentFieldIndex %= _inputFields.Count;
            SelectField(_currentFieldIndex);
        }
    }
}