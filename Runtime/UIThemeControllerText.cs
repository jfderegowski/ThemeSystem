using TMPro;
using UnityEngine;

namespace UIThemeSystem.Runtime
{
    [RequireComponent(typeof(TMP_Text))]
    public class UIThemeControllerText : UIThemeController
    {
        public ColorType colorType;

        private TMP_Text _text;
        
        protected override void Awake()
        {
            _text = GetComponent<TMP_Text>();
            
            base.Awake();
        }

        protected override void UpdateTheme()
        {
            if (!themeManager || !_text) return;
            
            if (_text.color == themeManager.current.GetColor(colorType)) return;
            
            _text.color = themeManager.current.GetColor(colorType);
        }
    }
}