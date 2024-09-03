using NoReleaseDate.Extensions.Runtime;
using UnityEngine;

namespace UIThemeSystem.Runtime
{
    [CreateAssetMenu(fileName = "ColorPalette", menuName = "NoReleaseDate/UIThemeSystem/ColorPalette")]
    public class UIThemeColorPalette : ScriptableObject
    {
        public Color firstColor = new Color().FromHex("#fffef5");
        public Color secondColor = new Color().FromHex("#313c50");
        public Color thirdColor = new Color().FromHex("#475866");
        public Color fourthColor = new Color().FromHex("#ad5143");

        public Color GetColor(ColorType colorType) =>
            colorType switch
            {
                ColorType.First => firstColor,
                ColorType.Second => secondColor,
                ColorType.Third => thirdColor,
                ColorType.Fourth => fourthColor,
                _ => Color.white
            };
    }
}