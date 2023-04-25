using System.Collections.Generic;
using System.Linq;
using DefaultNamespace.UI.Remotes;
using UI.Controllers;

namespace UI.Commands
{
    public class Receiver
    {
        private IRemote _remote;
        private UIController _uiController;
        private Dictionary<int[], ICommand> _commands;

        public Receiver(IRemote remote, UIController uiController)
        {
            _remote = remote;
            _uiController = uiController;
            _remote.OnPressed += OnButtonPressed;

            InitCommands();
        }

        private void OnButtonPressed(int code)
        {
            ICommand command = GetCommand(code);
            command?.Execute();
        }

        private ICommand GetCommand(int code)
        {
            foreach (var codes in _commands.Keys)
            {
                if (codes.Contains(code))
                    return _commands[codes];
            }
            return null;
        }

        private void InitCommands()
        {
            _commands = new Dictionary<int[], ICommand>()
            {
                {new []{23, 65, 0}, new DigitCommand(_uiController, 0)},
                {new []{24, 66, 1}, new DigitCommand(_uiController, 1)},
                {new []{25, 67, 2}, new DigitCommand(_uiController, 2)},
                {new []{26, 68, 3}, new DigitCommand(_uiController, 3)},
                {new []{27, 69, 4}, new DigitCommand(_uiController, 4)},
                {new []{28, 70, 5}, new DigitCommand(_uiController, 5)},
                {new []{29, 71, 6}, new DigitCommand(_uiController, 6)},
                {new []{30, 72, 7}, new DigitCommand(_uiController, 7)},
                {new []{31, 73, 8}, new DigitCommand(_uiController, 8)},
                {new []{32, 74, 9}, new DigitCommand(_uiController, 9)},
                {new []{56, 1, 10}, new UpCommand(_uiController)},
                {new []{58, 2, 11}, new DownCommand(_uiController)},
                {new []{57, 3, 12}, new LeftCommand(_uiController)},
                {new []{55, 4, 13}, new RightCommand(_uiController)},
                {new []{123, 55, 14}, new OkCommand(_uiController)},
                {new []{321, 45, 77}, new BackCommand(_uiController)},
            };
        }
    }
}