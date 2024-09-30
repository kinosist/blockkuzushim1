using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadWall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        // ƒ{[ƒ‹‚ğíœ
        Destroy(collision.gameObject);
    }
}
