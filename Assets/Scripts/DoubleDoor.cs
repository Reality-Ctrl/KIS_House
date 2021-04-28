using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(BoxCollider))]
public class DoubleDoor : MonoBehaviour
{
    private Animator animator;
    private BoxCollider doorBoxCollider;

    private void Awake()
    {
        animator = gameObject.GetComponent<Animator>();
        doorBoxCollider = gameObject.GetComponent<BoxCollider>();
    }

    public void Open()
    {
        animator.SetBool("isOpen", true);
        doorBoxCollider.enabled = false;
    }

    public void Close()
    {
        animator.SetBool("isOpen", false);
        doorBoxCollider.enabled = true;
    }

    public void ChangeState()
    {
        bool currStatus = animator.GetBool("isOpen");
        animator.SetBool("isOpen", !currStatus);
        doorBoxCollider.enabled = currStatus;
    }
}
