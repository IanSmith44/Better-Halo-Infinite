using UnityEngine;

public class floodDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -15) {
            Destroy(this.gameObject);
        }
    }
}
