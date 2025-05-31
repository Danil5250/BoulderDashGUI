using BoulderDashCore.Managers.InputManagers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDash.Utils
{
    internal static class KeyInterpreter
    {
        public static GameKeys? WinFormsKeyToGameKey(KeyEventArgs key)
        {
            if (key.Shift)
            {
                return key.KeyCode switch
                {
                    Keys.W => GameKeys.BombUp,
                    Keys.S => GameKeys.BombDown,
                    Keys.A => GameKeys.BombLeft,
                    Keys.D => GameKeys.BombRight,
                    _ => null
                };
            }
            return key.KeyCode switch
            {
                Keys.Up => GameKeys.UpArrow,
                Keys.Down => GameKeys.DownArrow,
                Keys.Left => GameKeys.LeftArrow,
                Keys.Right => GameKeys.RightArrow,
                Keys.W => GameKeys.JumpUp,
                Keys.S => GameKeys.JumpDown,
                Keys.A => GameKeys.JumpLeft,
                Keys.D => GameKeys.JumpRight,
                _ => null
            };
        }
    }
}
