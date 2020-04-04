using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonActions : MonoBehaviour
{
    [SerializeField] 
    AudioSource audioSource;

    [SerializeField] 
    Text rollText;

    public void rollDice(int V)

    {
        int rollValue = Random.Range(1, V);
        audioSource.Play(); 
        rollText.text = "  you rolled a " + rollValue.ToString(); }
    
    public void Attack(int V)
    { 
        int rollValue = Random.Range(1, V);
        audioSource.Play();
        rollText.text = "  you did " + rollValue.ToString() + " damage"; }
    
    public void Heal(int V)
    {   int rollValue = Random.Range(1, V);
        audioSource.Play();
        rollText.text = "  you recovered " + rollValue.ToString() + " health"; }
}

