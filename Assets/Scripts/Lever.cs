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

            Debug.Log("Lever Activated!");

            Gate gate = GetComponent<Gate>();

                if (gate != null)
                {
                    gate.GateOpen();
                }
        }
    }
}