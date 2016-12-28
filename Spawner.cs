using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

  public UpdateManger updateManager;

  public GameObject spawnplacer;

  private float moveSpeed = 30f;

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

      updateManager.spawnpoint = spawnplacer;
    

  }

  
      

}
