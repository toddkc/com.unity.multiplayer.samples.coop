/// <summary>
/// Used to confirm the new startup scene was used.
/// </summary>
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
