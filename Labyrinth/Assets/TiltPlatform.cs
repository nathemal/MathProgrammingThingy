using UnityEngine;

public class TiltPlatform : MonoBehaviour
{
    float hAxis;
    float vAxis;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Vertical");
        float v = Input.GetAxis("Horizontal");

        vAxis = Mathf.Clamp(vAxis + v, 0.4f, -0.4f);
        hAxis = Mathf.Clamp(hAxis + h, -0.4f, 0.4f);

        transform.Rotate(new Vector3(hAxis, 0, vAxis), Space.Self);
    }
}
