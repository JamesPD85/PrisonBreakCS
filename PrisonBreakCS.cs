﻿using System;
using System.Collections;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace PrisonStory
{
    public class TextController
    {
        //Sets player input variables
        //char ready;
        //char choice;

        public static void Main(string[] args)
        {
            PrisonTitle();
            System.Console.WriteLine("The Prison Game\n");
            System.Console.WriteLine("The object of this game is to escape the prison without being caught.\n\n");
            System.Console.WriteLine("Ready to begin? (y/n)");
            char ready = Console.ReadKey().KeyChar;
            if (ready.Equals('y')) cellMain();
            else if (ready.Equals('n')) System.Environment.Exit(1);
        }

        public static void PrisonTitle()
        {
            Console.Clear();
            Console.WriteLine("##################################################");
            Console.WriteLine("#      PPPPP RRRRR IIIII SSSSS  OOO  N    N      #");
            Console.WriteLine("#      P   P R   R   I   S     O   O N N  N      #");
            Console.WriteLine("#      PPPPP RRRRR   I   SSSSS O   O N  N N      #");
            Console.WriteLine("#      P     R  R    I       S O   O N   NN      #");
            Console.WriteLine("#      P     R   R IIIII SSSSS  OOO  N    N      #");
            Console.WriteLine("##################################################");
            System.Console.WriteLine("\n\n\n");
        }

        public static void cellMain()
        {
            PrisonTitle();
            System.Console.WriteLine("You are in a prison cell. You've been here for 20 years " +
                                     "for a crime you did not commit, and need to get out. " +
                                     "There are some dirty bed sheets, a mirror by the " +
                                     "sink, and the cell door is locked.\n\n" +
                                     "Press S to inspect the Sheets\n" +
                                     "Press L to inspect the Lock\n" +
                                     "Press M to inspect the Mirror\n");
            char choice = Console.ReadKey().KeyChar;
            if (choice.Equals('s')) sheets();
            else if (choice.Equals('m')) mirrorInspect();
            else if (choice.Equals('l')) cellLock();
        }

        public static void cellWithMirror()
        {
            PrisonTitle();
            System.Console.WriteLine("You are in your cell with the mirror. You wonder how you could use this to\n" +
                                     "escape. The gross sheets are still on the bed, and the cell door is locked.\n\n" +
                                     "Press S to inspect the Sheets\n" +
                                     "Press L to inspect the Lock\n");
            char choice = Console.ReadKey().KeyChar;
            if (choice.Equals('s')) sheetsWithMirror();
            else if (choice.Equals('l')) cellLockMirror();
        }

        public static void sheets()
        {
            PrisonTitle();
            System.Console.WriteLine("There are filthy, disgusting sheets on the bed. " +
                                     "You can't believe you actually\n" +
                                     "sleep in these. That's prison life...\n\n" +
                                     "Press R to Return to your cell\n\n");
            char choice = Console.ReadKey().KeyChar;
            if (choice.Equals('r')) cellMain();
        }

        public static void sheetsWithMirror()
        {
            PrisonTitle();
            System.Console.WriteLine("You look at the same disgusting sheets again. " +
                                     "Hopefully you won't have to look\nat them much longer.\n\n" +
                                     "Press R to Return to your cell\n\n");
            char choice = Console.ReadKey().KeyChar;
            if (choice.Equals('r')) cellWithMirror();
        }

        public static void mirrorInspect()
        {
            PrisonTitle();
            System.Console.WriteLine("As you look into the mirror yet again after 20 years, you suddenly notice that\n" +
                                     "the mirror looks a little strange. You are compelled to take " +
                                     "a closer look...\n\n" +
                                     "Press L to Look closer\n" +
                                     "Press R to Return to your cell\n\n");
            char choice = Console.ReadKey().KeyChar;
            if (choice.Equals('l')) mirrorLook();
            if (choice.Equals('r')) cellMain();
        }

        public static void mirrorLook()
        {
            PrisonTitle();
            System.Console.WriteLine("When you look at it from another angle, you can see that the mirror is loose.\n" +
                                     "It looks like you can take it.\n\n" +
                                     "Press T to take the mirror\n" +
                                     "Press R to Return to your cell\n\n");
            char playerChoice = Console.ReadKey().KeyChar;
            if (playerChoice.Equals('t')) cellWithMirror();
            if (playerChoice.Equals('r')) cellMain();
        }

        public static void cellLock()
        {
            PrisonTitle();
            System.Console.WriteLine("It's one of those keypad locks. You have no idea what the combination is.\n" +
                                     "You can't see the keypad from where you're standing. If you could look at it\n" +
                                     "from the outside, you might be able to see which numbers were pressed by that\n" +
                                     "slob guard's dirty hands.\n\n" +
                                     "Press R to Return to your cell\n");
            char choice = Console.ReadKey().KeyChar;
            if (choice.Equals('r')) cellMain();
        }

        public static void cellLockMirror()
        {
            PrisonTitle();
            System.Console.WriteLine("It's one of those keypad locks. You have no idea what the combination is.\n" +
                                     "Maybe now you can see which numbers were pressed by that slob guard's dirty\n" +
                                     "hands.\n\n" +
                                     "Press M to use Mirror\n" +
                                     "Press R to Return to your cell\n\n");
            char choice = Console.ReadKey().KeyChar;
            if (choice.Equals('r')) cellWithMirror();
            if (choice.Equals('m')) keypad();
        }

        public static void keypad()
        {
            PrisonTitle();
            System.Console.WriteLine("You reach your hand through the bars, and point the mirror back at the keypad.\n" +
                                     "You can now see the combination to unlock it.\n\n" +
                                     "Press K to use the Keypad\n" +
                                     "Press R to Return to your cell\n\n");
            char choice = Console.ReadKey().KeyChar;
            if (choice.Equals('r')) cellWithMirror();
            if (choice.Equals('k')) cellEscape();
        }

        public static void cellEscape()
        {
            PrisonTitle();
            System.Console.WriteLine("You escaped your cell! Now is your best chance to escape! There are some boxes\n" +
                                     "to your left, and a closet door about 20 feet away. The hallway looks like it\n" +
                                     "leads to some stairs.\n\n" +
                                     "Press C to check the Closet\n" +
                                     "Press S to check the Stairs\n\n");
            char choice = Console.ReadKey().KeyChar;
            if (choice.Equals('c')) closetKnob();
            if (choice.Equals('s')) stairsNoGuard();
        }

        public static void statesLockOpen1()
        {
            PrisonTitle();
            System.Console.WriteLine("You are in the hallway outside the cell. The hallway leads to stairs, and\n" +
                                     "there's a closet door about 20 feet away.\n\n" +
                                     "Press C to check the Closet\n" +
                                     "Press H to check the Hall\n" +
                                     "Press S to check the Stairs\n\n");
            char choice = Console.ReadKey().KeyChar;
            if (choice.Equals('c')) closetLockedNoHairpin();
            if (choice.Equals('h')) hallFindPin();
            if (choice.Equals('s')) stairsNoGuard();
        }

        public static void closetKnob()
        {
            PrisonTitle();
            System.Console.WriteLine("Just as you reach for the doorknob, you hear a guard coming down the hall. Your\n" +
                                     "heart is pounding in your chest as you start to panic. You need to hide!\n\n" +
                                     "Press C to hide in the Closet\n" +
                                     "Press B to hide behind the Boxes\n" +
                                     "Press R to Return to your cell\n\n");
            char choice = Console.ReadKey().KeyChar;
            if (choice.Equals('c')) closetLockedGuard();
            if (choice.Equals('b')) boxes();
            if (choice.Equals('r')) cellHide();
        }

        public static void boxes()
        {
            PrisonTitle();
            System.Console.WriteLine("You hide behind the boxes as the guard closes in. He notices the cell door open\n" +
                                     "and runs over to inspect. It doesn't take him long to notice you behind the\n" +
                                     "boxes. Before you know it, you're surrounded by guards. There is no escape.\n\n" +
                                     "The guards cuff you, and escort to the maximum security solitary cells. The head" +
                                     "guard says \"There's no way you can escape now. You will die in this cell!\"\n\n" +
                                     "Press R to Restart the game\n\n");
            char choice = Console.ReadKey().KeyChar;
            if (choice.Equals('r')) cellMain();
        }

        public static void cellHide()
        {
            PrisonTitle();
            System.Console.WriteLine("You are back in your cell. This should avoid suspicion from the gaurd.\n" +
                                     "You sit on the bed with nasty sheets as the guards walks by. He takes a quick\n" +
                                     "look in your cell, and walks back down the hall and up the stairs.\n\n" +
                                     "Press S to inspect the Sheets\n" +
                                     "Press H to go to the Hall\n\n");
            char choice = Console.ReadKey().KeyChar;
            if (choice.Equals('s')) sheetsGross();
            else if (choice.Equals('h')) hallNoGuard();
        }

        public static void closetLockedGuard()
        {
            PrisonTitle();
            System.Console.WriteLine("The closet door is locked. You might be able to pick the lock with something.\n" +
                                     "The guard is still coming! You don't have much time!\n\n" +
                                     "Press B to hide behind the Boxes\n" +
                                     "Press R to Return to your cell\n\n");
            char choice = Console.ReadKey().KeyChar;
            if (choice.Equals('c')) closetLockedGuard();
            if (choice.Equals('b')) boxes();
            if (choice.Equals('r')) cellHide();
        }

        public static void closetLockedNoHairpin()
        {
            PrisonTitle();
            System.Console.WriteLine("The closet door is locked. You might be able to pick the lock with something.\n\n" +
                                     "Press R to Return to the hall\n\n");
            char choice = Console.ReadKey().KeyChar;
            if (choice.Equals('r')) hallNoGuard();
        }

        public static void closetLockedHairpin()
        {
            PrisonTitle();
            System.Console.WriteLine("The closet door is locked. You might be able to pick the lock with something.\n\n" +
                                     "Press P to pick the lock\n" +
                                     "Press R to Return to the hall\n\n");
            char choice = Console.ReadKey().KeyChar;
            if (choice.Equals('p')) closetUnlock();
            if (choice.Equals('r')) hallWithHairpin();
        }

        public static void closetUnlock()
        {
            PrisonTitle();
            System.Console.WriteLine("You pick the lock with the hairpin. The hairpin breaks, but the closet door\n" +
                                     "opens.\n\n" +
                                     "Press S to Search the closet\n" +
                                     "Press R to Return to the hall\n\n");
            char choice = Console.ReadKey().KeyChar;
            if (choice.Equals('s')) closetUniformOff();
            if (choice.Equals('r')) hallClosetUnlocked();
        }

        public static void closetUniformOff()
        {
            PrisonTitle();
            System.Console.WriteLine("This closet is full of maintenance equipment. A spare janitor's uniform is\n" +
                                     "hanging up.\n\n" +
                                     "Press I to inspect the uniform\n" +
                                     "Press R to Return to the hall\n\n");
            char choice = Console.ReadKey().KeyChar;
            if (choice.Equals('i')) uniform();
            if (choice.Equals('r')) hallClosetUnlocked();
        }

        public static void closetUniformOn()
        {
            PrisonTitle();
            System.Console.WriteLine("This closet is full of maintenance equipment. Nothing else useful here.\n\n" +
                                     "Press C to Change out of uniform\n" +
                                     "Press R to Return to the hall\n\n");
            char choice = Console.ReadKey().KeyChar;
            if (choice.Equals('c')) closetUniformOff();
            if (choice.Equals('r')) hallWithUniform();
        }

        public static void openCloset()
        {
            PrisonTitle();
            System.Console.WriteLine("The closet door is open.\n\n" +
                                     "Press E to Enter closet\n" +
                                     "Press R to Return to the hall\n\n");
            char choice = Console.ReadKey().KeyChar;
            if (choice.Equals('e')) closetUniformOff();
            if (choice.Equals('r')) hallClosetUnlocked();
        }       

        public static void uniform()
        {
            PrisonTitle();
            System.Console.WriteLine("This uniform looks to be about your size.\n\n" +
                                     "Press W to Wear the uniform\n" +
                                     "Press R to Return to the closet\n\n");
            char choice = Console.ReadKey().KeyChar;
            if (choice.Equals('w')) closetJanitor();
            if (choice.Equals('r')) closetUniformOff();
        }

        public static void closetJanitor()
        {
            PrisonTitle();
            System.Console.WriteLine("You are now dressed as a janitor. This could be the perfect disguise.\n\n" +
                                     "Press C Change out of the uniform\n" +
                                     "Press R to Return to the closet\n\n");
            char choice = Console.ReadKey().KeyChar;
            if (choice.Equals('c')) closetUniformOff();
            if (choice.Equals('r')) closetUniformOn();
        }

        public static void stairsNoGuard()
        {
            PrisonTitle();
            System.Console.WriteLine("You peek up the stairs, and see 2 doors. One leading outside, and the other to\n" +
                                     "the guard's office. Trying to escape now is just asking to get shot. Better come" +
                                     "up with a plan.\n\n" +
                                     "Press R to Return to the hall\n\n");
            char choice = Console.ReadKey().KeyChar;
            if (choice.Equals('r')) hallNoGuard();
        }

        public static void stairsWithHairpin()
        {
            PrisonTitle();
            System.Console.WriteLine("You peek up the stairs, and see 2 doors. One leading outside, and the other to\n" +
                                     "the guard's office. All you are armed with is a hairpin. Trying to escape now\n" +
                                     "is just asking to get shot. Better come up with a plan.\n\n" +
                                     "Press R to Return to the hall\n\n");
            char choice = Console.ReadKey().KeyChar;
            if (choice.Equals('r')) hallWithHairpin();
        }

        public static void stairsWithUniform()
        {
            PrisonTitle();
            System.Console.WriteLine("There are two doors upstairs. One leading outside, and the other to\n" +
                                     "the guard's office. Being dressed as the janitor gives you the best chance yet\n" +
                                     "to escape unnoticed.\n\n" +
                                     "Press C to enter the Courtyard\n" +
                                     "Press R to Return to the hall\n\n");
            char choice = Console.ReadKey().KeyChar;
            if (choice.Equals('c')) courtyard();
            if (choice.Equals('r')) hallWithUniform();
        }

        public static void sheetsGross()
        {
            PrisonTitle();
            System.Console.WriteLine("Ugh! You wonder why you keep looking at these. You have to get out of here!\n\n" +
                                     "Press R to Return to your cell\n\n");
            char choice = Console.ReadKey().KeyChar;
            if (choice.Equals('r')) cellFinal();
        }

        public static void hallNoGuard()
        {
            PrisonTitle();
            System.Console.WriteLine("You are in the hallway outside the cell. The hallway leads to stairs, and\n" +
                                     "there's a closet door about 20 feet away.\n\n" +
                                     "Press C to check the Closet\n" +
                                     "Press H to check the Hall\n" +
                                     "Press S to check the Stairs\n\n");
            char choice = Console.ReadKey().KeyChar;
            if (choice.Equals('c')) closetLockedNoHairpin();
            if (choice.Equals('s')) stairsNoGuard();
            if (choice.Equals('h')) hallFindPin();
        }

        public static void hallFindPin()
        {
            PrisonTitle();
            System.Console.WriteLine("As you search the hallway, you come across a hairpin. This might come in handy.\n\n" +
                                     "Press T to Take the hairpin\n" +
                                     "Press R to Return to the hall\n");
            char choice = Console.ReadKey().KeyChar;
            if (choice.Equals('t')) hallWithHairpin();
            if (choice.Equals('r')) hallNoGuard();
        }

        public static void hallWithHairpin()
        {
            PrisonTitle();
            System.Console.WriteLine("You are in the hallway outside the cell. The hallway leads to stairs, and\n" +
                                     "there's a closet door about 20 feet away.\n\n" +
                                     "Press C to check the Closet\n" +
                                     "Press S to check the Stairs\n\n");
            char choice = Console.ReadKey().KeyChar;
            if (choice.Equals('c')) closetLockedHairpin();
            if (choice.Equals('s')) stairsWithHairpin();
        }

        public static void hallClosetUnlocked()
        {
            PrisonTitle();
            System.Console.WriteLine("You are back in the hallway. Looks like the stairs are your way out.\n\n" +
                                     "Press C to check the Closet\n" +
                                     "Press S to check the Stairs\n\n");
            char choice = Console.ReadKey().KeyChar;
            if (choice.Equals('c')) openCloset();
            if (choice.Equals('s')) stairsWithUniform();
        }

        public static void hallWithUniform()
        {
            PrisonTitle();
            System.Console.WriteLine("You are back in the hallway. Looks like the stairs are your way out.\n\n" +
                                     "Press C to check the Closet\n" +
                                     "Press S to check the Stairs\n\n");
            char choice = Console.ReadKey().KeyChar;
            if (choice.Equals('c')) closetUniformOn();
            if (choice.Equals('s')) stairsWithUniform();
        }

        public static void cellFinal()
        {
            PrisonTitle();
            System.Console.WriteLine("Ok, this is it. The guard won't be back for a while, so now is your last chance.\n" +
                                     "You can almost feel the freedom.\n\n" +
                                     "Press H to go to the Hallway.\n\n");
            char choice = Console.ReadKey().KeyChar;
            if (choice.Equals('h')) hallNoGuard();
        }

        public static void courtyard()
        {
            PrisonTitle();
            System.Console.WriteLine("Nervously, you start to climb the stairs. Your hearts is pounding! As you walk\n" +
                                     "by the office, you make eye contact with one of the guards. He says \"Hey!\"\n" +
                                     "and your heart stops.\n\n" +
                                     "Press T to Talk to the guard\n" +
                                     "Press R to Run for it\n\n");
            char choice = Console.ReadKey().KeyChar;
            if (choice.Equals('t')) guard();
            if (choice.Equals('r')) run();
        }

        public static void guard()
        {
            PrisonTitle();
            System.Console.WriteLine("The guards says \"Have a good night,\" and nods to you. You can't believe\n" +
                                     "that actually worked!\n\n" +
                                     "Press C to enter the Courtyard.\n");
            char choice = Console.ReadKey().KeyChar;
            if (choice.Equals('c')) freedom();
        }        

        public static void run()
        {
            PrisonTitle();
            System.Console.WriteLine("You panic and burst out the door as the guard chases you. The guard sounds the\n" +
                                     "alarm and signals to outside guards there's a prisoner on the loose. Both towers" +
                                     "have guns drawn on you as they take aim. The first bullet almost hits you in the" +
                                     "leg.\n\nYou keep running. The gate is only 20 yards away, just a little further and\n" +
                                     "you're free! Suddenly, you fall to the ground as you feel your lower body go\n" +
                                     "completely numb. You've been shot. You can't move your legs. You take one last\n" +
                                     "look at the gate, just several feet away. You hear one final shot and everything" +
                                     "goes black.\n\n" +
                                     "Press R to Restart\n\n");
            char choice = Console.ReadKey().KeyChar;
            if (choice.Equals('r')) cellMain();
        }

        public static void freedom()
        {
            PrisonTitle();
            System.Console.WriteLine("You wish the guard a good night, and enter the courtyard. Your heart\n" +
                                     "is pounding out of your chest as you walk to the outer gate. You get to the\n" +
                                     "gate, and look up at the tower.\n\n" +
                                     "You think to yourself, \"please open the gate...\" The gate opens for you.\n" +
                                     "You smile as you walk off the prison grounds. You are finally free!\n\n" +
                                     "Press R to Replay");
            char choice = Console.ReadKey().KeyChar;
            if (choice.Equals('r')) cellMain();
        }
    }
}