using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform player;
    
    public GameObject colorChanger;
    public Transform  colorChange;
    
    public GameObject circleSpawner;
    public Transform circleSpawn;
    
    
    public void ColorChangerSpawner()
    {
      colorChange.position = new Vector3(colorChange.position.x, colorChange.position.y + 10, colorChange.position.z);
      GameObject spawnedColorChanger = Instantiate(colorChanger, colorChange.position, colorChange.rotation);
       if (player.position.y > 5)
       {
         Destroy(spawnedColorChanger);
       }
    }
    
    public void CircleSpawner()
    {
      circleSpawn.position = new Vector3(circleSpawn.position.x, circleSpawn.position.y + 10, circleSpawn.position.z);
      GameObject spawnedCircleSpawner = Instantiate(circleSpawner, circleSpawn.position, circleSpawn.rotation);
      
      Rotator.speed = Rotator.speed + 15f;
      
      if (player.position.y > 5)
      {
        Destroy(spawnedCircleSpawner);
      }
    }
}

