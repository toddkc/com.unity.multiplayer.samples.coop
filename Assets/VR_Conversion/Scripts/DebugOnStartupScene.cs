namespace XRConversion
{
    using UnityEngine;

    public class DebugOnStartupScene : MonoBehaviour
    {
        private void Awake()
        {
            Debug.Log("Startup scene was loaded.");
        }
    }
}
