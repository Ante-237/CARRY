using System.Collections.Generic;
using UnityEngine;

/*

Camping Scenario for Packing Game


Scenario Description:
Imagine you are planning a three-day camping trip to a beautiful national park known for its lush forests and clear lakes. 
The weather forecast predicts sunny days but chilly nights, with temperatures dropping to around 45°F (7°C). 
Your goal is to pack smartly, ensuring you have everything needed for a comfortable and safe camping experience.

Essential Items to Pack:

Tent - Make sure it’s appropriate for the current season.
Sleeping Bag - Suitable for temperatures as low as 40°F.
Camping Stove - To cook meals since open fires are not allowed.
Water Filter - For purifying water from nearby streams or lakes.
First Aid Kit - Include bandages, antiseptic, and any personal medications.
Flashlight or Headlamp - Plus extra batteries.
Map and Compass - Even if you plan to use a GPS, always have a backup.
Weather-Appropriate Clothing - Include layers for warmth and a waterproof jacket.
Food Supplies - Non-perishable items that are easy to cook.
Eco-Friendly Soap - For cleaning dishes and personal hygiene.
Items to Confuse (Not Needed but Included in List):

Snowshoes - Unnecessary for the season and terrain.
Formal Wear - Impractical for a camping trip.
Heavy Books - Adds unnecessary weight.
Pet Fish in a Bowl - Difficult to manage and care for while camping.
Portable Sauna - Unrealistic and cumbersome for a basic camping trip.
Tips for Packing:

Prioritize Essentials: Always pack the essentials first to ensure they fit in your backpack or car.
Check Weather: Adapt your packing list based on the weather forecast a day before departure.
Practice Sustainability: Opt for eco-friendly products and practice Leave No Trace principles to minimize your impact on nature.
Safety First: Always inform someone of your itinerary and expected return. 
 */

/*
 *Second Options
 Scenario Description:
You're preparing for a long day of classes at your university. It's mid-semester, and your schedule includes lectures, a group project meeting, and a study session at the library. The weather forecast calls for mild weather, with a slight chance of rain in the late afternoon. Your challenge is to pack everything you'll need to stay organized, focused, and comfortable throughout the day.

Essential Items to Pack:

Laptop - Essential for taking notes and accessing online resources.
Charger - For your laptop and any other electronics you'll be using.
Notebooks and Pens - For taking notes in classes where electronics are not allowed.
Textbooks - Bring only the ones needed for today's classes.
Water Bottle - Stay hydrated, especially during back-to-back classes.
Snacks - Healthy options to keep your energy up, like nuts or fruit.
Umbrella - Just in case the rain comes earlier than expected.
Student ID and Wallet - Needed for access to various campus facilities.
Earphones - For listening to audio lectures or blocking out noise while studying.
Light Jacket - To stay comfortable if it gets chilly, especially in air-conditioned rooms.
Items to Confuse (Not Needed but Included in List):

Swimming Goggles - Unlikely to be useful unless you have a swim class.
Camping Stove - Not suitable or allowed on campus.
Dress Shoes - Too formal for a regular class day.
Beach Towel - Not necessary unless you plan to visit the pool after classes.
Halloween Costume - Out of place unless it’s a special themed day on campus.
Tips for Packing:

Organize Smartly: Use a backpack with compartments to keep your items organized.
Check Class Requirements: Make sure you pack specific items required for special class activities.
Prepare for the Unexpected: Pack a small umbrella or raincoat in case the weather changes.
Keep it Light: Avoid packing unnecessary items that add bulk and weight to your bag.
This scenario helps users prioritize and select appropriate items for a typical school day, enhancing their organizational skills while adding a layer of challenge with the inclusion of irrelevant items.
*/

[CreateAssetMenu(fileName = "DataSO")]
public class DataSO : ScriptableObject
{
    // provide a list of scenarios
    [Multiline]
    public List<string> Scenarios;

    // provide a struct which provides item and reason for item
    public List<Items> AllItems;

    // provide list for tips for each scenario
    public List<Tips> Tips;
}


/// <summary>
/// struct which holds items needed and those not needed 
/// </summary>
[System.Serializable]
public struct Items
{
    // tagged with needed script
    public List<GameObject> neededItems;
    // tagged with not needed script
    public List<GameObject> NotNeededItems;
}

/// <summary>
/// struct holds list of tips required 
/// </summary>
[System.Serializable]
public struct Tips
{
    public List<string> tip;
}
