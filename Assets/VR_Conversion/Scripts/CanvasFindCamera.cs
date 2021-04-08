namespace XRConversion
{
    using UnityEngine;

    public class CanvasFindCamera : MonoBehaviour
    {
        private void Awake()
        {
            var canvas = GetComponent<Canvas>();
            var cam = Camera.main;

            if(canvas.worldCamera == null && cam != null)
            {
                canvas.worldCamera = cam;
            }
        }
    }
}
