using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.XRTools.Rendering;

public class ControlLineRender : MonoBehaviour
{
    private XRLineRenderer renderer_script;
    private Vector3 lastPos = new Vector3(0.0f, 0.0f, 0.0f);
    private Vector3 curPos = new Vector3(0.0f, 0.0f, 0.0f);
    private List<Vector3> pos = new List<Vector3>();
    public GameObject line;
    public GameObject tip;
    private bool spawnCoroutineStarted = false;

    // Start is called before the first frame updates
    void Start()
    {
        tip = GameObject.Find("Tip");
        renderer_script = line.GetComponent<XRLineRenderer>();
        renderer_script.useWorldSpace = true;
        //StartCoroutine(ExampleCoroutine());
    }

    public IEnumerator Drawer() {
        if (true) {
            yield return null;
        }
        lastPos = tip.transform.position;
        pos.Add(lastPos);
        renderer_script.SetPositions(pos.ToArray(), true);

        yield return new WaitForSecondsRealtime(0.025f);
        spawnCoroutineStarted = false;
        // Debug.Log("Drawer has been run");
    }

    // Update is called once per frame
    void Update()
    {
        if (!spawnCoroutineStarted) {
            spawnCoroutineStarted = true;
            StartCoroutine(Drawer());
        }
        
    }

    IEnumerator ExampleCoroutine()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(1);
        

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
        spawnCoroutineStarted = false;
    }
}
