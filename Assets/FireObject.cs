using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FireObject : XRGrabInteractable
{
    [SerializeField] private float fireForce = 10f; // The force at which the object is fired.

    private Rigidbody rb;

    protected override void Awake()
    {
        base.Awake();
        rb = GetComponent<Rigidbody>();
    }

    protected override void OnSelectEntered(XRBaseInteractor interactor)
    {
        base.OnSelectEntered(interactor);
        rb.isKinematic = true;
    }

    protected override void OnSelectExited(XRBaseInteractor interactor)
    {
        base.OnSelectExited(interactor);
        rb.isKinematic = false;
        Fire(interactor);
    }

    private void Fire(XRBaseInteractor interactor)
    {
        Vector3 direction = interactor.transform.forward;
        rb.AddForce(direction * fireForce, ForceMode.Impulse);
    }
}