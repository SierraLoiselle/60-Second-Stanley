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


    private Rigidbody FoodInstance;
    private List<Rigidbody> foodStuff = new List<Rigidbody>();
    
    // Use this for initialization
	void Start () {


        for (int i = 0; i < 10; i++)
        {
            FoodInstance = Instantiate(HamPrefab);
            FoodInstance.position = new Vector3(Random.Range(-3f, 3f), 0, Random.Range(-23f, 23f));
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
