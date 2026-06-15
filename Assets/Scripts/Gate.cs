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
        BoxCollider2D[] colliders = GetComponentsInChildren<BoxCollider2D>();
        foreach (BoxCollider2D col in colliders)
        {
            col.enabled = false;
        }
        if (animator != null)
        {
            animator.enabled = true;
            animator.SetTrigger(GateOpenAnimationParamName);
        }

        Debug.Log("Gate Open");
    }
}