using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    public GameObject bullet;
    //public Rigidbody brigid;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
    

    }

    // Update is called once per frame
    void Update()
    {
        // always put jostick without a number to make sure it's always working for one player...
        if (Input.GetKeyDown(KeyCode.JoystickButton0))
         {
            Debug.Log("touche A");
            GameObject o = Instantiate(bullet, transform);
            o.transform.parent = this.transform;
            o.transform.localPosition = new Vector3(0, 0, 0);
            Destroy(o, 6f);
        }
   
    }
    
        
}
