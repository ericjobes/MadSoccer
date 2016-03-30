using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour {

    public Rigidbody projectile;
    Rigidbody clone;
    public float speed;
    public string key;
    public Transform fireTransform;

    void start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            clone = Instantiate(projectile, fireTransform.position, fireTransform.rotation)as Rigidbody;
            clone.velocity = speed * fireTransform.forward; 

            Destroy(clone.gameObject, 5);
        }
    }
}
