using UnityEngine;

public class OrbitOnCircle : MonoBehaviour
{
    public Transform centerObject;
    public float orbitRadius = 3f;
    public float orbitSpeed = 50f;

    private bool isClockwise = true;
    void Start()
    {

        Vector3 initialPosition = (transform.position - centerObject.position).normalized * orbitRadius + centerObject.position;
        transform.position = initialPosition;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isClockwise = !isClockwise;
        }

        float direction = isClockwise ? 1f : -1f;

        transform.RotateAround(centerObject.position, Vector3.forward, direction * orbitSpeed * Time.deltaTime);
    }
}
