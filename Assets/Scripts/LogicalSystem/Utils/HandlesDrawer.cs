using UnityEngine;

namespace LogicalSystem.Utils
{
    /// <summary>
    /// Contains info for debug drawing
    /// </summary>
    public static class HandlesDrawer
    {
#if UNITY_EDITOR
        public static GUIStyle GUIStyle = new()
        {
            fontStyle = FontStyle.Bold,
            fontSize = 15,
            richText = true,
            alignment = TextAnchor.MiddleCenter
        };
#endif
    }
}