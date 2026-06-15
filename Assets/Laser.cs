using UnityEngine;

public class Laser : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerHealth health = collision.GetComponent<PlayerHealth>();
        if (health != null)
        {
            health.TakeDamage(1);
        }
    }
    public void TurnOff()
    {
        gameObject.SetActive(false);
    }
}