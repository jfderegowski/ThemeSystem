using SingletonSystem.Runtime;
using UnityEngine;

namespace NoReleaseDate.ThemeSystem.Runtime
{
    [CreateAssetMenu(fileName = "ThemeManager", menuName = "NoReleaseDate/UIThemeSystem/ThemeManager")]
    public class ThemeManager : ScriptableObjectSingleton<ThemeManager>
    {
        public ThemeColorPalette current => defaultColorPalette;
        
        public ThemeColorPalette defaultColorPalette;
    }
}
