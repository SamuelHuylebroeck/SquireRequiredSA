using UnityEngine;
using System.Collections;
using Assets.Controller.ShipControllers;
using Assets.Controller.Factories;

public class SandBoxController : MonoBehaviour
{

    public BasicShipController testShip
    {
        get; private set;
    }
    public Sprite shipSprite;
    

    // Use this for initialization
    void Start()
    {
        initBasicShip();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void initBasicShip()
    {
        BasicShipFactory fac = new BasicShipFactory();
        this.testShip = new BasicShipController(fac.CreateShip());
        Debug.Log("Created: \n" + testShip.ship);
        Debug.Log("Adding sprite");
        testShip.SetSprite(shipSprite);

    }

}
