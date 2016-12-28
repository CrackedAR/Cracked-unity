using UnityEngine;
using System.Collections;

public class Spawner2 : MonoBehaviour {

  public UpdateManger updateManager;

  public GameObject spawnplacer2;

  private float moveSpeed = 60f;

  public Transform currentPoint;

  public Transform[] points;

  public int pointSelection;

 
  

  

  // Use this for initialization
  void Start ()
  {
    currentPoint = points[pointSelection];
    updateManager = FindObjectOfType<UpdateManger>();


  }
  
  // Update is called once per frame
  void Update ()
  {
      spawnplacer2.transform.position = Vector3.MoveTowards(spawnplacer2.transform.position, currentPoint.position, Time.deltaTime * moveSpeed);
      if (spawnplacer2.transform.position == currentPoint.position)
      {
          pointSelection++;

          if (pointSelection == points.Length)
          {
              pointSelection = 0;
          }

          currentPoint = points[pointSelection];
      }

      updateManager.spawnpoint2 = spawnplacer2;
    

  }

  
      

}
