using UnityEngine;

public class Cube_Controller : MonoBehaviour
{
    [SerializeField] GameObject cube;
    [SerializeField] float speed = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
            cube.transform.position = cube.transform.position + new Vector3(speed * 0.1f, 0, 0);
        if (Input.GetKey(KeyCode.S))
            cube.transform.position = cube.transform.position + new Vector3(speed * - 0.1f, 0, 0);
        if (Input.GetKey(KeyCode.A))
            cube.transform.position = cube.transform.position + new Vector3(0, 0, speed * 0.1f);
        if (Input.GetKey(KeyCode.D))
            cube.transform.position = cube.transform.position + new Vector3(0, 0, speed * - 0.1f);
    }
}
