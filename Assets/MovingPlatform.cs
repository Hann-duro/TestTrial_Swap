using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Transform WP1;
    public Transform WP2;
    public float moveSpeed = 2f;
    
    private Vector3 nextPosition;
    private bool isMoving = false; // Flag untuk status gerak

    void Start()
    {
        nextPosition = WP2.position;
    }

    void Update()
    {
        // Hanya bergerak jika isMoving bernilai true
        if (isMoving)
        {
            transform.position = Vector3.MoveTowards(transform.position, nextPosition, moveSpeed * Time.deltaTime);

            if (Vector3.Distance(transform.position, nextPosition) < 0.01f)
            {
                nextPosition = (nextPosition == WP1.position) ? WP2.position : WP1.position;
            }
        }
    }

    public void Move()
    {
        isMoving = true; // Mengubah flag agar Update() mulai memproses gerak
        Debug.Log("Platform Activated");
    }
}