using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace.UI.Remotes
{
    public class RemoteConfig
    {
        public static Dictionary<KeyCode, int> SumsungCodes = new Dictionary<KeyCode, int>()
        {
            {KeyCode.Keypad0, 23},
            {KeyCode.Keypad1, 24},
            {KeyCode.Keypad2, 25},
            {KeyCode.Keypad3, 26},
            {KeyCode.Keypad4, 27},
            {KeyCode.Keypad5, 28},
            {KeyCode.Keypad6, 29},
            {KeyCode.Keypad7, 30},
            {KeyCode.Keypad8, 31},
            {KeyCode.Keypad9, 32},
            {KeyCode.UpArrow, 56},
            {KeyCode.DownArrow, 58},
            {KeyCode.LeftArrow, 57},
            {KeyCode.RightArrow, 55},
            {KeyCode.KeypadEnter, 123},
            {KeyCode.Escape, 321},
            {KeyCode.Delete, 45},
        };

        public static Dictionary<KeyCode, int> LGCodes = new Dictionary<KeyCode, int>()
        {
            {KeyCode.Keypad0, 65},
            {KeyCode.Keypad1, 66},
            {KeyCode.Keypad2, 67},
            {KeyCode.Keypad3, 68},
            {KeyCode.Keypad4, 69},
            {KeyCode.Keypad5, 70},
            {KeyCode.Keypad6, 71},
            {KeyCode.Keypad7, 72},
            {KeyCode.Keypad8, 73},
            {KeyCode.Keypad9, 74},
            {KeyCode.UpArrow, 1},
            {KeyCode.DownArrow, 2},
            {KeyCode.LeftArrow, 3},
            {KeyCode.RightArrow, 4},
            {KeyCode.KeypadEnter, 55},
            {KeyCode.Escape, 77}
        };

        public static Dictionary<KeyCode, int> SonyCodes = new Dictionary<KeyCode, int>()
        {
            {KeyCode.Keypad0, 0},
            {KeyCode.Keypad1, 1},
            {KeyCode.Keypad2, 2},
            {KeyCode.Keypad3, 3},
            {KeyCode.Keypad4, 4},
            {KeyCode.Keypad5, 5},
            {KeyCode.Keypad6, 6},
            {KeyCode.Keypad7, 7},
            {KeyCode.Keypad8, 8},
            {KeyCode.Keypad9, 9},
            {KeyCode.UpArrow, 10},
            {KeyCode.DownArrow, 11},
            {KeyCode.LeftArrow, 12},
            {KeyCode.RightArrow, 13},
            {KeyCode.KeypadEnter, 14},
            {KeyCode.Escape, -1},
        };
    }
}