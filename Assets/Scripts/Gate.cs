using UnityEngine;

public class Gate : MonoBehaviour
{    
    public void GateOpen()
    {
        // Mencari semua BoxCollider2D yang ada di anak-anak objek ini (GroundRight & GroundLeft)
        BoxCollider2D[] colliders = GetComponentsInChildren<BoxCollider2D>();

        foreach (BoxCollider2D col in colliders)
        {
            col.enabled = false;
        }

        Debug.Log("Gate Open");
    }
}