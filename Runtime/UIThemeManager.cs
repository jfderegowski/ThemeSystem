using SingletonSystem.Runtime;
using UnityEngine;

namespace UIThemeSystem.Runtime
{
    [CreateAssetMenu(fileName = "UIThemeManager", menuName = "NoReleaseDate/UIThemeSystem/UIThemeManager")]
    public class UIThemeManager : ScriptableObjectSingleton<UIThemeManager>
    {
        public UIThemeColorPalette current => defaultColorPalette;
        
        public UIThemeColorPalette defaultColorPalette;
    }
}
