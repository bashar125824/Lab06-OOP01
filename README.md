# Lab06-OOP01 and Lab06-OOP02


# Lab06-OOP01



## An introduction to the project : 

---

***In this project , I suppose to implement the main principles of OOP , encabsulation , inheritence and abstraction , I used the animal species to clarify the ideas , like there is many types of animales , ex : mammals and birds , etc , and under every one of categories there are many creatures like horses , owls , and others , by this model inheritence can be clarified in easy way .***

---

## digital UML drawing of your zoo :

---

![IMG](/assets/UML2.jpg)

---

## OOP principles :

---

**Encapsulation :** *determine the nature of dealing with fields in the class , so if I want to access my data from anywhere by anyone , so I will use **public** access modifier , or if I want to access yo it just by the same class or derived class , so I will use **protected** access modifier , like I use in this lab , and if I want to access data from only the same class , so I should use **private** access modifier .*

```
protected string color;
protected bool hasTail;

```

---

**Abstraction :** *Hides the internal implementation details or display only the relevant attributes of objects and hides the unnecessary details , or if I want to create a parent and a child classes , and I don't want to make an objects out of the parent one , so I make it **abstract** .*

```

public abstract class animal

```

---


# Lab06-OOP02


---


***In this lab , I used **interfaces** in my code***


---


## What is interfaces :

---


***Blueprint of a class. It is like abstract class because all the methods which are declared inside the interface are abstract methods. It cannot have method body and cannot be instantiated. It is used to achieve multiple inheritance which can't be achieved by class.***

---

***example to clarify the idea in the code :***

---


***animal , cat and mammals classes  , animal and mammals are parent classes and cat is child class from mammals , in inheritance , if I want to code that (Not logically) , I can't say that cat is an animal and mammals in same time , but if animal and classes are interfaces then I can consider the cat class as an animal and mammals .***


---