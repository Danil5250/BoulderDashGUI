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
        internal static readonly char ElementsSeparator = '|';

        internal static readonly string DefaultFieldWidth = "10";
        internal static readonly string DefaultFieldHeight = "10";

        internal static readonly Color ItemsDefaultColor = Color.White;

        internal static readonly string SandFullName = "sand";
        internal static readonly string PlayerFullName = "player";
        internal static readonly string StoneFullName = "stone";
        internal static readonly string DiamondFullName = "diamond";
        internal static readonly string EnemyFullName = "enemy";

        internal static readonly string SandView = ".";
        internal static readonly string PlayerView = "P";
        internal static readonly string StoneView = "S";
        internal static readonly string DiamondView = "D";
        internal static readonly string EnemyView = "E";

        internal static string FullToShortName(string fullName)
        {
            if (fullName == SandFullName) return SandView;
            if (fullName == PlayerFullName) return PlayerView;
            if (fullName == StoneFullName) return StoneView;
            if (fullName == DiamondFullName) return DiamondView;
            if (fullName == EnemyFullName) return EnemyView;
            return EmptyCellView;
        }

        internal static Color GetCellColor(string value)
        {
            if (value == StoneFullName)
                return Color.Gray;     // Stone
            if (value == SandFullName)
                return Color.BurlyWood; // Sand
            if (value == PlayerFullName)
                return Color.Green;   // Player
            if (value == DiamondFullName)
                return Color.Blue;   // Diamond
            if (value == EnemyFullName)
                return Color.Red;      // Enemy
            return Color.White;             // Nothing
        }
    }
}
