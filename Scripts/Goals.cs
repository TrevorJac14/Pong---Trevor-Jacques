using UnityEngine;
using UnityEngine.Events;

public class Goals : MonoBehaviour
{
    public UnityEvent onTriggerEnter;

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Ball")) {
            onTriggerEnter.Invoke();
        }
    }
}
