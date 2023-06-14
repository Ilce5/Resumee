using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomText : MonoBehaviour
{
    string[] facts = { "You can’t directly see a Black Hole.", "Dying stars lead to stellar Black Holes.",
    "There are three categories of Black Holes: Primordial, Stellar, Supermassive .",
    "The first Black Hole wasn’t discovered until X-Ray astronomy was used.",
    "Closest Black Hole to Earth is called the Unicon sitting just about 1,500 light years away.", "We Don’t Know if Wormholes Exist.",
    "There are more stars in the universe than grains of sand on all the beaches on Earth. That’s at least a billion trillion.",
    "The universe has no centre and is constantly expanding every second – making it impossible to reach the edge.",
    "The Earth and the moon are about 4.5 billion years old, the universe on the other hand about 13.8 bilion years old",
    "The moon is the reason why we have tides and waves on Earth.", "There is a supermassive black hole at the heart of almost every large galaxy",
    "The Universe has the same temperature everywhere", "95% of the Universe is invisible", "Plate tectonics keep the planet comfortable",
    "70% of the Earth’s surface is covered in water",
    "Earth actually takes 23 hours, 56 minutes and 4 seconds to rotate once completely on its axis",
    "A year on Earth is actually 365.2564 days, that's why we tack on an extra day in February every four years",
    "The Moon is Earth’s only natural satellite and the fifth largest moon in the solar system.",
    "The Moon’s presence helps stabilize our planet’s wobble and moderate our climate.",
    "The Moon’s distance from Earth is about 386,000 km (240,000 miles).", "The Moon has a very thin atmosphere called an exosphere",
    "The Moon’s surface is cratered and pitted from comet and asteroid impacts.", "Over one million Earth’s could fit inside the Sun.",
    "The energy created by the Sun’s core is nuclear fusion.", "The Sun is travelling at 220 km per second.",
    "It takes eight minutes for the light to reach Earth from the Sun.", "The Sun is halfway through its life.",
    "Temperatures inside the Sun can reach 15 million degrees Celsius.",
    "The Aurora Borealis and Aurora Australis are caused by the interaction of solar winds with Earth’s atmosphere.",
    "Auroras are more likely to occur close to the equinoxes, in late March and late September, but displays can occur at any time of year.",
    "A day on Mars lasts 24 hours and 37 minutes."};
    public Text textToDisplay;
    private bool pauseIt = false;
    public GameObject deathScene;

    public string string1 = "You can’t directly see a Black Hole.";
    public string string2 = "Dying stars lead to stellar Black Holes.";
    public string string3 = "There are three categories of Black Holes: Primordial, Stellar, Supermassive .";
    public string string4 = "The first Black Hole wasn’t discovered until X-Ray astronomy was used.";
    public string string5 = "Closest Black Hole to Earth is called the Unicon sitting just about 1,500 light years away.";
    public string string6 = "We Don’t Know if Wormholes Exist.";
    public string string7 = "There are more stars in the universe than grains of sand on all the beaches on Earth. That’s at least a billion trillion.";
    public string string8 = "The universe has no centre and is constantly expanding every second – making it impossible to reach the edge.";
    public string string9 = "The Earth and the moon are about 4.5 billion years old, the universe on the other hand about 13.8 bilion years old";
    public string string10 = "The moon is the reason why we have tides and waves on Earth.";
    // Update is called once per frame
    void Update()
    {
        if (deathScene.activeSelf && pauseIt == false)
        {
            textToDisplay.text = facts[Random.Range(0, facts.Length)];
            pauseIt = true;
        }else if(!deathScene.activeSelf && pauseIt == true)
        {
            pauseIt = false;
        }
    }
}
