using System;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 0.1f;
    [SerializeField] private Transform sunTransform;
    [SerializeField] private GameObject shadow;
    private Transform prevPos;
    private int frameCount = 1;
    private const int RENDER_FRAME = 10;
    private GameObject shadowGO;

    ButtonScript buttonScript = new ButtonScript();

    bool play = false;

    // Start is called before the first frame update
    void Start()
    {
        buttonScript.click += StartButtonCliked;

        rotationSpeed = UnityEngine.Random.Range(0.1f, 0.2f);
    }

    // Update is called once per frame
    void Update()
    {
        if (play)
        {
            if (frameCount == RENDER_FRAME)
            {
                prevPos = transform;
            }

            transform.RotateAround(sunTransform.position, Vector3.up, rotationSpeed);

            if (frameCount == RENDER_FRAME)
            {
                //shadowGO?.SetActive(true);
                //shadowGO?.transform.LookAt(transform);
                shadowGO = Instantiate(shadow, prevPos.position, new Quaternion(0, 0, 0, 0));
                shadowGO.transform.LookAt(sunTransform);
                //shadowGO.SetActive(false);

                frameCount = 0;
            }

            ++frameCount;
        }
    }

    void StartButtonCliked()
    {
        play = !play;
    }
}