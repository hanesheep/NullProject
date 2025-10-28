using UnityEngine;

public class Hole : MonoBehaviour
{

    public string targetTag;
    bool isHolding;

    public bool IsHolding()
    {
        return isHolding;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isHolding = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag(targetTag))
        {
            isHolding = false;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        Rigidbody r = other.gameObject.GetComponent<Rigidbody>();

        Vector3 direction = other.gameObject.transform.position - transform.position;
        direction.Normalize();

        if (other.gameObject.CompareTag("Player"))
        {
            r.angularVelocity *= 0.9f;
            r.AddForce(direction * -50.0f, ForceMode.Acceleration);
        }
        else
        {
            r.AddForce(direction * 70.0f, ForceMode.Acceleration);
        }
    }
}
