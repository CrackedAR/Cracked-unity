using UnityEngine;
using System.Collections;

public class SpawnerMulti : MonoBehaviour {

  public GameObject spawnplacer;

  private float moveSpeed = 30f;

  public Transform currentPoint;

  public Transform[] points;

  public int pointSelection;

   public GameObject imageT;
   
   public GameObject spawnpoint;

   public GameObject spawnPart;

   public GameObject spawnObj;

 
  

  

  // Use this for initialization
  void Start ()
  {
    currentPoint = points[pointSelection];
    StartCoroutine("SpawnCo");

  }
  
  // Update is called once per frame
  void Update ()
  {
      spawnplacer.transform.position = Vector3.MoveTowards(spawnplacer.transform.position, currentPoint.position, Time.deltaTime * moveSpeed);
      if (spawnplacer.transform.position == currentPoint.position)
      {
          pointSelection++;

          if (pointSelection == points.Length)
          {
              pointSelection = 0;
          }

          currentPoint = points[pointSelection];
      }

      spawnpoint = spawnplacer;
    

  }

  public IEnumerator SpawnCo()
  {
      yield return new WaitForSeconds(20);
      Instantiate(spawnPart, spawnpoint.transform.position, spawnpoint.transform.rotation);
      GameObject obnew = (GameObject)Instantiate(spawnObj, spawnpoint.transform.position, spawnpoint.transform.rotation);
      obnew.transform.parent = imageT.gameObject.transform;
      StartCoroutine("SpawnCo");
  }

  
      

}
