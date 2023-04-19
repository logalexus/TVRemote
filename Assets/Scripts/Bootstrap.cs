using System;
using UI.Controllers;
using UnityEngine;

namespace DefaultNamespace
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private UIController uiController;

        private void Awake()
        {
            uiController.Init();
            uiController.OpenLoginScreen();
        }
    }
}