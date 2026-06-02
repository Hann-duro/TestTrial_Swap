using UnityEngine;

public class Lever : MonoBehaviour
{
    private bool isActivated = false;
    [SerializeField] private Gate targetGate; 

    public void Activate()
    {
        if (!isActivated)
        {
            isActivated = true;

            if (targetGate != null)
            {
                targetGate.GateOpen();
                Debug.Log("Lever Activated");
            }
        }
    }
}