using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JSONReader : MonoBehaviour
{
    public TextAsset carJSON;
    public TextAsset trafficJSON;

    [System.Serializable]
    public class Car
    {
        public int id;
        public int posX;
        public int posY;
        public int posZ;
        public int dir;
        public int step;
    }

    [System.Serializable]
    public class CarList
    {
        public Car[] car;
    }

    public CarList carList = new CarList();

    [System.Serializable]
    public class Traffic
    {
        public string id;
        public int state;
        public int step;
    }

    [System.Serializable]
    public class TrafficList
    {
        public Traffic[] traffic;
    }

    public TrafficList trafficList = new TrafficList();

    private void Start()
    {
        carList = JsonUtility.FromJson<CarList>(carJSON.text);
        trafficList = JsonUtility.FromJson<TrafficList>(trafficJSON.text);
    }
}
