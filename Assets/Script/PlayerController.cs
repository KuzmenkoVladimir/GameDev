using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public GameObject cameraPlayer;
    public Vector3 cameraPos;


    public float smoothTime = 0.3F;
    private Vector3 velocity = Vector3.zero;

    void Start()
    {
        
    }

    
    void Update()
    {

        Vector3 position = new Vector3(Input.GetAxis("Horizontal") * speed, 0, 0);
        transform.position += position;
    }

    void LateUpdate()
    {
        //cameraPlayer.transform.position = transform.position + cameraPos;

        cameraPlayer.transform.position = Vector3.SmoothDamp(cameraPlayer.transform.position, transform.position + cameraPos, ref velocity, smoothTime);
    }

    
}
