﻿namespace UI.Commands
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}