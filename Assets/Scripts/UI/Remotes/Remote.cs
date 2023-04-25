using System;
using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace.UI.Remotes
{
    public class Remote : MonoBehaviour, IRemote
    {
        [SerializeField] private RemoteType remoteType = RemoteType.Samsung;

        private Dictionary<KeyCode, int> CurrentRemoteCodes;
        
        public event Action<int> OnPressed;
        
        public void Start()
        {
            switch (remoteType)
            {
                case RemoteType.Samsung:
                    CurrentRemoteCodes = RemoteConfig.SumsungCodes;
                    break;
                case RemoteType.LG:
                    CurrentRemoteCodes = RemoteConfig.LGCodes;
                    break;
                case RemoteType.Sony:
                    CurrentRemoteCodes = RemoteConfig.SonyCodes;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Keypad0))
                OnPressed?.Invoke(CurrentRemoteCodes[KeyCode.Keypad0]);
            if (Input.GetKeyDown(KeyCode.Keypad1))
                OnPressed?.Invoke(CurrentRemoteCodes[KeyCode.Keypad1]);
            if (Input.GetKeyDown(KeyCode.Keypad2))
                OnPressed?.Invoke(CurrentRemoteCodes[KeyCode.Keypad2]);
            if (Input.GetKeyDown(KeyCode.Keypad3))
                OnPressed?.Invoke(CurrentRemoteCodes[KeyCode.Keypad3]);
            if (Input.GetKeyDown(KeyCode.Keypad4))
                OnPressed?.Invoke(CurrentRemoteCodes[KeyCode.Keypad4]);
            if (Input.GetKeyDown(KeyCode.Keypad5))
                OnPressed?.Invoke(CurrentRemoteCodes[KeyCode.Keypad5]);
            if (Input.GetKeyDown(KeyCode.Keypad6))
                OnPressed?.Invoke(CurrentRemoteCodes[KeyCode.Keypad6]);
            if (Input.GetKeyDown(KeyCode.Keypad7))
                OnPressed?.Invoke(CurrentRemoteCodes[KeyCode.Keypad7]);
            if (Input.GetKeyDown(KeyCode.Keypad8))
                OnPressed?.Invoke(CurrentRemoteCodes[KeyCode.Keypad8]);
            if (Input.GetKeyDown(KeyCode.Keypad9))
                OnPressed?.Invoke(CurrentRemoteCodes[KeyCode.Keypad9]);
            if (Input.GetKeyDown(KeyCode.UpArrow))
                OnPressed?.Invoke(CurrentRemoteCodes[KeyCode.UpArrow]);
            if (Input.GetKeyDown(KeyCode.DownArrow))
                OnPressed?.Invoke(CurrentRemoteCodes[KeyCode.DownArrow]);
            if (Input.GetKeyDown(KeyCode.LeftArrow))
                OnPressed?.Invoke(CurrentRemoteCodes[KeyCode.LeftArrow]);
            if (Input.GetKeyDown(KeyCode.RightArrow))
                OnPressed?.Invoke(CurrentRemoteCodes[KeyCode.RightArrow]);
            if (Input.GetKeyDown(KeyCode.KeypadEnter))
                OnPressed?.Invoke(CurrentRemoteCodes[KeyCode.KeypadEnter]);
            if (Input.GetKeyDown(KeyCode.Escape))
                OnPressed?.Invoke(CurrentRemoteCodes[KeyCode.Escape]);
        }
    }
}