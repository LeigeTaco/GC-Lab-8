using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab8
{

    class Program
    {

        struct student
        {

            public string name;
            public string infoName1;
            public string infoBody1;
            public string infoName2;
            public string infoBody2;

        }

        static student[] CreateRoster()
        {

            student[] classList = new student[20];

            classList[0].name = "William Twomey";
            classList[0].infoName1 = "nickname";
            classList[0].infoBody1 = "William T.'s nick name is Ash. Similar to Ash from Pokemon, however he was actually named after Ash Williams from the Evil Dead trilogy so now Terrell can stop with the Pokemon talk. He probably won't though.";
            classList[0].infoName2 = "favorite meme";
            classList[0].infoBody2 = "Take a closer look at that snout! Just a clip from a nature documentary that is very versatile in uses. Also elephant shrews are just kinda goofy lookin', ya feel me?";

            classList[1].name = "Dr. K";
            classList[1].infoName1 = "hometown";
            classList[1].infoBody1 = "Detroit. Hey, that's where we are!";
            classList[1].infoName2 = "favorite food";
            classList[1].infoBody2 = "Burgers.";

            classList[2].name = "Jacob Snover";
            classList[2].infoName1 = "hometown";
            classList[2].infoBody1 = "Merrillville. That's near Gary. Geary? I think it's in Indiana...";
            classList[2].infoName2 = "favorite food";
            classList[2].infoBody2 = "Pizza.";

            classList[3].name = "Kristen Rieske";
            classList[3].infoName1 = "favorite cod";
            classList[3].infoBody1 = "Black Ops 2. Me personally, I think BO3 was pretty good but I'm just a filthy zombies player so what do I know.";
            classList[3].infoName2 = "college studies";
            classList[3].infoBody2 = "Physics.";

            classList[4].name = "Student 5";
            classList[4].infoName1 = "something cool";
            classList[4].infoBody1 = "cool it worked";
            classList[4].infoName2 = "something amazing";
            classList[4].infoBody2 = "*Lifts car*";

            classList[5].name = "Lucifer S. Aeytan";
            classList[5].infoName1 = "favorite number";
            classList[5].infoBody1 = "66666666666666666... Likes lots of sixes...";
            classList[5].infoName2 = "favorite hobby";
            classList[5].infoBody2 = "Messing with the lives of mortals.";

            classList[6].name = "RNGesus";
            classList[6].infoName1 = "7";
            classList[6].infoBody1 = "...out of 20 is a pretty bad roll, the dragon roasts you alive.";
            classList[6].infoName2 = "roll for dex";
            classList[6].infoBody2 = "You roll a 1. You drop your bow and it somehow fires into your face. You died.";

            classList[7].name = "Arima Kousei";
            classList[7].infoName1 = "favorite food";
            classList[7].infoBody1 = "Egg salad sandwiches. This guy can go on and on about them...";
            classList[7].infoName2 = "colorblindness";
            classList[7].infoBody2 = "He no longer sees the world in monochrome but that wasn't a cheap upgrade.";

            classList[8].name = "Fictional Person 445";
            classList[8].infoName1 = "favorite mode of transportation";
            classList[8].infoBody1 = "Yeetasaurus-Rex. This dude memes on the haters.";
            classList[8].infoName2 = "why im like this";
            classList[8].infoBody2 = "I really don't know.";

            classList[9].name = "Death Metal Kitten";
            classList[9].infoName1 = "favorite champion";
            classList[9].infoBody1 = "Nidalee, she turns in to a cat.";
            classList[9].infoName2 = "favorite game";
            classList[9].infoBody2 = "League of Please-Stop-playing-this-Broken-Game";

            classList[10].name = "Kamina";
            classList[10].infoName1 = "style";
            classList[10].infoBody1 = "All in, never look back, pure anime fighting spirit!";
            classList[10].infoName2 = "lifestyle";
            classList[10].infoBody2 = "Depending on where you are in the show: no.";

            classList[11].name = "Lex";
            classList[11].infoName1 = "forehead size";
            classList[11].infoBody1 = "Bigger than a school bus.";
            classList[11].infoName2 = "favorite movie";
            classList[11].infoBody2 = "ANYTHING without those little yellow minions in it.";

            classList[12].name = "Ali-A";
            classList[12].infoName1 = "intro";
            classList[12].infoBody1 = "*Loud bass-boosted music plays*";
            classList[12].infoName2 = "favorite game";
            classList[12].infoBody2 = "\"Fortnite\"";

            classList[13].name = "Ajit Pai";
            classList[13].infoName1 = "favorite hobby";
            classList[13].infoBody1 = "Returning humanity to the Dark Ages";
            classList[13].infoName2 = "favorite food";
            classList[13].infoBody2 = "Hopes and dreams of a true free market.";

            classList[14].name = "Mark Zuckerberg";
            classList[14].infoName1 = "species";
            classList[14].infoBody1 = "Some sort of reptile, I think. Like an Argonian from Skyrim.";
            classList[14].infoName2 = "data";
            classList[14].infoBody2 = "Error: OverflowException\nWay too much data on EVERYONE\nThe CIA should hire this dude.";

            classList[15].name = "Elon Musk";
            classList[15].infoName1 = "overwatch rank";
            classList[15].infoBody1 = "If this dude finds Overwatch soothing, there's no way he's anywhere above gold.";
            classList[15].infoName2 = "fun machines";
            classList[15].infoBody2 = "Elon's collection includes: Flamethrowers, Rockets, Electric cars (in space), probably his own personal super computer.";

            classList[16].name = "Bill Gates";
            classList[16].infoName1 = "net worth";
            classList[16].infoBody1 = "93.3 Billion USD. \nyikes";
            classList[16].infoName2 = "fun";
            classList[16].infoBody2 = "Probably pretends to be one of the little kids who pretends to be more powerful than he really is on Xbox Live. It's fun because Bill could do anything he wants to anyone in his lobby.";

            classList[17].name = "Bricky";
            classList[17].infoName1 = "favorite operator";
            classList[17].infoBody1 = "Brazilian Spook Factory (Caveira)";
            classList[17].infoName2 = "intelligence";
            classList[17].infoBody2 = "INT: 1";

            classList[18].name = "David Hasselhoff";
            classList[18].infoName1 = "things he wants to love";
            classList[18].infoBody1 = "You: all night long, with his song.";
            classList[18].infoName2 = "survivor status";
            classList[18].infoBody2 = "True";

            classList[19].name = "Final Boss";
            classList[19].infoName1 = "roll";
            classList[19].infoBody1 = "You dodged his attack but you rolled off the edge and suffered an environmental death.";
            classList[19].infoName2 = "attack";
            classList[19].infoBody2 = "You swing your sword but are killed midway through your attack. git gud.";

            return classList;

        }

        static bool KeepLearning()
        {

            bool whileBreak = false;
            string cont = "";

            Console.WriteLine("Would you like to learn more? (Y/N)");

            do
            {

                try
                {

                    cont = Console.ReadLine();

                    if (cont.ToLower() == "yes" || cont.ToLower() == "y")
                    {

                        return true;

                    }
                    else if (cont.ToLower() == "no" || cont.ToLower() == "n")
                    {

                        return false;

                    }
                    else
                    {

                        Console.WriteLine("An unexpected error has occured, but the show must go on!");
                        Console.WriteLine("This time follow the prompt.");

                    }

                }
                catch (OverflowException)
                {

                    Console.WriteLine("Entry was too large.");
                    Console.WriteLine("Try using a sinlge letter like I asked for.");

                }
                catch (NullReferenceException)
                {

                    Console.WriteLine("CTRL + Z was a cool trick until everyone knew it.");
                    Console.WriteLine("A for effort though...");

                }

                Console.WriteLine("Please enter Y or N: ");

            } while (!whileBreak);

            return false;

        }

        static void FunFact(student subject, int selection)
        {

            if(selection == 1)
            {

                Console.WriteLine(subject.infoBody1);

            }
            else if(selection == 2)
            {

                Console.WriteLine(subject.infoBody2);

            }
            else
            {

                Console.WriteLine("Here's a catch all statement because some unexpected error occured.");

            }

        }

        static int SelectStudent(student[] roster)
        {

            int output = 0;

            do
            {

                Console.WriteLine($"Please enter a number 1 through {roster.Length} (inlusive): ");

                try
                {

                    output = int.Parse(Console.ReadLine()) - 1;

                    if (output <=20 || output >= 1)
                    {

                        //Console.WriteLine($"You have selected {roster[output]}!");
                        return output;

                    }
                    else
                    {

                        //Console.WriteLine("An unexpected error has occured, but the show must go on!");
                        Console.WriteLine("This time follow the prompt.");

                    }

                }
                catch (OverflowException)
                {

                    Console.WriteLine("Entry was too WAY large.");

                }
                catch (NullReferenceException)
                {

                    Console.WriteLine("You know very well what you did and were trying to do, shame on you!");

                }

            } while (true);

        }

        static int FactSelector(student subject)
        {

            string selection = "";
            Console.WriteLine($"Would you like to learn about {subject.name}'s {subject.infoName1} or {subject.infoName2}?");

            do
            {

                try
                {

                    selection = Console.ReadLine();

                    if (selection.ToLower() == subject.infoName1)
                    {

                        return 1;

                    }
                    else if (selection.ToLower() == subject.infoName2)
                    {

                        return 2;

                    }
                    else
                    {

                        Console.WriteLine("An unexpected error has occured, but the show must go on!");
                        Console.WriteLine("This time follow the prompt.");

                    }

                }
                catch (OverflowException)
                {

                    Console.WriteLine("Entry was too large.");

                }
                catch (NullReferenceException)
                {

                    Console.WriteLine("Ha ha, very funny. Stop trying this though. I'm copy and pasting these exception handlers everywhere.");

                }

                Console.WriteLine($"Please enter {subject.infoName1} or {subject.infoName2}: ");

            } while (true);

        }

        static void Main(string[] args)
        {

            student[] classList = CreateRoster();

            Console.WriteLine("Welcome to the Made-Up-Info-About-This-Class Wiki!");
            int stuSel = 0;
            int inSel = 0;

            do
            {

                stuSel = SelectStudent(classList);
                inSel = FactSelector(classList[stuSel]);
                FunFact(classList[stuSel], inSel);

            } while (KeepLearning());

            Console.WriteLine("See ya next time...");

        }

    }

}
