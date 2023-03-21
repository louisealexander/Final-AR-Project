using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    public Material selectedMaterial;
    private Material originalMaterial;
    // Sound
    public AudioClip audioClip;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        originalMaterial = gameObject.GetComponent<MeshRenderer>().material;
        audioSource = gameObject.AddComponent(typeof(AudioSource)) as AudioSource;
    }

    public void PlayAudio()
    {
        audioSource.Play();
    }

    // Update is called once per frame
    public void SetSelectedMaterial()
    {
        gameObject.GetComponent<MeshRenderer>().material = selectedMaterial;
    }
    public void SetOriginalMaterial()
    {
        gameObject.GetComponent<MeshRenderer>().material = originalMaterial;
    }
}
