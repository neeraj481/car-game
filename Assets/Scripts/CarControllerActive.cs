using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarControllerActive : MonoBehaviour
{

    public GameObject anyname;
    public GameObject Dreamcar01;

    // Use this for initialization

    void Start()
    {
        anyname.GetComponent<UnityStandardAssets.Vehicles.Car.CarController>().enabled = true;
        Dreamcar01.GetComponent<UnityStandardAssets.Vehicles.Car.CarAIControl>().enabled = true;

    }

}