using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairsTrigger : MonoBehaviour
{
    public GameObject player;
    public float timeWait;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
       if (Input.GetKeyDown(KeyCode.Space))
        {
          StartCoroutine(WaitAndPrint(2.0F));
        }
    }

    private IEnumerator WaitAndPrint(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        player.transform.position += Vector3.up * 5;
        
    }
}
