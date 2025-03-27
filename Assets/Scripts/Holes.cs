using UnityEngine;

public class Holes : MonoBehaviour
{
    public Collider Sphere;

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Sphere.enabled = false;
        }
    }
}
