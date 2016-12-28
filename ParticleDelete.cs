using UnityEngine;
using System.Collections;

public class ParticleDelete : MonoBehaviour
{

    private int Delay = 3;

    // Use this for initialization
    void Start()
    {
        StartCoroutine("DeleteCo");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public IEnumerator DeleteCo()
    {
        yield return new WaitForSeconds(Delay);
        Destroy(this.gameObject);
    }
}
