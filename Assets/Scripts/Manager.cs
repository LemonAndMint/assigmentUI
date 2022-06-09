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

    persons.Add(new Person("Ahmet", "Sarı", 25, new DateTime(1997,06,21), true, 
                            new List<Child>(){ new Child("Nezahat", "Akın", 19, new DateTime(2003,08,21), false), 
                                               new Child(),
                                               new Child()}));
    persons.Add(new Person("Mehmet", "Gül", 19, new DateTime(2003,08,21), false, 
                            new List<Child>(){ new Child("Yaren", "Leyla", 19, new DateTime(2003,08,21), false), 
                                               new Child(),
                                               new Child()}));
    persons.Add(new Person());
    persons.Add(new Person());
    persons.Add(new Person());

    cpm.InsListOfPersons(persons);
  }

 
}
