using UnityEngine;
using UnityEngine.Events;

public class Lights : MonoBehaviour
{
    public UnityEvent lightsOn;
    
    public void OnMouseDown()
    {
        lightsOn.Invoke();
    }
}
