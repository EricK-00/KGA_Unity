using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shadow : MonoBehaviour
{
    int lifeTime = 5 * 60;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<MeshRenderer>().materials[0].color = Color.gray;
    }

    // Update is called once per frame
    void Update()
    {
        if (lifeTime <= 0)
            Destroy(gameObject);

        --lifeTime;
    }
}
