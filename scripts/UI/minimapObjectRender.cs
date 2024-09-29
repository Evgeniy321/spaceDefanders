using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minimapObjectRender : MonoBehaviour
{
    private Camera MinimapCam;
    private Vector3 miniMapPos;

    private float MinimapSize;
    // Start is called before the first frame update
    void Start()
    {
        MinimapCam = GameObject.FindGameObjectWithTag("mapCam").GetComponent<Camera>();
        miniMapPos = MinimapCam.transform.position;
        MinimapSize = MinimapCam.orthographicSize;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
        Mathf.Clamp(transform.position.x, miniMapPos.x - MinimapSize, MinimapSize + miniMapPos.x),
        Mathf.Clamp(transform.position.y, miniMapPos.y - MinimapSize, MinimapSize + miniMapPos.y),
        0

    );
    }
}
