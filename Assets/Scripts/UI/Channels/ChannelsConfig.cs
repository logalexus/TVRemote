using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.UIElements;

namespace DefaultNamespace.UI.Channels
{
    [CreateAssetMenu(menuName = "SO/"+ nameof(ChannelsConfig), fileName = nameof(ChannelsConfig), order = 0)]
    public class ChannelsConfig : ScriptableObject
    {
        [SerializeField] private List<ChannelModel> channels;
        
        public List<ChannelModel> Channels => channels;
    }
}