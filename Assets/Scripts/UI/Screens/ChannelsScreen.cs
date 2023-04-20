using System;
using System.Collections.Generic;
using DefaultNamespace.UI.Channels;
using DG.Tweening;
using UI.Base;
using UI.Controllers;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Screens
{
    public class ChannelsScreen : BaseScreen
    {
        [SerializeField] private Button ok;
        [SerializeField] private Button back;
        [SerializeField] private ChannelView channelPrefab;
        [SerializeField] private ChannelsConfig channelsConfig;
        [SerializeField] private Transform channelContainer;
        [SerializeField] private RectTransform canvas;
        
        private RectTransform _channelContainerRect;
        private UIController _uiController;
        private List<ChannelView> _channelViews;
        private int _currentChannelIndex = 0;

        public override void Init(BaseUIController baseUIController)
        {
            base.Init(baseUIController);
            
            _uiController = baseUIController as UIController;
            
            ok.onClick.AddListener(_uiController.OpenPlayerScreen);
            back.onClick.AddListener(_uiController.OpenLoginScreen);

            CreateChannels();
        }

        private void Start()
        {
            SelectChannel(_currentChannelIndex);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
                SelectNextChannel();
            
            if (Input.GetKeyDown(KeyCode.LeftArrow))
                SelectNextChannel(-1);
        }

        private void CreateChannels()
        {
            _channelViews = new List<ChannelView>();
            
            foreach (var channel in channelsConfig.Channels)
            {
                ChannelView channelView = Instantiate(channelPrefab, channelContainer);
                channelView.Init(channel);
                _channelViews.Add(channelView);
            }
        }

        public void SelectNextChannel(int offset = 1)
        {
            _currentChannelIndex += offset;
            _currentChannelIndex = _currentChannelIndex < 0 ? _channelViews.Count + _currentChannelIndex : _currentChannelIndex;
            _currentChannelIndex %= _channelViews.Count;
            SelectChannel(_currentChannelIndex);
        }

        public void SelectChannel(int index)
        {
            ChannelView channel = _channelViews[_currentChannelIndex];
            channel.GetComponent<Button>().Select();
            CorrectChannelVisible(channel);
        }

        public void CorrectChannelVisible(ChannelView channelView)
        {
            RectTransform channelRect = channelView.GetComponent<RectTransform>();
            Vector2 leftBorder = Vector2.zero;
            Vector2 rightBorder = Vector2.right * canvas.rect.width;
            RectTransform channelContainerRect = channelContainer.GetComponent<RectTransform>();
            Vector2 currentPosition =  channelContainerRect.localPosition + channelRect.localPosition;

            
            if (currentPosition.x < leftBorder.x)
            {
                float distance = leftBorder.x - currentPosition.x;
                distance += channelRect.rect.width;
                channelContainerRect.DOLocalMoveX(distance, 1f).SetRelative(true);
            }
            
            if (currentPosition.x > rightBorder.x)
            {
                float distance = rightBorder.x - currentPosition.x;
                distance -= channelRect.rect.width;
                channelContainerRect.DOLocalMoveX(distance, 1f).SetRelative(true);
            }
        }
        
    }
}