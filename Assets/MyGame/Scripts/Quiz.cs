using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quiz : MonoBehaviour
{
    public Text question;
    public Text order;
    public AudioSource wizardLaugh;
    public GameObject Coin;
    

    public void OnTriggerEnter(Collider wizard)
    {

        if (wizard.gameObject.CompareTag("Player"))
        {
            wizardLaugh.Play();
            question.enabled = true;
            StartCoroutine(Timer());
            
        }

        else {

            wizardLaugh.Stop();
        }


    IEnumerator Timer()
        {
            Debug.Log("Coroutine funktioniert");
            yield return new WaitForSeconds(5);
            question.enabled = false;
            order.enabled = true;
            yield return new WaitForSeconds(5);
            order.enabled = false;

        }

        if (wizard.gameObject.CompareTag("RightBall"))
        {
            question.enabled = true;
            StartCoroutine(Timer());
            Coin.transform.position = new Vector3(-5, (float)0.3, 3);
            question.text = "You are right, my friend. Green is a symbol of jealousy.";
            order.text = "Now go to the well and finish your mission. Farewell.";

        }

        else if (wizard.gameObject.CompareTag("RedBall"))
        {
            question.enabled = true;
            StartCoroutine(Timer());
            question.text = "Red is not the color of jealousy...";
        }

        else if (wizard.gameObject.CompareTag("PurpleBall"))
        {
            question.enabled = true;
            StartCoroutine(Timer());
            question.text = "Purple doesn't equal Jealousy, try again.";
        }
        

    }

   
}