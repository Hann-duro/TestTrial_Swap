using UnityEngine;

public class Gate : MonoBehaviour
{
    public string GateOpenAnimationParamName = "GateOpen";
    
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        
        if (animator == null)
        {
            Debug.LogError("Komponen Animator tidak ditemukan di objek ini!");
            return;
        }
        animator.enabled = false;
    }

    public void GateOpen()
    {
        // 1. Matikan collider anak-anak gerbang
        BoxCollider2D[] colliders = GetComponentsInChildren<BoxCollider2D>();
        foreach (BoxCollider2D col in colliders)
        {
            col.enabled = false;
        }

        // 2. AKTIFKAN ANIMASI SAAT LEVER DI-TRIGGER
        if (animator != null)
        {
            // Hidupkan kembali animatornya agar bisa memproses animasi
            animator.enabled = true;

            // Picu parameter animasi pembuka gerbang
            animator.SetTrigger(GateOpenAnimationParamName);
        }

        Debug.Log("Gate Open");
    }
}