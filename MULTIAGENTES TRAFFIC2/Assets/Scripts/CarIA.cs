using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CarIA : MonoBehaviour, IPooledObject
{
    public float speed = 5.0f;
    public Transform nextTarget;
    private Vector3 startPos;
    [SerializeField]
    private float maxDistance = 23f;

    public void OnObjectSpawn()
    {
        transform.LookAt(new Vector3(nextTarget.position.x, nextTarget.position.y, nextTarget.position.z));
    }

    private void Awake()
    {
        startPos = transform.position;
    }

    private void Update()
    {
        transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));

        float currentDis = Vector3.Distance(startPos, transform.position);
        if (currentDis > maxDistance)
        {
            Destroy(gameObject);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Waypoint")
        {
            nextTarget = other.gameObject.GetComponent<WaypointNode>().nextWaypointNode;
            transform.LookAt(new Vector3(nextTarget.position.x, nextTarget.position.y, nextTarget.position.z));
        }
    }
}
