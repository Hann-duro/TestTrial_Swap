using UnityEngine;

public class Lever : MonoBehaviour
{
    private bool isActivated = false;

    [SerializeField] private Gate targetGate;
    [SerializeField] private Laser targetLaser;

    public void Activate()
    {
        if (!isActivated)
        {
            isActivated = true;

            if (targetGate != null)
            {
                targetGate.GateOpen();
            }

            if (targetLaser != null)
            {
                targetLaser.TurnOff();
            }

            Debug.Log("Lever Activated");
        }
    }
}