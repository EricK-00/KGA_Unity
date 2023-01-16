using System;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 0.1f;
    [SerializeField] private Transform sunTransform;
    [SerializeField] private GameObject shadow;
    [SerializeField] private GameObject controlButton;
    private Transform prevPos;
    private int frameCount = 1;
    private const int RENDER_FRAME = 10;
    private GameObject shadowGO;

    bool play = false;

    // Start is called before the first frame update
    void Start()
    {
        controlButton.GetComponent<ButtonScript>().click += ControlButtonCliked;

        rotationSpeed = UnityEngine.Random.Range(0.1f, 0.2f);
    }

    // Update is called once per frame
    void Update()
    {
        if (play)
        {
            transform.Rotate(0, 1, 0);

            if (frameCount == RENDER_FRAME)
            {
                prevPos = transform;
            }

            transform.RotateAround(sunTransform.position, Vector3.up, rotationSpeed);

            if (frameCount == RENDER_FRAME)
            {
                shadowGO = Instantiate(shadow, prevPos.position, new Quaternion(0, 0, 0, 0));
                shadowGO.transform.LookAt(sunTransform);

                frameCount = 0;
            }

            ++frameCount;
        }
    }

    void ControlButtonCliked(object o, EventArgs e)
    {
        Debug.Log("!!!");
        play = !play;
    }
}