using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDash.Config
{
    internal static class GenerateFormConfig
    {
        internal static readonly int CellSize = 40;
        internal static readonly string EmptyCellView = "";
        internal static readonly string SandView = ".";
        internal static readonly Color ItemsDefaultColor = Color.White;

        internal static Color GetCellColor(string value)
        {
            return value switch
            {
                "S" => Color.Gray,     // Stone
                "." => Color.BurlyWood,// Sand
                "P" => Color.Green,     // Player
                "D" => Color.Blue,   // Diamond
                "E" => Color.Red,      // Enemy
                _ => Color.White       // Nothing
            };
        }
    }
}
