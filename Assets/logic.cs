using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logic : MonoBehaviour
{
    [SerializeField] private GameObject ori = null;
    [SerializeField] private GameObject pt = null;

    [SerializeField] private LineRenderer xLR = null;
    [SerializeField] private LineRenderer yLR = null;
    [SerializeField] private LineRenderer zLR = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xLR.SetPosition(0, ori.transform.position);
        xLR.SetPosition(1, new Vector3(pt.transform.position.x, ori.transform.position.y, ori.transform.position.z));

        yLR.SetPosition(0, ori.transform.position);
        yLR.SetPosition(1, new Vector3(ori.transform.position.x, pt.transform.position.y, ori.transform.position.z));

        zLR.SetPosition(0, ori.transform.position);
        zLR.SetPosition(1, new Vector3(ori.transform.position.x, ori.transform.position.y, pt.transform.position.z));
    }
}
