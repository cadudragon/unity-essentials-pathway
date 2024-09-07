using UnityEngine;

public class CollectibleController : MonoBehaviour
{
    public float rotationSpeed;

    public GameObject onCollectEffect;

    public CollectibleController()
    {
        rotationSpeed = 0.0f;
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, rotationSpeed);
    }

    private void OnTriggerEnter(Collider other)
    {
        //TODO: Destroy the collectible
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            Instantiate(onCollectEffect, transform.position, transform.rotation);
        }

    }
}
