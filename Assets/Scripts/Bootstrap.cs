using System;
using DefaultNamespace.UI.Remotes;
using UI.Commands;
using UI.Controllers;
using UnityEngine;

namespace DefaultNamespace
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private UIController uiController;
        [SerializeField] private Remote remote;

        private Receiver _receiver; 
        
        private void Awake()
        {
            uiController.Init();
            uiController.OpenLoginScreen();

            _receiver = new Receiver(remote, uiController);
        }
    }
}