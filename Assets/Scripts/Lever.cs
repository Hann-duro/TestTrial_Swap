using UnityEngine;

public class Lever : MonoBehaviour
{
    private bool isActivated = false;

    [SerializeField] private Gate targetGate;
    [SerializeField] private Laser targetLaser;
    [SerializeField] private MovingPlatform targetPlatform;

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
            if (targetPlatform != null)
            {
                targetPlatform.Move();
            }

            Debug.Log("Lever Activated");
        }
    }
}