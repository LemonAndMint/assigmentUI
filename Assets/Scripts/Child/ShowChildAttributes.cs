using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowChildAttributes : MonoBehaviour
{
  public Child child;
  public Text desc;

  public void showAttributes(){

    desc.text = $"Name: {child.showAttributes().Item1} \nSurname: {child.showAttributes().Item2}\nAge: {child.showAttributes().Item3}\nBorn Date: {child.showAttributes().Item4}\nMarried: {child.showAttributes().Item5}" ;

  }
}
