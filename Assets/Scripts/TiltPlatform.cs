using UnityEngine;

public class TiltPlatform : MonoBehaviour
{
    /* float hAxis;
     float vAxis;
    */

    public float speed = 2.0f;
    public float angle = 30.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        float h = Input.GetAxis("Vertical") * angle;
        float v = Input.GetAxis("Horizontal") * angle;

        Quaternion target = Quaternion.Euler(h, 0, -v);
        rigidbody.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * speed);

        /*vAxis = Mathf.Clamp(vAxis + v, 0.4f, -0.4f);
        hAxis = Mathf.Clamp(hAxis + h, -0.4f, 0.4f);

        transform.Rotate(new Vector3(hAxis, 0, vAxis), Space.Self);
        */

    }
}
