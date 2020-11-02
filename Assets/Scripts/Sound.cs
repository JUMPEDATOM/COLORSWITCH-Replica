using UnityEngine.Audio;
using UnityEngine;

[System.Serializable] //when we use custom classes we should use SERIALIZABLE for showing in Inspector!

public class Sound
{
  public string name;
  public AudioClip clip;
  
  [Range(1f, 3f)] // add slicer
  public float volume;
  
  [Range(0.1f, 3f)]
  public float pitch;
  
  public bool loop;
  
  
  [HideInInspector] // for hide in inspector
  public AudioSource source; //create a varable for component
}
  
