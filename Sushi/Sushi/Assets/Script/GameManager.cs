using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject ricePrefab;
    public SashimiDictionary _SashimiDictionary;

    public GameObject oderPrefab1;
    public GameObject oderPrefab2;
    public GameObject oderPrefab3;
    public GameObject oderPrefab4;

    public static bool createNewOder = false;

    private int randomSeed;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating ("SpawnRice", 2, 1);
    }

    // Update is called once per frame
    void Update()
    {
        // if (createNewOder == true)
        // {
        //     NewOder();
        //     createNewOder = false;
        // }
    }

    public void SpawnRice()
    {
        GameObject rice = Instantiate(ricePrefab);
        Vector3 ricePos = new Vector3(12, Random.Range(-1, 2), -1);
        rice.transform.position = ricePos;

    }

    public void NewOder()
    {
        randomSeed = Random.Range(1, 3);
        GameObject oder = null;
        switch (randomSeed)
        {
            case 1:
                oder = Instantiate(oderPrefab1);
                break;
            case 2:
                oder = Instantiate(oderPrefab2);
                break;
            case 3:
                oder = Instantiate(oderPrefab3);
                break;
            
        }
        Vector3 oderPos = new Vector3(-11, (float)3.5, -1);
        oder.transform.position = oderPos;
        createNewOder = false;
    }
    
}
