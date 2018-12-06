using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeFood : MonoBehaviour {

    public Rigidbody BreadPrefab;
    public Rigidbody CakePrefab;
    public Rigidbody CheesePrefab;
    public Rigidbody FishPrefab;
    public Rigidbody HamPrefab;
    public Rigidbody PiePrefab;
    public Rigidbody RibsPrefab;
    public Rigidbody SteakPrefab;
    public Rigidbody StewPrefab;
    public Rigidbody WMelonPrefab;
    public float minxpos;
    public float maxxpos;
    public float minzpos;
    public float maxzpos;


    private Rigidbody FoodInstance;
    private List<Rigidbody> foodStuff = new List<Rigidbody>();
    
    // Use this for initialization
	void Start () {


        FoodInstance = HamPrefab;

        for (int i = 0; i < 10; i++)
        {
            FoodInstance.transform.position = new Vector3(Random.Range(minxpos, maxxpos), 0, Random.Range(minzpos, maxzpos));
            foodStuff.Add(FoodInstance);
            Instantiate(foodStuff[i]);
            Debug.Log("i = " + i + " : " + foodStuff[i].transform.position);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
