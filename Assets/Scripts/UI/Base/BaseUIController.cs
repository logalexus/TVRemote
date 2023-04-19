using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace UI.Base
{
    public class BaseUIController : MonoBehaviour
    {
        private BaseScreen _activeScreen;
        private Stack<BaseScreen> _screensStack;
        private List<BaseScreen> _screens;
        private int _fixLayerCount;


        public event Action OnClosedOverAllScreens;
        public event Action OnClosedAllScreens;
        public event Action<BaseScreen> OnOpenedScreenOverAll;
        public event Action<BaseScreen> OnOpenedScreenWithCloseAll;

        public virtual void Init()
        {
            _screensStack = new Stack<BaseScreen>();
            _screens = FindObjectsOfType<BaseScreen>(true).ToList();
            _fixLayerCount = _screens.Where(x => x.IsTopLayer).Count(); 
        }


        /// <summary> Открывает предыдущий экран </summary>
        public virtual void BackToPreviousScreen()
        {
            if (_screensStack.Count == 0)
                throw new Exception("No previous screen");


            _screensStack.Pop().Close();


            if (_screensStack.Count == 1)
                OnClosedOverAllScreens?.Invoke();
        }



        /// <summary>Открывает экран поверх других</summary>
        public virtual void OpenScreenOverAll(BaseScreen screen)
        {
            _activeScreen = screen;
            _activeScreen.Open();
            _activeScreen.transform.SetSiblingIndex(_screens.Count - _fixLayerCount - 1);
            _screensStack.Push(_activeScreen);

            OnOpenedScreenOverAll?.Invoke(screen);
        }


        /// <summary>Открывает экран, но закрывает другие</summary>
        public virtual void OpenScreenWithCloseAll(BaseScreen screen)
        {
            CloseAllScreens();

            _activeScreen = screen;
            _activeScreen.Open();

            _screensStack.Push(_activeScreen);

            OnOpenedScreenWithCloseAll?.Invoke(screen);
        }

        public virtual void CloseAllScreens()
        {
            foreach (var openedScreen in _screensStack)
                openedScreen.Close();
            _screensStack.Clear();

            OnClosedAllScreens?.Invoke();
        }
    }
}
