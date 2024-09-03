using UnityEngine;

namespace UIThemeSystem.Runtime
{
    [ExecuteInEditMode]
    public abstract class UIThemeController : MonoBehaviour
    {
        public static UIThemeManager themeManager => UIThemeManager.instance;

        protected virtual void Awake()
        {
            UpdateTheme();

            if (!Application.isPlaying) return;
            enabled = false;
        }

#if UNITY_EDITOR
        
        private void Update()
        {
            if (Application.isPlaying)
            {
                enabled = false;
                return;
            }
            
            UpdateTheme();
        }

#endif

        protected abstract void UpdateTheme();
    }
}