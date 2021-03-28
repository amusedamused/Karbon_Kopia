using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;
using System.Linq;
using System;

public class VoiceMovment : MonoBehaviour
{
    private KeywordRecognizer keywordRecognizer;
    private Dictionary<string, Action> actions = new Dictionary<string, Action>();
    public float distance = 10.0f;
    public float turnSpeed = 120.0f;

    private void Start()
    {
        actions.Add("forward", Forward);
        actions.Add("back", Back);
        actions.Add("down", Down);
        actions.Add("up", Up);
        actions.Add("left", Left);
        actions.Add("right", Right);

        keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += RecognizedSpeech;
        keywordRecognizer.Start();
    }

    private void RecognizedSpeech(PhraseRecognizedEventArgs speech)
    {

        Debug.Log(speech.text);
        actions[speech.text].Invoke();

    }

    private void Forward()
    {
        transform.Translate(Vector3.forward * distance * Time.deltaTime);
    }
    private void Back()
    {
        transform.Translate(Vector3.back * distance * Time.deltaTime);
    }
    private void Down()
    {
        transform.Translate(Vector3.down * distance * Time.deltaTime);
    }
    private void Up()
    {
        transform.Translate(Vector3.up * distance * Time.deltaTime);
    }
    private void Left()
    {
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * 45);
    }
    private void Right()
    {
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * -45);
    }

}
