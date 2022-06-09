using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Manager : MonoBehaviour
{
  public CanvasPanelManager cpm;
  private List<Person> persons;
  void Start()
  {
    persons = new List<Person>();

    persons.Add(new Person("Ahmet", "Sarı", 25, new DateTime(1980,06,21), true));
    persons.Add(new Person());
    persons.Add(new Person());
    persons.Add(new Person());
    persons.Add(new Person());

    cpm.InsListOfPersons(persons);
  }

 
}
