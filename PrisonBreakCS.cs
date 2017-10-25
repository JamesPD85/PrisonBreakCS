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
        char userOK;
        char playerChoice;

        public static void Main(string[] args)
        {
            System.Console.WriteLine("The Prison Game\n");
            System.Console.WriteLine("The object of this game is to escape the prison without being caught.\n\n");
            System.Console.WriteLine("Ready to begin? (y/n)");
            char userOK = Console.ReadKey().KeyChar;
            if (userOK.Equals('y')) statesCell();
            else if (userOK.Equals('n')) System.Environment.Exit(1);
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

        public static void statesCell()
        {
            PrisonTitle();
            System.Console.WriteLine("You are in a prison cell. You've been here for 20 years " +
                                     "for a crime you did not commit, and need to get out. " +
                                     "There are some dirty bed sheets, a mirror by the \n" +
                                     "sink, and the cell door is locked.\n\n" +
                                     "Press S to inspect the Sheets\n" +
                                     "Press L to inspect the Lock\n" +
                                     "Press M to inspect the Mirror\n");
            char playerChoice = Console.ReadKey().KeyChar;
            if (playerChoice.Equals('s')) statesSheets();
            else if (playerChoice.Equals('m')) statesMirror();
            else if (playerChoice.Equals('l')) statesCellLock();
        }

        public static void statesCellMirror()
        {
            PrisonTitle();
            System.Console.WriteLine("You are in your cell with the mirror. You wonder how you could use this to\n" +
                                     "escape. The gross sheets are still on the bed, and the cell door is locked.\n\n" +
                                     "Press S to inspect the Sheets\n" +
                                     "Press L to inspect the Lock\n");
            char playerChoice = Console.ReadKey().KeyChar;
            if (playerChoice.Equals('s')) statesSheetsMirror();
            else if (playerChoice.Equals('l')) statesCellLockMirror();
        }

        public static void statesSheets()
        {
            PrisonTitle();
            System.Console.WriteLine("There are filthy, disgusting sheets on the bed. " +
                                     "You can't believe you actually\n" +
                                     "sleep in these. That's prison life...\n\n" +
                                     "Press R to Return to your cell\n\n");
            char playerChoice = Console.ReadKey().KeyChar;
            if (playerChoice.Equals('r')) statesCell();
        }

        public static void statesSheetsMirror()
        {
            PrisonTitle();
            System.Console.WriteLine("You look at the same disgusting sheets again. " +
                                     "Hopefully you won't have to look\nat them much longer.\n\n" +
                                     "Press R to Return to your cell\n\n");
            char playerChoice = Console.ReadKey().KeyChar;
            if (playerChoice.Equals('r')) statesCellMirror();
        }

        public static void statesMirror()
        {
            PrisonTitle();
            System.Console.WriteLine("As you look into the mirror yet again after 20 years, you suddenly notice that\n" +
                                     "the mirror looks a little strange. You are compelled to take " +
                                     "a closer look...\n\n" +
                                     "Press L to Look closer\n" +
                                     "Press R to Return to your cell\n\n");
            char playerChoice = Console.ReadKey().KeyChar;
            if (playerChoice.Equals('l')) statesMirrorLook();
            if (playerChoice.Equals('r')) statesCell();
        }

        public static void statesMirrorLook()
        {
            PrisonTitle();
            System.Console.WriteLine("When you look at it from another angle, you can see that the mirror is loose.\n" +
                                     "It looks like you can take it.\n\n" +
                                     "Press T to take the mirror\n" +
                                     "Press R to Return to your cell\n\n");
            char playerChoice = Console.ReadKey().KeyChar;
            if (playerChoice.Equals('t')) statesCellMirror();
            if (playerChoice.Equals('r')) statesCell();
        }

        public static void statesCellLock()
        {
            PrisonTitle();
            System.Console.WriteLine("It's one of those keypad locks. You have no idea what the combination is.\n" +
                                     "You can't see the keypad from where you're standing. If you could look at it\n" +
                                     "from the outside, you might be able to see which numbers were pressed by that\n" +
                                     "slob guard's dirty hands.\n\n" +
                                     "Press R to Return to your cell\n");
            char playerChoice = Console.ReadKey().KeyChar;
            if (playerChoice.Equals('r')) statesCell();
        }

        public static void statesCellLockMirror()
        {
            PrisonTitle();
            System.Console.WriteLine("It's one of those keypad locks. You have no idea what the combination is.\n" +
                                     "Maybe now you can see which numbers were pressed by that slob guard's dirty\n" +
                                     "hands.\n\n" +
                                     "Press M to use Mirror\n" +
                                     "Press R to Return to your cell\n\n");
            char playerChoice = Console.ReadKey().KeyChar;
            if (playerChoice.Equals('r')) statesCellMirror();
            if (playerChoice.Equals('m')) statesKeypad();
        }

        public static void statesKeypad()
        {
            PrisonTitle();
            System.Console.WriteLine("You reach your hand through the bars, and point the mirror back at the keypad.\n" +
                                     "You can now see the combination to unlock it.\n\n" +
                                     "Press K to use the Keypad\n" +
                                     "Press R to Return to your cell\n\n");
            char playerChoice = Console.ReadKey().KeyChar;
            if (playerChoice.Equals('r')) statesCellMirror();
            if (playerChoice.Equals('k')) statesLockOpen0();
        }

        public static void statesLockOpen0()
        {
            PrisonTitle();
            System.Console.WriteLine("You escaped your cell! Now is your best chance to escape! There are some boxes\n" +
                                     "to your left, and a closet door about 20 feet away. The hallway looks like it\n" +
                                     "leads to some stairs.\n\n" +
                                     "Press C to check the Closet\n" +
                                     "Press S to check the Stairs\n\n");
            char playerChoice = Console.ReadKey().KeyChar;
            if (playerChoice.Equals('c')) statesCloset();
            if (playerChoice.Equals('s')) statesStairs0();
            //if (playerChoice.Equals('r')) statesCellOpen();
        }

        public static void statesLockOpen1()
        {
            PrisonTitle();
            System.Console.WriteLine("You are in the hallway outside the cell. The hallway leads to stairs, and\n" +
                                     "there's a closet door about 20 feet away.\n\n" +
                                     "Press C to check the Closet\n" +
                                     "Press H to check the Hall\n" +
                                     "Press S to check the Stairs\n\n");
            char playerChoice = Console.ReadKey().KeyChar;
            if (playerChoice.Equals('c')) statesClosetLocked1();
            if (playerChoice.Equals('h')) statesHall1();
            if (playerChoice.Equals('s')) statesStairs0();
        }

        public static void statesCloset()
        {
            PrisonTitle();
            System.Console.WriteLine("Just as you reach for the doorknob, you hear a guard coming down the hall. Your\n" +
                                     "heart is pounding in your chest as you start to panic. You need to hide!\n\n" +
                                     "Press C to hide in the Closet\n" +
                                     "Press B to hide behind the Boxes\n" +
                                     "Press R to Return to your cell\n\n");
            char playerChoice = Console.ReadKey().KeyChar;
            if (playerChoice.Equals('c')) statesClosetLocked0();
            if (playerChoice.Equals('b')) statesBoxes();
            if (playerChoice.Equals('r')) statesCellOpen();
        }

        public static void statesBoxes()
        {
            PrisonTitle();
            System.Console.WriteLine("You hide behind the boxes as the guard closes in. He notices the cell door open\n" +
                                     "and runs over to inspect. It doesn't take him long to notice you behind the\n" +
                                     "boxes. Before you know it, you're surrounded by guards. There is no escape.\n\n" +
                                     "The guards cuff you, and escort to the maximum security solitary cells. The head" +
                                     "guard says \"There's no way you can escape now. You will die in this cell!\"\n\n" +
                                     "Press R to Restart the game\n\n");
            char playerChoice = Console.ReadKey().KeyChar;
            if (playerChoice.Equals('r')) statesCell();
        }

        public static void statesCellOpen()
        {
            PrisonTitle();
            System.Console.WriteLine("You are back in your cell. This should avoid suspicion from the gaurd.\n" +
                                     "You sit on the bed with nasty sheets as the guards walks by. He takes a quick\n" +
                                     "look in your cell, and walks back down the hall and up the stairs.\n\n" +
                                     "Press S to inspect the Sheets\n" +
                                     "Press H to go to the Hall\n\n");
            char playerChoice = Console.ReadKey().KeyChar;
            if (playerChoice.Equals('s')) statesSheetsGross();
            else if (playerChoice.Equals('h')) statesHall0();
        }

        public static void statesClosetLocked0()
        {
            PrisonTitle();
            System.Console.WriteLine("The closet door is locked. You might be able to pick the lock with something.\n" +
                                     "The guard is still coming! You don't have much time!\n\n" +
                                     "Press B to hide behind the Boxes\n" +
                                     "Press R to Return to your cell\n\n");
            char playerChoice = Console.ReadKey().KeyChar;
            if (playerChoice.Equals('c')) statesClosetLocked0();
            if (playerChoice.Equals('b')) statesBoxes();
            if (playerChoice.Equals('r')) statesCellOpen();
        }

        public static void statesClosetLocked1()
        {
            PrisonTitle();
            System.Console.WriteLine("The closet door is locked. You might be able to pick the lock with something.\n\n" +
                                     "Press R to Return to the hall\n\n");
            char playerChoice = Console.ReadKey().KeyChar;
            if (playerChoice.Equals('r')) statesHall0();
        }

        public static void statesClosetLocked2()
        {
            PrisonTitle();
            System.Console.WriteLine("The closet door is locked. You might be able to pick the lock with something.\n\n" +
                                     "Press P to pick the lock\n" +
                                     "Press R to Return to the hall\n\n");
            char playerChoice = Console.ReadKey().KeyChar;
            if (playerChoice.Equals('p')) statesClosetOpen0();
            if (playerChoice.Equals('r')) statesHall2();
        }

        public static void statesClosetOpen0()
        {
            PrisonTitle();
            System.Console.WriteLine("You pick the lock with the hairpin. The hairpin breaks, but the closet door\n" +
                                     "opens.\n\n" +
                                     "Press S to Search the closet\n" +
                                     "Press R to Return to the hall\n\n");
            char playerChoice = Console.ReadKey().KeyChar;
            if (playerChoice.Equals('s')) statesClosetOpen1();
            if (playerChoice.Equals('r')) statesHall3();
        }

        public static void statesClosetOpen1()
        {
            PrisonTitle();
            System.Console.WriteLine("This closet is full of maintenance equipment. A spare janitor's uniform is\n" +
                                     "hanging up.\n\n" +
                                     "Press I to inspect the uniform\n" +
                                     "Press R to Return to the hall\n\n");
            char playerChoice = Console.ReadKey().KeyChar;
            if (playerChoice.Equals('i')) statesUniform();
            if (playerChoice.Equals('r')) statesHall3();
        }

        public static void statesClosetOpen2()
        {
            PrisonTitle();
            System.Console.WriteLine("This closet is full of maintenance equipment. Nothing else useful here.\n\n" +
                                     "Press C to Change out of uniform\n" +
                                     "Press R to Return to the hall\n\n");
            char playerChoice = Console.ReadKey().KeyChar;
            if (playerChoice.Equals('c')) statesClosetOpen1();
            if (playerChoice.Equals('r')) statesHall4();
        }

        public static void statesOpenCloset0()
        {
            PrisonTitle();
            System.Console.WriteLine("The closet door is open.\n\n" +
                                     "Press E to Enter closet\n" +
                                     "Press R to Return to the hall\n\n");
            char playerChoice = Console.ReadKey().KeyChar;
            if (playerChoice.Equals('e')) statesClosetOpen1();
            if (playerChoice.Equals('r')) statesHall3();
        }

        public static void statesOpenCloset1()
        {
            PrisonTitle();
            System.Console.WriteLine("The closet door is open.\n\n" +
                                     "Press E to Enter closet\n" +
                                     "Press R to Return to the hall\n\n");
            char playerChoice = Console.ReadKey().KeyChar;
            if (playerChoice.Equals('e')) statesClosetOpen2();
            if (playerChoice.Equals('r')) statesHall3();
        }

        public static void statesOpenCloset2()
        {
            PrisonTitle();
            System.Console.WriteLine("The closet door is open.\n\n" +
                                     "Press E to Enter closet\n" +
                                     "Press R to Return to the hall\n\n");
            char playerChoice = Console.ReadKey().KeyChar;
            if (playerChoice.Equals('e')) statesClosetOpen2();
            if (playerChoice.Equals('r')) statesHall4();
        }

        public static void statesUniform()
        {
            PrisonTitle();
            System.Console.WriteLine("This uniform looks to be about your size.\n\n" +
                                     "Press W to Wear the uniform\n" +
                                     "Press R to Return to the closet\n\n");
            char playerChoice = Console.ReadKey().KeyChar;
            if (playerChoice.Equals('w')) statesClosetJanitor();
            if (playerChoice.Equals('r')) statesClosetOpen1();
        }

        public static void statesClosetJanitor()
        {
            PrisonTitle();
            System.Console.WriteLine("You are now dressed as a janitor. This could be the perfect disguise.\n\n" +
                                     "Press C Change out of the uniform\n" +
                                     "Press R to Return to the closet\n\n");
            char playerChoice = Console.ReadKey().KeyChar;
            if (playerChoice.Equals('c')) statesClosetOpen1();
            if (playerChoice.Equals('r')) statesClosetOpen2();
        }

        public static void statesStairs0()
        {
            PrisonTitle();
            System.Console.WriteLine("You peek up the stairs, and see 2 doors. One leading outside, and the other to\n" +
                                     "the guard's office. Trying to escape now is just asking to get shot. Better come" +
                                     "up with a plan.\n\n" +
                                     "Press R to Return to the hall\n\n");
            char playerChoice = Console.ReadKey().KeyChar;
            if (playerChoice.Equals('r')) statesHall0();
        }

        public static void statesStairs1()
        {
            PrisonTitle();
            System.Console.WriteLine("You peek up the stairs, and see 2 doors. One leading outside, and the other to\n" +
                                     "the guard's office. All you are armed with is a hairpin. Trying to escape now\n" +
                                     "is just asking to get shot. Better come up with a plan.\n\n" +
                                     "Press R to Return to the hall\n\n");
            char playerChoice = Console.ReadKey().KeyChar;
            if (playerChoice.Equals('r')) statesHall2();
        }

        public static void statesStairs2()
        {
            PrisonTitle();
            System.Console.WriteLine("There are two doors upstairs. One leading outside, and the other to\n" +
                                     "the guard's office. Being dressed as the janitor gives you the best chance yet\n" +
                                     "to escape unnoticed.\n\n" +
                                     "Press C to enter the Courtyard\n" +
                                     "Press R to Return to the hall\n\n");
            char playerChoice = Console.ReadKey().KeyChar;
            if (playerChoice.Equals('c')) statesCourtyard();
            if (playerChoice.Equals('r')) statesHall4();
        }

        public static void statesSheetsGross()
        {
            PrisonTitle();
            System.Console.WriteLine("Ugh! You wonder why you keep looking at these. You have to get out of here!\n\n" +
                                     "Press R to Return to your cell\n\n");
            char playerChoice = Console.ReadKey().KeyChar;
            if (playerChoice.Equals('r')) statesCellFinal();
        }

        public static void statesHall0()
        {
            PrisonTitle();
            System.Console.WriteLine("You are in the hallway outside the cell. The hallway leads to stairs, and\n" +
                                     "there's a closet door about 20 feet away.\n\n" +
                                     "Press C to check the Closet\n" +
                                     "Press H to check the Hall\n" +
                                     "Press S to check the Stairs\n\n");
            char playerChoice = Console.ReadKey().KeyChar;
            if (playerChoice.Equals('c')) statesCloset();
            if (playerChoice.Equals('s')) statesStairs0();
            if (playerChoice.Equals('h')) statesHall1();
        }

        public static void statesHall1()
        {
            PrisonTitle();
            System.Console.WriteLine("As you search the hallway, you come across a hairpin. This might come in handy.\n\n" +
                                     "Press T to Take the hairpin\n" +
                                     "Press R to Return to the hall\n");
            char playerChoice = Console.ReadKey().KeyChar;
            if (playerChoice.Equals('t')) statesHall2();
            if (playerChoice.Equals('r')) statesHall0();
        }

        public static void statesHall2()
        {
            PrisonTitle();
            System.Console.WriteLine("You are in the hallway outside the cell. The hallway leads to stairs, and\n" +
                                     "there's a closet door about 20 feet away.\n\n" +
                                     "Press C to check the Closet\n" +
                                     "Press S to check the Stairs\n\n");
            char playerChoice = Console.ReadKey().KeyChar;
            if (playerChoice.Equals('c')) statesClosetLocked2();
            if (playerChoice.Equals('s')) statesStairs1();
        }

        public static void statesHall3()
        {
            PrisonTitle();
            System.Console.WriteLine("You are back in the hallway. Looks like the stairs are your way out.\n\n" +
                                     "Press C to check the Closet\n" +
                                     "Press S to check the Stairs\n\n");
            char playerChoice = Console.ReadKey().KeyChar;
            if (playerChoice.Equals('c')) statesOpenCloset0();
            if (playerChoice.Equals('s')) statesStairs2();
        }

        public static void statesHall4()
        {
            PrisonTitle();
            System.Console.WriteLine("You are back in the hallway. Looks like the stairs are your way out.\n\n" +
                                     "Press C to check the Closet\n" +
                                     "Press S to check the Stairs\n\n");
            char playerChoice = Console.ReadKey().KeyChar;
            if (playerChoice.Equals('c')) statesOpenCloset2();
            if (playerChoice.Equals('s')) statesStairs2();
        }

        public static void statesCellFinal()
        {
            PrisonTitle();
            System.Console.WriteLine("Ok, this is it. The guard won't be back for a while, so now is your last chance.\n" +
                                     "You can almost feel the freedom.\n\n" +
                                     "Press H to go to the Hallway.\n\n");
            char playerChoice = Console.ReadKey().KeyChar;
            if (playerChoice.Equals('h')) statesHall0();
        }

        public static void statesCourtyard()
        {
            PrisonTitle();
            System.Console.WriteLine("Nervously, you start to climb the stairs. Your hearts is pounding! As you walk\n" +
                                     "by the office, you make eye contact with one of the guards. He says \"Hey!\"\n" +
                                     "and your heart stops.\n\n" +
                                     "Press T to Talk to the guard\n" +
                                     "Press R to Run for it\n\n");
            char playerChoice = Console.ReadKey().KeyChar;
            if (playerChoice.Equals('t')) statesGuard0();
            if (playerChoice.Equals('r')) statesRun();
        }

        public static void statesGuard0()
        {
            PrisonTitle();
            System.Console.WriteLine("The guards says \"Have a good night,\" and nods to you. You can't believe\n" +
                                     "that actually worked!\n\n" +
                                     "Press C to enter the Courtyard.\n");
            char playerChoice = Console.ReadKey().KeyChar;
            if (playerChoice.Equals('c')) statesFreedom();
        }

        public static void statesGuard1()
        {
            PrisonTitle();
            System.Console.WriteLine("The guards says \"Have a good night,\" and nods to you. You can't believe\n" +
                                     "that actually worked." +
                                     "Press C to enter the Courtyard.\n");
            char playerChoice = Console.ReadKey().KeyChar;
            if (playerChoice.Equals('c')) statesFreedom();
        }

        public static void statesRun()
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
            char playerChoice = Console.ReadKey().KeyChar;
            if (playerChoice.Equals('r')) statesCell();
        }

        public static void statesFreedom()
        {
            PrisonTitle();
            System.Console.WriteLine("You wish the guard a good night, and enter the courtyard. Your heart\n" +
                                     "is pounding out of your chest as you walk to the outer gate. You get to the\n" +
                                     "gate, and look up at the tower.\n\n" +
                                     "You think to yourself, \"please open the gate...\" The gate opens for you.\n" +
                                     "You smile as you walk off the prison grounds. You are finally free!\n\n" +
                                     "Press R to Replay");
            char playerChoice = Console.ReadKey().KeyChar;
            if (playerChoice.Equals('r')) statesCell();
        }
    }
}