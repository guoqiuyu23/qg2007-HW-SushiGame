using UnityEngine;

public class riceMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      transform.Translate((Vector3.left*Time.deltaTime*5));
    }
}
