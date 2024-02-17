package Cornhacks2024;

import java.util.Scanner;

public class dragonsLair {
    dice dice = new dice();

    public static void magicWizardHand(character player) {
        System.out.println("Congrats you rolled a 16");
        System.out.println("You zap the dragon with your magic wiazrd hands and you kill the Dragon");
        southMountains.exploreSouthMountains(player);
    }

    public static void runAway(int roll, Scanner scanner, dice dice, character player) {
        System.out.println("You rolled a " + roll);
        System.out.println("You try run away from the Dragon");
        System.out.println("Will you dodge the Dragon?");
        System.out.println("Type 'yes' or 'no'");
        String runTrue = scanner.nextLine();
        while (runTrue.equals("yes") == true || runTrue.equals("no") == true) {
            if (runTrue.equals("yes")) {
                roll = dice.rollMediumChoice();
                if (roll >= 6) {
                    System.out.println("You rolled a " + roll);
                    System.out.println("Congrats, you have dodged the Dragon");
                    southMountains.exploreSouthMountains(player);
                } else {
                    System.out.println("You rolled a " + roll);
                    System.out.println("The Dragon hits you with a wrath of envious fire \n you die");
                    System.exit(0);
                }
            } else if (runTrue.equals("no")) {
                System.out.println("Uh oh, you died");
                System.exit(0);
            } else {
                System.out.println("Enter a valid input");
                runTrue = scanner.nextLine();
            }
        }
    }

    public static void fistFight(int roll, character player) {
        System.out.println("You rolled a " + roll);
        System.out.println("You decide to fist fight the dragon");
        int roll2 = 20;
        System.out.println("You rolled a " + roll2);
        System.out.println(
                "You punch the dragon straight in its nose, \n you are then engulfed in a massive flame and die");
        System.exit(0);
    }

    public static void readyToDieMessage() {
        System.out.println("Are you ready to die");
        System.out.println("Type 'yes' or 'no'");
    }

    public static void dragonInLair(Scanner scanner, int roll, character player) {
        dice dice = new dice();
        System.out.println("Dragon in Lair");
        System.out.println("The Dragon sees you how would you like to react");
        System.out.println("Silly choice I have a better one");
        roll = (dice.rollHardChoice());
        if (roll == 16) {
            magicWizardHand(player);
        } else if (roll >= 8) {
            runAway(roll, scanner, dice, player);
        } else {
            fistFight(roll, player);
        }
    }

    public static void dragonNotInLair(character player) {
        System.out.println("You entered the Dragon's Lair and there is no dragon, so you leave");
        southMountains.exploreSouthMountains(player);
    }

    public static void dragonsLairPlace(character player) {
        dice dice = new dice();
        System.out.println("Welcome to the Dragon's Lair");
        readyToDieMessage();
        Scanner scanner = new Scanner(System.in);
        String input = scanner.nextLine();
        while (input.equals("yes") == false) {
            input = scanner.nextLine(); // Fix: Remove the String type declaration
            System.out.println("SORRY WRONG ANSWER!!! \n Lets try that again...");
            readyToDieMessage();
        }
        int roll = dice.rollEasyChoice(); // Fix: Change 'dice' to 'dice.rollEasyChoice()'
        if (roll <= 3) {
            dragonInLair(scanner, roll, player);
        } else {
            dragonNotInLair(player);
        }

    }
}
