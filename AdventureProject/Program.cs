using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureProject
{
    class CYOA
    {
        static void Main(string[] args)
        {
            string username;
            string computer;
            string start;
            string bestfriend;
            string direction;
            string oldman;
            string gender;

            computer = "Drew";
            bestfriend = "Brian";
            oldman = "Antwon";

            Console.WriteLine("Hello! Before we begin, I'll need your name.");

            username = Console.ReadLine();

            Console.WriteLine("Excellent, " + username + ".");

            Console.WriteLine("He(he) or She(she)?");

            gender = Console.ReadLine();

            Console.WriteLine("So, your a " + gender + " and your name is " + username + ".");

            Console.WriteLine("This story is made to be interactive, with winding paths. The decisions you make along the way will dictate where you end up. Oh, I'm " + computer + " by the way.");

            Console.WriteLine("Let's begin. Type 'yes' to start: ");

            start = Console.ReadLine();

            if (start == "yes")
            {
                Console.WriteLine("Last night must've been rough. I can't even remember where I was or who I was with. Could it have been " + bestfriend + "? Ehh...probably not.");
            }

            Console.WriteLine("Doesn't matter much now. My body is cold and my bones ache.");
            Console.WriteLine("Shrubs and flowers surround me. Besides the fauna, nothing lives. Should I head north, east, or west?");

            
            direction = Console.ReadLine();

            if (direction == "north")
            {
                Console.WriteLine("The trees get taller and the taller the more you proceed. Hidden animals make noises few can tolerate.");
                Console.WriteLine("A strange man approaches me. He's tall and dirty. And his beard - bigger than his head!");
                Console.WriteLine("'Hello...who are you? ' I am " + username + ". I've headed north from behind the foliage. I'm trying to figure out why I am here.");
                Console.WriteLine("Who are you, bearded man? The old man takes a deep breath and tells all. " + oldman + ", to you.");
                Console.WriteLine(oldman + "wants me to follow him. He has something he would like to show me...");
            }
            else if (direction == "east")
            {
                Console.WriteLine("The north seems a bit too harsh. And the west appears to be a dead-end. I better stick east.");
                Console.WriteLine("After walking for a long while, nothing. Radio silence. My phone's dead so I have no way of contacting anybody. And my feet are blistered.");
                Console.WriteLine("Animal sounds ring in my ear. The sound is too much to bear. 'Ahhh!!!' " + username + " ran as fast as " + gender + "could until slamming into an old man's back.");
                Console.WriteLine("Hey! Watch where you're going. I'm " + oldman + " by the way. Follow me... ");
            }
            else
            {
                Console.WriteLine("Crap!! " + username + " died.");

                return;
            }
            Console.WriteLine(username + " followed " + oldman + " past the forest. Large oak trees were replaced by sand dunes.");

            }
        }
    }