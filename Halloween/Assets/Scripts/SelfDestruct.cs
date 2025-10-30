using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
	    if (Input.GetKey("x"))
	    {
		    Destroy(gameObject);
	    }
    }
}
