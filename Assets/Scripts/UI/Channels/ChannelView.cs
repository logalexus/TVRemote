using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace.UI.Channels
{
    public class ChannelView : MonoBehaviour
    {
        [SerializeField] private TMP_Text channelName;
        [SerializeField] private GameObject highlight;
        [SerializeField] private Button self;

        public void Init(ChannelModel model)
        {
            channelName.text = model.Name;
        }
    }
}