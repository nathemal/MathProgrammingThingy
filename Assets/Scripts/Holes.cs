using UnityEngine;

public class Holes : MonoBehaviour
{
    public Collider Sphere;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Sphere.enabled = false;
        }
    }
}
