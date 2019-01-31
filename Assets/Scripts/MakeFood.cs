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
    public Rigidbody Beerprefab;
    public Rigidbody BigPotionPrefab;
    public Rigidbody SmallPotionPrefab;
    public Rigidbody WinebottlePrefab;
    public Rigidbody Winejugprefab;
    public float minxpos;
    public float maxxpos;
    public float minzpos;
    public float maxzpos;


    private Rigidbody FoodInstance;
    private List<Rigidbody> foodStuff = new List<Rigidbody>();
    
    // Use this for initialization
	void Start () {



        for (int i = 0; i < 10; i++)
        {
            if (i<1)
            {
                FoodInstance = BreadPrefab;
            }
            else if (i < 2)
            {
                FoodInstance = CakePrefab;
            }
            else if (i < 3)
            {
                FoodInstance = CheesePrefab;
            }
            else if (i < 4)
            {
                FoodInstance = FishPrefab;
            }
            else if (i < 5)
            {
                FoodInstance = HamPrefab;
            }
            else if (i < 6)
            {
                FoodInstance = PiePrefab;
            }
            else if (i < 7)
            {
                FoodInstance = RibsPrefab;
            }
            else if (i < 8)
            {
                FoodInstance = SteakPrefab;
            }
            else if (i < 9)
            {
                FoodInstance = StewPrefab;
            }
            else if (i < 10)
            {
                FoodInstance = WMelonPrefab;
            }

            FoodInstance.transform.position = new Vector3(Random.Range(minxpos, maxxpos), .5f, Random.Range(minzpos, maxzpos));
            foodStuff.Add(FoodInstance);
            Instantiate(foodStuff[i]);
            Debug.Log("i = " + i + " : " + foodStuff[i].transform.position);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
