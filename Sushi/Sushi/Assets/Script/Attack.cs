using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject singleSashimiPrefab;
    private GameObject singleSashimi;
    public string Type;
    //private GameObject singleSashimi;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // if(transform.position.y > MAX_Y){ //if the bullet has moved to far up
        //     KaiPool.instance.Push(gameObject);  //return it to the pool
        // }
    }

    private void OnMouseDown()
    {
        switch (Type)
        {
            case "Kai":
                singleSashimi =  KaiPool.instance.GetBullet();
                break;
            case "Uni":
                singleSashimi =  UniPool.instance.GetBullet();
                break;
            case "Salmon":
                singleSashimi =  SalmonPool.instance.GetBullet();
                break;
            
            default:
                break;
        }
        singleSashimi.GetComponent<Rigidbody2D>().gravityScale = -2;
    }
}
