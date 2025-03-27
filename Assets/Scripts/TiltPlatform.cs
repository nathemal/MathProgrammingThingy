using UnityEngine;

public class TiltPlatform : MonoBehaviour
{
    public float speed = 2.0f;
    public float angle = 30.0f;

    void Start()
    {
        
    }

    void Update()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        float h = Input.GetAxis("Vertical") * angle;
        float v = Input.GetAxis("Horizontal") * angle;

        Quaternion target = Quaternion.Euler(h, 0, -v);
        rigidbody.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * speed);
    }
}
