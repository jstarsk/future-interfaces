using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UDP;



public class LSystem : MonoBehaviour
{
    public GameObject prefab;
    UDPManager updManager;
    UDPManagermsg msg;
    float[] lines;

    LineRenderer lineRenderer;

    // Start is called before the first frame update
    void Start()
    {
        updManager = GetComponent<UDPManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(updManager.update);
        Debug.Log(updManager.msg_counter);
        if (updManager.msg_json.data != null && updManager.update)
        {

            for (int line = 0; line < updManager.msg_json.data.Count; line++)
            {
                GameObject prefabCopy = Instantiate(prefab);
                LineRenderer PrefabLineRenderer = prefabCopy.GetComponent<LineRenderer>();
                PrefabLineRenderer.widthMultiplier = 0.2f;
                PrefabLineRenderer.positionCount = 2;

                float x_0 = updManager.msg_json.data[line][0][0];
                float y_0 = updManager.msg_json.data[line][0][2];
                float z_0 = updManager.msg_json.data[line][0][1] * -1;
                PrefabLineRenderer.SetPosition(0, new Vector3(x_0, y_0, z_0));

                float x_1 = updManager.msg_json.data[line][1][0];
                float y_1 = updManager.msg_json.data[line][1][2];
                float z_1 = updManager.msg_json.data[line][1][1] * -1;
                PrefabLineRenderer.SetPosition(1, new Vector3(x_1, y_1, z_1));

            }
        }

        //GameObject[] _destroy;
        //_destroy = GameObject.FindGameObjectsWithTag("to_destroy");


        //foreach(GameObject _to_destroy in _destroy)
        //{
        //    Destroy(_to_destroy);
        //}

    }
}
