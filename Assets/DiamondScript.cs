using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondScript : MonoBehaviour
{
    
    public SpriteRenderer rend;
    public Transform other;
    public Color newColor;

    [Range(-10000,10000)]
    public float rotationSpeed;
       
    // Use this for initialization
    void Start()
    {
        rend.color = newColor;
        rend.color = new Color(1f, 0.5f, 0, 3f);
        //other.position = new Vector3(3, 2, other.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {

            transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {

            transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(5 * Time.deltaTime, 0, 0, Space.Self);
        }
    }
}
